using System.Collections.Generic;
using POS.Entities;
using POS.Product.interfaces;

namespace POS.Product
{
	public class MenuService : IMenuService
	{
		private readonly IMenuProviderService _menuProviderService;

		public MenuService(IMenuProviderService menuProviderService)
		{
			_menuProviderService = menuProviderService;
		}		

		public IList<Item> GetAllItems()
		{
			return _menuProviderService.GetDefaultMenu().Items;
		}

		public IList<Category> GetAllCategory()
		{
			return _menuProviderService.GetDefaultMenu().Categories;
		}

	}
}
