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
    public partial class AccountStartedTrainingsList : UserControl
    {

        public AccountStartedTrainingsList()
        {
            InitializeComponent();

            using(ForumContainer container = new ForumContainer())
            {
                var trainings = container.TrainingProgressSet.Where(x => x.AccountId == MainForm.Client.AccountId);
                int i = 0;

                if(trainings.Count() == 0) {
                    label1.Text = "Вы еще не начинали обучения.";
                    return;
                }

                foreach (var train in trainings.Select(x => x.TrainingSet))
                {
                    SimpleTraining simpleTraining = new SimpleTraining(train)
                    {
                        Location = new Point(3, 3),
                        Anchor = AnchorStyles.Left | AnchorStyles.Right
                    };

                    simpleTraining.ContinueTraining(ContinueTraining_Click);

                    TrainingLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize, simpleTraining.Height));
                    TrainingLayoutPanel.RowCount++;

                    TrainingLayoutPanel.Controls.Add(simpleTraining, 0, i);
                    i++;
                }
            }
        }

        private void ContinueTraining_Click(object sender, EventArgs e)
        {
            var buttonControl = (Button)sender;
            var panelControl = (Panel)buttonControl.Parent;
            var smplTrain = (SimpleTraining)panelControl.Parent;

            Training training = new Training(smplTrain.Training) { Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right };

            Parent.Controls.Add(training);

            Dispose();
        }
    }
}
