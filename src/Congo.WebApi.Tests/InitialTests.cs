using System;
using FluentAssertions;
using Xunit;

namespace Congo.WebApi.Tests
{
    public class InitialTests
    {
        [Fact]
        public void MyFirstUnitTest()
        {
            // Arrange
            var expected = 1;

            // Act
            var actual = 1;

            // Asset
            actual.Should().Be(expected);
        }
    }
}
