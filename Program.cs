/*  char[,] charArray = new char[,] { { 'a', 'b' }, { 'c', 'd' } };

  string result = CreateStringFrom2DArray(charArray);

  Console.WriteLine(result);


string CreateStringFrom2DArray(char[,] array)
{
  string result = "";

  for (int i = 0; i < array.GetLength(0); i++)
  {
      for (int j = 0; j < array.GetLength(1); j++)
      {

          result += array[i, j];
      }
  }
  return result;
}*/

/*string input = "AbCdEfGh";
string low = input.ToLower();
string up = input.ToUpper();
Console.WriteLine(low);
Console.WriteLine(up);*/

/*string input = "Arra";
bool isPalindrome = IsPalindrome(input);

Console.WriteLine(isPalindrome ? "Да" : "Нет");


 bool IsPalindrome(string str)
{
    
    string normalized = new
    string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();

    return normalized.SequenceEqual(normalized.Reverse());
}*/

string input = "Hello my world";

string result = ReverseWords(input);

Console.WriteLine(result);

string ReverseWords(string str)
{

string[] words = str.Split(' ');
Array.Reverse(words);
return string.Join(" ", words);
}