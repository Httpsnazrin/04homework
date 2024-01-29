#region LOOP TASKS
#region Task1 
//ulong i = 1;
//ulong hasil = 1;

//while (i <= 50)
//{

//    hasil *= i;
//    i++;

//}
//Console.WriteLine($"Hasil:{hasil}");
#endregion
#region Task2
//int cem = 0;
//int hasil = 1;
//int tekEdedSayi = 0;

//for (int i = -30; i <= 28; i++)
//{
//    if (i % 6 == 0)
//    {
//        cem += i;
//    }

//    if (i % 2 == 0 || i % 5 == 0)
//    {
//        hasil *= i;
//    }

//    if (i % 2 != 0)
//    {
//        tekEdedSayi++;
//    }
//}

//Console.WriteLine($"Cem: {cem}");
//Console.WriteLine($"Hasil: {hasil}");
//Console.WriteLine($"Tek ededlerin sayi: {tekEdedSayi}");
#endregion
#region Task3
//304001
//int eded = 304001;
//int musbetReqemCemi = 0;
//int sifirlarinSayi = 0;
//while (eded > 0)
//{
//    int reqem = eded % 10;

//    if (reqem > 0)
//    {
//        musbetReqemCemi += reqem;

//    }
//    else if (reqem == 0)
//    {
//        sifirlarinSayi++;
//    }

//    eded /= 10;
//}
//Console.WriteLine($"Musbet reqemlerin cemi: {musbetReqemCemi}");
//Console.WriteLine($"Sifirlarin sayi: {sifirlarinSayi}");


#endregion
#region Task4
//4573un tersini tapan proqram yazin
//int eded = 45763;
//int ededinTersi = 0;
//while (eded > 0)
//{
//    int reqem = eded % 10;
//    ededinTersi = ededinTersi * 10 + reqem;
//    eded /= 10;

//}
//Console.WriteLine(ededinTersi);
//#endregion
#region Task5
//string correctLogin = "booleanteach";
//string correctPassword = "booleanms13";
//int attempts = 0;

//while (attempts <= 3)
//{
//    Console.Write("Login daxil edin: ");
//    string enteredLogin = Console.ReadLine();

//    Console.Write("Password daxil edin: ");
//    string enteredPassword = Console.ReadLine();

//    if (enteredLogin == correctLogin && enteredPassword == correctPassword)
//    {
//        Console.WriteLine("Sisteme daxil oldunuz");
//        break;
//    }
//    else
//    {
//        Console.WriteLine("Login ve ya Password sehvdir");
//        attempts++;

//        if (attempts == 3)
//        {
//            Console.WriteLine("Sistem bloklanmishdir");
//            break;
//        }
//    }
//}
#endregion
#endregion
#endregion
#region Array Tasks
#region Task1
//string[] telebeMassivi = new string[5];

//for (int i = 0; i < 5; i++)
//{
//    Console.Write($"{i + 1}-ci telebenin adini daxil edin: ");
//    telebeMassivi[i] = Console.ReadLine();
//}

//Console.WriteLine("Telebeler:");

//foreach (string telebe in telebeMassivi)
//{
//    Console.Write(telebe + ";");
//}
#endregion
#region Task2 
//int[] numbers = new int[5];
//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.Write($"Eded {i + 1}-i daxil edin: ");
//    numbers[i] = Convert.ToInt32(Console.ReadLine());
//}
//int cem = 0;
//int hasil = 1;
//for (int i = 0;i < numbers.Length; i++) { 


//    if (numbers[i] % 2 == 0)
//    {
//        cem += numbers[i];


//    }
//    else if (numbers[i] % 2 == 1)
//    {

//        hasil *= numbers[i];

//    }


//}
//Console.WriteLine($"Cutlerin cemi: {cem}");
//Console.WriteLine($"Teklerin hasil: {hasil}");
#endregion
#region Task3
//int[] numbersA = new int[5] { 4, 6, -3, 44, -5 };
//int[] numbersB = new int[5] { 9, 16, 100, 11, -20 };

//int maxA = numbersA[0];
//int minB = numbersB[0];
//int maxAIndex = 0;
//int minBIndex = 0;

//for (int i = 1; i < 5; i++)
//{
//    if (numbersA[i] > maxA)
//    {
//        maxA = numbersA[i];
//        maxAIndex = i;
//    }

//    if (numbersB[i] < minB)
//    {
//        minB = numbersB[i];
//        minBIndex = i;
//    }
//}


//int copy = numbersA[maxAIndex];
//numbersA[maxAIndex] = numbersB[minBIndex];
//numbersB[minBIndex] = copy;

//foreach (int i in numbersA)
//{
//    Console.WriteLine(i);
//}
//foreach (int y in numbersB)
//{
//    Console.WriteLine(y);
//}

#endregion
#region Task4
//int[,] matrixA =
//    {
//    { 1, 2, 3 },
//    { 4, 5, 6 }
//};
//int[,] matrixB =
//    {
//    { 7, 8 },
//    { 9, 10 },
//    { 11, 12 }
//};
//int rowsA = matrixA.GetLength(0);
//int colsA = matrixA.GetLength(1);
//int rowsB = matrixB.GetLength(0);
//int colsB = matrixB.GetLength(1);

//if (colsA == rowsB)
//{
//    int[,] hasilMatrix = new int[rowsA, colsB];

//    for (int i = 0; i < rowsA; i++)
//    {
//        for (int j = 0; j < colsB; j++)
//        {
//            for (int k = 0; k < colsA; k++)
//            {
//                hasilMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
//            }
//        }
//    }

//    Console.WriteLine("Matrixlerin hasili:");
//    for (int i = 0; i < rowsA; i++)
//    {
//        for (int j = 0; j < colsB; j++)
//        {
//            Console.Write(hasilMatrix[i, j] + " ");
//        }
//        Console.WriteLine();
//    }
//}


#endregion
#endregion
