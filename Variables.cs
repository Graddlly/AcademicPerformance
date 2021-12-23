using System;

namespace AcademicPerformance
{
    internal class Variables
    {
        private int _tb3, _tb4, _tb5, _tb6, _tb7, _tb8;

        internal int Tb3
        {
            get => _tb3;
            set
            {
                if (value < 1 || value > 5)
                {
                    throw new IndexOutOfRangeException(@"Значение выходит за пределы разрешенных!");
                }

                _tb3 = value;
            }
        }
        
        internal int Tb4
        {
            get => _tb4;
            set
            {
                if (value < 1 || value > 5)
                {
                    throw new IndexOutOfRangeException(@"Значение выходит за пределы разрешенных!");
                }

                _tb4 = value;
            }
        }
        
        internal int Tb5
        {
            get => _tb5;
            set
            {
                if (value < 1 || value > 5)
                {
                    throw new IndexOutOfRangeException(@"Значение выходит за пределы разрешенных!");
                }

                _tb5 = value;
            }
        }
        
        internal int Tb6
        {
            get => _tb6;
            set
            {
                if (value < 1 || value > 5)
                {
                    throw new IndexOutOfRangeException(@"Значение выходит за пределы разрешенных!");
                }

                _tb6 = value;
            }
        }
        
        internal int Tb7
        {
            get => _tb7;
            set
            {
                if (value < 1 || value > 5)
                {
                    throw new IndexOutOfRangeException(@"Значение выходит за пределы разрешенных!");
                }

                _tb7 = value;
            }
        }
        
        internal int Tb8
        {
            get => _tb8;
            set
            {
                if (value < 1 || value > 5)
                {
                    throw new IndexOutOfRangeException(@"Значение выходит за пределы разрешенных!");
                }

                _tb8 = value;
            }
        }
    }
}