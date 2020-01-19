using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Director
    {
        IBuilder _builder;

        public IBuilder Builder 
        {
            set { _builder = value; }
        }

        public void BuildMinStructure()
        {
            this._builder.BuildWalls();
            this._builder.BuildRoof();
        }

        public void BuildMaxStructure()
        {
            this._builder.BuildBasemant();
            this._builder.BuildWalls();
            this._builder.BuildRoof();
            this._builder.BuildWindows();
        }
    }
}
