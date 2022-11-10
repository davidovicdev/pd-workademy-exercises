namespace PD.Workademy.Exercises.Tasks
{
    public static class ArrayIsContinuousSequence
    {
        public static void Test(int[] ints)
        {
            /*
             Write a method that receives an array of integers and returns true if array is continuous sequence, otherwise it returns false.
            Array is continuous sequence if its elements are ordered ascendingly or descendingly.
            Also neighboring elements can have the same values.*/
            if ((ints.Length < 1 || ints.Length > 1000) || ints.Any(x => x < 1 || x > 1000))
            {
                Console.WriteLine(
                    "Array needs to have length between 1 and 1000 and every number in array needs to be between 1 and 1000"
                );
            }
            else
            {
                bool isContinuousSequence = false;
                string order = "";
                for (int i = 0; i < ints.Length - 1; i++)
                {
                    int j = i + 1;
                    if (ints[i] != ints[j])
                    {
                        if (ints[i] > ints[j])
                        {
                            if (order == "ASC")
                            {
                                isContinuousSequence = false;
                                break;
                            }
                            else
                            {
                                isContinuousSequence = true;
                                order = "DESC";
                            }
                        }
                        else
                        {
                            if (order == "DESC")
                            {
                                isContinuousSequence = false;
                                break;
                            }
                            else
                            {
                                isContinuousSequence = true;
                                order = "ASC";
                            }
                        }
                    }
                }
                Console.WriteLine(
                    $"Input: [{string.Join(",", ints)}]; Output: {isContinuousSequence}"
                );
            }
        }
    }
}
