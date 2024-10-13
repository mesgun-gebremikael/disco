using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disco
{
    internal class Helpers
    {
        public static List <person> fillDisco(int discoSize)
        {
            List <person> persons = new List <person>();
            for(int i = 0; i <  discoSize; i++)
            {
                person person = new person();
                if(i ==0)
                {
                  person.Infected = true;
                  person.InfectedWhen = 0;
                }
                persons.Add(person);
                

            }
            return persons;
        }
    }

}
