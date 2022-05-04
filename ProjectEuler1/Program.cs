//Project Euler 1

//If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
//Find the sum of all the multiples of 3 or 5 below 1000.

int number = 1000;
int multiple1 = 3;
int multiple2 = 5;
int multipleMin;
int sum = 0;
int multiple1Result;
int multiple2Result;
if (multiple1 < multiple2)
{
    multipleMin = multiple1;
}
else
{
    multipleMin = multiple2;
}
int count = multipleMin;
while (count < number)
{
    multiple1Result = count % multiple1;
    multiple2Result = count % multiple2;

    if ((multiple1Result == 0) || (multiple2Result == 0))
    {
        sum = sum + count;
        Console.WriteLine("Multiple: " + count);
    }
    count++;
}

Console.WriteLine("Final: " + sum);