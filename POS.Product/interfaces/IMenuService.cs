using System.Collections.Generic;
using POS.Entities;

namespace POS.Product.Interfaces
{
	public interface IMenuService
	{
		IList<Item> GetAllItems();
		IList<Category> GetAllCategory();
	}
}
