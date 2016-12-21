using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using POS.Entities;
using POS.Product.Interfaces;

namespace TrainingForm
{
	public partial class FrmMain : Form
	{		
		private readonly IMenuService _menuService;
		private readonly IInvoiceService _invoiceService;
		Invoice _invoice = new Invoice();

	public FrmMain(IMenuService menuService, IInvoiceService invoiceService)
		{
			InitializeComponent();
			_menuService = menuService;
			_invoiceService = invoiceService;
		}

		private void FrmMain_Load(object sender, EventArgs e)
		{
			CreateMenu();
		}

		private void CreateMenu()
		{
			_menuService.GetAllItems().ToList().ForEach(x => pnlMenu.Controls.Add(new Button { Text = x.Name, Tag = x }));

			foreach (Control c in pnlMenu.Controls)
			{
				c.Click += new EventHandler((object sender, EventArgs e) =>
				{
					Button b = (Button)sender;
					_invoiceService.AddItemToInvoice(_invoice, (Item)b.Tag, 1);
					RefreshInvvoice();
				});

			}
		}

		
		private void RefreshInvvoice()
		{
			lstInvoice.Clear();
			_invoice.Lines.ToList().ForEach(x =>
			{
				lstInvoice.Items.Add(string.Format("{0}| {1} {2}", x.Qte.ToString(), x.Item.Name, x.Total().ToString("C")));
			});
			lstInvoice.Items.Add(new string('_', 20));
			lstInvoice.Items.Add(string.Format("Total {0}", _invoice.Lines.Sum(x => x.Total()).ToString("C")));


			var test = _invoice.Lines.Select(x => new { Bob = x.Item.Name, Bobette =  x.Qte });


			_menuService.GetAllCategory()
							 .Where(category => _invoice
									.Lines
									.Any(l => l.Item.Category.Id == category.Id))
			.ToList()
			.ForEach(cat =>	lstInvoice.Items.Add(CreateGRoupingINvoiceLine(cat)));							
		}

		private string CreateGRoupingINvoiceLine(Category category)
		{
			return string.Format("Total {0} {1}",
						category.Name,
						_invoice
							.Lines
							.Where(l => l.Item.Category.Name == category.Name)
							.Sum(x => x.Total()).ToString("C"));
		}

		private void cmdClear_Click(object sender, EventArgs e)
		{
			_invoice.Lines.Clear();
			RefreshInvvoice();
		}
	}
}
