using System;
using System.IO;
using System.Text;

namespace KPO_laba11_3
{
    class Program
    {
        static void Main(string[] args)
        {
            PostOffice postOffice = new PostOffice();

            ISubscriber Alex = new SubscriberNewsparer();
			ISubscriber Lena = new SubscriberNewsparer();
            ISubscriber Ivan = new SubscriberMagazines();
            ISubscriber Oly = new SubscriberMagazines();			

            postOffice.subscribe(Alex);
			postOffice.subscribe(Lena);
            postOffice.subscribe(Ivan);
			postOffice.subscribe(Oly);			

            postOffice.sendNewspaper();            
			Console.WriteLine("--------------------------");
            postOffice.sendLog();
			Console.WriteLine("--------------------------");			
        }
    }
}
