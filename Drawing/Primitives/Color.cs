﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing
{
    /// <summary>
    /// Container for simple color information with transparency layer.
    /// </summary>
    public struct Color
    {
        public byte R { get; set; }
        public byte G { get; set; }
        public byte B { get; set; }
        public byte A { get; set; }

        /// <summary>
        /// Returns the color as a 32bit integer.
        /// </summary>
        public int ToInt32()
        {
            return BitConverter.ToInt32(new byte[] { R, G, B, A }, 0);
        } 

        /// <summary>
        /// Returns the color as a byte array (0=Blue, 1=Green, 2=Red)
        /// </summary>
        public byte[] ToBit24BGR()
        {
            return new byte[] { B, G, R };
        }

        /// <summary>
        /// Returns the color as a byte array (0=Blue, 1=Green, 2=Red, 3=Alpha)
        /// </summary>
        public byte[] ToBit32BGRA()
        {
            return new byte[] { B, G, R, A };
        }

        /// <summary>
        /// Creates the color from RGBA.
        /// </summary>
        /// <param name="r">The red value of the color.</param>
        /// <param name="g">The green value of the color.</param>
        /// <param name="b">The blue value of the color.</param>
        /// <param name="a">The transparency value of the color.</param>
        /// <returns></returns>
        public static Color FromRgbA(byte r, byte g, byte b, byte a)
        {
            Color col = new Color();
            col.R = r;
            col.G = g;
            col.B = b;
            col.A = a;

            return col;
        }

        /// <summary>
        /// Creates the color from Int32.
        /// </summary>
        /// <param name="col">Int32 value</param>
        /// <returns></returns>
        public static Color FromInt32(int col)
        {
            byte[] bytes = BitConverter.GetBytes(col);
            return new Color() { R = bytes[0], G = bytes[1], B = bytes[2], A = bytes[3] };
        }

        public static Color Red {get => new Color() { R = 255, G = 0, B = 0, A = 255 }; }
        public static Color Green { get => new Color() { R = 0, G = 255, B = 0, A = 255 }; }
        public static Color Blue { get => new Color() { R = 0, G = 0, B = 255, A = 255 }; }
        public static Color Black { get => new Color() { R = 0, G = 0, B = 0, A = 255 }; }
        public static Color White { get => new Color() { R = 255, G = 255, B = 255, A = 255 }; }
    }
}
