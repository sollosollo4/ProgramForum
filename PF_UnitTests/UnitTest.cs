using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static PF_UnitTests.AddNewQuestion;
using static PF_UnitTests.Registration;

namespace PF_UnitTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestRegistrationMethod() {
            Registration registration = new Registration();

            Dictionary<StringTypeRegistration, string> exampleMethod1 = new Dictionary<StringTypeRegistration, string>();
            exampleMethod1[StringTypeRegistration.Email] = "exampleEmail";
            exampleMethod1[StringTypeRegistration.Login] = "exampleLogin";
            exampleMethod1[StringTypeRegistration.Password] = "12345";
            exampleMethod1[StringTypeRegistration.Telephone] = "89179017321";
            exampleMethod1[StringTypeRegistration.UserName] = "testtesttest";
            var error = registration.RegistrationAccount(exampleMethod1);

            Assert.AreEqual(error, AllTrue);
        }
        [TestMethod]
        public void TestAddNewQuestionMethod() {
            AddNewQuestion addnewquestion = new AddNewQuestion();

            Dictionary<StringTypeQuestion, string> exampleMethod1 = new Dictionary<StringTypeQuestion, string>();
            exampleMethod1[StringTypeQuestion.QuestionText] = "Сколько программных модулей использует EntityFramework?";
            exampleMethod1[StringTypeQuestion.QuestionType] = "1";
            List<string> answers = new List<string>();
            answers.Add("0");
            answers.Add("2");
            answers.Add("3");
            answers.Add("8");

            var error = addnewquestion.NewQuestion(exampleMethod1, answers, 1, 1);

            Assert.AreEqual(error, true);
        }
        [TestMethod]
        public void SendMessageMethod() {
            SendMessage sendmessage = new SendMessage();

            var error = sendmessage.Send("тестовое сообщение", 2, 3);

            Assert.AreEqual(error, true);
        }
    }
}
