Console.Clear();

var meuArray = new int[5];
int[] meuArray2 = new int[5] { 1, 2, 3, 4, 5 };

meuArray[0] = 12;
meuArray.Clone();

Console.WriteLine(meuArray[0]);
Console.WriteLine(meuArray.Length);

// for (var item = 0; item < meuArray.Length; item++) { Console.WriteLine(meuArray[item]); }

foreach (var item in meuArray) { Console.WriteLine(item); }
