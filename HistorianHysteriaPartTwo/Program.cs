var input = File.ReadAllText("input.txt").Split("\n");

var leftNumbers = new List<int>();
var rightNumbers = new List<int>();
foreach (var str in input)
{ 
    var tmp = str.Split("   ");
    leftNumbers.Add(Convert.ToInt32(tmp[0]));
    rightNumbers.Add(Convert.ToInt32(tmp[1]));
}

var duplicateCount = new Dictionary<int, int>();

for (var i = 0; i < rightNumbers.Count; i++)
{
    if (duplicateCount.ContainsKey(rightNumbers[i]))
        duplicateCount[rightNumbers[i]] += 1;
    else
        duplicateCount.Add(rightNumbers[i], 1);
}

var result = 0;
for (int i = 0; i < leftNumbers.Count; i++)
{
    if (duplicateCount.ContainsKey(leftNumbers[i]))
    {
        result += leftNumbers[i] * duplicateCount[leftNumbers[i]];
    }
}

Console.WriteLine($"Result: {result}");