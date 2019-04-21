﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing
{
    public class PointF
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Length { get => (float)Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2)); }

        public PointF()
        {
            X = 0;
            Y = 0;
        }

        public PointF(float x, float y)
        {
            X = x;
            Y = y;
        }

        public SizeF ToSize()
        {
            return new SizeF(X, Y);
        }

        public static PointF operator+ (PointF pt1, PointF pt2)
        {
            return new PointF(pt1.X + pt2.X, pt1.Y + pt2.Y);
        }

        public static PointF operator- (PointF pt1, PointF pt2)
        {
            return new PointF(pt1.X - pt2.X, pt1.Y - pt2.Y);
        }

        public static PointF operator* (PointF pt1, float f)
        {
            return new PointF(pt1.X * f, pt1.Y * f);
        }

        public static PointF operator/ (PointF pt1, float f)
        {
            return new PointF(pt1.X / f, pt1.Y / f);
        }
    }
}
