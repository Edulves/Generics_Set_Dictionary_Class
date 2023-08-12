using Generics_Set_Dictionary_Rascunho;

PrintService<int> printServiceString = new PrintService<int>();

Console.Write("How many values? ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++) {
    int x = int.Parse(Console.ReadLine());
    printServiceString.AddValue(x);
}

int a = printServiceString.First();
int b = a + 2;
Console.WriteLine(b);

printServiceString.Print();
Console.WriteLine("First: " + printServiceString.First());