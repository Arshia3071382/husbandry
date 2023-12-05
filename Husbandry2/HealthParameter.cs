using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Husbandry2
{
   
   public class HealthParameter<T>
        {
            public string Name { get; set; }
            public T Current { get; set; }
            public T Standard { get; set; }

            public override string ToString()
            {
                return $"HealthParameter: Name={Name}, Current={Current}, Standard={Standard}";
            }

            public float StressFactor()
            {
                
                return 0;
            }
        }



    }

