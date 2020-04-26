using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramForum.Content.Training
{
    public partial class LessonControl : UserControl
    {
        public LessonSet LessonSet;

        EventHandler lesson_Click;

        public LessonControl()
        {
            InitializeComponent();
        }

        public Image Picture { get { return this.LessonPicture.Image; } set { this.LessonPicture.Image = value; } }
        public string LessName { get { return this.LessonName.Text; } set { this.LessonName.Text = value; } }
        public Color ControlColor { get { return this.BackColor; } set { this.BackColor = value; } }

        public void AddTheory(TheoryLessonSet theory)
        {

        }
        public void AddQuestion()
        {

        }

        internal void SetOtherChildrenControlClick(EventHandler lesson_Click)
        {
            this.lesson_Click = lesson_Click;
            LessonPicture.Click += LessonPicture_Click;
            LessonName.Click += LessonName_Click;
        }

        private void LessonName_Click(object sender, EventArgs e)
        {
            var label = (Label)sender;
            lesson_Click(label.Parent, e);
        }

        private void LessonPicture_Click(object sender, EventArgs e)
        {
            var picture = (PictureBox)sender;
            lesson_Click(picture.Parent, e);
        }
    }
}
