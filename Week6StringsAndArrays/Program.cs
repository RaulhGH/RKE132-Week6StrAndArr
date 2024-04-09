string hello = "hello, world!";

int hellolength = hello.Length;

Console.WriteLine(hellolength);

hello=hello.Trim();

char firstLetter = hello[0];
Console.WriteLine(firstLetter);

hello = hello.Replace(hello[0], char.ToUpper(hello[0]));

Console.WriteLine(hello);


//int worldCounter = 1;
//for (int i = 1; i < hello.Length; i++)
//{
//    if (char.IsWhiteSpace(hello[i]){
//        worldCounter++;
//    }
//}

//Console.WriteLine(worldCounter);

