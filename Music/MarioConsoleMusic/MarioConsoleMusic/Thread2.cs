using System;

namespace MarioConsoleMusic
{
    class Thread2
    {
        public Boolean Test = true;
        int _i;
        int _y;
        public void Work()
        {
            while (true)
            {
                while (Test)
                {

                }
                Console.Beep(_i, _y+20);
                Console.WriteLine("Pip {0} - {1}", _i, (_y+20));
                Test = true;
            }
        }

        public void SetIy(int l, int m)
        {
            _i = l;
            _y = m;
        }
        public void ChangeTest()
        {
            Test = false;
        }

    }
}
