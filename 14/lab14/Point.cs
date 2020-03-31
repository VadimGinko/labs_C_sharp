using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab14
{
    [Serializable]
    public class Point
    {
        public int x = 10;
        public int y = 20;
        public Point()
        {
        }
        public Point(int v1, int v2)
        {
            this.x = v1;
            this.y = v2;
        }
    }
}
