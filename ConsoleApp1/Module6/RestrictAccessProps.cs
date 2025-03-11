using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Module6
{
    class RestrictAccessProps
    {
        public static void RunRestrictProps ()
        {

        }
    }

    // RESTRINGIR EL ACCESO A LAS PROPIEDADES

    /*  Una clase puede especificar cómo se puede acceder a cada uno de sus miembros es codificar fuera 
        de la clase . Los métodos y variables que no están diseñados para usarse desde fuera de la clase 
        o el ensamblado se pueden ocultar para limitar el potencial de errores de codificación o 
        vulnerabilidades de seguridad malintencionadas.

        Algunos métodos y propiedades están diseñados para llamarse o acceder a ellas desde código fuera 
        de una clase, conocido como código de cliente. Es posible que otros métodos y propiedades solo 
        se usen en la propia clase. Es importante limitar la accesibilidad del código para que solo el 
        código de cliente previsto pueda llegar a él. Especifique cómo se puede acceder a los tipos y 
        sus miembros para el código de cliente mediante los siguientes modificadores de acceso:

        * public: el tipo o miembro es accesible por cualquier otro código del mismo ensamblado u otro 
          ensamblado que haga referencia a él.

        * protected: el tipo o miembro solo es accesible por código de la misma clase o una clase 
          derivada.

        * internal: cualquier código del mismo ensamblado puede acceder al tipo o al miembro, pero no 
          desde otro ensamblado.

        * protected internal: el tipo o miembro es accesible por cualquier código del mismo ensamblado 
          o por cualquier clase derivada de otro ensamblado.

        * private: el tipo o miembro solo es accesible por código de la misma clase o estructura.
         
        * private protected: el tipo o miembro solo es accesible por código en el mismo ensamblado y 
          solo por código de la misma clase o una clase derivada.

        Los miembros de clase se asignan private acceso de forma predeterminada.
    */

    // 1) MODIFICADORES DE ACCESO EN PROPIEDADES Y DESCRIPTORES DE ACCESO

    /*  Hasta este punto del módulo, nos centramos en propiedades que incluyen descriptores de acceso 
        get y set. Estas propiedades se conocen como propiedades de lectura y escritura. Además de las 
        propiedades de lectura y escritura, puede crear propiedades de solo lectura o proporcionar una 
        accesibilidad diferente a los descriptores de acceso set y get.

        De forma predeterminada, los descriptores de acceso get y set tienen el mismo nivel de 
        accesibilidad que la propiedad a la que pertenecen. Sin embargo, puede restringir la 
        accesibilidad del descriptor de acceso get o set. Los modificadores de acceso son útiles cuando 
        desea restringir el acceso a la propia propiedad, pero siguen permitiendo el acceso al valor de 
        la propiedad a través de un descriptor de acceso get.

        Supongamos que tiene una clase Person que solo debe habilitar el cambio del valor de la propiedad 
        FirstName de otros métodos de la clase . Puede proporcionar la accesibilidad privada del 
        descriptor de acceso set en lugar de interna o pública:
    */

    public class PersonAccess 
    {
        public string? FirstName { get; private set; }
        //Omitted for brevity
    }

    /*  La propiedad FirstName se puede leer desde cualquier código, pero solo se puede asignar desde 
        el código de la clase Person.

        Puede agregar cualquier modificador de acceso restrictivo a los descriptores de acceso set o get.
        Un modificador de acceso en un descriptor de acceso individual debe ser más restrictivo que el 
        acceso de la propiedad. El código anterior es legal porque la propiedad FirstName es public, 
        pero el descriptor de acceso set es private. No se pudo declarar una propiedad private con un 
        descriptor de acceso public. Las declaraciones de propiedad también se pueden declarar protected,
        internal, protected internalo, incluso private.

        Hay dos modificadores de acceso especiales para descriptores de acceso set:

        * Un descriptor de acceso set puede tener init como modificador de acceso. Ese descriptor de 
          acceso set solo se puede llamar desde un inicializador de objeto o los constructores del tipo. 
          Es más restrictivo que private en el descriptor de acceso set.

        * Una propiedad implementada automáticamente puede declarar un descriptor de acceso get sin un 
        descriptor de acceso set. En ese caso, el compilador permite llamar al descriptor de acceso set 
        solo desde los constructores del tipo. Es más restrictivo que el descriptor de acceso init en 
        el descriptor de acceso set.

        Tenga en cuenta las siguientes actualizaciones de la clase Person:*/

    public class PersonAccess2
    {
        public PersonAccess2(string firstName) => FirstName = firstName;

        public string FirstName { get; }

        // Omitted for brevity.
    }

    // 2) Restringir la accesibilidad del descriptor de acceso

    /*  En algunos casos, resulta útil restringir el acceso a los descriptores de acceso get o set. 
        Normalmente, restringe la accesibilidad del descriptor de acceso set, al tiempo que mantiene el 
        descriptor de acceso get accesible públicamente.

        ejemplo:
        
        
        private string _name = "Hello";
        
        public string Name
        {
            get
            {
                return _name;
            }
            protected set
            {
                _name = value;
            }
        }

        En este ejemplo, una propiedad denominada Name define un descriptor de acceso get y set. El 
        descriptor de acceso get recibe el nivel de accesibilidad de la propia propiedad, public en 
        este caso, mientras que el descriptor de acceso set está restringido explícitamente aplicando 
        el modificador de acceso protected al propio descriptor de acceso.  
    */

}
