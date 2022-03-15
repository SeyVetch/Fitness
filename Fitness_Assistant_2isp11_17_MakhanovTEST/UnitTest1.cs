using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static Fitness_Assistant_2isp11_17_Makhanov.Classes.ValidationReg;

namespace Fitness_Assistant_2isp11_17_MakhanovTEST
{
    [TestClass]
    public class ValidationTest
    {
        [TestMethod]
        public void IsPasswordValid_Correct_true()
        {
            //Arrange
            string password = "Q%b5nY&3o";
            bool result = true;

            //Act
            bool act = IsPasswordValid(password);

            //Assert
            Assert.AreEqual(result, act);

        }
        [TestMethod]
        public void IsPasswordValid_Length7_false()
        {
            //Arrange
            string password = "!A1abcd";
            bool result = false;

            //Act
            bool act = IsPasswordValid(password);

            //Assert
            Assert.AreEqual(result, act);

        }
        [TestMethod]
        public void IsPasswordValid_Length21_false()
        {
            //Arrange
            string password = "!A1abcd12345678901234";
            bool result = false;

            //Act
            bool act = IsPasswordValid(password);

            //Assert
            Assert.AreEqual(result, act);

        }
        [TestMethod]
        public void IsPasswordValid_NoDigit_false()
        {
            //Arrange
            string password = "!Aabcdef";
            bool result = false;

            //Act
            bool act = IsPasswordValid(password);

            //Assert
            Assert.AreEqual(result, act);

        }
        [TestMethod]
        public void IsPasswordValid_NoLower_false()
        {
            //Arrange
            string password = "!A1ABCDE";
            bool result = false;

            //Act
            bool act = IsPasswordValid(password);

            //Assert
            Assert.AreEqual(result, act);

        }
        [TestMethod]
        public void IsPasswordValid_NoUpper_false()
        {
            //Arrange
            string password = "!a1abcde";
            bool result = false;

            //Act
            bool act = IsPasswordValid(password);

            //Assert
            Assert.AreEqual(result, act);

        }
        [TestMethod]
        public void IsPasswordValid_NoSpecSymbol_false()
        {
            //Arrange
            string password = "AA1abcde";
            bool result = false;

            //Act
            bool act = IsPasswordValid(password);

            //Assert
            Assert.AreEqual(result, act);

        }
        [TestMethod]
        public void IsPasswordValid_Empty_false()
        {
            //Arrange
            string password = "";
            bool result = false;

            //Act
            bool act = IsPasswordValid(password);

            //Assert
            Assert.AreEqual(result, act);

        }
        [TestMethod]
        public void IsPasswordValid_OnlySpace_false()
        {
            //Arrange
            string password = "        "; //8 * " "
            bool result = false;

            //Act
            bool act = IsPasswordValid(password);

            //Assert
            Assert.AreEqual(result, act);

        }
        [TestMethod]
        public void IsPasswordValid_Space_false()
        {
            //Arrange
            string password = "a!A1  aab1";
            bool result = false;

            //Act
            bool act = IsPasswordValid(password);

            //Assert
            Assert.AreEqual(result, act);

        }
        [TestMethod]
        public void IsLoginValid_Correct_true()
        {
            //Arrange
            string login = "SeyVetch";
            bool result = true;

            //Act
            bool act = IsLoginValid(login);

            //Assert
            Assert.AreEqual(result, act);

        }
        [TestMethod]
        public void IsLoginValid_IsEditRepeatLogin_true()
        {
            //Arrange
            string login = "Login";
            int id = 1;
            bool result = true;

            //Act
            bool act = IsLoginValid(login, id);

            //Assert
            Assert.AreEqual(result, act);

        }
        [TestMethod]
        public void IsLoginValid_LoginExists_false()
        {
            //Arrange
            string login = "Login";
            int id = 2;
            bool result = false;

            //Act
            bool act = IsLoginValid(login, id);

            //Assert
            Assert.AreEqual(result, act);

        }
        [TestMethod]
        public void IsLoginValid_Length31_false()
        {
            //Arrange
            string login = "A123456789012345678901234567890";
            bool result = false;

            //Act
            bool act = IsLoginValid(login);

            //Assert
            Assert.AreEqual(result, act);

        }
        [TestMethod]
        public void IsLoginValid_Empty_false()
        {
            //Arrange
            string login = "";
            bool result = false;

            //Act
            bool act = IsLoginValid(login);

            //Assert
            Assert.AreEqual(result, act);

        }
        [TestMethod]
        public void IsLoginValid_OnlySpace_false()
        {
            //Arrange
            string login = "        ";
            bool result = false;

            //Act
            bool act = IsLoginValid(login);

            //Assert
            Assert.AreEqual(result, act);

        }
        [TestMethod]
        public void IsLoginValid_Space_false()
        {
            //Arrange
            string login = "a a";
            bool result = false;

            //Act
            bool act = IsLoginValid(login);

            //Assert
            Assert.AreEqual(result, act);

        }
        [TestMethod]
        public void IsNameValid_Correct_true()
        {
            //Arrange
            string name = "Маханов Александр-Анатольевич";
            bool result = true;

            //Act
            bool act = IsNameValid(name);

            //Assert
            Assert.AreEqual(result, act);

        }
        [TestMethod]
        public void IsNameValid_HasDigit_false()
        {
            //Arrange
            string name = "Маханов1";
            bool result = false;

            //Act
            bool act = IsNameValid(name);

            //Assert
            Assert.AreEqual(result, act);

        }
        [TestMethod]
        public void IsNameValid_NoUpper_false()
        {
            //Arrange
            string name = "маханов";
            bool result = false;

            //Act
            bool act = IsNameValid(name);

            //Assert
            Assert.AreEqual(result, act);

        }
        [TestMethod]
        public void IsNameValid_InvalidUpperPlacement_false()
        {
            //Arrange
            string name = "маХанов";
            bool result = false;

            //Act
            bool act = IsNameValid(name);

            //Assert
            Assert.AreEqual(result, act);

        }
        [TestMethod]
        public void IsNameValid_OnlySpace_false()
        {
            //Arrange
            string name = "            ";
            bool result = false;

            //Act
            bool act = IsNameValid(name);

            //Assert
            Assert.AreEqual(result, act);

        }
        [TestMethod]
        public void IsNameValid_Empty_false()
        {
            //Arrange
            string name = "";
            bool result = false;

            //Act
            bool act = IsNameValid(name);

            //Assert
            Assert.AreEqual(result, act);

        }
        [TestMethod]
        public void IsGenderValid_Correct_true()
        {
            //Arrange
            string gender = "Мужской";
            bool result = true;

            //Act
            bool act = IsGenderValid(gender);

            //Assert
            Assert.AreEqual(result, act);

        }
        [TestMethod]
        public void IsGenderValid_Empty_false()
        {
            //Arrange
            string gender = "";
            bool result = false;

            //Act
            bool act = IsGenderValid(gender);

            //Assert
            Assert.AreEqual(result, act);

        }
        [TestMethod]
        public void IsGenderValid_OnlySpace_false()
        {
            //Arrange
            string gender = "         ";
            bool result = false;

            //Act
            bool act = IsGenderValid(gender);

            //Assert
            Assert.AreEqual(result, act);

        }
        [TestMethod]
        public void IsBirthDateValid_Correct_true()
        {
            //Arrange
            string BirthDate = "07/07/2002";
            bool result = true;

            //Act
            bool act = IsBirthDateValid(BirthDate);

            //Assert
            Assert.AreEqual(result, act);

        }
        [TestMethod]
        public void IsBirthDateValid_Invalid_false()
        {
            //Arrange
            string BirthDate = (DateTime.Now + (DateTime.Now - DateTime.Parse("07.07.2002"))).Date.ToString();
            bool result = false;

            //Act
            bool act = IsBirthDateValid(BirthDate);

            //Assert
            Assert.AreEqual(result, act);

        }
        [TestMethod]
        public void IsBirthDateValid_Empty_false()
        {
            //Arrange
            string BirthDate = "";
            bool result = false;

            //Act
            bool act = IsBirthDateValid(BirthDate);

            //Assert
            Assert.AreEqual(result, act);

        }
        [TestMethod]
        public void IsBirthDateValid_OnlySpace_false()
        {
            //Arrange
            string BirthDate = "       ";
            bool result = false;

            //Act
            bool act = IsBirthDateValid(BirthDate);

            //Assert
            Assert.AreEqual(result, act);

        }
        [TestMethod]
        public void IsParameterValid_Correct_true()
        {
            //Arrange
            string par = "60";
            bool result = true;

            //Act
            bool act = IsParameterValid(par);

            //Assert
            Assert.AreEqual(result, act);

        }
        [TestMethod]
        public void IsParameterValid_Low_false()
        {
            //Arrange
            string par = "9";
            bool result = false;

            //Act
            bool act = IsParameterValid(par);

            //Assert
            Assert.AreEqual(result, act);

        }
        [TestMethod]
        public void IsParameterValid_High_false()
        {
            //Arrange
            string par = "301";
            bool result = false;

            //Act
            bool act = IsParameterValid(par);

            //Assert
            Assert.AreEqual(result, act);

        }
        [TestMethod]
        public void IsParameterValid_NotNumber_false()
        {
            //Arrange
            string par = "A22";
            bool result = false;

            //Act
            bool act = IsParameterValid(par);

            //Assert
            Assert.AreEqual(result, act);

        }
        [TestMethod]
        public void IsParameterValid_Empty_false()
        {
            //Arrange
            string par = "";
            bool result = false;

            //Act
            bool act = IsParameterValid(par);

            //Assert
            Assert.AreEqual(result, act);

        }
        [TestMethod]
        public void IsParameterValid_OnlySpace_false()
        {
            //Arrange
            string par = "         ";
            bool result = false;

            //Act
            bool act = IsParameterValid(par);

            //Assert
            Assert.AreEqual(result, act);

        }
        [TestMethod]
        public void IsParameterValid_Space_false()
        {
            //Arrange
            string par = "12 3";
            bool result = false;

            //Act
            bool act = IsParameterValid(par);

            //Assert
            Assert.AreEqual(result, act);

        }
    }
}
