public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    /// 
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        /*Initialize a list to store the multiples.
        Generate the mulpliples of the starting number using a loop,
        it will 
        */

        // Initialize the list to store the multiples
        List<double> multiples = new List<double>();

        // Generate multiples using a loop
        for (int i = 1; i <= length; i++)
        {
            double Multiple = number * i;
            multiples.Add(Multiple);
        }

        // Convert the list to an array
        return multiples.ToArray(); // replace this return statement with your own
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

        /*First calculate the rotation that will be implemented by calculating the modulo of the amount
        with the length of the list (amount % data.Count).

        Divide the list in two based on the rotation amount.
    
            The first one will be the last amount elements of the list and the second one will be the elements
            before the last elements.

        Clear the original list by using ".Clear" in the list element "data.Clear()"
        
        Concatenate the parts in reverse order.

        Return the original list reverted.
        */

        //Calculate the rotation
        int n = data.Count;
        amount = amount % n;

        //Check if the rotation is needed, if not return early
        if (amount == 0)
        {
            return;
        }

        //Get the elements from the end that will be moved to the front
        List<int> start = data.GetRange(0, n - amount);
        
        //Get the elements from the start that will be moved to the back
        List<int> end = data.GetRange(n - amount, amount);

        //Clear the original list
        data.Clear();
        //Add the end of the list
        data.AddRange(end);
        //Add the start of the list
        data.AddRange(start);
    }
}
