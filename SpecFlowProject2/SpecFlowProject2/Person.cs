using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject2
{
    public class Person
    {
        public int Weight { get; set; }   
        
        public int Train(int increaseWeight, int currentWeight)
        {
            return currentWeight + increaseWeight;

        }
    }
    
}
