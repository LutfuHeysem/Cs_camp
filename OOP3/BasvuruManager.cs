using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager)
        {
            //Basvuran bilgisi degerlendirme
            //
            //

            krediManager.Calculate();
        }

        public void BasvuruOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach(var kredi in krediler)
            {
                kredi.Calculate();
            }
        }
    }
}
