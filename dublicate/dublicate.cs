int[] num = { 1, 1, 4, 2, 5, 5, 3, 6, 2, 1, 8, 9 };
int same = 0;

for (int i = 0; i < num.Length; i++)
{
    same = 0;

    for (int j = i+1; j < num.Length; j++)
    {
        if(num[i] == num[j])
        {
            same++;
            
        }
        if (num.Length - 1 == j)
        {
            Console.WriteLine("count of " + num[i] + " = "+ same);
        }
        
    }
    
}


//bunu ayri tapdim
int[] arr = { 1, 1, 4, 2, 5, 5, 3, 6, 2, 1, 8, 9 };

bool[] seen = new bool[arr.Length];

for (int i = 0; i < arr.Length; i++)
{
    if (seen[i]) continue;

    bool duplicate = false;
    for (int j = i + 1; j < arr.Length; j++)
    {
        if (arr[i] == arr[j])
        {
            duplicate = seen[j] = true;
        }
    }
    if (duplicate)
        Console.WriteLine(arr[i] + " ");
}