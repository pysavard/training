using System.Collections.Generic;
using POS.Entities;

namespace POS.Product.interfaces
{
	public interface IMenuService
	{
		IList<Item> GetAllItems();
		IList<Category> GetAllCategory();
	}
}
