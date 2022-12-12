#region Task



//static string Reverse(string Name)
//{


//    char[] arr = Name.ToCharArray();


//    string reverse = string.Empty;


//    for (int i = arr.Length - 1; i > -1; i--)
//    {


//        reverse += arr[i];
//    }


//    return reverse;
//}

//Console.WriteLine(Reverse("Merdekan"));




#endregion






//int a = 5;
//int b = a;
//b = 10;
//Console.WriteLine(a);
//Console.WriteLine(b);

//int[] arr1 = { 1, 2, 3 };
//int[] arr2 = { 4, 5, 6 };

//arr2[0] = arr1[0];

//Console.WriteLine(arr2[0]);
//Console.WriteLine(arr1[0]);






//int[] arr = { 2, 3, 4, 5 };

//static void Test(int n)
//{
//    n = 100;
//    Console.WriteLine(n);
//}

//Test2(arr);
//Console.WriteLine(arr[0]);

//static void Test2(int[] arr)
//{
//    arr[0] = 200;
//    Console.WriteLine(arr[0]);
//}   





//int n = 5;
//Test(ref n);

//Console.WriteLine(n);
//static void Test(ref int n)
//{
//    n = 100; 
//    Console.WriteLine(n);
//}







//int n = 5;
//Test(out n);

//Console.WriteLine(n);
//static void Test(out int n)
//{
//    n = 100;
//    Console.WriteLine(n);
//}



//string name = "Pervin";
//string name2 = name;
//name2 = "Cavid";

//Console.WriteLine(name);
//Console.WriteLine(name2);



//string address = "Ehmedli";

//Console.WriteLine(address.Length);


//string address = "Ehmedli";
//Console.WriteLine(address.StartsWith("e"));

//string address = "Ehmedli";
//Console.WriteLine(address.EndsWith("i"));




//string address = "Ehmedli";

//if (address.EndsWith("i"))
//{
//    Console.WriteLine("yes");
//}
//else
//{
//    Console.WriteLine("no");

//}




//string address = "Ehmedli";

//var res = address.Split();
//Console.WriteLine(res);





//string address = "Ehmedli,Azerbaycan,Qax";

//var res = address.Split(",");

//foreach (var item in res)
//{
//    Console.WriteLine(item);
//}




//string address = "Ehmedli";
//Console.WriteLine(address.ToLower());



//string address = "Ehmedli";
//Console.WriteLine(address.ToUpper());



//string address = "roya";
//var letter = address[0].ToString().ToUpper();   
//var arr = address.ToCharArray();
//arr[0]= char.Parse(letter); 
//foreach(var item in arr)
//{
//    Console.Write(item);
//} 



//string name = "Baku";
//Console.WriteLine(name.ToUpper());


//string name = "Baku";
//Console.WriteLine(name.Substring(1));



//string name = "Baku";
//Console.WriteLine(name.Substring(2).ToUpper());


//string name = "       Baku";
//Console.WriteLine(name.Trim());


//string name = "   Baku";
//string name2 = "Baku";
//Console.WriteLine(name==name2);


string name = "Baku";
Console.WriteLine(name.Replace("B","C"));


