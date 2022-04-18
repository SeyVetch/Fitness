using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using static Fitness_Assistant_2isp11_17_Makhanov.ClassHelper.ParametersClass;

namespace Fitness_Assistant_2isp11_17_MakhanovTEST
{
    [TestClass]
    public class UnitTest2
    {
        static readonly string[] BMITypes =
            {
            "Выраженный дефицит массы тела",        //BMI<=16      0
            "Недостаточная (дефицит) масса тела",   //16<BMI<=18.5 1
            "Норма",                                //18.5<BMI<=25 2
            "Избыточная масса тела (предожирение)", //25<BMI<=30   3
            "Ожирение 1 степени",                   //30<BMI<=35   4
            "Ожирение 2 степени",                   //35<BMI<=40   5
            "Ожирение 3 степени"                    //40<BMI       6
            };

        [TestMethod]
        public void BMIType_15Is0_true()
        {
            //Arrange
            double par = 15;
            bool result = true;

            //Act
            bool act = BMIType(par) == BMITypes[0];

            //Assert
            Assert.AreEqual(result, act);

        }
        [TestMethod]
        public void BMIType_16Is0_true()
        {
            //Arrange
            double par = 16;
            bool result = true;

            //Act
            bool act = BMIType(par) == BMITypes[0];

            //Assert
            Assert.AreEqual(result, act);

        }
        [TestMethod]
        public void BMIType_17Is1_true()
        {
            //Arrange
            double par = 17;
            bool result = true;

            //Act
            bool act = BMIType(par) == BMITypes[1];

            //Assert
            Assert.AreEqual(result, act);

        }
        [TestMethod]
        public void BMIType_18Dot5Is1_true()
        {
            //Arrange
            double par = 18.5;
            bool result = true;

            //Act
            bool act = BMIType(par) == BMITypes[1];

            //Assert
            Assert.AreEqual(result, act);

        }
        [TestMethod]
        public void BMIType_20Is2_true()
        {
            //Arrange
            double par = 20;
            bool result = true;

            //Act
            bool act = BMIType(par) == BMITypes[2];

            //Assert
            Assert.AreEqual(result, act);

        }
        [TestMethod]
        public void BMIType_25Is2_true()
        {
            //Arrange
            double par = 25;
            bool result = true;

            //Act
            bool act = BMIType(par) == BMITypes[2];

            //Assert
            Assert.AreEqual(result, act);

        }
        [TestMethod]
        public void BMIType_26Is3_true()
        {
            //Arrange
            double par = 26;
            bool result = true;

            //Act
            bool act = BMIType(par) == BMITypes[3];

            //Assert
            Assert.AreEqual(result, act);

        }
        [TestMethod]
        public void BMIType_30Is2_true()
        {
            //Arrange
            double par = 20;
            bool result = true;

            //Act
            bool act = BMIType(par) == BMITypes[2];

            //Assert
            Assert.AreEqual(result, act);

        }

    }
}
