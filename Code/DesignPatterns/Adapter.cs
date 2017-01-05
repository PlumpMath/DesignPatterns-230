using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class TextDrawThirdParty
    {
        public void DrawTextImproved() { Console.WriteLine("External method for Text Draw"); }
    }

    public interface IShape
    {
        void Draw();
        void ShapeName();
    }

    public class Circle : IShape
    {
        public void Draw() { Console.WriteLine("Draw Circle"); }
        public void ShapeName() { Console.WriteLine("Circle"); }
    }

    public class Text : IShape
    {
        readonly TextDrawThirdParty _externalTextDraw;

        public Text() { _externalTextDraw = new TextDrawThirdParty(); }
        public void Draw() { _externalTextDraw.DrawTextImproved(); }
        public void ShapeName() { Console.WriteLine("Text"); }
    }

}
