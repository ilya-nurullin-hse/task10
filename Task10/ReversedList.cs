using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class ReversedList
    {
        public int data;
        public ReversedList prev;

        public ReversedList(int data, ReversedList prev = null)
        {
            this.data = data;
            this.prev = prev;
        }

        public ReversedList append(int s)
        {
            return new ReversedList(s, this);
        }

        public override string ToString()
        {
            if (prev == null) return "null";
            return data + "->" + prev.ToString();
        }
    }
}
