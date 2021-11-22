using System;
using System.Threading.Tasks;
using Congo.Contracts.Requests.Products;
using Congo.WebApi.Controllers;
using FluentAssertions;
using MediatR;
using Moq;
using Xunit;

namespace Congo.WebApi.Tests
{
    public class SellerProductsControllerTests
    {
        private readonly Mock<IMediator> mediatorMoq;
        private readonly SellerProductsController _subject;

        public SellerProductsControllerTests()
        {
            mediatorMoq = new Mock<IMediator>();
            _subject = new SellerProductsController(mediatorMoq.Object);
        }

        [Fact]
        public async Task SellerProductsController_ShouldReturnProductIdAfterInsertingProduct()
        {
            // Arrange
            var product = new InsertProductRequest { Name = "Les pains boulogne whole", Description = "...", Price = 1.59m, ImageUrl = "" };

            // Act
            var productId = await _subject.CreateProduct(product);

            // Assert
            productId.Value.Should().Be(Guid.Empty);
        }
    }
}
