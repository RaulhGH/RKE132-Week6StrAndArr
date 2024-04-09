int[] number =new int[10];

Random rnd = new Random ();

int sum = 0;

//populating the arry

for (int i = 0; i<number.Length; i++)    
{
 number[i] = rnd.Next (1, number.Length+1);
    sum += number[i];
}

foreach (int i in number)
{
    Console.WriteLine(i);
}

Console.WriteLine(sum);