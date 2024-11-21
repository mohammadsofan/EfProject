using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Test
    {
        private static Test test=null;
        private Test() { }
      
        public static Test Instance { get { if (test == null) test = new Test(); return test; } }

    }
}
