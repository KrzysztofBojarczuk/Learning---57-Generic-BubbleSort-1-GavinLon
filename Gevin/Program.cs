// See https://aka.ms/new-console-template for more information


using Gevin;

//int[] arr = new int[] { 2, 1, 4, 3 };
//string[] arr = new string[] { "Bob", "Henry", "Andy", "Greg" };
Employee[] arr = new Employee[]
{
    new Employee { Id = 4, Name = "John" },
    new Employee { Id = 2, Name = "Bob"  },
    new Employee { Id = 3, Name = "Greg" },
    new Employee { Id = 1, Name = "Tom"  }
};


SortArray<Employee> sortArray = new SortArray<Employee>();

//SortArray<int> sortArray = new SortArray<int>();

//SortArray<string> sortArray = new SortArray<string>();

sortArray.BubbleSort(arr);


foreach (object item in arr)
{
    Console.WriteLine(item);
}
