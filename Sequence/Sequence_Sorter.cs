using Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Vision.Sequence
{
    public class Sequence_Sorter : Sequence_Interface
    {

        public Sequence_Sorter(int nMode) 
        {
            Mode = nMode;
            SeqTask = new List<Thread>();

            for (int i = 0; i < 2; i++)
            {
                Thread Task_Sorter = new Thread(() => Task(i));
                SeqTask.Add(Task_Sorter);
            }
        }

        ~Sequence_Sorter()
        {
            foreach (var seq in SeqTask)
            {
                //seq.Wait();
                //seq.Dispose();
            }
        }

        public override void Run()
        {
            foreach (var seq in SeqTask)
            {
                seq.Start();
            }
        }

        public override void Stop()
        {
            foreach (var seq in SeqTask)
            {
                seq.Abort();
            }
        }


        public override void Task(int Num) 
        { 
            while(GlobalInstance.Run)
            {
                System.Threading.Thread.Sleep(10);
            }
        }
    }
}
