using System;
using Congo.WebApi.Controllers;
using FluentAssertions;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace Congo.WebApi.Tests
{
    public class CartControllerTests
    {
        private readonly Mock<IMediator> _mediatorMoq;
        private readonly CartController _subject;

        public CartControllerTests()
        {
            _mediatorMoq = new Mock<IMediator>();
            _subject = new CartController(_mediatorMoq.Object);
        }

        [Fact]
        public async void CartController_ReturnsCartOfTypeCartResponse()
        {
            // Arrange
            var guidToSearch = new Guid();  // All zeros
            var cartResponse = await _subject.GetCartById(guidToSearch);

            // Assert
            cartResponse.Result.Should().BeAssignableTo<OkObjectResult>();
        }
    }
}
