using System.Collections.Generic;
using POS.Product.interfaces;

namespace POS.Product
{
	public class MenuService : IMenuService
	{
		public MenuService()
		{
			Menu = new Menu();
		}
		private Menu Menu { get; set; }

		public IList<Item> GetAllItems()
		{
			return Menu.Items;
		}
	}
}
