using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace POS.Product
{
	public class AutofacModule : Autofac.Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			var assembly = Assembly.GetExecutingAssembly();

			builder.RegisterAssemblyTypes(assembly)
				   .Where(t => t.Name.EndsWith("Service"))
				   .AsImplementedInterfaces();
		}
	}
}
