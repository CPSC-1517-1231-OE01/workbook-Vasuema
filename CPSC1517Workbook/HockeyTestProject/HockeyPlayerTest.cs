using Hockey.Data;
using FluentAssertions;

namespace HockeyTestProject
{
    public class HockeyPlayerTest
    {
        [Fact]
        public void Test1()
        {
            //arrange
            int a = 1;
            int b = 2;
            int actual;

            //act
            actual = a + b;

            //assert
            //Assert.Equal(3, actual);

            actual.Should().Be(3);
        }
    }
}