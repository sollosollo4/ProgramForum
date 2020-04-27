using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramForum.Panels
{
    public partial class SimpleTraining : UserControl
    {
        TrainingSet Training;
        public SimpleTraining(TrainingSet training)
        {
            Training = training;
            InitializeComponent();
            TrainingName.Text = Training.TrainingName;
            TrainingDescription.Text = Training.TrainingDescrition;
        }

        private void StartTraining_Click(object sender, EventArgs e)
        {
            using (ForumContainer container = new ForumContainer())
            {
                var client = container.AccountSet.FirstOrDefault(x => x.AccountId == MainForm.Client.AccountId);

                if(client.TrainingProgressSet.FirstOrDefault(x => x.TrainingId == Training.TrainingId) != null)
                {
                    MessageBox.Show("Вы уже начали это обучение. Для того, чтобы продолжить изучение перейдите на главную");
                    return;
                }
                else
                {
                    var FirstLesson = container.LessonSet.FirstOrDefault(x => x.TrainingId == Training.TrainingId && x.Position == 0);

                    TrainingProgressSet progressSet = new TrainingProgressSet()
                    {
                        AccountId = MainForm.Client.AccountId,
                        LessonId = FirstLesson.LessonId,
                        TrainingId = Training.TrainingId
                    };
                    container.TrainingProgressSet.Add(progressSet);
                    container.SaveChanges();
                }
            }
        }
    }
}
