using System.Collections.Generic;
using System.Linq;

namespace POS.Product
{
	public class Invoice
	{
		public IList<InvoiceLine> Lines { get; set; }

		public Invoice()
		{
			Lines = new List<InvoiceLine>();
		}

		public void AddItem(Item item, int qte)
		{
			InvoiceLine currentLine = Lines.SingleOrDefault(x => x.Item.Id == item.Id);

			if (currentLine == null) {
				currentLine = new InvoiceLine
				{
					Item = item
				};
				Lines.Add(currentLine);
			}

			currentLine.Qte++;			
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
