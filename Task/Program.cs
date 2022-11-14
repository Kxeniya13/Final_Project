Console.Clear();
Console.Write("Задайте количество элементов первоначального массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] arrayStart = new string[size];
FirstArray(arrayStart);
string[] arrayFinish = new string[arrayStart.Length];
int lengthItem = 3;
int index = 0;
for (int j = 0; j < arrayStart.Length; j++) {
    if (arrayStart[j].Length <= lengthItem)
    {
        arrayFinish[index] = arrayStart[j];
        index++;
    }
}
Console.WriteLine("Элементы, максимальная длина которых <= 3: ");
PrintArray(arrayFinish);

void FirstArray (string[] massive) {
    for (int i = 0; i < massive.Length; i++) {
       Console.Write($"Введите {i+1}-й элемент массива: " + massive[i]);
        string item = Convert.ToString(Console.ReadLine());
        massive[i] = item;   
    }
    Console.WriteLine();
}
void PrintArray(string[] array) {
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
