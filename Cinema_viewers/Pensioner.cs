using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_viewers
{
    public class Pensioner : BasicViewer
    {
        public Pensioner() { }
        public override void Visit()
        {
            base.Visit();
            Console.WriteLine("Наш кинотеатр посетил пенсионер {0}", this.Name);
            this.ReturnBill();
        }
        public override void ReturnBill()
        {
            int sum = 0;
            for (int i = enter_count; i < enter_count + ticket_count; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(TicketPrices.FreeTicket);
                    continue;
                }
                sum += ticket_cost / 2;
                Console.WriteLine(TicketPrices.Discount50);
            }
            Console.WriteLine(TicketPrices.BillTitle);
            Console.WriteLine("Итого к оплате: {0}", sum);
        }
    }
}
