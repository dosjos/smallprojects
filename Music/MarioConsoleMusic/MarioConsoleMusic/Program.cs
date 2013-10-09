using System;
using System.Threading;
using System.Collections;
using System.Timers;

namespace MarioConsoleMusic
{
    class Program
    {
        static readonly IList List = new ArrayList();
        static readonly IList List2 = new ArrayList();
        static readonly IList DelayList = new ArrayList();
        static Thread2 _t;
        static Thread _oThread;
        static int _counter;
        static readonly System.Timers.Timer Timer = new System.Timers.Timer();
        static void Main()
        {
            Timer.Elapsed += OnTimedEvent;
            _t = new Thread2();
            _oThread = new Thread(_t.Work);
                        Play(660, 100);
            Delay(75); Play(660, 100);
            Delay(150); Play(660, 100);
            Delay(150); Play(510, 100);
            Delay(50); Play(660, 100);
            Delay(150); Play(770, 100);
            Delay(275); Play(380, 100);
            Delay(287); Play(510, 100);
            Delay(225); Play(380, 100);
            Delay(200); Play(320, 100);
            Delay(250); Play(440, 100);
            Delay(150); Play(480, 80);
            Delay(165); Play(450, 100);
            Delay(75); Play(430, 100);
            Delay(150); Play(380, 100);
            Delay(100); Play(660, 80);
            Delay(100); Play(760, 50);
            Delay(75); Play(860, 100);
            Delay(150); Play(700, 80);
            Delay(75); Play(760, 50);
            Delay(175); Play(660, 80);
            Delay(150); Play(520, 80);
            Delay(75); Play(580, 80);
            Delay(75); Play(480, 80);
            Delay(175); Play(510, 100);
            Delay(275); Play(380, 100);
            Delay(200); Play(320, 100);
            Delay(250); Play(440, 100);
            Delay(150); Play(480, 80);
            Delay(165); Play(450, 100);
            Delay(75); Play(430, 100);
            Delay(150); Play(380, 100);
            Delay(100); Play(660, 80);
            Delay(100); Play(760, 50);
            Delay(75); Play(860, 100);
            Delay(150); Play(700, 80);
            Delay(75); Play(760, 50);
            Delay(175); Play(660, 80);
            Delay(150); Play(520, 80);
            Delay(75); Play(580, 80);
            Delay(75); Play(480, 80);
            Delay(250); Play(500, 100);
            Delay(150); Play(760, 100);
            Delay(50); Play(720, 100);
            Delay(75); Play(680, 100);
            Delay(75); Play(620, 150);
            Delay(150); Play(650, 150);
            Delay(150); Play(380, 100);
            Delay(75); Play(430, 100);
            Delay(75); Play(500, 100);
            Delay(150); Play(430, 100);
            Delay(75); Play(500, 100);
            Delay(50); Play(570, 100);
            Delay(110); Play(500, 100);
            Delay(150); Play(760, 100);
            Delay(50); Play(720, 100);
            Delay(75); Play(680, 100);
            Delay(75); Play(620, 150);
            Delay(150); Play(650, 200);
            Delay(150); Play(1020, 80);
            Delay(150); Play(1020, 80);
            Delay(75); Play(1020, 80);
            Delay(150); Play(380, 100);
            Delay(150); Play(500, 100);
            Delay(150); Play(760, 100);
            Delay(50); Play(720, 100);
            Delay(75); Play(680, 100);
            Delay(75); Play(620, 150);
            Delay(150); Play(650, 150);
            Delay(150); Play(380, 100);
            Delay(75); Play(430, 100);
            Delay(75); Play(500, 100);
            Delay(150); Play(430, 100);
            Delay(75); Play(500, 100);
            Delay(50); Play(570, 100);
            Delay(110); Play(500, 100);
            Delay(150); Play(760, 100);
            Delay(50); Play(720, 100);
            Delay(75); Play(680, 100);
            Delay(75); Play(620, 150);
            Delay(150); Play(650, 200);
            Delay(150); Play(1020, 80);
            Delay(150); Play(1020, 80);
            Delay(75); Play(1020, 80);
            Delay(150); Play(380, 100);
            Delay(150); Play(500, 100);
            Delay(150); Play(760, 100);
            Delay(50); Play(720, 100);
            Delay(75); Play(680, 100);
            Delay(75); Play(620, 150);
            Delay(150); Play(650, 150);
            Delay(150); Play(380, 100);
            Delay(75); Play(430, 100);
            Delay(75); Play(500, 100);
            Delay(150); Play(430, 100);
            Delay(75); Play(500, 100);
            Delay(50); Play(570, 100);
            Delay(210); Play(585, 100);
            Delay(275); Play(550, 100);
            Delay(210); Play(500, 100);
            Delay(180); Play(380, 100);
            Delay(150); Play(500, 100);
            Delay(150); Play(500, 100);
            Delay(75); Play(500, 100);
            Delay(150); Play(500, 60);
            Delay(75); Play(500, 80);
            Delay(150); Play(500, 60);
            Delay(175); Play(500, 80);
            Delay(75); Play(580, 80);
            Delay(175); Play(660, 80);
            Delay(75); Play(500, 80);
            Delay(150); Play(430, 80);
            Delay(75); Play(380, 80);
            Delay(300); Play(500, 60);
            Delay(75); Play(500, 80);
            Delay(150); Play(500, 60);
            Delay(175); Play(500, 80);
            Delay(75); Play(580, 80);
            Delay(75); Play(660, 80);
            Delay(225); Play(870, 80);
            Delay(162); Play(760, 80);
            Delay(300); Play(500, 60);
            Delay(75); Play(500, 80);
            Delay(150); Play(500, 60);
            Delay(175); Play(500, 80);
            Delay(75); Play(580, 80);
            Delay(175); Play(660, 80);
            Delay(75); Play(500, 80);
            Delay(150); Play(430, 80);
            Delay(75); Play(380, 80);
            Delay(300); Play(660, 100);
            Delay(75); Play(660, 100);
            Delay(150); Play(660, 100);
            Delay(150); Play(510, 100);
            Delay(50); Play(660, 100);
            Delay(150); Play(770, 100);
            Delay(225); Play(380, 100);
            // Start the thread
            _oThread.Start();

            Timer.Enabled = true;

        }
        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            try
            {
                _t.SetIy((int)List[_counter], (int)List2[_counter]);
                Timer.Interval = (int)DelayList[_counter] + (int)List2[_counter];
                _counter++;
                Timer.Enabled = true;
                _t.ChangeTest();
            }
            catch (Exception)
            {
                Timer.Enabled = false;
                Console.WriteLine("FINISHED; WEY");
                Console.WriteLine("press enter...");
                Console.ReadLine();
                Environment.Exit(0);

            }
        }

        private static void Delay(int p)
        {
            DelayList.Add(p);
        }

        public static void Play(int i, int y)
        {
            List.Add(i);
            List2.Add(y);
        }
    }
}
