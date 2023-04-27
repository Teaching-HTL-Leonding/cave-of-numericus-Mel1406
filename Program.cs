int numberOfValues = 1_000_000;
int maxValue = 1_000_000_001;
Console.WriteLine($"Number of values: {numberOfValues}");
GenerateRandomNumbers(out int min, out int max, numberOfValues, maxValue);
GetAverageDistance(min, max, numberOfValues);

void GenerateRandomNumbers(out int min, out int max, int numberOfValues, int maxValue)
{
    min = int.MaxValue;
    max = int.MinValue;
    var rand = new Random(4711);
    for (int i = 0; i < numberOfValues ; i++)
    { 
        int number = rand.Next(1, maxValue);
        if (number < min)
        {
            min = number;
        }
        if (number > max)
        {
            max = number;
        }
    }
}
void GetAverageDistance(int min, int max, int numberOfValues)
{
    double averageDistance = (max - min) / ((double)numberOfValues - 1);
    Console.WriteLine($"Average distance: {Math.Round(averageDistance, 5)} ");
}
void QuickSort(int[] arr, int left, int right)
{
    if (left < right)
    {
        int pivotIndex = Partition(arr, left, right);

        QuickSort(arr, left, pivotIndex - 1);
        QuickSort(arr, pivotIndex + 1, right);
    }
}

int Partition(int[] arr, int left, int right)
{
    int pivot = arr[right];
    int i = left - 1;

    for (int j = left; j < right; j++)
    {
        if (arr[j] < pivot)
        {
            i++;
            Swap(arr, i, j);
        }
    }

    Swap(arr, i + 1, right);

    return i + 1;
}

void Swap(int[] arr, int i, int j)
{
    int temp = arr[i];
    arr[i] = arr[j];
    arr[j] = temp;
}