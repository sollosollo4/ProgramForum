using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramForum.Panels.Training
{
    public partial class TrainingList : UserControl
    {
        public TrainingList()
        {
            InitializeComponent();

            using(ForumContainer container = new ForumContainer())
            {
                var trainings = container.TrainingSet.Where(x => x.LanguageId == MainForm.Language.LanguageId);
                foreach(var train in trainings) {
                    SimpleTraining simpleTraining = new SimpleTraining(train);
                    TrainingLayoutPanel.Controls.Add(simpleTraining);
                }
            }
        }
    }
}
