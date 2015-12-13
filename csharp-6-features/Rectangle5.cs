using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using csharp_6_features.Math; // Imported namespace

namespace csharp_6_features
{
    /// <summary>Rectange class written in a C# 5.0 style</summary>
    class Rectangle5 : IRectangle
    {
        private readonly int width;

        private readonly int height;

        /// <summary>Readonly Width Property using private field</summary>
        public int Width { get { return width; } }

        /// <summary>Readonly Height Property using private field</summary>
        public int Height {  get { return height; } }

        /// <summary>Property calculated in get code block using a static function, imported by namespace</summary>
        public int Area { get { return AreaCalculator.Area(width, height); } }

        /// <summary>Constructor setting height property default to 10</summary>
        /// <param name="width">Width value</param>
        /// <param name="height">Height value</param>
        public Rectangle5(int width, int height = 10)
        {
            this.width = width;
            this.height = height;
        }

        /// <summary>Log the Rectangle if the logger is valid</summary>
        /// <param name="logger">Logger Action</param>
        public void Log(Action<string> logger)
        {
            if (logger != null)
            {
                logger(this.ToString());
            }
        }

        public void Log(Action<string> logger1, Action<string> logger2)
        {
            try
            {
                if (logger1 == null)
                {
                    throw new ArgumentNullException("logger1");
                }
                Log(logger1);

                if (logger2 == null)
                {
                    throw new ArgumentNullException("logger2");
                }
                Log(logger2);
            }
            catch (ArgumentNullException arg)
            {
                // Exception block contains if statement
                if (arg.ParamName == "logger1")
                {
                    Console.Write("logger1 is null");
                } else if (arg.ParamName == "logger2")
                {
                    Console.Write("logger2 is null");
                }
            }
        }

        /// <summary>ToString() property names are string literals, using string.format</summary>
        /// <returns>String value</returns>
        public override string ToString()
        {
            return string.Format("{0}: {1}, {2}: {3}, {4} : {5}", "Width", Width, "Height", Height, "Area", Area);
        }
    }
}
