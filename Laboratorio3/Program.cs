//-----  1  Manipulando lista
List<string>  listaStrings = new List<String>();
listaStrings.Add("Um");
listaStrings.Add("Hello");
listaStrings.Add("World");
Console.WriteLine(listaStrings[0]);
Console.WriteLine(listaStrings[1]);
Console.WriteLine(listaStrings[2]);

//-----  2  Manipulando fila
Queue<Object> q = new Queue<object>();
q.Enqueue(".Net Framework");
q.Enqueue(new Decimal(123.456));
q.Enqueue(654.321);
Console.WriteLine(q.Dequeue());
Console.WriteLine(q.Dequeue());
Console.WriteLine(q.Dequeue());

Queue<int> minhaFila = new Queue<int>();
minhaFila.Enqueue(10);
minhaFila.Enqueue(200);
minhaFila.Enqueue(1000);
Console.WriteLine(minhaFila.Dequeue());
Console.WriteLine(minhaFila.Dequeue());
Console.WriteLine(minhaFila.Dequeue());

//-----  2  Manipulando dicionários genéricos
Dictionary<int, string> paises = new Dictionary<int, string>();
paises[44] = "Reino Unido";
paises[33] = "França";
paises[55] = "Brasil";
Console.WriteLine("O código 55 é: {0}", paises[55]);
foreach (KeyValuePair<int, string> item in paises)
{
    int codigo = item.Key;
    string pais = item.Value;
    Console.WriteLine("O código {0} = {1}", codigo, pais); 
}


/*----------------------EXERCÍCIOS----------------------*/
Console.WriteLine("\n\n--------- Exercícios ---------");

//----- Exercício 1
Console.WriteLine("\n--- Ex.1");
string paisNome = "França";
foreach (KeyValuePair<int, string> item in paises)
{
    if(item.Value.Equals(paisNome)){
        Console.WriteLine("O país {0} tem código {1}", item.Value, item.Key); 
        break;
    }
}

//----- Exercício 2
Console.WriteLine("\n--- Ex.2");
List<int> listaNumeros = new List<int>();
listaNumeros.Add(1);
listaNumeros.Add(10);
listaNumeros.Add(20);
listaNumeros.Add(30);
listaNumeros.Add(35);

double media = listaNumeros.Average();
Console.WriteLine("O número de elementos maiores que a média {0} são {1}", media,TotalAcimaMedia()); 

int TotalAcimaMedia(){
    int total = 0;
 
    foreach (var item in listaNumeros)
    {
        if(item > media){
            total++;
        }
    }
    return total;
}

//----- Exercício 3
Console.WriteLine("\n--- Ex.3");
List<int> novaListaNumeros = ListaAcimaMedia();
Console.WriteLine("Os números acima da média são:"); 
foreach (var item in novaListaNumeros)
{
    Console.WriteLine(item); 
}

List<int> ListaAcimaMedia(){
    List<int> lista = new List<int>();

    foreach(var item in listaNumeros){
         if(item > media){
            lista.Add(item);
        }
    }

    return lista;
}