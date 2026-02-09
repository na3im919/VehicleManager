using BL;
using DevExpress.Utils.Drawing.Animation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Office.Drawing.LazyGroupBrush;

namespace VehicleManager
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                AppDomain.CurrentDomain.SetData("DataDirectory", AppDomain.CurrentDomain.BaseDirectory);

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                //cls_bl_DbInitializer.InitializeDatabase();

                Application.Run(new Main());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // في بداية دالة Main
            
        }
    }
}
