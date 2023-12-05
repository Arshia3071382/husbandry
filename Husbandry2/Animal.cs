using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Husbandry2
{
    public class Animal
    {
        public DateTime BirthDate { get; init; }
     
        public List<Environment> Environments  = new List<Environment>();
        public float Weight { get; set; }
        public bool Gender { get; set; }
        public string Name { get; set; }

        public float StressFactor()
        {
          
            return 0;
        }

        public int Life()
        {
           
            return 0;
        }
    }
    public class Cow : IComparable<Cow>, IEnumerable<Cow>
    {
        public DateTime BirthDate { get; init; }
      
        public List<Environment> Environments  = new List<Environment>();
        public static int Number { get; set; }
        public List<CowParameter> CowParameters  = new List<CowParameter>();

        public int CompareTo(Cow other)
        {
           
            return 0;
        }

        public IEnumerator<Cow> GetEnumerator()
        {
            
            return null;
        }

       
       

        public override string ToString()
        {
            return $"Cow: BirthDate={BirthDate}, Number={Number}";
        }
    }

    public class Sheep : IComparable<Sheep>, IEnumerable<Sheep>
    {
        public DateTime BirthDate { get; init; }
     
        public List<Environment> Environments  = new List<Environment>();
        public static int Number { get; set; }
        public List<SheepParameter> SheepParameters  = new List<SheepParameter>();

        public int CompareTo(Sheep other)
        {
           
            return 0;
        }

       

   
        }

        public override string ToString()
        {
            return $"Sheep: BirthDate={BirthDate}, Number={Number}";
        }
    }

}

