// to test the pre-commit hook...
// 1. add a blank line to the end of this file
// 2. stage it
// 3. run git commit -v
// 4. notice formatting get's corrected and staged

// dotnet format will change the following to var
string a = "huh?";
int b = 1;
StringBuilder c = new StringBuilder("hola!");
bool d = true;

// dotnet format won't chop this line up, but csharpier will!
string[] array = new string[] { a, b, c, d, "1234567890", "1234567890", "1234567890", "1234567890", "1234567890", "1234567890", "1234567890", "1234567890", "1234567890", "1234567890", "1234567890", "1234567890", "1234567890" };

Console.WriteLine(string.Join(", ", array));
