using System.Collections.Generic;

namespace POS.Product.interfaces
{
	public interface IMenuService
	{
		IList<Item> GetAllItems();
	}
}
