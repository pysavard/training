using System.Collections.Generic;
using System.Linq;

namespace POS.Entities
{
	public class Menu
	{
		public IList<Item> Items;
		public IList<Category> Categories;

		private Menu()
		{

		}

		public static Menu CreateDefaultMenu()
		{
			IList<Category> categories = new List<Category>
				{
					new Category{Id = 1, Name = "Main dish" },
					new Category{Id = 3, Name = "Appetizer" },
					new Category{Id = 2, Name = "Drink" },
				};
			return new Menu
			{
				Categories = categories,
				Items = new List<Item>{
					new Item { Id = 1, Name = "Cheeseburger", Price = 5, Category = categories.Single(x => x.Id == 1 )},
					new Item { Id = 2, Name = "Poutine", Price = 3, Category = categories.Single(x => x.Id == 1 ) },
					new Item { Id = 3, Name = "Coke", Price = 1,  Category = categories.Single(x => x.Id == 2 ) },
					new Item { Id = 4, Name = "Salade", Price = 2,  Category = categories.Single(x => x.Id == 3 )}
				}
			};
		}
	}
}
