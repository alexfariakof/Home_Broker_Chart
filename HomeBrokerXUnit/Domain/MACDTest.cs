﻿using Domain.Charts.ValueObject;
using HomeBrokerXUnit.Faker;

namespace Domain;
public class MACDTest
{
    const int MIN_AMOUNT_DATA = 34;

    [Fact]
    public void Should_Create_MACD_Correctly()
    {
        // Arrange
        var faker = MagazineLuizaHistoryPriceFaker.GetListFaker(MIN_AMOUNT_DATA);

        // Act
        var macd = new MACD(faker);

        // Assert
        Assert.NotNull(macd);
        Assert.NotNull(macd.MACDLine);
        Assert.NotNull(macd.Signal);
        Assert.NotNull(macd.Histogram);
    }

    [Fact]
    public void Should_Throws_Erro_when_Calculates_MCAD()
    {
        // Arrange
        int ERRO_MIN_DATA = 33;
        var faker = MagazineLuizaHistoryPriceFaker.GetListFaker(ERRO_MIN_DATA);

        // Act & Assert
        var exception = Assert.Throws<ArgumentException>(() => new MACD(faker));
        Assert.Equal("Não há dados suficientes para gerar um MACD.", exception.Message);
    }
}