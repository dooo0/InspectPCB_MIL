using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;//.Tasks;

namespace Vision.Sequence
{
    public class Sequence_Laser : Sequence_Interface
    {
        public Sequence_Laser(int nMode)
        {
            Mode = nMode;

            for (int i = 0; i < 2; i++)
            {
                SeqTask[0] = new Thread(() => Task(0));
                SeqTask[1] = new Thread(() => Task(1));
            }
        }

        ~Sequence_Laser()
        {
            foreach (var seq in SeqTask)
            {
               // seq.();
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
                //seq.Wait();
            }
        }


        public override void Task(int Num)
        {
            while (true)
            {

            }
        }
    }
}
