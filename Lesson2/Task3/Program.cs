//int n = 10;
int[] array = {1, 4, 5, 7, 7, 35, 1, 3, 5 };
int i = 0;

while(i < array.Length)
{
    if (array[i] % 2 == 0 ){
        System.Console.Write($"{array[i]} ");
    }
    i = i + 1;
}
