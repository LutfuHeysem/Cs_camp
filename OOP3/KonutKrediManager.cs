using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class KonutKrediManager : IKrediManager
    {
        public void Calculate()
        {
            Console.WriteLine("Konut kredisi odeme plani hesaplandi.");
        }
    }
}
