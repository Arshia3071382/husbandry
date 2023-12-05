using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Husbandry2
{
    public class Environment
    {
        
            public HealthParameter<int> TDS { get; set; }
            public HealthParameter<int> Temp { get; set; }
            public HealthParameter<float> Density { get; set; }
            public HealthParameter<float> db { get; set; }
            public HealthParameter<int> AQI { get; set; }
            public HealthParameter<int> OX { get; set; }
            public DateTime Date { get; set; }

            public override string ToString()
            {
                return $"Environment: TDS={TDS}, Temp={Temp}, Density={Density}, db={db}, AQI={AQI}, OX={OX}, Date={Date}";
            }

            public int TimeToDie()
            {
               
                return 1;
            }

            public float KillPriority()
            {
                
                return 0;
            }

            public int CostPerDay()
            {
                
                return 1;
            }

            public int ValuePerDay()
            {
              
                return 0;
            }
        }



    }

