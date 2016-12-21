using POS.Entities;
using POS.Product.Interfaces;

namespace POS.Product
{
	public class MenuProviderService : IMenuProviderService
	{
		public Menu GetDefaultMenu()
		{
			return Menu.CreateDefaultMenu();
		}
	}
}
