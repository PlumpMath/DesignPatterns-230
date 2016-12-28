using System;

namespace DesignPatterns
{
    public interface IDrawApi
    {
        void DrawCircle(int radius, int x, int y);
    }

    public class CircleDrawApi : IDrawApi
    {
        protected string color;

        public CircleDrawApi(string col)
        {
            color = col;
        }

        public virtual void DrawCircle(int radius, int x, int y)
        {
            Console.WriteLine(string.Format("Drawing Circle in API Ver1: " +
                                            "Radius={0}, Center=({1},{2}), Color: {3}", 
                                            radius, x, y, color));
        }
    }

    public class CircleDrawApi_V2 : IDrawApi
    {
        public void DrawCircle(int radius, int x, int y)
        {
            Console.WriteLine(string.Format("Drawing Circle in API Ver2: " +
                                            "Radius={0}, Center=({1},{2})", 
                radius, x, y));
        }
    }

    public abstract class Shape
    {
        protected IDrawApi _drawAPIBridge;
        public Shape(IDrawApi drawApi)
        {
            _drawAPIBridge = drawApi;
        }

        public abstract void Draw();
    }

    public class Circle : Shape
    {
        int radius, x, y;

        public Circle(int rad, int x, int y, IDrawApi drawApi) : base(drawApi)
        {
            radius = rad;
            this.x = x;
            this.y = y;
        }

        public override void Draw()
        {
            _drawAPIBridge.DrawCircle(radius, x, y);
        }
    }
}
