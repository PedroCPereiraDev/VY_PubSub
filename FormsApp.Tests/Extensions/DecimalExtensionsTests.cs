namespace FormsApp.Tests.Extensions; 

using FluentAssertions;
using FormsApp.Extensions;
using NUnit.Framework;

internal class DecimalExtensionsTests
{
    [Test]
    public void ParseAsCurrency_ReceiveDecimal_ReturnValueAsCurrencyText()
    {
        //Arrange
        var data = 123.22M;

        //Act
        var result = data.ParseAsCurrency();

        //Assert
        result.Should().NotBeNullOrWhiteSpace();
        result.Should().BeEquivalentTo("123.22 EUR");
    }
}
