namespace TDDProject
{
    public class StringManipulator
    {
        public string ReverseString(string input)
        {
            // TODO: Implement the logic to reverse the input string

            char[] chars = input.ToCharArray();
            Array.Reverse(chars);

            return new string(chars);
        }

        public bool IsPalindrome(string input)
        {
            // TODO: Implement the logic to check if the input string is a palindrome
            // (A palindrome = same forwards as backwards)

            return input == ReverseString(input);
        }
    }
}
