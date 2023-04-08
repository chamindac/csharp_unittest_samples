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
}
