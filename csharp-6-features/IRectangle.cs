using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_6_features
{
    public interface IRectangle
    {
        int Width { get; }

        int Height { get; }

        int Area { get; }

        void Log(Action<string> logger);

        void Log(Action<string> logger1, Action<string> logger2);
    }
}
