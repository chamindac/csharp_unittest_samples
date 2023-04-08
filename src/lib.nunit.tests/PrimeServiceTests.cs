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

    [TestCase(2)]
    [TestCase(3)]
    [TestCase(5)]
    [TestCase(7)]
    [TestCase(11)]
    [TestCase(13)]
    [TestCase(17)]
    [TestCase(19)]
    [TestCase(97)]
    [TestCase(101)]
    [TestCase(113)]
    public void IsPrime_PrimeInput_RetrunTrue(int input)
    {
        bool result = _primeService.IsPrime(input);
        Assert.IsTrue(result, $"{input} should be prime.");
    }

    [TestCase(1)]
    [TestCase(4)]
    [TestCase(6)]
    [TestCase(8)]
    [TestCase(9)]
    [TestCase(10)]
    [TestCase(12)]
    [TestCase(14)]
    [TestCase(15)]
    [TestCase(16)]
    [TestCase(18)]
    [TestCase(20)]
    [TestCase(95)]
    [TestCase(99)]
    [TestCase(105)]
    public void IsPrime_NonPrimeInput_RetrunFalse(int input)
    {
        bool result = _primeService.IsPrime(input);
        Assert.IsFalse(result, $"{input} should not be prime.");
    }
}
