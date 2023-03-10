using UnitTesting_ExampleProgramme;

namespace XUnit_CheckingTheAirthematicoperations
{
    public class UnitTest1
    {
        [Fact]
        public void Task_Add_TwoNumber()
        {
            // Arrange  
            var num1 = 2.9;
            var num2 = 3.1;
            var expectedValue = 6 ;

            // Act  
            var sum = AirthematicOperations.Add(num1, num2);

            //Assert  
            Assert.Equal(expectedValue, sum, 1);
        }
         

        [Fact]
        public void Task_Subtract_TwoNumber()
        {
            // Arrange  
            var num1 = 2.9;
            var num2 = 3.1;
            var expectedValue = -0.2;

            // Act  
            var sub = AirthematicOperations.Subtract(num1, num2);

            //Assert  
            Assert.Equal(expectedValue, sub, 1);
        }

        [Fact]
        public void Task_Multiply_TwoNumber()
        {
            // Arrange  
            var num1 = 2.9;
            var num2 = 3.1;
            var expectedValue = 8.99;

            // Act  
            var mult = AirthematicOperations.Multiply(num1, num2);

            //Assert  
            Assert.Equal(expectedValue, mult, 2);
        }

        [Fact]
        public void Task_Divide_TwoNumber()
        {
            // Arrange  
            var num1 = 2.9;
            var num2 = 3.1;
            var expectedValue = 0.94; //Rounded value  

            // Act  
            var div = AirthematicOperations.Divide(num1, num2);

            //Assert  
            Assert.Equal(expectedValue, div, 2);
        }
    }
}