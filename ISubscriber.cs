using KPO_laba11_3;

namespace KPO_laba11_3
{
    // Интерфейс подписчика
    public interface ISubscriber
    {
		public PostOffice postOffice { get; set; }
        void update(bool package);
    }
}