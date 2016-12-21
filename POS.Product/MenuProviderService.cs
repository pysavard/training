using POS.Entities;
using POS.Product.interfaces;

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
