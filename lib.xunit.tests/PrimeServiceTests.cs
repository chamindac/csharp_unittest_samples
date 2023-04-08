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
}
