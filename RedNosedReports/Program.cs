var inputString = File.ReadAllText("input.txt").Split("\n");

var data = new List<List<int>>();
foreach (var s in inputString)
{
    var tmp = s.Split(" ");
    var tmpList = new List<int>();
    foreach (var s1 in tmp)
    {
        tmpList.Add(Convert.ToInt32(s1));
    }
    data.Add(tmpList);
}



Console.ReadLine();