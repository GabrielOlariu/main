using Xunit;
using BPCalculator.Core;

namespace BPCalculator.UnitTests
{
    public class BloodPressureBehaviourTests
    {
        [Theory(DisplayName = "Given readings, When I calculate, Then I get the correct category")]
        [InlineData(85,  55, "Low Blood Pressure")]
        [InlineData(115, 75, "Ideal Blood Pressure")]
        [InlineData(130, 85, "Pre-High Blood Pressure")]
        [InlineData(145, 95, "High Blood Pressure")]
        public void CategoryBehaviorTest(int systolic, int diastolic, string expected)
        {
            // Given
            var bp = new BloodPressure { Systolic = systolic, Diastolic = diastolic };

            // When
            var actual = bp.CategoryDisplay;

            // Then
            Assert.Equal(expected, actual);
        }
    }
}