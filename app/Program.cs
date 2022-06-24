var solution = new Solution752();

String[] deadends = new String[]
{
    "0201","0101","0102","1212","2002"
};

var target = "0202";

var res = solution.OpenLock(deadends, target);

Console.WriteLine(res);



