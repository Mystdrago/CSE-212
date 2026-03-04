public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.


        // PLAN:
        // 1. Create a new array of type double with the given length.
        // 2. Loop from index 0 up to length - 1.
        // 3. For each index i:
        //      - The value should be number * (i + 1)
        //        because the first multiple is number * 1.
        // 4. Store that value in the array at position i.
        // 5. After the loop finishes, return the array.

        double[] result = new double[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        return result; // replaced with my own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // PLAN:
        // 1. Determine how many elements need to move from the end to the front.
        // 2. The last "amount" elements should move to the beginning.
        // 3. Store those last elements temporarily.
        // 4. Remove those elements from the end of the list.
        // 5. Insert the stored elements at the beginning of the list.
        // 6. The list will now be rotated to the right.

        // Step 1 & 2: Get the last "amount" elements
        List<int> temp = data.GetRange(data.Count - amount, amount);

        // Step 3 & 4: Remove them from the end
        data.RemoveRange(data.Count - amount, amount);

        // Step 5: Insert them at the beginning
        data.InsertRange(0, temp);
    }
}
