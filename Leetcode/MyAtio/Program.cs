// Example 1:
//
// Input: s = "42"

using MyAtio;

var sln = new Solution();
var t1 = sln.MyAtoi("42");
var t2 = sln.MyAtoi("-042");
var t3 = sln.MyAtoi("1337c0d3");
var t4 = sln.MyAtoi("words and 987");
var t5 = sln.MyAtoi("20000000000000000000");
// var t6 = sln.MyAtoi("      +kl1");
var t7 = sln.MyAtoi("1095502006p8");
Console.WriteLine("test");

//
// Output: 42
//
// Explanation:
//
// The underlined characters are what is read in and the caret is the current reader position.
//     Step 1: "42" (no characters read because there is no leading whitespace)
//     ^
//     Step 2: "42" (no characters read because there is neither a '-' nor '+')
//     ^
//     Step 3: "42" ("42" is read in)
//     ^
//     Example 2:
//
// Input: s = " -042"
//
// Output: -42
//
// Explanation:
//
// Step 1: "   -042" (leading whitespace is read and ignored)
//     ^
//     Step 2: "   -042" ('-' is read, so the result should be negative)
//     ^
//     Step 3: "   -042" ("042" is read in, leading zeros ignored in the result)
//     ^
//     Example 3:
//
// Input: s = "1337c0d3"
//
// Output: 1337
//
// Explanation:
//
// Step 1: "1337c0d3" (no characters read because there is no leading whitespace)
//     ^
//     Step 2: "1337c0d3" (no characters read because there is neither a '-' nor '+')
//     ^
//     Step 3: "1337c0d3" ("1337" is read in; reading stops because the next character is a non-digit)
// ^
//     Example 4:
//
// Input: s = "0-1"
//
// Output: 0
//
// Explanation:
//
// Step 1: "0-1" (no characters read because there is no leading whitespace)
//     ^
//     Step 2: "0-1" (no characters read because there is neither a '-' nor '+')
//     ^
//     Step 3: "0-1" ("0" is read in; reading stops because the next character is a non-digit)
// ^
//     Example 5:
//
// Input: s = "words and 987"
//
// Output: 0
//
// Explanation:
//
// Reading stops at the first non-digit character 'w'.