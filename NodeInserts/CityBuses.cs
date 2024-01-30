using NodeClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeInserts
{
    public class CityBuses
    {
        private string city;
        private Node<Bus> buses;
        public string GetCity() { return city; }
        public Node<Bus> GetBuses() {  return buses; }
    }
}
