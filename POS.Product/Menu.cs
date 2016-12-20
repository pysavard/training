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
		public IList<Category> Categories;
		public Menu()
		{
			Categories = new List<Category>
			{
				new Category{Id = 1, Name = "Main dish" },
				new Category{Id = 3, Name = "Appetizer" },
				new Category{Id = 2, Name = "Drink" },				
			};



			Items = new List<Item>{
				new Item { Id = 1, Name = "Cheeseburger", Price = 5, Category = Categories.Single(x => x.Id == 1 )},
				new Item { Id = 2, Name = "Poutine", Price = 3, Category = Categories.Single(x => x.Id == 1 ) },
				new Item { Id = 3, Name = "Coke", Price = 1,  Category = Categories.Single(x => x.Id == 2 ) },
				new Item { Id = 4, Name = "Salade", Price = 2,  Category = Categories.Single(x => x.Id == 3 )}
			};
		}
	}
}
