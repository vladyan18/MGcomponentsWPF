using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGcomponentsWPF
{
    public class Order
    {
        int author { get; }
        string order { get; }
        List<int> args { get; }

        public Order(int author, string order = "", List<int> args = null)
        {
            this.author = author;
            this.order = order;
            this.args = args;
        }
    }
}
