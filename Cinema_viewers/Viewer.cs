using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_viewers
{
    public class Viewer : BasicViewer
    {
        
        public Viewer()
        {

        }

        public override void Visit()
        {
            base.Visit();
            Console.WriteLine("Наш кинотеатр посетил новый клиент {0}", this.Name);
            Console.WriteLine("Количество купленных билетов {0}", this.ticket_count);
            base.ReturnBill();
        }
    }
}
