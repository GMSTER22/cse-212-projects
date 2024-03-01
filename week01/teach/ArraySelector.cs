public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}

        var l3 = new[] {1, 2, 3, 4};
        var l4 = new[] {10, 20, 30, 40};
        var select1 = new[] {1, 1, 2, 2, 1, 1, 2, 2};
        var intResult1 = ListSelector(l3, l4, select1);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult1) + "}"); // <int[]>{1, 2, 10, 20, 3, 4, 30, 40}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        int list1NextIndex = 0;
        int list2NextIndex = 0;

        int[] result = new int[select.Length];

        for (int i = 0; i < select.Length; i++)
        {
            if (select[i] == 1)
            {
                result[i] = list1[list1NextIndex];
                list1NextIndex++;
            } 
            else 
            {
                result[i] = list2[list2NextIndex];
                list2NextIndex++;
            }
        }

        return result;
    }
}