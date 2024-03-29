﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitterEngine.Source {
    public class Vector2 {
        public float X { get; set; }
        public float Y { get; set; }

        public Vector2() {
            X = Zero().X;
            Y = Zero().Y;
        }

        /// <summary>
        /// Returns specified values for X & Y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Vector2(float x, float y) {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Returns X & Y as 0
        /// </summary>
        /// <returns></returns>
        public static Vector2 Zero() {
            return new Vector2(0, 0);
        }
    }
}
