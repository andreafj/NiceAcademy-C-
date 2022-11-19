// See https://aka.ms/new-console-template for more information
/* Declaring two variables of type double and two variables of type string. */
double x = 10, y = 5;
string a = "abcd", b="fgh";

//Basic math operators are +, -, /, *
Console.WriteLine("-------------Basic Math--------------");
//PEMDA
/*
P=POTENCIA
E=EXPONENTE
M=MULT
D=DIV
A=SUMA
S=RESTA
*/
Console.WriteLine((x/y) *x);
//Console.WriteLine(x / (y *x));

//Concatenar
Console.WriteLine(a+b);
Console.WriteLine("Concatenacion "+" "+a+b);

//Incremento / Decremento

Console.WriteLine("--------INC/Decrement");
x++;
y--;
Console.WriteLine(x);
Console.WriteLine(y);


//Incrementos shorthand
Console.WriteLine("---------SHORTHAND");
a +=b;
x +=y;

Console.WriteLine(a);
Console.WriteLine(x);

//Logical
///alt+124 ||
Console.WriteLine("---------LOGIC && ||");
Console.WriteLine(x +" "+y);
Console.WriteLine(x>y && y>=5);
Console.WriteLine(x>y || y>=5);

//Operatores null
Console.WriteLine("---------OPERATOR NULL");
string str = null;
//string str = "cat";
str ??= "New String";
//Console.WriteLine(str ?? "Unknow String");
Console.WriteLine(str);