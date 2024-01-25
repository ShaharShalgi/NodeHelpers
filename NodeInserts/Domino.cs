using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeInserts
{
    public class Domino
    {
        private int firstnum;
        private int secondnum;
        public Domino(int firstnum, int secondnum) 
        {
        this.firstnum = firstnum;
            this.secondnum = secondnum;
        }
        public int getFirstnum() { return firstnum; }
        public int getSecondnum() {  return secondnum; }
        public void setFirstnum(int firstnum) {  this.firstnum = firstnum; }
        public void setSecondnum(int secondnum) { this.secondnum = secondnum; }
        public bool isDomino(int t)
        {
            if(firstnum == t ||secondnum == t) return true;
            return false;
        }
    }
}
