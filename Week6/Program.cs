string hello = "I am a robot ";

int stringLenght = hello.Length;
//string trimmedString = hello.Trim();

hello = hello.Trim();

char firstLetter = hello[0];

hello = hello.Replace(hello[0], char.ToUpper(hello[0]));

Console.WriteLine(firstLetter);





//int wordCounter = 0;

//for(int i = 0; i < hello.Length; i++)
//{
//    //Console.WriteLine($"{i} symbol in string: {hello[i]}");
//    if (char.IsWhiteSpace(hello[i]))//(hello[i] == ' ')
//    {
//        wordCounter++;
//    }
//}

//Console.WriteLine(hello.Length);

//Console.WriteLine($"Word count in {hello}: {wordCounter +1} words");