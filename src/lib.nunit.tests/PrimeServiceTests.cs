using NUnit.Framework;
using lib.Prime.Services;

namespace lib.nunit.tests;

[TestFixture]
public class PrimeServiceTests
{
    private PrimeService _primeService;

    public PrimeServiceTests()
    { 
        _primeService = new PrimeService(); 
    }

    [Test]
    public void IsPrime_InputIs1_RetrunFalse()
    {
        bool result = _primeService.IsPrime(1);
        Assert.IsFalse(result, "1 should not be prime.");
    }
}
