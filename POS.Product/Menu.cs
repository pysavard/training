using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Product
{
	public class Menu
	{
		public IList<Item> Items;
		public IList<Category> Category;
		public Menu()
		{
			Category = new List<Category>
			{
				new Category{Name = "Main dish" },
				new Category{Name = "Drink" }
			};

			Items = new List<Item>{
				new Item { Id = 1, Name = "Cheeseburger", Price = 5 },
				new Item { Id = 2, Name = "Poutine", Price = 3 },
				new Item { Id = 3, Name = "Coke", Price = 1 },
			};
		}
	}
}
