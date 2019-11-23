using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace KPO_laba11_3
{
    /* Класс PostOffice класс-издатель 
    Имитирует работу отделения почты, изменение которого интересно отслеживать подписчикам.
    Отвечает за подписку/отписку на рассылку
    Отправляет газеты/журналы подписчикам*/
    public class PostOffice
    {
        // Список хранящий подписчиков
		public List<ISubscriber> subscribers;
		
        public PostOffice()
		{
			subscribers = new List<ISubscriber>();
		}
		// Подписка на рассылку
		public void subscribe(ISubscriber s)
		{
			if (s.postOffice == null)
			{
				subscribers.Add(s);
			}
		}
		// Отказаться от рассылки
		public void unsubscribe(ISubscriber s)
		{
			subscribers.Remove(s);
		}
		// Отправка газеты
		public void sendNewspaper()
		{
			foreach(var subscr in subscribers)
			{
				subscr.update(true);
			}
		}
		// Отправка журнала
		public void sendLog()
		{
			foreach (var subscr in subscribers)
			{
				subscr.update(false);
			}
		}
    }
}