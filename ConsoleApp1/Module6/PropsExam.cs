using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Module6
{
    class PropsExam
    {
        public static void RunPropsExam()
        {
            // 1) 

            // Inicializamos un nuevo objeto
            Customer cust1 = new Customer(4987.63, "Northwind", 90108);
            // Modificamos una propiedad
            cust1.TotalPurchases += 499.99;


            // 2)

            // Some simple data sources.
            string[] names = ["Person One","Person Two", "Person Three",
                            "Person Four", "Person Five"];
            string[] addresses = ["123 Main St.", "345 Cypress Ave.", "678 1st Ave",
                                "12 108th St.", "89 E. 42nd St."];

            // Simple query to demonstrate object creation in select clause.
            // Create Contact objects by using a constructor.
            var query1 = from i in Enumerable.Range(0, 5)
                         select new Contact(names[i], addresses[i]);

            // List elements can't be modified by client code.
            var list = query1.ToList();
            foreach (var contact in list)
            {
                Console.WriteLine("{0}, {1}", contact.Name, contact.Address);
            }

            // Create Contact2 objects by using a static factory method.
            var query2 = from i in Enumerable.Range(0, 5)
                         select Contact2.CreateContact(names[i], addresses[i]);

            // Console output is identical to query1.
            var list2 = query2.ToList();

            // List elements can't be modified by client code.
            // CS0272:
            // list2[0].Name = "Person Six";
        }
    }

    // EXAMEN DE PROPIEDADES IMPLEMENTADAS AUTOMATICAMENTE

    /*  La sintaxis estandar para definir una propiedad en C# incluye un descriptor de acceso "get" y un
        descriptor de acceso "set". Sin embargo, cuando no se requiere ninguna otra logica en los descriptores
        de acceso, puede usar propiedades implementadas automaticamente.
    */

    // 1) PROPIEDADES IMPLEMENTADAS AUTOMATICAMENTE

    /*  Las propiedades implementadas automaticamente hacen que la declaracion de propiedad sea mas concisa
        cuando no se requiere ninguna otra logica en los descriptores de acceso de propiedad. Tambien
        permiten que el codigo de cliente cree objetos. Cunado se declara una propiedad como se muestra
        en el ejemplo siguiente, el compilador crea un campo de respaldo privado y anonimo al que solo
        se puede acceder a traves de los descriptores de acceso "get" y "set" de la propiedad. "init"
        descriptores de acceso tambien se pueden declarar como propiedades implementadas automaticamente

        En el ejemplo siguiente se muestra una clase simple que tiene algunas propiedades implementadas
        automaticamente:        
    */

    // Esta data es mutable. Su data puede ser modificada desde afuera de la clase

    public class Customer
    {
        // Auto implementa las propiedades get y set

        public double TotalPurchases { get; set; }
        public string Name { get; set; }
        public int CustomerId { get; set; }

        // Constructor
        public Customer(double purchases, string name, int id) 
        {
            TotalPurchases = purchases;
            Name = name;
            CustomerId = CustomerId;
        }

        // Metodos
        public string GetContactInfo()
        {
            return "ContactInfo";
        }

        public string GetTransactionHistory()
        {
            return "History";
        }


        // Otros metodos, eventos, etc
    }

    /*  Las propiedades respaldadas por campos e implementadas automaticamente declaran un campo de
        respaldo de instancia privada. Puede inicializar propiedades implementadas automaticamente de
        forma similar a los campos:

        public string FirstName { get; set; } = "FirstName";

        la clase Customer que se muestra en el ejemplo anterior es mutable. El codigo de cliente puede
        cambiar los valores de los objetos despues de la creacion. En clases complejas que contienen un
        comportamiento significativo (metodos) y datos, a menudo es necesario tener propiedades publicas
        sin embargo, para clases o estructuras pequeñas que simplemente encapsulan un conjunto de valores
        (datos) y tienen poco o ningun comportamiento, debe usar una de las siguientes opciones para hacer
        que los objetos sean inmutables:

        * Declare solo un descriptor de acceso get (inmutable en todas partes excepto el constructor).
        * Declare un descriptor de acceso get y un descriptor de acceso init (inmutable en todas partes
          excepto durante la construccion del objeto).
        * Declare un descriptor de acceso set como privado (inmutable para los consumidores).
        
        Es posible que tenga que agregar validacion a una propiedad implementada automaticamente. C# 13
        agrega propiedades respaldadas por campos como una caracteristica de vista previa. Use la palabra
        field para acceder al campo de respaldo sintetizado del compilador de una propiedad implementada
        automaticamente. Por ejemplo, podria asegurarse de que la propiedad FirstName del ejemplo anterior
        no se pueda establecer a null o en cadena vacia:

        public string FirstName 
        { 
            get; 
            set 
            { 
                field = (string.IsNullOrWhiteSpace(value) is false
                    ? value
                    : throw new ArgumentException(nameof(value), "First name can't be whitespace or null"));
            }
        } = "FirstName";
        
        Esta caracteristica permite agregar logica a descriptores de acceso sin necesidad de declarar
        explicitamente el campo de respaldo.Use la palabra clave field para acceder al campo de respaldo
        generado por el compilador.
    */

    // 2) PROPIEDADES CON CAMPOS DE RESPALDO

    /*  Puede combinar el concepto de una propiedad calculada con un campo privado y crear una propiedad
        evaluada en cache. Por ejemplo, actualice la propiedad FullName para que el formato de cadena
        se produzca en el primer acceso
    */

    public class People
    {
        public People() { }

        [SetsRequiredMembers]
        public People(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public required string FirstName { get; init; }
        public required string LastName { get; init; }

        private string? _fullName;
        public string FullName
        {
            get
            {
                if (_fullName is null)
                    _fullName = $"{FirstName} {LastName}";
                return _fullName;
            }
        }
    }

    /*  Esta implementación funciona porque las propiedades FirstName y LastName son de solo lectura. 
        Las personas pueden cambiar su nombre. La actualización de las propiedades FirstName y LastName 
        para permitir los descriptores de acceso de set requiere que invalide cualquier valor almacenado 
        en caché para fullName. Modifique los descriptores de acceso set de la propiedad FirstName y 
        LastName para que el campo fullName se calcule de nuevo:
    */

    public class People2
    {
        private string? _firstName;
        public string? FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
                _fullName = null;
            }
        }

        private string? _lastName;
        public string? LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                _fullName = null;
            }
        }

        private string? _fullName;
        public string FullName
        {
            get
            {
                if (_fullName is null)
                    _fullName = $"{FirstName} {LastName}";
                return _fullName;
            }
        }
    }

    /*  Esta versión final evalúa la propiedad FullName solo cuando es necesario. La versión calculada 
        anteriormente se usa si es válida. De lo contrario, el cálculo actualiza el valor almacenado en 
        caché. Los desarrolladores que usan esta clase no necesitan conocer los detalles de la 
        implementación. Ninguno de estos cambios internos afecta al uso del objeto Person.

        A partir de C# 13, puede crear partial properties en clases parciales. La declaración de 
        implementación de una propiedad partial no puede ser una propiedad implementada automáticamente. 
        Una propiedad implementada automáticamente usa la misma sintaxis que una declaración de 
        propiedad parcial.
    */

    // 3) IMPLEMENTACION DE UNA CLASE LIGERA CON PROPIEDADES IMPLEMENTADAS AUTOMATICAMENTE

    /*  Es posible que encuentre situaciones en las que necesite crear una clase ligera inmutable
        que solo sirve para encapsular un conjunto de propiedades implementadas automaticamente.
        Use este tipo de construccion en lugar de un struct cuando deba usar la semantica de tipos
        de referencia.

        Puede hacer que una propiedad inmutable sea inmutable de las siguientes maneras:

        * Declare solo el descriptor de acceso get, que hace que la propiedad sea inmutable en todas 
          partes, excepto en el constructor del tipo.
        * Declare un descriptor de acceso init en lugar de un descriptor de acceso de set, que hace que 
          la propiedad solo se puede establecer en el constructor o mediante un inicializador de objeto.
        * Declare el descriptor de acceso set que se va a private. La propiedad se puede establecer 
          dentro del tipo, pero es inmutable para los consumidores.

        Puede agregar el modificador required a la declaración de propiedad para forzar a los autores de 
        llamada a establecer la propiedad como parte de la inicialización de un nuevo objeto.

        En el ejemplo siguiente se muestra cómo una propiedad con solo el descriptor de acceso get 
        difiere de uno con get y private set.
    */

    class Contact
    {
        public string Name { get; }
        public string Address { get; private set; }

        public Contact(string contactName, string contactAddress)
        {
            // Both properties are accessible in the constructor.
            Name = contactName;
            Address = contactAddress;
        }

        // Name isn't assignable here. This will generate a compile error.
        //public void ChangeName(string newName) => Name = newName;

        // Address is assignable here.
        public void ChangeAddress(string newAddress) => Address = newAddress;
    }

    /*  En el ejemplo siguiente se muestran dos maneras de implementar una clase inmutable mediante 
        propiedades implementadas automáticamente. Cada forma declara una de las propiedades con un set 
        privado y una de las propiedades con un get solo. La primera clase usa un constructor solo para 
        inicializar las propiedades y la segunda clase usa un método de generador estático que llama a }
        un constructor.
    */

    public class Contact2
    {
        // Read-write property with a private set accessor.
        public string Name { get; private set; }

        // Read-only property.
        public string Address { get; }

        // Private constructor.
        private Contact2(string contactName, string contactAddress)
        {
            Name = contactName;
            Address = contactAddress;
        }

        // Public factory method.
        public static Contact2 CreateContact(string name, string address)
        {
            return new Contact2(name, address);
        }
    }
}
