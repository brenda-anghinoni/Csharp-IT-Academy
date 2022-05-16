Circulo circ1 = new Circulo();
Console.WriteLine(circ1);
Circulo circ2 = new Circulo(2.4, 5, 3);
Console.WriteLine(circ2);

CirculoColorido circ3 = new CirculoColorido();
Console.WriteLine(circ3);
CirculoColorido circ4 = new CirculoColorido(1.5, 3.1, 1, "vermelho");
Console.WriteLine(circ4);



/*----------------------EXERCÍCIOS----------------------*/
Console.WriteLine("\n\n--------- Exercícios ---------");

//----- Exercício 1
Console.WriteLine("\n--- Ex.1");
Console.WriteLine("X: " + circ4.CentroX);
Console.WriteLine("Y: " + circ4.CentroY);

//----- Exercício 2
Console.WriteLine("\n--- Ex.2");
CirculoColoridoPreenchido circ5 = new CirculoColoridoPreenchido();
Console.WriteLine(circ5);
CirculoColoridoPreenchido circ6 = new CirculoColoridoPreenchido(1.5, 3.1, 1, "green", "pink");
Console.WriteLine(circ6);


//----- Exercício 3
Console.WriteLine("\n--- Ex.3");
Circulo[] circulos = new Circulo[6];

circulos[0] = new Circulo();
circulos[1] = new Circulo(7, 10, 2);

circulos[2] = new CirculoColorido();
circulos[3] = new CirculoColorido(10, 15.5, 12, "blue");

circulos[4] = new CirculoColoridoPreenchido();
circulos[5] = new CirculoColoridoPreenchido(6, 6, 7, "black", "purple");

foreach (var item in circulos)
{
    Console.WriteLine(item);
}