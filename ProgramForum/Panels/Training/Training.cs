using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProgramForum.Panels.Training
{
    public partial class Training : UserControl
    {
        public TrainingSet TrainingSet;


        public Training(TrainingSet training)
        {
            TrainingSet = training;
            InitializeComponent();

            using(ForumContainer container = new ForumContainer())
            {
                // Выбираем все уроки и выводим их на интерфейс
                var lessons = container.LessonSet.Where(x => x.TrainingId == TrainingSet.TrainingId);
                
                foreach(var lesson in lessons.OrderBy(x => x.Position))
                {
                    // Узнаём язык
                    var language = container.LanguageSet.FirstOrDefault(x => x.LanguageId == lesson.TrainingSet.LanguageId);

                    // Получаем нужные нам объекты Question
                    List<QuestionSet> needQuestion = lesson.QuestionListLessonSet.Where(x => x.LessonId == lesson.LessonId).OrderBy(x => x.Position).Select(x => x.QuestionSet).ToList();
                    List<Content.Training.Question> questions = new List<Content.Training.Question>();
                    foreach (var quest in needQuestion)
                    {
                        Content.Training.Question question = new Content.Training.Question(language);
                        question.QuestionSet = quest;
                        questions.Add(question);
                    }

                    // Получаем нужные нам объекты Theories
                    List<TheoryLessonSet> needTheories = lesson.TheoryLessonSet.Where(x => x.LessonId == lesson.LessonId).OrderBy(x => x.Position).ToList();
                    List <Content.Training.Theory> theories = new List<Content.Training.Theory>();
                    foreach(var theory in needTheories)
                    {
                        Content.Training.Theory theoryy = new Content.Training.Theory();
                        theoryy.TheoryLessonSet = theory;
                        theoryy.Position = theory.Position;
                        theoryy.LessonSetId = theory.LessonId;
                        theories.Add(theoryy);
                    }


                    Content.Training.LessonControl currentLessonControl = new Content.Training.LessonControl();
                    currentLessonControl.LessonSet = lesson;
                    currentLessonControl.Questions = questions;
                    currentLessonControl.Theories = theories;
                    Color c = Color.FromArgb(100, 0, 0, 0);
                    currentLessonControl.ControlColor = ColorTranslator.FromOle(lesson.Color == null ? ColorTranslator.ToOle(c) : lesson.Color.Value);
                    currentLessonControl.Picture = byteArrayToImage(lesson.Picture);

                    currentLessonControl.LessonContentEnter();
                    currentLessonControl.LessName = lesson.LessonName;

                    LessonsLayoutPanel.Controls.Add(currentLessonControl);
                }

                // Выбираем id Урока на котором остановились
                var CurrentAccoutLesson = container.TrainingProgressSet
                                    .FirstOrDefault(x => x.TrainingId == TrainingSet.TrainingId &&
                                    x.AccountId == MainForm.Client.AccountId).LessonId;

                // Окрашиваем все объекты
                foreach(Content.Training.LessonControl ctrl in LessonsLayoutPanel.Controls) {
                    // Красим в серый ( недопустимый )
                    if(!(ctrl.LessonSet.LessonId == CurrentAccoutLesson))
                    {
                        ctrl.SetOtherChildrenControlClick(LessonControl_Badly_Click);
                        continue;
                    }
                    else
                    {
                        ctrl.SetOtherChildrenControlClick(LessonControl_Godly_Click);
                        continue;
                    }
                }
            }
        }


        private void LessonControl_Badly_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы не прошли предыдущие уроки, чтобы начать данный!");
            return;
        }

        /// <summary>
        /// Загрузчик урока
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LessonControl_Godly_Click(object sender, EventArgs e)
        {
            
        }


        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
    }
}
