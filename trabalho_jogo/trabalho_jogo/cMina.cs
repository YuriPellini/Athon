using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_jogo
{
    public class cMina
    {
        string[,] Campo = new string[6, 6]
        { 
            { "a1", "a2", "a3", "a4", "a5", "a6" }, 
            { "b1", "b2", "b3", "b4", "b5", "b6" }, 
            { "c1", "c2", "c3", "c4", "c5", "c6" },
            { "a1", "d2", "d3", "d4", "d5", "d6" },
            { "e1", "e2", "e3", "e4", "e5", "e6" },
            { "f1", "f2", "f3", "f4", "f5", "f6" }
        };
        public void Boon()
        {
            Random = new Random();
        }
        public void Bomba()
        {
            
        }
    }
}
