IEstadoBinario[] lista = new IEstadoBinario[3];
lista[0] = new Lampada(110, 60);
lista[0].Ligar();
lista[1] = new TermometroEletrico();
lista[2] = new Televisao(32);
lista[2].Ligar();
for (int i = 0; i <3; i++)
{
    Console.WriteLine(lista[i].ToString()+" "+ lista[i].Estado);
}