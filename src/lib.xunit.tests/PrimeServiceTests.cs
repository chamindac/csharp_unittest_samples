using Xunit;
using lib.Prime.Services;

namespace lib.nunit.tests;

public class PrimeServiceTests
{
    private PrimeService _primeService;

    public PrimeServiceTests()
    { 
        _primeService = new PrimeService(); 
    }

    [Fact]
    public void IsPrime_InputIs1_RetrunFalse()
    {
        bool result = _primeService.IsPrime(1);
        Assert.False(result, "1 should not be prime.");
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(0)]
    [InlineData(1)]
    public void IsPrime_InputLessThan2_RetrunFalse(int input)
    {
        bool result = _primeService.IsPrime(input);
        Assert.False(result, $"{input} should not be prime.");
    }

    [Fact]
    public void IsPrime_InputIs2_RetrunTrue()
    {
        bool result = _primeService.IsPrime(2);
        Assert.True(result, "2 should be prime.");
    }

    [Theory]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(5)]
    [InlineData(7)]
    [InlineData(11)]
    [InlineData(13)]
    [InlineData(17)]
    [InlineData(19)]
    [InlineData(97)]
    [InlineData(101)]
    [InlineData(113)]
    public void IsPrime_PrimeInput_RetrunTrue(int input)
    {
        bool result = _primeService.IsPrime(input);
        Assert.True(result, $"{input} should be prime.");
    }

    [Theory]
    [InlineData(1)]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    [InlineData(9)]
    [InlineData(10)]
    [InlineData(12)]
    [InlineData(14)]
    [InlineData(15)]
    [InlineData(16)]
    [InlineData(18)]
    [InlineData(20)]
    [InlineData(95)]
    [InlineData(99)]
    [InlineData(105)]
    public void IsPrime_NonPrimeInput_RetrunFalse(int input)
    {
        bool result = _primeService.IsPrime(input);
        Assert.False(result, $"{input} should not be prime.");
    }
}
