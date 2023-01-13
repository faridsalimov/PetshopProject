using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    internal class CatHouse
    {
        public List<Cat> cats = new();

        public int CatCount()
        {
            return cats.Count();
        }

        public void AddCat(Cat c)
        {
            cats.Add(c);
        }

        public void RemoveByNickname(string nn)
        {
            foreach (Cat cat in cats)
            {
                if (cat.Nickname == nn)
                {
                    cats.Remove(cat);
                }
            }
        }

        public void ShowCats()
        {
            foreach (Cat item in cats)
            {
                Console.WriteLine(item);
            }
        }
    }
}