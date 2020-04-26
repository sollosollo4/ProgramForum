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

        private int Position;
        
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

            /*lesson.MouseDown += Lesson_MouseDown;
            lesson.MouseMove += Lesson_MouseMove;
            lesson.MouseUp += Lesson_MouseUp;

            TestTrainingPanel.DragOver += TestTrainingPanel_DragOver;*/

            lesson.Click += Lesson_Click;
            lesson.SetOtherChildrenControlClick(Lesson_Click);
        }

        /*private void TestTrainingPanel_DragOver(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(typeof(LessonControl)))
                return;

            e.Effect = e.AllowedEffect;
            var draggedButton = (LessonControl)e.Data.GetData(typeof(LessonControl));

            var pt = TestTrainingPanel.PointToClient(new Point(e.X, e.Y));
            var button = (LessonControl)TestTrainingPanel.GetChildAtPoint(pt);

            if (button != null)
            {
                var pos = TestTrainingPanel.GetPositionFromControl(button);
                TestTrainingPanel.Controls.Add(draggedButton, pos.Column, pos.Row);
                draggedButton.Tag = null;
            }
        }*/

        private void Lesson_MouseDown(object sender, MouseEventArgs e)
        {
            ((LessonControl)sender).Tag = new object();
        }

        private void Lesson_MouseMove(object sender, MouseEventArgs e)
        {
            var button = (LessonControl)sender;
            if (button.Tag != null)
                button.DoDragDrop(sender, DragDropEffects.Move);
        }

        private void Lesson_MouseUp(object sender, MouseEventArgs e)
        {
            ((LessonControl)sender).Tag = null;
        }

        private void Lesson_Click(object sender, EventArgs e)
        {
            SelectedElement = (LessonControl)sender;

            LessonControl StatusLessonControl = new LessonControl();

            StatusLessonControl.Location = new Point(0, 0);
            StatusLessonControl.ControlColor = SelectedElement.ControlColor;
            StatusLessonControl.LessName = SelectedElement.LessName;
            StatusLessonControl.Picture = SelectedElement.Picture;

            StatusElement = StatusLessonControl;

            SelectedElementPanel.Controls.Clear();
            SelectedElementPanel.Controls.Add(StatusLessonControl);
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
        }

        void fadeOutAddTheory(object sender, EventArgs e)
        {
            if (LessonConentLayoutPanel.BackColor.A <= 0)
            {
                t1.Stop();
                // Добавление теории на форму
                Theory theory = new Theory();
                theory.Position = Position;
                LessonConentLayoutPanel.Controls.Add(theory);
                Position++;
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

            LessonName.Text = string.Empty;

            SelectedElementPanel.Controls.Clear();
        }

        private void StripMenuItemDeleteElement_Click(object sender, EventArgs e)
        {
            var StripMenu = (ToolStripMenuItem)sender;
            var toolStrip = StripMenu.GetCurrentParent();
            var lesson = toolStrip.Parent;

            TestTrainingPanel.Controls.Remove(lesson);
        }

        private void AddTrainingToDb_Click(object sender, EventArgs e)
        {
            // не забыть добавить всем TheoryLessonSet -> LessonId
        }
    }
}
