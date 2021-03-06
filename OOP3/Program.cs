using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
           IKrediManager ihtiyaçKrediManager = new İhtiyaçKrediManager();
            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            KonutKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafkredi = new EsnafKredi();
            ILoggerService databasLoggerService = new DatabaseLoggerService();
            ILoggerService fileLogerService = new FileLoggerService();


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafkredi, new SmsLogger());

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyaçKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
