// See https://aka.ms/new-console-template for more information
using Musica001;


IValidable MiValidador = new Validador02();
IFabricaMusica MiFabrica = new FabricaMusica(MiValidador);
IColeccionDistribucion MiGestor = new ColeccionDistribucion01();

IReproducible elemento = MiFabrica.DameReproducible(EnumTipoReproducible.Canciones, 102.2);

MiGestor.Add(elemento);
MiGestor.Add(MiFabrica.DameReproducible(EnumTipoReproducible.Canciones, 505.5));
MiGestor.Add(MiFabrica.DameReproducible(EnumTipoReproducible.Canciones, 663));
//elemento = MiFabrica.DameReproducible(EnumTipoReproducible.Canciones, 663);
//if (elemento != null)
//    MiGestor.Add(elemento);


Console.WriteLine($"(Duración Total de la lista: {MiGestor.totalDuracion()})");
Console.WriteLine($"(numero de canciones Total: {MiGestor.numeroCanciones()})");