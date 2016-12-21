using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Entities;
using POS.Product.Interfaces;

namespace POS.Product
{
	public class InvoiceService : IInvoiceService
	{
		public Invoice AddItemToInvoice(Invoice invoice, Item item, int quantity)
		{
			InvoiceLine currentLine = invoice.GetInvoiceLine(item.Id);

			if (currentLine == null)
			{
				currentLine = new InvoiceLine
				{
					Item = item					
				};
				invoice.AddInvoiceLine(currentLine);
			}

			currentLine.Qte += quantity;

			if (currentLine.Qte > 99) throw new Exception("Too much");
			return invoice;
		}
	}
}
