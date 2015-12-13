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
        public int Width { get; }

        /// <summary>Readonly Height Property, no additional field required, default value set</summary>
        public int Height { get; } = 10;

        /// <summary>Property calculated in expression using a static function, imported by class</summary>
        public int Area => Area(Width, Height);

        /// <summary>Constructor default height property not required</summary>
        /// <param name="width">Width property</param>
        public Rectangle6(int width)
        {
            this.Width = width;
        }

        /// <summary>Constructor when default height property not used</summary>
        /// <param name="width">Width property</param>
        /// <param name="height">Height property</param>
        public Rectangle6(int width, int height) : this(width)
        {
            this.Height = height;
        }

        /// <summary>Log the Rectange if the logger is valid</summary>
        /// <param name="logger">Logger Action</param>
        public void Log(Action<string> logger)
        {
            logger?.Invoke(this.ToString());
        }

        /// <summary>ToString() property names are calculated at compile time in a string interpolation</summary>
        /// <returns>String value</returns>
        public override string ToString()
        {
            return $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}, {nameof(Area)} : {Area}";
        }
    }
}
