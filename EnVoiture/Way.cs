﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnVoiture
{
    public class Way
    {
        /// <summary>
        /// Location of the way
        /// </summary>
        public Point Location
        {
            get;
            private set;
        }

        /// <summary>
        /// Size of the way
        /// </summary>
        public Size Size
        {
            get;
            private set;
        }

        /// <summary>
        /// Orientations of the way
        /// </summary>
        public List<Orientation> Orientations
        {
            get;
            private set;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="orientations"></param>
        public Way(int x, int y, int width, int height, List<Orientation> orientations)
        {
            this.Location = new Point(x, y);
            this.Size = new Size(width, height);
            this.Orientations = orientations;
            WaysGenerator(3, 3);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="location"></param>
        /// <param name="size"></param>
        /// <param name="orientations"></param>
        public Way(Point location, Size size, List<Orientation> orientations)
        {
            this.Location = location;
            this.Size = size;
            this.Orientations = orientations;
        }

        public static List<Way> WaysGenerator(int largeurVille, int hauteurVille)
        {
            int nbWays = largeurVille * hauteurVille;
            List<Way> _waysVille = new List<Way>();

            for (int i = 1; i <= largeurVille; i++)
			{
                for (int j = 0; j < hauteurVille; j++)
                {
                _waysVille.Add(new Way(new Point(25 * j, 25*i), new Size(25, 25), new List<Orientation>()));
                    
                }
			}
            return _waysVille;
        }

        public  void Paint(Graphics g)
        {
            g.FillRectangle(Brushes.Gray,Location.X, Location.Y, Size.Width, Size.Height);
        }
    }
}
