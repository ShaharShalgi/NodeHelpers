using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeInserts
{
    public class Station
    {
        private string street;
        private int num;
        public Station(string street, int num) 
        {
            this.street = street;
            this.num = num;
        }
        public string GetStreet() { return this.street; }
        public int GetNum() { return this.num;}
        public void SetStreet(string street) {  this.street = street; }
        public void SetNum(int num) {  this.num = num; }
        public bool Equals(Station s)
        {
            if(this == s) return true;
             return false;
        }
    }
}
