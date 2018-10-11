using System;
using Xunit;

namespace SakilaTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int n1 = 3;
            int n2 = 5;
            int sum = n1 + n2;
            Assert.Equal(8,sum);
        }
    }
}
