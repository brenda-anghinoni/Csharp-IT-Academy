//-----  1  Ordenação padrão
string[] lista = { "Julio", "Lucia", "Daniel", "Joao" };
Console.WriteLine("Array antes da ordenacao");
for(int i = 0; i< lista.Length; i++)
{
    Console.WriteLine(lista[i] + " ");
}
Console.WriteLine();
Array.Sort(lista);
Console.WriteLine("Array depois da ordenacao");
for(int i = 0; i < lista.Length; i++)
{
    Console.WriteLine(lista[i] +" ");
}

//-----  2 Interfaces do .NET Framework
Console.WriteLine();
Pessoa[] lista2 = {
    new Pessoa("Jose", 25),
    new Pessoa("Ana", 28),
    new Pessoa("Paulo", 20)
};

for(int i = 0; i < lista2.Length; i++)
{
    Console.WriteLine(lista2[i].Nome+" ");
}

/*----------------------EXERCÍCIOS----------------------*/
Console.WriteLine("\n\n--------- Exercícios ---------");

//----- Exercício 1
Console.WriteLine("\n--- Ex.1");
Array.Sort(lista2);
Console.WriteLine("Array depois da ordenacao");
for(int i = 0; i < lista2.Length; i++)
{
    Console.WriteLine(lista2[i].Nome +" - "+lista2[i].Idade+" anos");
}

//----- Exercício 3
Console.WriteLine("\n--- Ex.3");
Console.WriteLine("Ordenando por idade:");
Array.Sort(lista2,Pessoa.ComparadorIdade());
for(int i = 0; i < lista2.Length; i++)
{
    Console.WriteLine(lista2[i].Nome +" - "+lista2[i].Idade+" anos");
}

Array.Sort(lista2,Pessoa.ComparadorNome());
Console.WriteLine("Ordenando por nome:");
for(int i = 0; i < lista2.Length; i++)
{
    Console.WriteLine(lista2[i].Nome +" - "+lista2[i].Idade+" anos");
}

