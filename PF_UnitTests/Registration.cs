using ProgramForum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF_UnitTests
{
    public class Registration
    {
        private static string[] registrationErrorCodes = new string[8] {
            "Вы оставили поле Логин пустым",
            "Вы оставили поле Почта пустым",
            "Вы оставили поле Телефон пустым",
            "Вы оставили поле Пароль пустым",
            "Вы оставили поле Имя пустым",
            "Данный логин уже занят. Выберите другой логин для входа на форум.",
            "Данный емайл уже занят. Выберите другой емайл.",
            "Данный телефонный номер уже занят. Выберите другой телефонный номер.",
        };

        public static string AllTrue = "Аккаунт был успешно создан";

        public enum StringTypeRegistration : int
        {
            /// <summary>
            /// Логин пользователя
            /// </summary>
            Login = 0,
            /// <summary>
            /// Почта пользователя
            /// </summary>
            Email = 1,
            /// <summary>
            /// Телефон пользователя
            /// </summary>
            Telephone = 2,
            /// <summary>
            /// Пароль пользователя
            /// </summary>
            Password = 3,
            /// <summary>
            /// Имя пользователя
            /// </summary>
            UserName = 4,
        }

        public string RegistrationAccount(Dictionary<StringTypeRegistration, string> param_S)
        {
            string errorCode = "unknown";

            if (param_S[StringTypeRegistration.Login] == string.Empty)
            {
                errorCode = registrationErrorCodes[(int)StringTypeRegistration.Login];
                return errorCode;
            }

            if (param_S[StringTypeRegistration.Email] == string.Empty)
            {
                errorCode = registrationErrorCodes[(int)StringTypeRegistration.Email];
                return errorCode;
            }

            if (param_S[StringTypeRegistration.Telephone] == string.Empty)
            {
                errorCode = registrationErrorCodes[(int)StringTypeRegistration.Telephone];
                return errorCode;
            }

            if (param_S[StringTypeRegistration.Password] == string.Empty)
            {
                errorCode = registrationErrorCodes[(int)StringTypeRegistration.Password];
                return errorCode;
            }

            if (param_S[StringTypeRegistration.UserName] == string.Empty)
            {
                errorCode = registrationErrorCodes[(int)StringTypeRegistration.UserName];
                return errorCode;
            }

            using (ForumContainer container = new ForumContainer())
            {
                string login = param_S[StringTypeRegistration.Login];
                if (container.AccountSet.SingleOrDefault(x => x.Login == login) != null)
                {
                    errorCode = registrationErrorCodes[5];
                    return errorCode;
                }

                string email = param_S[StringTypeRegistration.Email];
                if (container.AccountSet.SingleOrDefault(x => x.Email == email) != null)
                {
                    errorCode = registrationErrorCodes[6];
                    return errorCode;
                }

                string telephone = param_S[StringTypeRegistration.Telephone];
                if (container.AccountSet.SingleOrDefault(x => x.PhoneNumber == telephone) != null)
                {
                    errorCode = registrationErrorCodes[7];
                    return errorCode;
                }

                // good
            }

            return "Аккаунт был успешно создан";
        }
    }
}
