using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramForum.Forms.AdministrationForms
{
    public partial class PickPicture : Form
    {
        public PickPicture()
        {
            InitializeComponent();

            LoadPictures();
        }

        private void LoadPictures()
        {
            Bitmap[] array = new Bitmap[626];
            for (int i = 0; i < 626; i++)
            {
                int k = i + 1;
                string resourceName = "resource__" + k + "_";
                array[i] = (Bitmap)Properties.Resources.ResourceManager.GetObject(resourceName);
            }
         
            foreach (Bitmap image in array)
            {
                PictureBox pict = new PictureBox();
                pict.BorderStyle = BorderStyle.FixedSingle;
                pict.Image = image;
                pict.Width = 80;
                pict.Height = 80;
                pict.SizeMode = PictureBoxSizeMode.StretchImage;
                flowLayoutPanel1.Controls.Add(pict);

                pict.MouseClick += Pict_MouseClick;
            }
        }

        private void Pict_MouseClick(object sender, MouseEventArgs e)
        {
            var picture = (PictureBox)sender;
            AddNewTraining.SelectedImage = picture.Image;
            Close();
        }
    }
}
