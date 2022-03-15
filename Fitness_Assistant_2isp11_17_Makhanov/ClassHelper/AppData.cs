using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Assistant_2isp11_17_Makhanov.ClassHelper
{
    class AppData
    {
        public static EF.FitnessEntities Context { get; } = new EF.FitnessEntities();
    }
}
