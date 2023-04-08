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

    // 4) Pass
    // IsPrime_InputLessThan2_RetrunFalse
    // IsPrime_InputIs2_RetrunTrue
    public bool IsPrime(int num)
    {
        if (num < 2)
        {
            return false;
        }
        else if (num == 2) 
        {
             return true;
        }
        throw new NotImplementedException("Please write test first");
    }
}
