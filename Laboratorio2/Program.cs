//-----  1  Alocando, inicializando e acessando dados de array

//----- Utilizando for
int[] array = new int[5] { 10, 20, 30, 40, 50 };
int i;
for(i = 0; i < 5; i++){
    Console.WriteLine("Indice = " + i + " & Valor = " + array[i]);
}

string[] str = new string[3];
int iStr;
str[0] = "Um";
str[1] = "Dois";
str[2] = "Três";
for(iStr = 0; iStr < 3; iStr++){
    Console.WriteLine("Indice = " + iStr + " & Valor = " + str[iStr]);
}


DateTime[] dt = new DateTime[2];
int iDate;
dt[0] = new DateTime(2002,5,1);
dt[0] = new DateTime(2002,6,1);
for(iDate = 0; iDate < 2; iDate++){
    Console.WriteLine("índice = "+ iDate + " & Data = "+dt[iDate].ToShortDateString());
}

//----- Utilizando foreach
Console.WriteLine("\nUtilizando FOREACH\n");
i = 0;
foreach (var item in array)
{
    Console.WriteLine("Indice = " + i + " & Valor = " + item);
    i++;
}

iStr = 0;
foreach (var item in str)
{
    Console.WriteLine("Indice = " + iStr + " & Valor = " + item);
    iStr++;
}

iDate = 0;
foreach (var item in dt)
{
    Console.WriteLine("Indice = " + iDate + " & Valor = " + item);
    iDate++;
}


/*----------------------EXERCÍCIOS----------------------*/
Console.WriteLine("\n\n--------- Exercícios ---------");

//----- Exercício 1
Console.WriteLine("\n--- Ex.1");
int tam = 10;
int[] array1 = new int[tam];
int[] array2 = new int[tam];

for(var cont = 0; cont < tam; cont++){
    array1[cont] = tam - cont;
}

//FORMA 1
//for(var cont = 0; cont < tam; cont++){
//    array2[cont] = array1[cont];
//}

//FORMA 2
Array.Copy(array1, array2, array2.Length);

Console.WriteLine("\nArray 1:");
foreach (var item in array1)
{
    Console.WriteLine("Valor = " + item);
}

Console.WriteLine("\nArray 2:");
foreach (var item in array1)
{
    Console.WriteLine("Valor = " + item);
}


//----- Exercício 2
Console.WriteLine("\n--- Ex.2");

int tamM = 5;
int linha;
int coluna;
int contador = 1;

//Utilizando array multidimensional
int[,] arrayMulti = new int[tamM,tamM];

for(linha = 0; linha < tamM; linha++){ //insere valores
    for(coluna = 0; coluna < tamM; coluna++){
        arrayMulti[linha,coluna] = contador;
        contador++;
    }
}

string dadosLinha = "";
for(linha = 0; linha < tamM; linha++){ //exibe matriz
    for(coluna = 0; coluna < tamM; coluna++){
        dadosLinha += arrayMulti[linha,coluna].ToString()+"\t";
    }
    Console.WriteLine(dadosLinha);
    dadosLinha = "";
}

int somaColuna = 0;
for(coluna = 0; coluna < tamM; coluna++){ //soma colunas
    for(linha = 0; linha < tamM; linha++){
        somaColuna += arrayMulti[linha,coluna];
    }
    Console.WriteLine($"A soma da coluna {coluna+1} é: {somaColuna}");
    somaColuna = 0;
}

Console.WriteLine("\n");

//Utilizando array jagged
int posicao1;
int posicao2;
int[][] arrayJagged = new int[tamM][];
for(posicao1 = 0; posicao1 < tamM; posicao1++){
    arrayJagged[posicao1] = new int[tamM];
}

contador = 1;
for(posicao2 = 0; posicao2 < tamM; posicao2++){ //insere valores
    for(posicao1 = 0; posicao1 < tamM; posicao1++){
        arrayJagged[posicao1][posicao2] = contador;
        contador++;
    }
}

dadosLinha = "";
for(posicao2 = 0; posicao2 < tamM; posicao2++){ //exibe matriz
    for(posicao1 = 0; posicao1 < tamM; posicao1++){ 
        dadosLinha += arrayJagged[posicao1][posicao2].ToString()+"\t";
    }
    Console.WriteLine(dadosLinha);
    dadosLinha = "";
}

somaColuna = 0;
for(posicao1 = 0; posicao1 < tamM; posicao1++){ //soma colunas
    for(posicao2 = 0; posicao2 < tamM; posicao2++){
        somaColuna += arrayJagged[posicao1][posicao2];
    }
    Console.WriteLine($"A soma da coluna {posicao1+1} é: {somaColuna}");
    somaColuna = 0;
}
