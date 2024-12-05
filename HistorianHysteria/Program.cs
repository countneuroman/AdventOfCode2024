var input = File.ReadAllText("input.txt").Split("\n");

var leftNumbers = new List<int>();
var rightNumbers = new List<int>();
foreach (var str in input)
{ 
    var tmp = str.Split("   ");
    leftNumbers.Add(Convert.ToInt32(tmp[0]));
    rightNumbers.Add(Convert.ToInt32(tmp[1]));
}

leftNumbers.Sort();
rightNumbers.Sort();

var result = 0;
for (var i = 0; i < leftNumbers.Count; i++)
{
    result += Math.Abs(leftNumbers[i] - rightNumbers[i]);  
}

Console.WriteLine($"Result: {result}");