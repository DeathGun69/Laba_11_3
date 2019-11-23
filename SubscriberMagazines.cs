using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace KPO_laba11_3
{
    /* Класс SubscriberMagazines, класс-подписчик 
    Данный подпискич подписан на получение журналов*/
    public class SubscriberMagazines: ISubscriber
    {
        public PostOffice postOffice { get; set; }
		public void update(bool package)
		{
			// Проверить полученую почту
			if (!package)
			{
				Console.WriteLine("\nПочта верна!");
                Console.WriteLine("Почтальон доставил журнал.");
			} 
		}
    }
}