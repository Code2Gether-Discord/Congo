using System;
using System.Threading.Tasks;
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
        private readonly Mock<IMediator> mediatorMoq;
        private readonly ProductsController _subject;

        public ProductsControllerTests()
        {
            mediatorMoq = new Mock<IMediator>();
            _subject = new ProductsController(mediatorMoq.Object);
        }

        [Fact]
        public async Task ProductsController_ReturnsListOfProductsWithHttpStatus200()
        {
            // Arrange
            var allProducts = await _subject.GetAllProducts();

            // Assert
            allProducts.Result.Should().BeAssignableTo<OkObjectResult>();
        }

        [Fact]
        public async Task ProductsController_ReturnsOrderConfirmationForProduct()
        {
            // Arrange
            /* This is a productId from products.json */
            var productGuidToPurchase = new Guid("647fc15f-1b8e-4c85-a310-6d7d1431d39d");

            // Act
            var orderConfirmation = await _subject.PurchaseProductById(productGuidToPurchase);

            // Assert
            orderConfirmation.Result.Should().BeAssignableTo<OkObjectResult>();
        }

        [Fact]
        public async Task ProductsController_ReturnsHttpStatus400WhenProductDoesNotExist()
        {
            // Arrange
            /* Defaults to a Guid of all zeros */
            var productGuidToPurchase = new Guid();

            // Act
            var orderConfirmation = await _subject.PurchaseProductById(productGuidToPurchase);

            // Assert
            orderConfirmation.Result.Should().BeAssignableTo<BadRequestResult>();
        }
    }
}
