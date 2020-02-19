using System;

namespace OtroNamespace
{
    class MiClase
    {
        //Puede ser visto por cualquier clase
        public void MetodoPublico()
        {
            Console.WriteLine("Llamando al metodo publico");
        }

        //Puede ser visto desde esta clase o cualquier clase de MiClase
        protected void MetodoProtected()
        {
            Console.WriteLine("Llamando al metodo protected");
        }

        //Puede ser visto porcualquier clase dentro del mismo assembly (el proyecto actual)
        internal void MetodoInternal()
        {
            Console.WriteLine("Llamando al metodo internal");
        }

        //Puede ser visto solo por esta clase
        private void MetodoPrivado()
        {
            Console.WriteLine("Llamando al metodo privado");
        }

    }
}
