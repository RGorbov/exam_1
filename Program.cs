string[] getArray(int len){
    string[] array_ = new string[len];
    for (int i=0; i<len; i++){
        Console.Write("Enter array element: ");
        array_[i] = Console.ReadLine();
        Console.WriteLine();
    }
    return array_;
}


// Формирование  входного массива данных
Console.Write("Input in_array length: ");
int len = Convert.ToInt32(Console.ReadLine());
string[] in_array = getArray(len);

List<string> out_array = new List<string>();

// Фильтрация по длине элементов
for (int i=0; i < in_array.Length; i++){
    string curr_el = in_array[i];
    Console.WriteLine($"Element: {curr_el}; Element length: {curr_el.Length}");

    if (curr_el.Length <=3){
        out_array.Add(curr_el);
    }
}

// Вывод результата
Console.WriteLine();
Console.WriteLine("Output array is: ");
foreach (string el in out_array)
{
    Console.Write($"{el} ");
}
Console.WriteLine();

