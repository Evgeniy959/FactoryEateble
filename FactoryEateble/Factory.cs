using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryEateble
{
    class Factory
    {
        public IEateble GetEateble(int num) 
        {
            switch (num) 
            {
                case 1: return new IceCream("Пломбир"); break;  
                case 2: return new IceCream("Эскимо"); break;  
                case 3: return new Chocolate ("Сникерс", 50); break;  
                case 4: return new Chocolate ("Марс", 100); break;  
            }
            return null;
        }
    }
}
