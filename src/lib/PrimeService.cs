namespace lib.Prime.Services;
public class PrimeService
{
    //// 1) Fail all tests
    //public bool IsPrime(int num)
    //{
    //    throw new NotImplementedException("Please write test first");
    //}

    //// 2) Pass IsPrime_InputIs1_RetrunFalse
    //public bool IsPrime(int num)
    //{
    //    if (num == 1) 
    //    { 
    //        return false;
    //    }
    //    throw new NotImplementedException("Please write test first");
    //}

    //// 3) Pass IsPrime_InputLessThan2_RetrunFalse
    //public bool IsPrime(int num)
    //{
    //    if (num < 2)
    //    {
    //        return false;
    //    }
    //    throw new NotImplementedException("Please write test first");
    //}

    //// 4) Pass
    //// IsPrime_InputLessThan2_RetrunFalse
    //// IsPrime_InputIs2_RetrunTrue
    //public bool IsPrime(int num)
    //{
    //    if (num < 2)
    //    {
    //        return false;
    //    }
    //    else if (num == 2) 
    //    {
    //         return true;
    //    }
    //    throw new NotImplementedException("Please write test first");
    //}

    // 5) Pass
    // IsPrime_InputLessThan2_RetrunFalse
    // IsPrime_InputIs2_RetrunTrue
    // IsPrime_PrimeInput_RetrunTrue
    // IsPrime_NonPrimeInput_RetrunFalse
    public bool IsPrime(int num)
    {
        if (num < 2)
        {
            return false;
        }
        else
        {
            bool isPrime = true;
            int halfOfNum = num / 2;

            for (int i = 2; i <= halfOfNum; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                }
            }
            return isPrime;
        }
        throw new NotImplementedException("Please write test first");
    }
}
