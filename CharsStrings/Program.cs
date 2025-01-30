namespace CharsStrings;

class Program : Python
{
    private static bool _check = true;

    private static int _task, _n;

    private static string? _str = "Тут короче слова  понятно да", _subStr;
    
    public static void Main(string[] args)
    {
        while (_check)
        {
            _task = int.Parse(input("Задание: "));

            switch (_task)
            {
                case 1:
                    _str = input("Введите строку: ");
                    
                    print(_str);

                    _n = int.Parse(input("Введите длину новой строки: "));
                    
                    _str = _str.Length > _n ? _str.Remove(0, _str.Length - _n) : _str.PadLeft(_n, '.');
                    
                    print($"Полученная строка: {_str}");
                    
                    break;
                case 2:
                    _str = input("Введите строку: ");
                    _subStr = input("Введите подстроку: ");
                    
                    print(_str.Replace(_subStr, ""));
                    
                    break;
                case 3:
                    _str = input("Введите исходную строку: ");
                    _subStr = input("Введите подстроку: ");

                    _str = _str.Substring(_str.IndexOf(_subStr), _str.LastIndexOf(_subStr));
                    
                    print(_str);
                    
                    break;
                case 4:
                    print($"Исходная строка: {_str}");
                    
                    print(_str.Replace(' ', '.'));
                    
                    break;
                case 5:
                    print($"Исходная строка: {_str}");

                    string[] words = _str.Split(new[] { ' ' }, StringSplitOptions.None);
                    for (int i = 0; i < words.Length; i++)
                    {
                        if (!string.IsNullOrEmpty(words[i]))
                        {
                            words[i] = TransformWord(words[i]);
                        }
                    }
                    
                    var result = string.Join(" ", words);
                    print($"Полученная строка: {result}");
                    
                    break;
                case 6:
                    _str = input("Введите строку: ");

                    result = "";
                    var result1 = "";

                    for (int i = 0; i < _str.Length; i++)
                        if(i % 2 == 0)
                            result += _str[i];
                    
                    for (int i = _str.Length - 1; i >= 0; i--)
                        if (i % 2 != 0)
                            result += _str[i];
                    
                    for (int i = result.Length - 1; i >= 0; i--)
                        result1 += result[i];
                    
                    print($"Результат: {result1}");
                    
                    break;
                case 7:
                    _str = input("Введите слово: ");

                    char[] charArr = new char[_str.Length];
                    var index = 0;

                    for (var i = _str.Length - 1; i >= 0; i--)
                    {
                        charArr[i] = _str[index];
                        
                        index++;
                    }
                    
                    var fStr = new string(charArr);
                    
                    if (fStr == _str)
                        print("Это слово палиндром");
                    else
                        print("Это слово не палиндром");
                    
                    break;
                case 0:
                    _check = false;
                    break;
                default:
                    print("ошибка");
                    break;
            }
        }
    }
    
    private static string TransformWord(string word)
    {
        if (word.Length == 0)
            return word;

        var firstChar = word[0];
        var lastChar = word[word.Length - 1];
        
        var firstTransformed = firstChar + string.Join("", word.Substring(1).Replace(firstChar.ToString(), ""));
        
        var lastTransformed = string.Join("", firstTransformed.Substring(0, firstTransformed.Length - 1).Replace(lastChar.ToString(), "")) + lastChar;

        return lastTransformed;
    }
}