using System;

class Program
{
    static void Main()
    {
        int[] aiMultsOfThree = new int[333];
        int[] aiMultsOfFive = new int[200];
        
        int iFirstCount = 0;
        while (iFirstCount < 333)
            {
                aiMultsOfThree[iFirstCount] = 3 + (3 * iFirstCount); 
                iFirstCount++;
            }

        int iSecondCount = 0;
        while (iSecondCount < 200)
            {
                aiMultsOfFive[iSecondCount] = 5 + (5 * iSecondCount);
                iSecondCount++;
            }

        int iThirdCount = 0;
        int iThreeMultsSum = 0;
        while (iThirdCount < 333)
            {
                iThreeMultsSum += aiMultsOfThree[iThirdCount] + aiMultsOfThree[(iThirdCount++)];
                iThirdCount++;
            }

        int iFourthCount = 0;
        int iFiveMultsSum = 0;
        while (iFourthCount < 200)
            {
                iFiveMultsSum += aiMultsOfThree[iFourthCount] + aiMultsOfFive[(iFourthCount++)];
                iFourthCount++;
            }

        int iResult = iFiveMultsSum + iThreeMultsSum;

        int iCheckFor15 = 0;
        while (iCheckFor15 < 333)
            { 
                if (aiMultsOfThree[iCheckFor15] % 15 == 0)
                {
                    iResult = iResult - aiMultsOfThree[iCheckFor15];
                    iCheckFor15++;
                }
                else
                iCheckFor15++;
            }

        /*
        iCheckFor15 = 0;
        while (iCheckFor15 < 200)
        {
            if (aiMultsOfFive[iCheckFor15] % 15 == 0)
            {
                iResult = iResult - aiMultsOfFive[iCheckFor15];
                iCheckFor15++;
            }
            else
            iCheckFor15++;
        }
        */   
   

        Console.WriteLine("The total sum of all the multiples of 3 and 5 below 1000 is: " + iResult);


        //      To my newbie eyes I thought this would be able to initialize two arrays of lenth 333 and 200, 
        //  one for the muultiples of 3 below 1000 and one for the multiples of 5 below 1000 and add all the elements
        //  of each array to arrive with the correct result of the sum of all numbers below 1000 divisable by either 3 or 5.
    }

}

