using RentABikeV3.Shared;
using System.Data;

namespace Test
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}
		[Test]
		public void Should_Return_Ok()
		{
			var sut = new Reservation();
			var result = sut.ValidateReservation("Gabriela", new DateTime(2023, 5, 12, 10, 30, 00), new DateTime(2023, 5, 12, 13, 30, 00));
			Assert.AreEqual("OK!", result);
		}
		[Test]
		public void Should_Return_Rent_period_too_short()
		{
			var sut = new Reservation();
			var result = sut.ValidateReservation("Gabriela", new DateTime(2023, 5, 12, 10, 00, 00), new DateTime(2023, 5, 12, 10, 30, 00));
			Assert.AreEqual("Rent period too short. Must be at least 1H", result);
		}
		[Test]
		public void Should_Return_Rent_period_too_long()
		{
			var sut = new Reservation();
			var result = sut.ValidateReservation("Gabriela", new DateTime(2023, 6, 12, 10, 00, 00), new DateTime(2023, 6, 19, 10, 30, 00));
			Assert.AreEqual("Rent period too long. Must be at most 48H", result);
		}
	}
}