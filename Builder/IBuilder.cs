using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    interface IBuilder
    {
        void BuildBasemant();
        void BuildWalls();
        void BuildWindows();
        void BuildRoof();
    }
}
