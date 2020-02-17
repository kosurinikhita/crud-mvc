using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChocolateShop.entity;

namespace ChocolateShop.repository
{
    public class ChocolateRepository
    {
        public static List<Chocolate> chocolate = new List<Chocolate>();
        static ChocolateRepository()
        {
            chocolate.Add(new Chocolate { Name = "CadburySilk", Price = 100, Protein = 10 });
            chocolate.Add(new Chocolate { Name = "Milkybar", Price = 25, Protein = 15 });
            chocolate.Add(new Chocolate { Name = "Kitkat", Price = 10, Protein = 10 });
        }
        public IEnumerable<Chocolate> GetChocolateDetails()
        {
            return chocolate;
        }
        public void AddChocolate(Chocolate chocolates)
        {
            chocolate.Add(chocolates);
        }
        public Chocolate GetChocolate(string Names)
        {
            return chocolate.Find(id => id.Name.Equals(Names));
        }
        public void DeleteChocolate(string Names)
        {
            Chocolate list = GetChocolate(Names);
            if(list!=null)
            {
                chocolate.Remove(list);
            }
        }
    }
}
