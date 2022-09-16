Console.Write("Введите строку: ");
string [] s = Console.ReadLine().Split();
for (int i=0;i<s.Length;i++)
{
if (s[i].Length > 2)
s[i]="";
Console.Write(s[i]+" ");
}

