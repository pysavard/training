using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Product.interfaces
{
	public interface IMenuService
	{
		IList<Item> GetAllItems();
		IList<Category> GetAllCategory();
	}
}
