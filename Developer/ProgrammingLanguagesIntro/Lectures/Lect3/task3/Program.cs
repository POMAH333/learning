// Дан текст. В нём нужно все пробелы заменить чёрточками, маленькие буквы «к» заменить большими «К», а большие «С» заменить на маленькие «с».

// string s = "qwerty"
//             012345
// s[3] - r

string text = "Я думаю, - сказал Князь улыбаясь, - что,"
            + "ежели бы вас послали вместо нашего милого Винценгороде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы.Вы дадите мне чаю?"; 
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty; //инициализация пустой строки
    int length = text.Length; // свойство показывающее колличество символов в строке
   // for(int i = 0; i < length; i++)
    int i = 0;
    while(i < length)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
        i++;
    }
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);
