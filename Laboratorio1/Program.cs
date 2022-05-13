//-----  1  Tipos-valor byte, int e long
Console.WriteLine("--- 1 BYTE, INT E LONG\n");
byte b;
b = byte.MaxValue;
Console.WriteLine("Valor maximo de byte "+ b);
Console.WriteLine($"Valor maximo de byte: {b}");

int i;
i = int.MaxValue;
Console.WriteLine("Valor Maximo de int: "+ i );

long l;
l = long.MaxValue;
Console.WriteLine("Valor Maximo de long: "+ l );


//-----  2  Strings
Console.WriteLine("\n\n--- 2 STRINGS\n");
string strPrimeira = "Alo ";
string strSegunda = "Mundo";
string strTerceira = strPrimeira + strSegunda;
Console.WriteLine(strTerceira);

int cchTamanho = strTerceira.Length;
string strQuarta = "Tamanho = " + cchTamanho.ToString();
Console.WriteLine(strQuarta);

Console.WriteLine(strTerceira.Substring(0,5));

//-----3  Objetos
Console.WriteLine("\n\n--- 3 OBJETOS\n");
DateTime dt = new DateTime(2015, 04, 23);
string strQuinta = dt.ToString();
Console.WriteLine(strQuinta);



/*----------------------EXERCÍCIOS----------------------*/
Console.WriteLine("\n\n--------- Exercícios ---------");

//----- Exercício 1
Console.WriteLine("\n--- Ex.1");
float f = float.MaxValue;
double db = double.MaxValue;
decimal dc = decimal.MaxValue;

Console.WriteLine($"Valor maximo de float: {f}");
Console.WriteLine($"Valor maximo de double: {db}");
Console.WriteLine($"Valor maximo de decimal: {dc}");

float PIf = 3.14159265358979323846f;
double PIdb  = 3.14159265358979323846;
decimal PIdc = 3.14159265358979323846m;
Console.WriteLine($"PI float: { PIf}");
Console.WriteLine($"PI double: {PIdb}");
Console.WriteLine($"PI decimal: {PIdc}");


//----- Exercício 2
Console.WriteLine("\n--- Ex.2");
string linha1 = "C1L1\tC2L1\tC3L1\n";
string linha2 = "C1L2\tC2L2\tC3L2\n";
string linha3 = "C1L3\tC2L3\tC3L3\n";

string tabela = linha1 + linha2 + linha3;
Console.WriteLine(tabela);

string literais = @"Use ""\n"" para quebrar linha" +"\n"+ @"Use ""\t"" para tab";
Console.WriteLine(literais);

string substitui = "Oi fulano";
Console.WriteLine(substitui);
Console.WriteLine(substitui.Replace("fulano", "fulana"));

string strEmpty = String.Empty;
Console.WriteLine("1- "+strEmpty);


//----- Exercício 3
Console.WriteLine("\n--- Ex.3");
DateTime dataNow = DateTime.Now;
Console.WriteLine("Now: "+dataNow);

DateTime dataToday = DateTime.Today;
Console.WriteLine("Today: "+dataToday);
Console.WriteLine("Formatação pt-br: "+ dataNow.ToString("dd/MM/yyyy"));

DateTime dataAdiantadaHora = dataNow.AddHours(1); 
if(dataNow > dataAdiantadaHora){
    Console.WriteLine($"{dataNow.ToString("dd/MM/yyyy HH:mm:ss")} é maior que {dataAdiantadaHora.ToString("dd/MM/yyyy HH:mm:ss")}");
}else{
    Console.WriteLine($"{dataAdiantadaHora.ToString("dd/MM/yyyy HH:mm:ss")} é maior que {dataNow.ToString("dd/MM/yyyy HH:mm:ss")}");
}


//----- Exercício 4
Console.WriteLine("\n--- Ex.4");
int numI = 10;
float numF = 0;
numF = numI; //conversao implícita, sem perda de dados;
Console.WriteLine(numF);

numF = 0.5f;
numI = (int) numF; //conversão explícita, com perda de dados;
Console.WriteLine(numI);


//----- Exercício 5
Console.WriteLine("\n--- Ex.5");
string stringInteiro = "123456789";
int valorStringInteiro = Convert.ToInt32(stringInteiro);
Console.WriteLine(valorStringInteiro);

Int64 valorInt64 = 123456789;
int valorInt = Convert.ToInt32(valorInt64);
Console.WriteLine(valorInt);

//ERRO
// string stringInteiroGrande = "99999999999999999999999999999999";
// int ValorStringInteiroGrande = Convert.ToInt32(stringInteiroGrande);


//----- Exercício 6
Console.WriteLine("\n--- Ex.6");
string stringInteiroTP = "123456789";
int valorStringInteiroTP;
bool conversao1 = Int32.TryParse(stringInteiroTP, out valorStringInteiroTP);
Console.WriteLine("Conversão efetuada: "+ conversao1 + "\tValor: "+valorStringInteiro);

string stringInteiroGrande = "99999999999999999999999999999999";
int ValorStringInteiroGrande;
bool conversao2 = Int32.TryParse(stringInteiroGrande, out ValorStringInteiroGrande);
Console.WriteLine("Conversão efetuada: "+ conversao2 + "\tValor: "+ValorStringInteiroGrande);

string stringLetras = "abc";
double valorStringLetras;
bool conversao3 = Double.TryParse(stringLetras, out valorStringLetras);
Console.WriteLine("Conversão efetuada: "+ conversao3 + "\tValor: "+valorStringLetras);


//----- Exercício 7
Console.WriteLine("\n--- Ex.7");
double valorFracionado = 4.3;
int valorInteiro1 = (int) valorFracionado; //Pega apenas inteiro
int valorInteiro2 = Convert.ToInt32(valorFracionado); //Arrendonda
Console.WriteLine("Conversão explícita = "+valorInteiro1);
Console.WriteLine("Conversão método Convert = "+valorInteiro2);

//----- Exercício 8
Console.WriteLine("\n--- Ex.8");
int x1 = 10;
double y1 = 3.4;
Console.WriteLine("{0}   {1}",x1,y1); //substitui os indexes de acordo com os valores passados por parâmetro