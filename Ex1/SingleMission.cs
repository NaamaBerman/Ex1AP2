using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class SingleMission : IMission
    {

        private Func<Double, Double> mission;
        public SingleMission(Func<Double, Double> mission, String name) 
        {
            this.mission = mission;
            this.Name = name;
            this.Type = "Single";
        }

        public string Name { get; }

        public string Type { get; }

        public event EventHandler<double> OnCalculate;

        public double Calculate(double value)
        {
            value = mission(value);
            OnCalculate?.Invoke(this, value);
            return value;

        }



    }//////////
}
