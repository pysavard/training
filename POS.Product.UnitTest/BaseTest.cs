using Moq;
using Ploeh.AutoFixture;

namespace POS.Product.UnitTest
{
	public class BaseTest<T>
	{
		private AutoMoq.AutoMoqer _mocker;		
		public T TestInstance { get; set; }
		public IFixture AutoFixture { get; set; }

		public BaseTest()
		{
			AutoFixture = new Fixture();
			_mocker = new AutoMoq.AutoMoqer();
			TestInstance = _mocker.Create<T>();
		}

		public Mock<TT> GetMock<TT>() where TT : class
		{
			return _mocker.GetMock<TT>();
		}
	}
}
