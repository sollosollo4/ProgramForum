using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramForum.Forms.AdministrationForms
{
    public partial class SaveTraining : Form
    {
        public string TrainingName;
        public string TrainingDescription;

        public SaveTraining()
        {
            InitializeComponent();
        }

        private void AddTrainingToDb_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Вы не ввели название обучения!");
                return;
            }

            TrainingName = textBox1.Text;
            TrainingDescription = textBox2.Text;
            Close();
        }
    }
}
