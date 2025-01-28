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
                    
                    print(_str);

                    _n = int.Parse(input("Введите длину новой строки: "));
                    
                    _str = _str.Length > _n ? _str.Remove(0, _str.Length - _n) : _str.PadLeft(_n, '.');
                    
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