using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_viewers
{
    struct TicketPrices
    {
        public const string BillTitle = "=================Чек=================";
        public const string Discount50 = "+ билет со скидкой 50%";
        public const string Discount5 = "+ билет со скидкой 5%";
        public const string Discount10 = "+ билет со скидкой 10%";
        public const string Discount20 = "+ билет со скидкой 20%";
        public const string FullPrice = "+ билет за полную стоимость";
        public const string FreeTicket = "+ билет с полной скидкой";
    }
    public abstract class BasicViewer
    {
        public string? Name { get; set; }

        public int enter_count;
        public int ticket_cost;
        public int ticket_count;

        public virtual void Visit() { 
            Console.WriteLine("Введите имя: ");
            this.Name = Console.ReadLine();
            Console.WriteLine("Введите количество посещений: ");
            this.enter_count = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите стоимость билета: ");
            this.ticket_cost = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите количество билетов: ");
            this.ticket_count = Convert.ToInt16(Console.ReadLine());
        }

        public virtual void ReturnBill()
        {
            Console.WriteLine("Количество купленных билетов {0}", this.ticket_count);
            Console.WriteLine(TicketPrices.BillTitle);
            Console.WriteLine("Итого к оплате: {0}", ticket_count * ticket_cost);
        }
    }
}
