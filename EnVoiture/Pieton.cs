﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnVoiture
{
    public class Pieton : RoadUser
    {
        
        public Pieton(int x, int y, int width, int height, double v, double vMax)
            : base(x,y,width,height,v,vMax)
        {
            
        }
       
    }
}

