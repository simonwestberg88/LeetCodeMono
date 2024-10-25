
string LongestPalindrome(string s)
{
    var longest = "";
    for(var i = 0; i < s.Length; i++){
            var even = LongestPalindromeFunc(s, i, i+1, "");
            if (even.Length > longest.Length)
            {
                longest = even;
            }
            var odd = LongestPalindromeFunc(s, i-1, i+1, s[i].ToString());
            if (odd.Length > longest.Length)
            {
                longest = odd;
            }
    }

    return longest;
}

string LongestPalindromeFunc(string s, int i, int j, string palindrome)
{
    if (i < 0 || j > s.Length - 1 || s[i] != s[j])
    {
        return palindrome;
    }
    palindrome = s[i] + palindrome + s[j];
    return LongestPalindromeFunc(s, i-1, j+1, palindrome);
}

var input = "babad";

var output = LongestPalindrome(input);
Console.WriteLine(output);
