string name = "C# is programming language";
string name1 = "";


for (int i = name.Length - 1; i >= 0; i--)
{
    name1 += name[i].ToString();
}

string[] newName1;
newName1 = name1.Split(' ');

for (int i = newName1.Length - 1; i >= 0; i--)
{
    Console.Write(newName1[i]+" ");
}



//string[] newName;

//newName = name.Split(' ');

//Console.WriteLine(newName[0]);