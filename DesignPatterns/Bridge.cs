using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Test
    {
        Shape redCircle = new Circle(100, 100, 10, new RedCircle());
        Shape greenCircle = new Circle(100, 100, 10, new GreenCircle());
    }
    public interface DrawAPI
    {
        void DrawCircle(int radius, int x, int y);
    }

    public class RedCircle : DrawAPI
    {
        public void DrawCircle(int radius, int x, int y)
        {
            Console.WriteLine("Drawing Circle[ color: red, radius: " + radius + ", x: " + x + ", " + y + "]");
        }
    }

    public class GreenCircle : DrawAPI
    {
        public void DrawCircle(int radius, int x, int y)
        {
            Console.WriteLine("Drawing Circle[ color: green, radius: " + radius + ", x: " + x + ", " + y + "]");
        }
    }

    public abstract class Shape
    {
        protected DrawAPI _drawAPI;
        protected Shape(DrawAPI drawAPI)
        {
            _drawAPI = drawAPI;
        }

        public abstract void draw();
    }

    public class Circle : Shape
    {
        private int x, y, radius;
        public Circle(int x, int y, int radius, DrawAPI drawAPI) :
            base(drawAPI)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public override void draw()
        {
            _drawAPI.DrawCircle(radius, x, y);
        }
    }
}
