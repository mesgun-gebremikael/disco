namespace disco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int discoSize = 20;
            int virusTime = 5;
            int discoHour = 0;

            List<person> persons = Helpers.fillDisco(discoSize);

            while(true)
            {
                int contageous = 0;
                int personCount = 0;
                Console.WriteLine("klockan är "+ discoHour + "timmar");

                foreach(person person in persons)

                {
                    if(person.Infected == true && discoHour >= (person.InfectedWhen + virusTime))
                    {
                        person.Infected = false;
                        person.Immune = true;
                    }

                   if (person.Infected == true)
                   {
                        contageous ++;


                   }
                   // hitta  nästa person som kan bli smittad
                   //Iumna perso och redan smittde person kan inte bli snittad igen
                   // varje person kan bara smitta en enda preson till
                   //timme 0 blir ingen smittad

                   if(discoHour > 0 &&
                        contageous > 0 &&
                        person.Immune == false && 
                        person.Infected == false)
                   {
                        person.Infected = true;
                        person.InfectedWhen = discoHour;
                        contageous --;

                   }
                    Console.WriteLine("Person " + personCount + "\t" +
                      (person.Infected ? "Sjuk" : "Frisk") +
                      "\tSmittotimme: " + person.InfectedWhen +
                      "\t" + (person.Immune ? "Immun" : "Riskerar att bli smittad"));

                    personCount++;
                   
                }
                Console.ReadKey();
                Console.Clear();
                discoHour++;

            }
        }
    }
}
