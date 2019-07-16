using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1007_BounceBall
{
    class TimerExample
    {
        private void allRelevantCode()
        {
            System.Timers.Timer timer = new System.Timers.Timer(10);
            timer.Elapsed += Timer_Elapsed;
            timer.Enabled = true;

        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
        //    Action a = () =>
        //    {
        //        NewX = NewX + dx;
        //        NewY = NewY + dy;
        //        BallPicBx.Location = new Point(NewX, NewY);

        //        if (NewX == X_WINDOW_SIZE + 1)
        //        {
        //            dx = -1;
        //        }
        //        if (NewY == Y_WINDOW_SIZE + 1)
        //        {
        //            dy = -1;
        //        }
        //        if (NewX == 100)
        //        {
        //            dx = 1;
        //        }
        //        if (NewY == 100)
        //        {
        //            dy = 1;
        //        }
        //    };

        //    this.BeginInvoke(a);
        }
    }
}
