// See https://aka.ms/new-console-template for more information
using ObdulioYTienda;

IValidador MiValidadorPositivo = new ValidadorPositivo();
IFabricaVendibles MiFabrica = new FabricaJacinto();
MiFabrica.Validador = MiValidadorPositivo;

IColeccionVendibles MovDiario = new MovimientosDiarios();

var entrada = "";
while (entrada.ToUpper() != "X")
{
    entrada = MuestraOpciones();
    switch (entrada)
    {
        case "1": Pon(TipoOrdenador.Lentorro);break;
        case "2": Pon(TipoOrdenador.Normal);break;
        case "3": Pon(TipoOrdenador.Gamer);break;
        case "4": PonConDatos(TipoOrdenador.Lentorro, damePrecio(), dameGarantia());break;
        case "5": PonConDatos(TipoOrdenador.Normal, damePrecio(), dameGarantia());break;
        case "6": PonConDatos(TipoOrdenador.Gamer, damePrecio(), dameGarantia());break;
    }
}
Console.WriteLine($"El total ingresado es {MovDiario.TotalImporteFacturado()}");

void Pon(TipoOrdenador tipo)
{
    IVendible MiOrdenador = MiFabrica.DameVendible(tipo);
    if (MiOrdenador != null)
    {
        MovDiario.Add(MiOrdenador);
        Console.WriteLine($"Creado {tipo.ToString()} ..");
    }
    else
    {
        Console.WriteLine($"Error en la creación del ordenador {tipo.ToString()}");
    }
}
void PonConDatos(TipoOrdenador tipo, int precio, int garantia)
{
    IVendible MiOrdenador = MiFabrica.DameVendible(tipo,precio,garantia);
    if (MiOrdenador != null)
    {
        MovDiario.Add(MiOrdenador);
        Console.WriteLine($"Creado {tipo.ToString()} ..");
    }
    else
    {
        Console.WriteLine($"Error en la creación del ordenador {tipo.ToString()}");
    }
}
int damePrecio()
{
    Console.WriteLine("Mete precio");
    return Int32.Parse(Console.ReadLine());
}
int dameGarantia()
{
    Console.WriteLine("Mete garantia");
    return Int32.Parse(Console.ReadLine());
}
 string MuestraOpciones()
{
    Console.WriteLine("Que Ordenador desea:");
    Console.WriteLine("1.- Lentorro Estandar");
    Console.WriteLine("2.- Normal Estandar");
    Console.WriteLine("3.- Gamer Estandar");
    Console.WriteLine("4.- Lentorro valores personalizados");
    Console.WriteLine("5.- Normal valores personalizados");
    Console.WriteLine("6.- Gamer valores personalizados");
    Console.WriteLine("X.- Salir");

    return Console.ReadLine();
}