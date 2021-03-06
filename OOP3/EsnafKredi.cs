using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class EsnafKredi : IKrediManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Esnaf Kredisi Hesaplandı");
        }
    }
}
