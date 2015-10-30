using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPE1700GiyeonKimICAs05
{
    public enum Suit
    {
        Diamonds,
        Clubs,
        Hearts,
        Spades
    }
    public enum Faces
    {
        Two =1,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
    public struct Cards
    {
        
        public Suit Suits;
        public Faces Face;


        public override string ToString()
        {
            return Face + " of " + Suits;
        }
    }
}
