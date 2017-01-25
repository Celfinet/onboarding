using Cfn.OnBoarding.TDD.Classroom;
using Cfn.OnBoarding.TDD.MathToolBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cfn.OnBoarding.TDD.Classroom.Math
{
    public class MathClassroom : IClassroom
    {
        private IMathToolBox _toolBox;
        
        public string GetExercicesReport(params object[] parameters)
        {

            var str = parameters.Select(p => (int)p).Select(p => $"Fibonacci of {p} is: {_toolBox.Fibonacci(p)}").Aggregate("", (p, a) => a += $"{p}\n");
            //var builder = new StringBuilder();
            //foreach (var parameter in parameters)
            //{
            //    var item = (int)parameter;
            //    builder.Append($"Fibonacci of {item} is: {_toolBox.Fibonacci(item)}\n");

            //}
            //return builder.ToString();
            return str;
        }

        public MathClassroom(IMathToolBox toolBox)
        {
            _toolBox = toolBox;
        }
    }
}
