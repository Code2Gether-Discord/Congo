using Congo.WebApi.Controllers;
using FluentAssertions;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace Congo.WebApi.Tests
{
    public class ProductsControllerTests
    {
        private readonly ProductsController sut;
        private readonly Mock<IMediator> mediatorMoq;
        private ProductsController _subject;

        public ProductsControllerTests()
        {
            mediatorMoq = new Mock<IMediator>();
            _subject = new ProductsController(mediatorMoq.Object);
        }

        [Fact]
        public async void Should_ReturnListOfProductsWithStatus200()
        {
            // Arrange
            var allProducts = await _subject.Get();

            // Assert
            allProducts.Result.Should().BeAssignableTo<OkObjectResult>();
        }
    }
}
