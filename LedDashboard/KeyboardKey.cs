﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedDashboard
{

    public class KeyComparer : IComparer<KeyboardKey>
    {
        private int x;
        private int y;

        public KeyComparer(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int Compare(KeyboardKey a, KeyboardKey b)
        {
            double dist1 = Math.Pow(a.X - x, 2) + Math.Pow(a.Y - y, 2);
            double dist2 = Math.Pow(b.X - x, 2) + Math.Pow(b.Y - y, 2);
            return dist1.CompareTo(dist2);
        }
    }

    public class KeyboardKey
    {
        public int X;
        public int Y;
        public int? Width;
        public int? Height;
    }
}
