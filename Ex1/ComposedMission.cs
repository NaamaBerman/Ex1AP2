
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class ComposedMission : IMission
    {
        private List<Func<Double, Double>> missionList = new List<Func<Double, Double>>();

        public ComposedMission(String name)
        {
            this.Name = name;
            this.Type = "Composed";
        }
    
        public string Name { get; }

        public string Type { get; }

        public event EventHandler<double> OnCalculate;

        public double Calculate(double value)
        {
            
            foreach (var m in missionList)
            {
                value = m(value);
            }
            OnCalculate?.Invoke(this, value);
            return value;
        }
        public ComposedMission Add(Func<Double, Double> mission)
        {
            missionList.Add(mission);
            return this;
        }

    }///////
}
