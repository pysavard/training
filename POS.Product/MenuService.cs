using System.Collections.Generic;
using POS.Entities;
using POS.Product.Interfaces;

namespace POS.Product
{
	public class MenuService : IMenuService
	{
		private readonly IMenuProviderService _menuProviderService;
		private readonly IMagieService _magieService;
		
		public MenuService(IMenuProviderService menuProviderService, IMagieService magieService)
		{
			_menuProviderService = menuProviderService;
			_magieService = magieService;
		}		

		public IList<Item> GetAllItems()
		{
			string test = _magieService.DoMagic();			

			return _menuProviderService.GetDefaultMenu().Items;		
		}

		public IList<Category> GetAllCategory()
		{
			return _menuProviderService.GetDefaultMenu().Categories;
		}

	}
}
