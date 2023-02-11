string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
                +"ежели бы вас послали вместо нашего милого Винценгероде, "
                +"вы бы взяли приступом согласие прусского короля. "
                +"Вы так красноречивы. Вы дадите мне чаю?";

//string text = "qwerty"
//               012345
//text[3] // r

string repllace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int lenght = text.Length;
    for(int i = 0; i < lenght; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

// string peplaced = repllace(text, ' ', '|');
// peplaced = repllace(peplaced, 'к', 'К');
// peplaced = repllace(peplaced, 'С', 'с');
// Console.WriteLine(peplaced);


int[] arr = {1, 5, 3, 7, 1, 1, 2, 4, 6};

void printArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;


        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

printArray(arr);
SelectionSort(arr);
printArray(arr);