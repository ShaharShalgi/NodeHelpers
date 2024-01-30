using NodeClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeInserts
{
    public class Bus
    {
        private int num;
        private double price;
        private Node<Station> stations;
        public Node<Station> GetStation() { return stations; }
      
        public double Ride(Station start, Station end)
        {
            bool isStart = false;
            double total = 0;
            Node<Station> node = this.stations;
            while(node != null && !node.GetValue().Equals(end))
            {
                if(!isStart && node.GetValue().Equals(start)) 
                {
                    
                    total += price;
                    isStart = true;

                }
                else if (isStart)
                {
                    total += price;
                }
                node = node.GetNext();
            }
            if (node == null || !isStart)
            {
                return -1;
            }
            else
                return total;

        }
    }
}
