using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeInserts
{
    public class Device
    {
        protected string pwd;
        protected bool working;
        public Device(string pwd) 
        {
            this.pwd = pwd;
            this.working = false;
        }
    }
}
