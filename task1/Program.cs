using task1;

var c = new Cache<string>();
c.Add("aaa");
c.Add("bbb");
c.Add("ccc");
foreach (var item in c.GetValue())
{
    System.Console.WriteLine(item + " ");   
}
System.Console.WriteLine($"-------");
c.Remove("aaa");
foreach (var item in c.GetValue())
{
    System.Console.Write(item + " ");   
}