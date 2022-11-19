// See https://aka.ms/new-console-template for more information
int a;
int b = 3;
string c = "Mayor";
Console.WriteLine("Pleaser, enter a value");
string d = Console.ReadLine();

if(c==d){
    Console.WriteLine("Is the same");
}else{
    Console.WriteLine("Is not the same");
}

//Exercise with numbers

Console.WriteLine("Pleaser, enter a number");
a = Convert.ToInt32(Console.ReadLine());
//a = int.Parse(Console.ReadLine());

if(a>b){ 
     Console.WriteLine("Is greater");
}else{
     Console.WriteLine("Is less");
}