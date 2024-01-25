using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeInserts
{
    public class Participant
    {
        private string name;
        private double before;
        private double after;
        public Participant(string name, double before, double after)
        {
            this.name = name;
            this.before = before;
            this.after = after;
        }
        public string GetName() {  return name; }
        public double GetBefore() { return before; }
        public double GetAfter() { return after; }
        public void SetName(string name) { this.name = name;}
        public void SetBefore(double before) {  this.before = before;}
        public void SetAfter(double after) {  this.after = after;}
        public double LossPercent() { return ((this.after-this.before)/this.before)*100; }
    }
}
