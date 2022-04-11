//Boxing And UnBoxing
//装箱和拆箱
//拆箱性能消耗更大  
//装箱 值类型（栈/堆）——>引用类型（堆）
//拆箱 引用类型（堆）——>值类型（栈/堆）

using System.Collections;
using System.Diagnostics;

ArrayList ar = new();
List<int> list = new();
int nums = 100000;
int tempNums = -1;
Stopwatch st = new();


st.Restart();
for (int i = 0; i < nums; i++)
{
    ar.Add(i);
}
st.Stop();
Console.WriteLine($"ArraryList Elapsed Boxing:{st.Elapsed}");

st.Restart();
for (int i = 0; i < nums; i++)
{
    tempNums = ar.IndexOf(i);
}
st.Stop();
Console.WriteLine($"ArraryList Elapsed UnBoxing:{st.Elapsed}");

st.Restart();
for (int i = 0; i < nums; i++)
{
    list.Add(i);
}
st.Stop();
Console.WriteLine($"Genericity don't have Boxing  Elapsed:{st.Elapsed}");

st.Restart();
for (int i = 0; i < nums; i++)
{
    tempNums = list[i];
}
st.Stop();
Console.WriteLine($"Genericity  don't have UnBoxing Elapsed:{st.Elapsed}");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("You can see the unboxing runing time than boxing long");

Console.ResetColor();


