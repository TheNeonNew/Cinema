using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_viewers
{
    public class Student : BasicViewer
    {
        public Student() { }
        public override void Visit()
        {
            base.Visit();
            Console.WriteLine("Наш кинотеатр посетил студент {0}", this.Name);
            this.ReturnBill();
        }
        public override void ReturnBill()
        {
            int sum = 0;
            for (int i = enter_count; i < enter_count + ticket_count; i++)
            {
                if (i % 3 == 0) {
                    sum += ticket_cost / 2;
                    Console.WriteLine(TicketPrices.Discount50);
                    continue;
                }
                sum += ticket_cost;
                Console.WriteLine(TicketPrices.FullPrice);
            }
            Console.WriteLine(TicketPrices.BillTitle);
            Console.WriteLine("Итого к оплате: {0}", sum);
        }
    }
}
