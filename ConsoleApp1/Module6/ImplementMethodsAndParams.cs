using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Module6
{
    class ImplementMethodsAndParams
    {
        public static void RunApp()
        {

        }
    }

    // IMPLEMENTACION DE METODOS Y PARAMETROS DE CLASE

    /*  Un método es un bloque de código que contiene una serie de instrucciones. Un programa hace 
        que las instrucciones se ejecuten llamando al método y especificando los argumentos de método 
        necesarios. En C#, todas las instrucciones ejecutadas se realizan en el contexto de un método.
    */

    // FIRMAS DE METODO

    /*  Los métodos se declaran en una clase, registro o estructura especificando:

        * Un nivel de acceso opcional, como public o private. El valor predeterminado es private.
        * Modificadores opcionales como abstract o sealed.
        * Valor devuelto o void si el método no tiene ninguno.
        * Nombre del método.
        * Cualquier parámetro de método. Los parámetros de método se incluyen entre paréntesis y están 
          separados por comas. Los paréntesis vacíos indican que el método no requiere parámetros.

        Estas partes funcionan juntas para formar la firma del método.
    */
    abstract class Motorcycle
    {
        // Anyone can call this.
        public void StartEngine() {/* Method statements here */ }

        // Only derived classes can call this.
        protected void AddGas(int gallons) { /* Method statements here */ }

        // Derived classes can override the base class implementation.
        public virtual int Drive(int miles, int speed) { /* Method statements here */ return 1; }

        // Derived classes can override the base class implementation.
        public virtual int Drive(TimeSpan time, int speed) { /* Method statements here */ return 0; }

        // Derived classes must implement this.
        public abstract double GetTopSpeed();
    }

    /*  La clase Motorcycle incluye un método sobrecargado, Drive. Los dos métodos Drive tienen el 
        mismo nombre, pero tipos de parámetros diferentes.
    */

    // INVOCACION DE METODO

    /*  Los métodos pueden ser de instancia o estáticos . Debe crear una instancia de un objeto para 
        invocar un método de instancia en esa instancia; un método de instancia funciona en esa 
        instancia y sus datos. Para invocar un método estático, haga referencia al nombre del tipo al 
        que pertenece el método; Los métodos estáticos no funcionan en datos de instancia. Si se 
        intenta llamar a un método estático a través de una instancia de objeto, se genera un error 
        del compilador.

        Llamar a un método es como acceder a un campo. Después del nombre del objeto (si llama a un 
        método de instancia) o el nombre de tipo (si llama a un método estático), agregue un punto, 
        el nombre del método y paréntesis. Los argumentos se enumeran entre paréntesis y están 
        separados por comas.

        La definición del método especifica los nombres y tipos de cualquier parámetro que sea 
        necesario. Cuando un llamador invoca el método , proporciona valores concretos, denominados 
        argumentos, para cada parámetro. Los argumentos deben ser compatibles con el tipo de parámetro,
        pero el nombre del argumento, si se usa uno en el código de llamada, no tiene que ser el mismo 
        que el parámetro denominado definido en el método . En el ejemplo siguiente, el método Square 
        incluye un único parámetro de tipo int denominado i. La primera llamada al método pasa el 
        método Square una variable de tipo int denominada num; el segundo, una constante numérica; 
        y la tercera expresión.
    */
    public static class SquareExample
    {
        public static void Main()
        {
            // Call with an int variable.
            int num = 4;
            int productA = Square(num);

            // Call with an integer literal.
            int productB = Square(12);

            // Call with an expression that evaluates to int.
            int productC = Square(productA * 3);
        }

        static int Square(int i)
        {
            // Store input argument in a local variable.
            int input = i;
            return input * input;
        }
    }
}
