// See https://aka.ms/new-console-template for more information

using LongestCommonPrefix;

var sln = new Solution();
var strs = new []{"flower", "flow", "flight"};
var t1 = sln.LongestCommonPrefix(strs);
var t2 = sln.LongestCommonPrefix(["ab", "a"]);

Console.WriteLine("Hello, World!");