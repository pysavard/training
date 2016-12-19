using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS.Product.interfaces;
using POS.Product;

namespace TrainingForm
{
	public partial class FrmMain : Form
	{
		IMenuService _menuService { get; set; }
		Invoice _invoice = new Invoice();

		public FrmMain()
		{
			InitializeComponent();
			_menuService = new MenuService();
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
					_invoice.AddItem((Item)b.Tag,1);
					RefreshInvvoice();
				});

			}
		}

		private void RefreshInvvoice()
		{
			lstInvoice.Clear();
			_invoice.Lines.ToList().ForEach(x =>
			{
				lstInvoice.Items.Add(string.Format("{0}| {1} {2}", x.Qte.ToString(),x.Item.Name, x.Total().ToString("C")));
			});
			lstInvoice.Items.Add(new string('_', 20));
			lstInvoice.Items.Add(string.Format("Total {0}", _invoice.Lines.Sum(x =>x.Total()).ToString("C")));
		}

		private void cmdClear_Click(object sender, EventArgs e)
		{
			_invoice.Lines.Clear();
			RefreshInvvoice();
		}
	}
}
