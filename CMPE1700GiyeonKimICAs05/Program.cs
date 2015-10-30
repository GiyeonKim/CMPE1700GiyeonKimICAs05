using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPE1700GiyeonKimICAs05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an array of structs

            
            Cards[] Deck = new Cards[Enum.GetValues(typeof(Faces)).Length+43];

         
            int i = 0;
            foreach (Suit s in Enum.GetValues(typeof(Suit)))
            {
                Deck[i].Suits = s;
                Deck[i++].Suits = s;
                

                foreach (Faces f in Enum.GetValues(typeof(Faces)))
                {
                    Deck[i].Face = f;
                    Deck[i++].Face = f;
                    Console.WriteLine(f + " of " + s);
                }
            }
            Console.ReadKey();
           
        }

        
        
    }
}
