using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac;

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

			builder.RegisterAssemblyTypes(assembly)
				   .Where(t => t.Name.EndsWith("Service"))
				   .AsImplementedInterfaces();

			var container = builder.Build();

			Application.Run(new FrmMain());
		}
	}
}
