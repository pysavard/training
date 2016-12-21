using System.Collections.Generic;
using System.Linq;

namespace POS.Entities
{
	public class Invoice
	{
		public IList<InvoiceLine> Lines { get; set; }

		public Invoice()
		{
			Lines = new List<InvoiceLine>();
		}

		public void AddInvoiceLine(InvoiceLine line)
		{
			Lines.Add(line);
		}

		public InvoiceLine GetInvoiceLine(int itemId)
		{
			return Lines.SingleOrDefault(x => x.Item.Id == itemId);
		}
		 
	}

	public class InvoiceLine
	{
		public int Qte { get; set; }
		public Item Item { get; set; }
		public double Total()
		{
			return Item.Price * Qte;
		}
	}
}
