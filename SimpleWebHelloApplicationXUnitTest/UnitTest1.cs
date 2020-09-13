using System;
using Xunit;

namespace SimpleWebHelloApplicationXUnitTest
{
    //A throw away test, just to make sure testing works in DevOps.
    public class UnitTest1
    {
        [Fact]
        public void AssertTrue()
        {
            var test = "Testing";

            var result = "Testing";

            Assert.Equal(result, test);
        }
    }
}
