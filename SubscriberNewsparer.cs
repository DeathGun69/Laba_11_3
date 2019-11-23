using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace KPO_laba11_3
{
    /* Класс SubscriberNewsparer, класс-подписчик 
    Данный подпискич подписан на получение газет*/
    public class SubscriberNewsparer: ISubscriber
    {
        public PostOffice postOffice { get; set; }
		public void update(bool package)
		{
			// Проверить полученую почту
			if (package)
			{
				Console.WriteLine("\nПочта верна!");
                Console.WriteLine("Почтальон доставил газеты.");
			} 
		}
    }
}