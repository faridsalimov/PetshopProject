using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    internal class PetShop
    {
        public List<CatHouse> catHouses = new();

        public int CatHouseCount()
        {
            return catHouses.Count();
        }

        public PetShop() {}
    }
}