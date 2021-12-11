namespace PalindromeNameSpace
{
    public class Palindrome
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string");
            string input = InputString();

            Console.WriteLine();
            Console.WriteLine("Palindrome partitions for " + input + ":");

            List<List<string>> allPalindromePartitions = GetAllPalindromePartitions(input);

            OutputString(allPalindromePartitions);
        }

        private static string InputString()
        {
            return Console.ReadLine();
        }

        private static void OutputString(List<List<string>> allPalindromePartitions)
        {
            for (int i = 0; i < allPalindromePartitions.Count; i++)
            {
                for (int j = 0; j < allPalindromePartitions[i].Count; j++)
                {
                    Console.Write(allPalindromePartitions[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static List<List<string>> GetAllPalindromePartitions(string input)
        {
            int inputLength = input.Length;

            List<List<string>> allPalindromePartitions = new List<List<string>>();

            List<string> currentPalindromePartitions = new List<string>();

            GetPartionsRecursively(allPalindromePartitions, currentPalindromePartitions, 0, inputLength, input);

            return allPalindromePartitions;
        }

        private static void GetPartionsRecursively(List<List<string>> allPalindromePartitions,
                List<string> currentPalindromePartitions, int start, int inputLength, string input)
        {
            if (start >= inputLength)
            {
                allPalindromePartitions.Add(new List<string>(currentPalindromePartitions));
                return;
            }

            for (int i = start; i < inputLength; i++)
            {

                if (IsPalindrome(input, start, i))
                {
                    currentPalindromePartitions.Add(input.Substring(start, i + 1 - start));

                    GetPartionsRecursively(allPalindromePartitions, currentPalindromePartitions, i + 1, inputLength, input);

                    currentPalindromePartitions.RemoveAt(currentPalindromePartitions.Count - 1);
                }
            }
        }

        public static bool IsPalindrome(string input,
                                        int start, int i)
        {
            while (start < i)
            {
                if (input[start++] != input[i--])
                    return false;
            }
            return true;
        }
    }
}
