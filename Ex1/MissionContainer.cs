using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
  
    public class FunctionsContainer
    {
        private Dictionary<String, Func<Double, Double>> expression =
            new Dictionary<String, Func<Double, Double>>();

        public Func<Double, Double> this[String key]
        {
            get
            {
                if (!expression.ContainsKey(key))
                {
                    expression[key] = val => val; 
                }
                return expression[key];
            }
            set
            {
          
                expression[key] = value;
            }
        }

        public IEnumerable<String> getAllMissions()
        {
            List<string> missionnList = new List<string>(this.expression.Keys);
            return missionnList;
        }





    } // end of class 

        
}
