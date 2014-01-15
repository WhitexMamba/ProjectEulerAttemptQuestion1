using System;

class EulerProjectAttemptFINAL
{
    static void Main()
    {
        const int iLimit = 1000;
        const int iNumberOfThrees = (iLimit - 1) / 3;
        const int iNumberOfFives = (iLimit - 1) / 5;
        const int iRepeats = iLimit / 15;

        int[] aiMultsOfThree = new int[iNumberOfThrees];
        int[] aiMultsOfFive = new int[iNumberOfFives];

        int iFirstCount = 0;
        while (iFirstCount < iNumberOfThrees)
            {
                aiMultsOfThree[iFirstCount] = 3 + (3 * iFirstCount);
                iFirstCount++;
            }

        int iSecondCount = 0;
        while (iSecondCount < iNumberOfFives)
        {
            aiMultsOfFive[iSecondCount] = 5 + (5 * iSecondCount);
            iSecondCount++;
        }

        int iThirdCount = 0;
        int iThreeMultsSum = 0;
        while (iThirdCount < iNumberOfThrees)
        {
            iThreeMultsSum += aiMultsOfThree[iThirdCount];
            iThirdCount++;
        }

        int iFourthCount = 0;
        int iFiveMultsSum = 0;
        while (iFourthCount < iNumberOfFives)
        {
            iFiveMultsSum += aiMultsOfFive[iFourthCount];
            iFourthCount++;
        }


        int iResult = iFiveMultsSum + iThreeMultsSum;

        int iCheckFor15 = 0;
        while (iCheckFor15 < iNumberOfThrees)
        {
            if (aiMultsOfThree[iCheckFor15] % 15 == 0)
            {
                iResult = iResult - aiMultsOfThree[iCheckFor15];
                iCheckFor15++;
            }
            else
                iCheckFor15++;
        }

        Console.WriteLine("The Sum of all numbers divisible by 3 or 5 is " + iResult);
    }

}
