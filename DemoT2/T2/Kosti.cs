using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Kosti
    {
        private List<int> values = new List<int>();
        public int Min { get { return values.Min(); } }
        public int Max { get { return values.Max(); } }
        public double Avg { get { return values.Average(); } }

        public Kosti()
        {

        }

        public void addValue(int value)
        {
            values.Add(value);
        }

        public void Reset()
        {
            values.Clear();
        }
    }
}
