using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Assistant_2isp11_17_Makhanov.ClassHelper
{
    public class ParametersClass
    {
        static readonly string[] BMITypes =
            {
            "Выраженный дефицит массы тела",
            "Недостаточная (дефицит) масса тела",
            "Норма",
            "Избыточная масса тела (предожирение)",
            "Ожирение 1 степени",
            "Ожирение 2 степени",
            "Ожирение 3 степени"
            };
        public static double BMI(double weight, double height)
        {
            return Math.Round(weight / (height * height / 10000), 2);
        }
        public static double BMR(string idGender, double height, double weight, double age)
        {
            int s = 0;
            if (idGender == "ж")
            {
                s = -161;
            }
            if (idGender == "м")
            {
                s = 5;
            }
            return Math.Round(10 * weight + 6.25 * height - 5 * (double)age + s, 2);
        }
        public static string BMIType(double d)
        {
            if (d <= 16) return BMITypes[0];
            if (d <= 18.5) return BMITypes[1];
            if (d <= 25) return BMITypes[2];
            if (d <= 30) return BMITypes[3];
            if (d <= 35) return BMITypes[4];
            if (d <= 40) return BMITypes[5];
            return BMITypes[6];
        }
    }
}
