//задача:одномерный массив array из n эл-в, требуется найти эл-т массива равный find
int[] array = { 11, 81, 21, 31, 41, 15, 16, 17, 81, 19 };

int n = array.Length;
int find = 81;

int index = 0;

while (index < n)
{
   if(array[index] == find)
   {
    Console.WriteLine(index);
    break;
   }

    //index = index +1;
    index++;
}