using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var s = new student
            {
                name="sajad",
                family="hoini",
                id="123456",

                Dars = new List<dars>
                {
                    new dars
                    {
                        vahed=3,
                        name="phizk",
                        reshte="math"

  
                    },
                    new dars
                    {
                        vahed=2,
                        name="shimi",
                        reshte="ensani",

                    },
                            



                }



           
            };
            Console.Write("name:      family:      id:     jame vahed:         tedade dars:      vahed:");
            Console.WriteLine();
            Console.Write("{0}    {1}      {2}       {3}                    {4}             {5}", s.name, s.family, s.id,s.Dars.Sum(x=>x.vahed),s.Dars.Count,s.Dars.Select(x=>x.vahed));
            Console.ReadLine(); 
        }
    }

}
