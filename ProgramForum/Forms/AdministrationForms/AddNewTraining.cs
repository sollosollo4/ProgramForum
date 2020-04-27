using ProgramForum.Content.Training;
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
    public partial class AddNewTraining : Form
    {
        List<LanguageSet> languageList;
        LanguageSet Language;

        LessonControl SelectedElement;
        LessonControl StatusElement;
        
        public static Image SelectedImage;

        private static int Position;
        
        Timer t1 = new Timer();

        public AddNewTraining()
        {
            InitializeComponent();
            BlackLine1.Visible = false;
            MaximumSize = new Size(720, 90);
            Position = 0;
        }

        private void AddNewTraining_Load(object sender, EventArgs e)
        {
            using (ForumContainer container = new ForumContainer())
            {
                var LanguageList = container.LanguageSet.Select(x => x.LanguageName);
                languageList = new List<LanguageSet>();
                languageList = container.LanguageSet.ToList();
                ChooseLanguageStrip.Items.AddRange(LanguageList.ToArray());
            }
        }

        private void ChooseLanguageStrip_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaximizeBox = true; MinimizeBox = true; MaximumSize = new Size(1280, 960);
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            BlackLine1.Visible = true;

            var screen = Screen.FromControl(this);
            Top = screen.Bounds.Height / 2 - Height / 2;
            Left = screen.Bounds.Width / 2 - Width / 2;

            Language = languageList.Single(x => x.LanguageName == ChooseLanguageStrip.SelectedItem.ToString());
            SendKeys.Send("{TAB}");

            ChooseLanguageStrip.Location = new Point(776, 10);
            AddTrainingToDb.Visible = true;
        }

        private void AddNewTraining_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите прекратить работу?", this.Text,
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
                return;
            }
        }

        private void AddElementPicture_Click(object sender, EventArgs e)
        {
            if (StatusElement == null)
            {
                MessageBox.Show("Вы не выбрали урок!");
                return;
            }

            PickPicture pickPicture = new PickPicture();
            pickPicture.ShowDialog();

            StatusElement.Picture = SelectedImage;
        }

        private void Element1_Click(object sender, EventArgs e)
        {
            LessonControl lesson = new LessonControl();
            
            TestTrainingPanel.Controls.Add(lesson);
            lesson.ContextMenuStrip = contextMenuStrip;

            lesson.Click += Lesson_Click;
            lesson.SetOtherChildrenControlClick(Lesson_Click);
            lesson.Position = Position;
            Position++;
        }

        private void Lesson_Click(object sender, EventArgs e)
        {
            SelectedElement = (LessonControl)sender;

            LessonControl StatusLessonControl = new LessonControl();

            StatusLessonControl.Location = new Point(0, 0);
            StatusLessonControl.ControlColor = SelectedElement.ControlColor;

            StatusLessonControl.LessName = SelectedElement.LessName;
            StatusLessonControl.Picture = SelectedElement.Picture;

            StatusLessonControl.Theories = SelectedElement.Theories;
            StatusLessonControl.Questions = SelectedElement.Questions;

            LessonName.Text = SelectedElement.LessName;

            StatusElement = StatusLessonControl;

            SelectedElementPanel.Controls.Clear();
            SelectedElementPanel.Controls.Add(StatusLessonControl);

            LessonConentLayoutPanel.Controls.Clear();
            LessonConentLayoutPanel.Controls.AddRange(StatusLessonControl.Theories.ToArray());
            LessonConentLayoutPanel.Controls.AddRange(StatusLessonControl.Questions.ToArray());
        }

        private void Element2_Click(object sender, EventArgs e)
        {
            if (StatusElement == null)
            {
                MessageBox.Show("Вы не выбрали урок!");
                return;
            }

            Color myRgbColor = new Color();
            myRgbColor = Color.FromArgb(255, 255, 255, 0);
            LessonConentLayoutPanel.BackColor = myRgbColor;
            t1.Tick += new EventHandler(fadeOutAddTheory);
            t1.Interval = 100;
            t1.Start();
            
            Theory theory = new Theory();
            StatusElement.AddTheory(theory);

            LessonConentLayoutPanel.Controls.Add(theory);
        }

        void fadeOutAddTheory(object sender, EventArgs e)
        {
            if (LessonConentLayoutPanel.BackColor.A <= 0) {
                t1.Stop();
            }
            else
            {
                Color myRgbColor = new Color();
                int alpha = LessonConentLayoutPanel.BackColor.A;
                alpha -= 100;
                if (alpha < 0)
                    alpha = 0;

                myRgbColor = Color.FromArgb(alpha, 255, 255, 0);
                LessonConentLayoutPanel.BackColor = myRgbColor;
            }
        }

        private void Element3_Click(object sender, EventArgs e)
        {
            if (StatusElement == null)
            {
                MessageBox.Show("Вы не выбрали урок!");
                return;
            }

            Question quest = new Question(Language);
            StatusElement.AddQuest(quest);

            LessonConentLayoutPanel.Controls.Add(quest);
        }

        private void ChangeElement_Click(object sender, EventArgs e)
        {
            if (StatusElement == null)
            {
                MessageBox.Show("Вы не выбрали урок!");
                return;
            }
        }

        private void ChangeElementColor_Click(object sender, EventArgs e)
        {
            if (StatusElement == null)
            {
                MessageBox.Show("Вы не выбрали урок!");
                return;
            }
            colorDialog.ShowDialog();
            StatusElement.ControlColor = colorDialog.Color;
        }

        private void LessonName_TextChanged(object sender, EventArgs e)
        {
            if (StatusElement == null)
            {
                MessageBox.Show("Вы не выбрали урок!");
                return;
            }

            StatusElement.LessName = LessonName.Text;
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            if (StatusElement == null)
            {
                MessageBox.Show("Вы не выбрали урок!");
                return;
            }

            SelectedElement.ControlColor = StatusElement.ControlColor;
            SelectedElement.LessName = StatusElement.LessName;
            SelectedElement.Picture = StatusElement.Picture;
            SelectedElement.Theories = StatusElement.Theories;
            SelectedElement.Questions = StatusElement.Questions;

            LessonName.Text = string.Empty;

            SelectedElementPanel.Controls.Clear();
            LessonConentLayoutPanel.Controls.Clear();
        }

        private void StripMenuItemDeleteElement_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem senderItem = (ToolStripMenuItem)sender;
            var lesson = (LessonControl)senderItem.Owner.Tag;

            TestTrainingPanel.Controls.Remove(lesson);
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            contextMenuStrip.Tag = ((ContextMenuStrip)sender).SourceControl;
        }

        private void AddTrainingToDb_Click(object sender, EventArgs e)
        {
            SaveTraining saveTraining = new SaveTraining();
            saveTraining.ShowDialog();

            if(saveTraining.TrainingName == "")
            {
                return;
            }

            using (ForumContainer container = new ForumContainer())
            {
                TrainingSet training = new TrainingSet()
                {
                    AuthorId = MainForm.Client.AccountId,
                    TrainingName = saveTraining.TrainingName,
                    TrainingDescrition = saveTraining.TrainingDescription,
                    LanguageId = Language.LanguageId
                };

                container.TrainingSet.Add(training);
                container.SaveChanges();

                foreach(var Lesson in TestTrainingPanel.Controls)
                {
                    var CurrentLesson = (LessonControl)Lesson;
                    LessonSet lesson = new LessonSet()
                    {
                        TrainingId = training.TrainingId,
                        Color = ColorTranslator.ToOle(CurrentLesson.ControlColor),
                        PictureId = -1111111,
                        LessonName = CurrentLesson.LessName,
                        LessonText = "??",
                        Position = CurrentLesson.Position,
                        Shape = 0,
                    };
                    container.LessonSet.Add(lesson);
                    container.SaveChanges();

                    foreach (var theory in CurrentLesson.Theories)
                    {
                        TheoryLessonSet theoryLesson = new TheoryLessonSet()
                        {
                            LessonId = lesson.LessonId,
                            Position = theory.Position,
                            TheoryId = theory.TheoryLessonSet.TheoryId,
                            TheoryText = theory.TheoryLessonSet.TheoryText,
                            CodeId = theory.TheoryLessonSet.CodeId
                        };

                        container.TheoryLessonSet.Add(theoryLesson);
                        container.SaveChanges();
                    }

                    foreach(var quest in CurrentLesson.Questions)
                    {
                        QuestionListLessonSet questionListLesson = new QuestionListLessonSet()
                        {
                            LessonId = lesson.LessonId,
                            Position = quest.Position,
                            QuestionId = quest.QuestionSet.QuestionId
                        };

                        container.QuestionListLessonSet.Add(questionListLesson);
                        container.SaveChanges();
                    }
                    
                }
            }
        }
    }
}
