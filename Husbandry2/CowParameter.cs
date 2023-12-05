using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Husbandry2
{
    public class CowParameter
    {

        public HealthParameter<int> TimeToStand { get; set; }
        public HealthParameter<int> TimeToDeal { get; set; }
        public HealthParameter<int> TimeToRelax { get; set; }
        public HealthParameter<int> NumberOfMeal { get; set; }
        public HealthParameter<int> NumberOfMilkProduction { get; set; }
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return $"CowParameter: TimeToStand={TimeToStand}, TimeToDeal={TimeToDeal}, TimeToRelax={TimeToRelax}, NumberOfMeal={NumberOfMeal}, NumberOfMilkProduction={NumberOfMilkProduction}, Date={Date}";
        }
    }

    public class SheepParameter
    {
        public HealthParameter<int> TimeToStand { get; set; }
        public HealthParameter<int> TimeToDeal { get; set; }
        public HealthParameter<int> TimeToRelax { get; set; }
        public HealthParameter<int> NumberOfMeal { get; set; }
        public HealthParameter<int> NumberOfWoolProduction { get; set; }
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return $"SheepParameter: TimeToStand={TimeToStand}, TimeToDeal={TimeToDeal}, TimeToRelax={TimeToRelax}, NumberOfMeal={NumberOfMeal}, NumberOfWoolProduction={NumberOfWoolProduction}, Date={Date}";
        }

    }
}
