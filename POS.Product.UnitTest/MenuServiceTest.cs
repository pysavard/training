using Microsoft.VisualStudio.TestTools.UnitTesting;
using POS.Entities;
using Ploeh.AutoFixture;
using System.Collections.Generic;
using POS.Product.Interfaces;
using FluentAssertions;
using System.Linq;

namespace POS.Product.UnitTest
{
	[TestClass]
	public class MenuServiceTest : BaseTest<MenuService>
	{
		[TestMethod]
		public void GetAllItems_ShouldReturnAllItems()
		{
			//Arrange			
			Menu menu = AutoFixture.Create<Menu>();

			GetMock<IMenuProviderService>()
				.Setup(x => x.GetDefaultMenu())
				.Returns(menu);

			//Act
			IList<Item> result = TestInstance.GetAllItems();			

			//Assert 
			result.ShouldAllBeEquivalentTo(menu.Items);
		}

		[TestMethod]
		public void ShouldDoMagic()
		{
			//Arrange
			GetMock<IMenuProviderService>()
				.Setup(x => x.GetDefaultMenu()).Returns(AutoFixture.Create<Menu>());

			//Act
			TestInstance.GetAllItems();

			//Assert 
			GetMock<IMagieService>().Verify(x => x.DoMagic(), Moq.Times.Once);

		}
	}
}
