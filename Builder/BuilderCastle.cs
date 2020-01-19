using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class BuilderCastle : IBuilder
    {
        Product _castle = new Product();

        // Новый экземпляр строителя должен содержать пустой объект продукта,
        // который используется в дальнейшей сборке.
        public BuilderCastle()
        {
            this.Reset();
        }

        private void Reset()
        {
            this._castle = new Product();
        }

        public void BuildBasemant()
        {
            this._castle.Add("Beautiful Basemant");
        }

        public void BuildRoof()
        {
            this._castle.Add("The Best Roof in the World");
        }

        public void BuildWalls()
        {
            this._castle.Add("Gold Walls");
        }

        public void BuildWindows()
        {
            this._castle.Add("Diamond Windows");
        }

        public Product GetCastle()
        {
            Product result = this._castle;

            this.Reset();

            return result;
        }
    }
}
