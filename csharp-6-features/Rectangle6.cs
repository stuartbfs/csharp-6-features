using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static csharp_6_features.Math.AreaCalculator;  // Imported class containing static function

namespace csharp_6_features
{
    /// <summary>Rectange class written in a C# 6.0 style</summary>
    class Rectangle6 : IRectangle
    {
        /// <summary>Readonly Width Property, no additional field required</summary>
        public int Width { get; } = 1;

        /// <summary>Readonly Height Property, no additional field required, default value set</summary>
        public int Height { get; } = 1;

        /// <summary>Property calculated in expression using a static function, imported by class</summary>
        public int Area => Area(Width, Height);

        /// <summary>Constructor default height property not required</summary>
        /// <param name="width">Width property</param>
        public Rectangle6(int width, int height = 10)
        {
            this.Width = width;
            this.Height = height;
        }

        /// <summary>Log the Rectange if the logger is valid</summary>
        /// <param name="logger">Logger Action</param>
        public void Log(Action<string> logger) => logger?.Invoke(this.ToString());

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
            // When clause replaces the if statement
            catch (ArgumentNullException arg) when (arg.ParamName == "logger1")
            {
                Console.Write("logger1 is null");
            }
            catch (ArgumentNullException arg) when (arg.ParamName == "logger2")
            {
                Console.Write("logger2 is null");
            }
        }

        /// <summary>ToString() property names are calculated at compile time in a string interpolation</summary>
        /// <returns>String value</returns>
        public override string ToString()
        {
            return $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}, {nameof(Area)} : {Area}";
        }
    }
}
