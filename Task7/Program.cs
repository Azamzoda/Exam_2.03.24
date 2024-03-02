
List<int> list = new List<int>() {1, 0, 5, -4, 5, 10, -80, 24, 0, -4, 100, 24, 45, 6, -1};
//1
System.Console.WriteLine(list.Max());
//2
list.Distinct();
foreach (var item in list)
{
    System.Console.WriteLine(item);    
}
//3
list.Sort();
//4


