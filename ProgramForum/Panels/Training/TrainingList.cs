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
                int i = 0;
                foreach(var train in trainings) {
                    SimpleTraining simpleTraining = new SimpleTraining(train)
                    {
                        Location = new Point(3, 3),
                        Anchor = AnchorStyles.Left | AnchorStyles.Right
                    };

                    TrainingLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize, simpleTraining.Height));
                    TrainingLayoutPanel.RowCount++;

                    TrainingLayoutPanel.Controls.Add(simpleTraining, 0, i);
                    i++;
                }
            }
        }
    }
}
