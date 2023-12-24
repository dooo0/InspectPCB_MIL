using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Vision.Sequence
{
    public class Sequence_Interface
    {
        protected int Mode = 0;
        protected List<Thread> SeqTask;

        public Sequence_Interface() { }
        ~Sequence_Interface() { }

        public virtual void Run() { }
        public virtual void Stop() { }
        public virtual void Task(int Num) { }       
    }
}
