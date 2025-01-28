namespace CharsStrings;

class Program : Python
{
    private static bool _check = true;

    private static int _task, _n;

    private static string? _str;
    
    public static void Main(string[] args)
    {
        while (_check)
        {
            _task = int.Parse(input("Задание: "));

            switch (_task)
            {
                case 1:
                    _str = input("Введите строку: ");

                    _n = int.Parse(input("Введите длину новой строки: "));

                    if (_str.Length > _n)
                        _str = _str.Remove(_n, _str.Length - _n);
                    else
                        _str = _str.PadLeft(_n, '.');
                    
                    print($"Полученная строка: {_str}");
                    
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
}