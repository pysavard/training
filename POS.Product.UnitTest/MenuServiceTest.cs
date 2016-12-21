using Microsoft.VisualStudio.TestTools.UnitTesting;
using POS.Entities;
using Ploeh.AutoFixture;
using System.Collections.Generic;
using POS.Product.interfaces;
using FluentAssertions;

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
	}
}
