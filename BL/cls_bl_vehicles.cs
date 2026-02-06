using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using DAL;
using DocumentFormat.OpenXml.Spreadsheet;
using Models;

namespace BL
{
    public class cls_bl_vehicles
    {
        public static List<cls_ml_vehicles> GetAllVehicles(
            out string error_message,
            string columnName = null,
            string searchText = null)
        {
            return cls_dal_vehicles.GetAllVehicles(out error_message, columnName, searchText);


        }
         public static int GetTotalVehiclesCount(string status, out string error_message)
        {
            return cls_dal_vehicles.GetTotalVehiclesCount(status, out error_message);
        }


        public static int GetInServiceVehiclesCount(out string error_message)
        {
            return cls_dal_vehicles.GetInServiceVehiclesCount(out error_message);
        }


        public static cls_ml_vehicles GetVehicleByID(int vehicleID, out string error)
        {
            return cls_dal_vehicles.GetVehicleByID(vehicleID, out error);
        }

        public static bool AddNewVehicle(cls_ml_vehicles newVehicle, out string error)
        {
            return cls_dal_vehicles.AddNewVehicle(newVehicle, out error);
        }

        public static bool UpdateVehicle(int vehicleID, cls_ml_vehicles updatedVehicle, out string error)
        {
            return cls_dal_vehicles.UpdateVehicle(vehicleID, updatedVehicle, out error);
        }

        public static bool DeleteVehicle(int vehicleID, out string error)
        {
            return cls_dal_vehicles.DeleteVehicle(vehicleID, out error);
        }

        public static int GetVehicleIDByNumber(string vehicleNumber, out string error)
        {
               return cls_dal_vehicles.GetVehicleIDByNumber(vehicleNumber, out error);
        }
        public static bool ImportVehiclesFromExcel(string filePath, out string error, out int rowsNumber)
        {
            error = string.Empty;
            rowsNumber = 0;
            try
            {
                using (var workbook = new XLWorkbook(filePath))
                {
                    var ws = workbook.Worksheet(1);
                    var headerRow = ws.Row(1);

                    if(headerRow.Cell(1).GetString().Trim() != "N°" || headerRow.Cell(2).GetString().Trim() != "Véhicule" || headerRow.Cell(3).GetString().Trim() != "Immatriculation" || headerRow.Cell(4).GetString().Trim() != "Préstataire" || headerRow.Cell(5).GetString().Trim() != "Affectation" || headerRow.Cell(6).GetString().Trim() != "Service Fait (Conducteur)" || headerRow.Cell(7).GetString().Trim() != "DATE MISE EN SERVICE" || headerRow.Cell(8).GetString().Trim() != "DATE FIN DE SERVICE" || headerRow.Cell(9).GetString().Trim() != "OBSERVATION")
                    {
                        error = "Le Exel doit contenir les colonnes suivantes dans cet ordre : N°, Véhicule, Immatriculation, Préstataire, Affectation, Service Fait (Conducteur), DATE MISE EN SERVICE, DATE FIN SERVICE, OBSERVATION.";
                        return false;
                    }

                    var rows = ws.RowsUsed().Skip(1);

                    foreach(var row in rows)
                    {
                        try
                        {
                            string vehicle_number = row.Cell(3).GetValue<string>().Trim();
                            if(GetVehicleIDByNumber(vehicle_number, out string getError) != -1)
                            {
                                continue; // Skip if vehicle already exists
                            }


                            string vehicle_name = row.Cell(2).GetValue<string>().Trim();
                            string provider = row.Cell(4).GetValue<string>().Trim();
                            if(string.IsNullOrEmpty(provider))
                            {
                                error += $"Erreur à la ligne {row.RowNumber()}: Le champ 'Préstataire' est obligatoire.\n";
                                return false;
                            }
                            string department = row.Cell(5).GetValue<string>().Trim();
                            string driver = row.Cell(6).GetValue<string>().Trim();
                            DateTime start_service = row.Cell(7).GetValue<DateTime>();
                            DateTime? end_service = (DateTime?)null;
                            if (!string.IsNullOrEmpty(row.Cell(8).GetValue<string>()))
                                end_service = row.Cell(7).GetValue<DateTime>();
                                

                            string observation = row.Cell(9).GetValue<string>().Trim();

                            int provider_id;
                            int? department_id;
                            int? driver_id;

                            if (cls_bl_providers.GetProviderIDByName(provider, out error) != -1)
                            {
                                provider_id = cls_bl_providers.GetProviderIDByName(provider, out error);
                            }
                            else
                            {
                                provider_id = cls_bl_providers.AddNewProvider(provider, out error);
                            }

                            if(!string.IsNullOrEmpty(department))
                            {
                                if (cls_bl_departments.GetDepartmentIdByName(department, out error) != -1)
                                {
                                    department_id = cls_bl_departments.GetDepartmentIdByName(department, out error);
                                }
                                else
                                {
                                    department_id = cls_bl_departments.AddNewDepartment(department, out error);
                                }
                            }
                            else
                            {
                                department_id = null; 
                            }

                           if(!string.IsNullOrEmpty(driver))
                            {
                                if (cls_bl_drivers.GetDriverIdByName(driver, out error) != -1)
                                {
                                    driver_id = cls_bl_drivers.GetDriverIdByName(driver, out error);
                                }
                                else
                                {
                                    driver_id = cls_bl_drivers.AddNewDriver(driver, out error);
                                }
                            }
                           else
                            {
                                driver_id = null;
                            }



                            cls_ml_vehicles newVehicle = new cls_ml_vehicles
                            {
                                registration_number = vehicle_number,
                                vehicle_brand = vehicle_name,
                                provider_id = provider_id,
                                department_id = department_id,
                                driver_id = driver_id,
                                start_date = start_service,
                                end_date = end_service,
                                observation = observation
                            };
                            if(!AddNewVehicle(newVehicle, out string addError))
                            {
                                error += $"Erreur à la ligne {row.RowNumber()}: {addError}\n";
                                return false;
                            }
                            rowsNumber++;

                        }
                        catch(Exception ex)
                        {
                           error += $"Erreur à la ligne {row.RowNumber()}: {ex.Message}\n";
                            return false;
                        }
                    }
                    return true;



                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        public static void ExportEmptyVehiclesExcel(string filePath, out string error)
        {
            error = string.Empty;

            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var ws = workbook.Worksheets.Add("Vehicles");

                    // Header row
                    ws.Cell(1, 1).Value = "N°";
                    ws.Cell(1, 2).Value = "Véhicule";
                    ws.Cell(1, 3).Value = "Immatriculation";
                    ws.Cell(1, 4).Value = "Préstataire";
                    ws.Cell(1, 5).Value = "Affectation";
                    ws.Cell(1, 6).Value = "Service Fait (Conducteur)";
                    ws.Cell(1, 7).Value = "DATE MISE EN SERVICE";
                    ws.Cell(1, 8).Value = "DATE FIN SERVICE";
                    ws.Cell(1, 9).Value = "OBSERVATION";

                    // Header style
                    var headerRange = ws.Range(1, 1, 1, 10);
                    headerRange.Style.Font.Bold = true;
                    //headerRange.Style.Fill.BackgroundColor = XLColor.LightGray;
                    headerRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    // Adjust columns width
                    ws.Columns().AdjustToContents();

                    workbook.SaveAs(filePath);
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
        }

    }

    public class vehiclesCountingChangedEventArgs : EventArgs
    {
        public int currentCounting { get; }
        public string label_name { get; }

        public vehiclesCountingChangedEventArgs(int currentCounting, string label_name)
        {
            this.currentCounting = currentCounting;
            this.label_name = label_name;
        }
    }

   
}
