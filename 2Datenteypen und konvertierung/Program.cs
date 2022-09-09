//Aufgabe 1

Console.WriteLine(short.MaxValue);
Console.WriteLine(short.MinValue);
/*
  16 Bit 
  32767
  -32768
*/

Console.WriteLine(int.MaxValue);
Console.WriteLine(int.MinValue);
/*
 * 214783647
 -2147483648
*/

//Aufagbe 2

string vorname = "Parsa";
string alter = "20";
string frage = "true";

Console.WriteLine("Ich stelle Ihnen jetzt ein paar Frage!");
Console.WriteLine("");
Console.WriteLine("Frage 1. Wie heißen sie?");
vorname = Console.ReadLine();
Console.WriteLine("Frage 2. Wie alt sind Sie?");
alter = Console.ReadLine();
Console.WriteLine("Letzte Frage. Ist C# die erste Programiersprache, die Sie lernen?");
frage = Console.ReadLine();

Console.WriteLine("");
Console.WriteLine("Ihre Anworten:");
Console.WriteLine($"1. {vorname}\n2. {alter}\n3. {frage}");

//Aufgabe 3
/*
  int Dollarzeichen = 36;
  char Dollar = Dollazahl
*/

//Aufgabe 4
Console.WriteLine("Geben Sie die erste Variable ein!");
string v1_str = Console.ReadLine();

short v1_short = Convert.ToInt16(v1_str);
Console.WriteLine(v1_short);