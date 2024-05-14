// See https://aka.ms/new-console-template for more information

using ConsoleApp3;

IValidable validador = new Validador1();
IFabricaVendible MiFabrica = new Fabrica01(validador);
IColeccionVendible MiGestor = new Coleccion01();
MiGestor.Add(MiFabrica.dameInstancia(EnumTipoVendible.JarronPorcelana));
MiGestor.Add(MiFabrica.dameInstancia(EnumTipoVendible.JarronMing));
MiGestor.Add(MiFabrica.dameInstancia(EnumTipoVendible.JarronPorcelana));


Console.WriteLine($"(Coste Total: {MiGestor.dameCoste()})");
Console.WriteLine($"(Beneficio Total: {MiGestor.dameBeneficio()})");
Console.WriteLine($"(Venta Total: {MiGestor.dameVenta()})");