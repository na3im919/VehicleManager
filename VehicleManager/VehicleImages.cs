using BL;
using DevExpress.Utils;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraEditors;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace VehicleManager
{
    public partial class VehicleImages : XtraForm
    {

        private readonly int _vehicleId;
        private int _selectedImageId = -1;
        private string _selectedImagePath = string.Empty;
        private PictureBox _selectedPicture;
        private readonly string _rootPath;

        public VehicleImages(int vehicleID)
        {
            InitializeComponent();
            _vehicleId = vehicleID;

            // المسار الجذري للتطبيق
            _rootPath = AppDomain.CurrentDomain.BaseDirectory;
        }


        private void LoadImages()
        {
            flowImages.Controls.Clear();
            _selectedImageId = -1;
            _selectedImagePath = string.Empty;
            _selectedPicture = null;

            string error = string.Empty;
            var images = cls_bl_vehicle_images.GetVehcleImagesById(_vehicleId, out error);
            if (!string.IsNullOrEmpty(error))
            {
                XtraMessageBox.Show(error);
                return;
            }

            foreach (var img in images)
            {
                if (!File.Exists(img.ImagePath))
                    continue;

                PictureBox pic = new PictureBox
                {
                    Width = 180,
                    Height = 130,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Image = LoadImageWithoutLock(img.ImagePath),
                    Tag = img,
                    BorderStyle = BorderStyle.FixedSingle,
                    Cursor = Cursors.Hand,
                    Margin = new Padding(8)
                };

                pic.Click += Pic_Click;              // لتحديد الصورة
                pic.DoubleClick += Pic_DoubleClick;  // لفتح الصورة FullScreen
                pic.MouseDown += Pic_MouseDown;        // Right click
                pic.ContextMenuStrip = cmsImageOptions;

                flowImages.Controls.Add(pic);
            }
        }

        private void Pic_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var pic = sender as PictureBox;
                if (pic == null) return;

                // حدّد الصورة
                _selectedPicture = pic;
                var img = (cls_ml_vehicle_image)pic.Tag;
                _selectedImageId = img.ImageID;
                _selectedImagePath = img.ImagePath;

                // ضع إطار حول الصورة المحددة (اختياري)
                foreach (PictureBox p in flowImages.Controls.OfType<PictureBox>())
                    p.BackColor = Color.Transparent;

                _selectedPicture.BackColor = Color.LightSteelBlue;
            }
        }


        private Image LoadImageWithoutLock(string path)
        {
            using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                return Image.FromStream(fs);
            }
        }

        private void Pic_Click(object sender, EventArgs e)
        {
            if (_selectedPicture != null)
                _selectedPicture.BackColor = Color.Transparent;

            _selectedPicture = (PictureBox)sender;
            _selectedPicture.BackColor = Color.LightSteelBlue;

            var img = (cls_ml_vehicle_image)_selectedPicture.Tag;
            _selectedImageId = img.ImageID;
            _selectedImagePath = img.ImagePath;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string error = string.Empty;
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Images|*.jpg;*.jpeg;*.png"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string newPath = ImageHelper.CopyToVehicleFolder(
                    _rootPath,
                    _vehicleId,
                    ofd.FileName
                );

               if( cls_bl_vehicle_images.AddVehicleNewImage(new cls_ml_vehicle_image
                {
                    VehicleID = _vehicleId,
                    ImagePath = newPath
                }, out error))
                    XtraMessageBox.Show("Image ajoutée avec succès");
               else
                                        XtraMessageBox.Show(error);

                LoadImages();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_selectedImageId == -1)
            {
                MessageBox.Show("Select an image first");
                return;
            }

            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Images|*.jpg;*.jpeg;*.png"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // حذف الصورة القديمة من القرص
                ImageHelper.DeleteImage(_selectedImagePath);

                string newPath = ImageHelper.CopyToVehicleFolder(
                    _rootPath,
                    _vehicleId,
                    ofd.FileName
                );

                cls_bl_vehicle_images.UpdateVehicleImage(new cls_ml_vehicle_image
                {
                    ImageID = _selectedImageId,
                    ImagePath = newPath
                });

                LoadImages();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedImageId == -1)
            {
                return;
            }

            if (MessageBox.Show(
                "Supprimer cette image ?",
                "Confirmer",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ImageHelper.DeleteImage(_selectedImagePath);
                cls_bl_vehicle_images.DeleteVehicleImage(_selectedImageId);

                LoadImages();
            }
        }

        private void VehicleImages_Load(object sender, EventArgs e)
        {
            LoadImages();
            

        }

        private void Pic_DoubleClick(object sender, EventArgs e)
        {
            var pic = sender as PictureBox; // هكذا تحصل على الـ PictureBox الذي تم DoubleClick عليه
            if (pic == null) return;

            var img = (cls_ml_vehicle_image)pic.Tag;

            if (!File.Exists(img.ImagePath))
                return;

            // فتح الصورة في Form
            Form frm = new Form
            {
                Text = "Image Preview",
                Size = new Size(800, 600),
                StartPosition = FormStartPosition.CenterParent
            };

            PictureBox pb = new PictureBox
            {
                Dock = DockStyle.Fill,
                Image = Image.FromFile(img.ImagePath),
                SizeMode = PictureBoxSizeMode.Zoom
            };

            frm.Controls.Add(pb);
            frm.ShowDialog();
            pb.Image.Dispose();
        }

        private void ouvrirLemplacementDimageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_selectedImagePath == null || !File.Exists(_selectedImagePath))
                return;

            string folder = Path.GetDirectoryName(_selectedImagePath);
            if (Directory.Exists(folder))
            {
                System.Diagnostics.Process.Start("explorer.exe", folder);
            }
        }
    }
}
