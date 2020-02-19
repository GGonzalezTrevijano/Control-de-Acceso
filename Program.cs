using OtroNamespace;    //Usando el namespace de "MiClase" y con esta referencia podemos usar las clases y metodos de dicho namespace

namespace Proyecto3_Control_de_Acceso
{
    class Program
    {
        static void Main(string[] args)
        {
            MiClase obj = new MiClase();
            obj.MetodoPublico();
            obj.MetodoInternal();
            // obv.MetodoProtected(); no deja llamarlo por su nivel de proteccion
            // obv.MetodoPrivado(); no deja llamarlo por su nivel de proteccion
        }
    }
}

