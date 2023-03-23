// See https://aka.ms/new-console-template for more information
#region Usings

using System.Text;

#endregion

#region Main

int[] givenArray = { 1,2,3,4,5,6,7 };

Console.WriteLine("Given Array:");
Console.WriteLine(ArrayToStrig(givenArray));
Console.WriteLine();

Console.WriteLine("PrefixSums Array:");
Console.WriteLine(ArrayToStrig(PrefixSums(givenArray)));
Console.WriteLine();

Console.WriteLine("SliceSum:");
Console.WriteLine(SliceSum(givenArray, 1, 3));
Console.WriteLine();



#endregion

#region Methods
int[] PrefixSums(int[] input)
{
    int[] returnArray = new int[input.Length];
    returnArray[0] = input[0];

    for (int i = 1; i < input.Length; i++)
    {
        returnArray[i] = returnArray[i - 1] + input[i];
    }

    return returnArray;
}

int SliceSum(int[] input, int leftIndex, int rightIndex)
{
    int[] prefixSums = PrefixSums(input);

    if (leftIndex > 0)
    {
        return prefixSums[rightIndex] - prefixSums[leftIndex-1];
    }
    else
    {
        return prefixSums[rightIndex] - prefixSums[leftIndex];
    }

    
}

#endregion

#region ConsoleUtility
string ArrayToStrig(int[] input)
{
    StringBuilder sb = new StringBuilder();

    sb.Append("[");

    for (int i = 0; i < input.Length; i++)
    {
        sb.Append(input[i].ToString());
        if (i < input.Length - 1)
            sb.Append(", ");
    }

    sb.Append("]");

    return sb.ToString();
}

#endregion


