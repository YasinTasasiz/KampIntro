using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            
            IKrediManager tasitKrediManager = new TasitKrediManager();
            
            IKrediManager konutKrediManager = new KonutKrediManager();

            IKrediManager esnafKrediManager = new EsnafKrediManager();

            IloggerService databaseLoggerService = new DatabaseLoggerService(); 
            IloggerService fileLoggerService = new FileLoggerService();
            IloggerService smsLoggerService = new SmsLoggerService();
            
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKrediManager, new List<IloggerService>() { fileLoggerService, databaseLoggerService });

            List<IKrediManager> krediler = new List<IKrediManager>() {esnafKrediManager, tasitKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }

}
