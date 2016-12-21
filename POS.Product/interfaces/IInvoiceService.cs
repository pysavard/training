using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Entities;

namespace POS.Product.Interfaces
{
	public interface IInvoiceService
	{
		Invoice AddItemToInvoice(Invoice invoice, Item item, int quantity);

	}
}
