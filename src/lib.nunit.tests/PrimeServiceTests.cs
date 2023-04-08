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

    [TestCase(-1)]
    [TestCase(0)]
    [TestCase(1)]
    public void IsPrime_InputLessThan2_RetrunFalse(int input)
    {
        bool result = _primeService.IsPrime(input);
        Assert.IsFalse(result, $"{input} should not be prime.");
    }

    [Test]
    public void IsPrime_InputIs2_RetrunTrue()
    {
        bool result = _primeService.IsPrime(2);
        Assert.IsTrue(result, "2 should be prime.");
    }
}
