using Grammarfy;
using Grammarfy.Enums;
using TestingSuite;

var profileCount = 10;

var context = "profiles";

var profileTest = new Profile { };

Console.WriteLine($"This will change {profileCount.Plural("profiles")}");