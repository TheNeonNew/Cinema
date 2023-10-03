using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_viewers
{
    public class Regular : BasicViewer
    {
        public Regular() { }
        public override void Visit()
        {
            base.Visit();
            Console.WriteLine("Наш кинотеатр посетил постоянный покупатель {0}", this.Name);
            this.ReturnBill();
        }
    }
}
