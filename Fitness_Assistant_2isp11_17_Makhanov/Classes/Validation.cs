using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fitness_Assistant_2isp11_17_Makhanov.ClassHelper;
using Fitness_Assistant_2isp11_17_Makhanov.EF;

namespace Fitness_Assistant_2isp11_17_Makhanov.Classes
{
    public class ValidationReg
    {
        public static bool IsPasswordValid(string password)
        {
            bool flag = false;
            if (password.Length < 8 || password.Length > 20)
            {
                return false;
            }
            if (password.Contains(' '))
            {
                return false;
            }
            for (int i = 0; i < password.Length; i++)
            {
                flag = char.IsDigit(password[i]);
                if (flag)
                {
                    break;
                }
            }
            if (!flag)
            {
                return false;
            }
            for (int i = 0; i < password.Length; i++)
            {
                flag = char.IsUpper(password[i]);
                if (flag)
                {
                    break;
                }
            }
            if (!flag)
            {
                return false;
            }
            for (int i = 0; i < password.Length; i++)
            {
                flag = char.IsLower(password[i]);
                if (flag)
                {
                    break;
                }
            }
            if (!flag)
            {
                return false;
            }
            string speialcSymbols = "!@#$%^&*()-=_+";
            for (int i = 0; i < password.Length; i++)
            {
                flag = speialcSymbols.Contains(password[i]);
                if (flag)
                {
                    break;
                }
            }
            if (!flag)
            {
                return false;
            }
            return true;
        }
        public static bool IsLoginValid(string login)
        {
            if (login.Length < 1 || login.Length > 30)
            {
                return false;
            }
            if (login.Contains(' '))
            {
                return false;
            }
            var userAuth = AppData.Context.User.ToList().FirstOrDefault(i => i.Login == login);
            return userAuth == null;
        }
        public static bool IsLoginValid(string login, int id)
        {
            if (login.Length < 1 || login.Length > 30)
            {
                return false;
            }
            if (login.Contains(' '))
            {
                return false;
            }
            var userAuth = AppData.Context.User.ToList().FirstOrDefault(i => i.Login == login && i.idUser != id);
            return userAuth == null;
        }
        public static bool IsNameValid(string name)
        {
            if (name.Length < 1)
            {
                return false;
            }
            string name1 = name.Replace('-', ' ');
            bool flag = false;
            string[] nameSepperate = name1.Split();
            foreach (string n in nameSepperate)
            {
                if (n == "")
                {
                    return false;
                }
                if (char.IsLower(n[0]))
                {
                    return false;
                }
                for (int i = 1; i < n.Length; i++)
                {
                    flag = char.IsUpper(n[i]);
                    if (flag)
                    {
                        break;
                    }
                }
                if (flag)
                {
                    return false;
                }
                for (int i = 0; i < n.Length; i++)
                {
                    flag = char.IsDigit(n[i]);
                    if (flag)
                    {
                        break;
                    }
                }
                if (flag)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool IsParameterValid(string par)
        {
            if (par.Length < 1)
            {
                return false;
            }
            bool flag = false;
            for (int i = 0; i < par.Length; i++)
            {
                flag = !char.IsDigit(par[i]);
                if (flag)
                {
                    break;
                }
            }
            if (flag)
            {
                return false;
            }
            double p = double.Parse(par);
            return p >= 10 && p <= 300;
        }
        public static bool IsGenderValid(string gender)
        {
            var g = AppData.Context.Gender.ToList().FirstOrDefault(i => i.Gender1 == gender);
            return g != null;
        }
        public static bool IsBirthDateValid(string bd)
        {
            DateTime date = DateTime.Now;
            bool flag = DateTime.TryParse(bd, out date);
            return flag && ((DateTime.Now - date).TotalDays / 365.25) > 6;
        }
    }
}
