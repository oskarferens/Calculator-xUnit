namespace Calculator.Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestMultiplication()
        {
            //Arrange
            int a = 15;
            int b = 4;

            //Act
            //Assert
            Assert.Equal(60,Calc.Multiplication(a,b));
        }
        
        [Fact]
        public void TestAddition()
        {
            //Arrange
            int a = 15;
            int b = 4;

            //Act
            //Assert
            Assert.Equal(19,Calc.Addition(a,b));
        }
        
        [Fact]
        public void TestDivision()
        {
            //Arrange
            int a = 15;
            int b = 5;
            double expected = 3;
            //Act
            double actual = Calc.Division(a, b);

            //Assert
            Assert.Equal(expected, Calc.Division(a,b));
        }
        
        [Fact]
        public void TestSubstraction()
        {
            //Arrange
            int a = 15;
            int b = 4;

            //Act
            //Assert
            Assert.Equal(11,Calc.Substraction(a,b));
        }

        [Fact]
        public void TestAdditionOverloaded()
        {
            //Arrange
            List<double> numbers = new List<double> { 15.5, 12.5 };
            //Act
            //Assert
            Assert.Equal(28, Calc.Addition(numbers));
        }

        [Fact]
        public void TestSubstractionOverloaded()
        {
            //Arrange
            List<double> numbers = new List<double> { 5.5, 2.2 };
            //Act
            //Assert
            Assert.Equal(3.3, Calc.Substraction(numbers));
        }
    }
}