namespace SimpleFactoryPattern.UnitTests
{
    [TestClass]
    public class VisitTests
    {

        // Method_Scenario_Expected       
        [TestMethod]
        [DataRow(60, 0, "N")]
        [DataRow(120, 0, "N")]
        [DataRow(60, 100, "P")]
        [DataRow(120, 200, "P")]
        [DataRow(60, 90, "F")]
        [DataRow(120, 180, "F")]
        public void CalculateCost_VisitType_ShouldReturnsGreatherThanZero(int durationInMinutes, int expectedCost, string visitType)
        {
            // Arrange
            TimeSpan duration = TimeSpan.FromMinutes(durationInMinutes);
            decimal pricePerHour = 100;            

            Visit visit = new Visit(duration, pricePerHour);

            // Act
            decimal result = visit.CalculateCost(visitType);

            // Asserts
            Assert.AreEqual(expectedCost, result);

        }
    }
}