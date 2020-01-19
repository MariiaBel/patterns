using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class BuildeHouser : IBuilder
    {
        Product _house = new Product();

        // Новый экземпляр строителя должен содержать пустой объект продукта,
        // который используется в дальнейшей сборке.
        public BuildeHouser()
        {
            this.Reset();
        }

        private void Reset()
        {
            this._house = new Product();
        }

        public void BuildBasemant()
        {
            this._house.Add("Basemant");
        }

        public void BuildRoof()
        {
            this._house.Add("Roof");
        }

        public void BuildWalls()
        {
            this._house.Add("Walls");
        }

        public void BuildWindows()
        {
            this._house.Add("Windows");
        }

        public Product GetHouse()
        {
            Product result = this._house;

            this.Reset();

            return result;
        }
    }
}
