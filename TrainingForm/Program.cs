using System;
using System.Reflection;
using System.Windows.Forms;
using Autofac;
using POS.Product;
using POS.Product.Interfaces;

namespace TrainingForm
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			var builder = new ContainerBuilder();

			var assembly = Assembly.GetExecutingAssembly();

			builder.RegisterType(typeof(FrmMain));
			builder.RegisterAssemblyModules((typeof(MenuService)).Assembly);
				
			var container = builder.Build();

			Application.Run(container.Resolve<FrmMain>() );
		}
	}
}
