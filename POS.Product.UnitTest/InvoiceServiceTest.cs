using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using POS.Entities;
using Ploeh.AutoFixture;
using FluentAssertions;

namespace POS.Product.UnitTest
{
	[TestClass]
	public class InvoiceServiceTest : BaseTest<InvoiceService>
	{
		[TestMethod]
		public void WhenLineDoesNOtExistInInvoice_ShouldAddNewLine()
		{
			//Arange
			Invoice invoice = AutoFixture.Create<Invoice>();
			Item item = AutoFixture.Create<Item>();

			//Act
			Invoice result = TestInstance.AddItemToInvoice(invoice, item, 1);

			//Assert 
			result.Lines.Any(x => x.Item.Id == item.Id).Should().BeTrue();
		}

		[TestMethod]
		public void WhenLineDoesNotExistInInvoice_ShouldSetQteToQuantityInParameter()
		{
			//Arrange
			Invoice invoice = AutoFixture.Create<Invoice>();
			Item item = AutoFixture.Create<Item>();
			int quantity = AutoFixture.Create<int>();

			//Act
			Invoice result = TestInstance.AddItemToInvoice(invoice, item, quantity);

			//Assert
			result.GetInvoiceLine(item.Id).Qte.Should().Be(quantity);
		}

		[TestMethod]
		public void WhenLineExist_ShouldAllQuantityToLine()
		{
			//Arrange
			Item item = AutoFixture.Create<Item>();
			InvoiceLine line = AutoFixture.Build<InvoiceLine>()
							.With(x => x.Item, item)
							.Create();
			Invoice invoice = AutoFixture.Build<Invoice>()
				.With(x => x.Lines, new List<InvoiceLine>{line})
				.Create();

			int startingQte = line.Qte;
			int quantity = AutoFixture.Create<int>();


			//Act
			Invoice result = TestInstance.AddItemToInvoice(invoice, item, quantity);

			//Assert
			result.GetInvoiceLine(item.Id).Qte.Should().Be(startingQte + quantity);
		}

		[TestMethod]
		public void WhenQteIsmortThan99_ShouldThrow()
		{
			//Arange
			Invoice invoice = AutoFixture.Create<Invoice>();
			Item item = AutoFixture.Create<Item>();

			//Act
			Action action = () => TestInstance.AddItemToInvoice(invoice, item, 100);

			//Assert 			
			action.ShouldThrow<Exception>().WithMessage("Too Much");




		}



	}
}
