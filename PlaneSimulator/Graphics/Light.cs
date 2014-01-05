﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX;

namespace PlaneSimulator.Graphics
{
    class Light
    {
        public Vector3 Direction { get; set; }
        public Vector4 Color { get; set; }
        public Vector4 AmbiantColor { get; set; }

        public Light(Vector3 direction, Vector4 color, Vector4 ambiantColor)
        {
            Direction = direction;
            Color = color;
            AmbiantColor = ambiantColor;
        }
    }
}
