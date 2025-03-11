using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Module6
{
    class PropsAndClassMethods
    {
        public static void RunApp()
        {   
            //1)
            /*Person person = new Person("Julian", 26);
            person.Display();*/
            
            
            //2)
            Employee employee = new Employee(); // Crea la instancia de la clase Employee
            Console.WriteLine(employee.Name); // Usa el descriptor de acceso "get" para leer el valor de Name
            
            
            //3)
            var student = new Student();
            student.Name = "StudentName"; // El accesor set es invocado aqui
            Console.WriteLine(student.Name); // El accesor set es invocado aqui


            //4)
            Console.WriteLine("---------------------------------------------------------------------");

            // Creamos nueva instancia de la clase Person
            Person person = new Person();

            // Imprimimos los valores por defecto de name y age de Person
            Console.WriteLine($"Person details - Name = {person.Name}, Age = {person.Age}");

            // Seteamos algunos valores a name y age de la persona
            person.Name = "PersonName";
            person.Age = 99;
            Console.WriteLine($"Person details - Name = {person.Name}, Age = {person.Age}");

            // Incrementamos el valor de la edad de la persona en 1
            person.Age += 1;
            Console.WriteLine($"Person details - Name = {person.Name}, Age = {person.Age}");

            // Mantenemos abierta la consola en modo debug
            //Console.WriteLine("Press any key to exit.");
            //Console.ReadKey();


            //5)
            Console.WriteLine("---------------------------------------------------------------------");

            var aPerson = new Person3("PersonName");
            aPerson = new Person3 { FirstName = "PersonName" };
            // Error CS9035: Required member `Person.FirstName` must be set:
            var aPerson2 = new Person();
        }
    }

    /* 1). Campos, Propiedades, metodos y constructores en una definicion de clase

       Aunque una definicion de clase puede incluir todos los miembros enumerados en la tabla,
       los mas comunes son CAMPOS, PROPIEDADES, METODOS Y CONSTRUCTORES. Estos miembros forman
       la estructura principal de la mayoria de las clases de C#, lo que proporciona el almacenamiento
       de datos necesario, los mecanismos de acceso, las definiciones de comportamiento y logica de
       inicializacion.
       
       El siguiente fragmento de codigo muestra como se pueden usar los miembros de clase comunes 
       para definir e implementar una clase en C#
    */

   /* public class Person
    {
        // Fields
        private string name;
        private int age;

        // Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        // Constructors
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Methods
        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }*/

    /* En este ejemplo se usan los siguientes tipos de miembro:
       
       * La clase Person tiene dos campos, name y age, que son privados.
       * Propiedades: la clase Person tiene dos propiedades, Name y Age, que proporcionan acceso a los
         campos privados. Las propiedades usan los descriptores de acceso get y set para leer y escribir
         valores de los campos.
       * Constructores: la clase Person tiene un cosntructor que inicializa los campos name y age cuando
         se crea un nuevo objeto person.
       * Metodos: la clase Person tiene un metodo Display que escribe el nombre y la antiguedad de la 
         persona en la consola

    */

    //INTRODUCCION A LAS PROPIEDADES Y DESCRIPTORES DE ACCESO DE LA CLASE

    /* Las propiedades de clase proporcionan un mecanismo flexible para leer, escribir o calcular el valor
       de un campo de datos. Aparecen como miembros de datos publicos, pero se implementan como metodos
       especiales denominados descriptores de acceso. Esta caracteristica permite a los autores de llamadas
       acceder facilmente a los datos y seguir contribuyendo a promover la seguridad y flexibilidad de los
       datos.

       Uso de propiedades:

        Las propiedades combinan aspectos de ambos campos y metodos. Para el usuario de un objeto, una propiedad
        parece ser un campo. El acceso a la propiedad requiere la misma sintaxis que el acceso a un campo.
        Para el implementador de una clase, una propiedad es uno o dos bloques de codigo, que representa
        un descriptor de accedo de "get" o un descriptor de acceso "set" o "init". El bloque de codigo del
        descriptor de acceso "get" se ejecuta cuando se lee la propiedad. El bloque de codigo de un descriptor
        de acceso "set" se ejecuta cuando a la propiedad se le asigna un valor. Una propiedad sin un descriptor
        de acceso "set" se considera de solo lectura. Una propiedad sin un descriptor de acceso "get" se con
        sidera de solo escritura. Una propiedad que tiene ambos descriptores de acceso es de lectura y escritura
        puede usar un descriptor de acceso "init" en lugar de un descriptor de acceso de "set" para permitir
        que la propiedad se establezca como parte de la inicializacion de objetos, pero de lo contrario, hacer
        que sea de solo lectura.
        
        A diferencia de los campos, las propiedades no se clasifican como variables. Por lo tanto, no se
        puede pasar una propiedad como un parametro "ref" o "out".

        las propiedades suelen usar para admitir los siguientes escenarios:

        * Pueden validar los datos antes de permitir un cambio.
        * Pueden exponer datos de forma transparente en una clase donde esos datos se recuperan de algun
          otro origen, como una base de datos.
        * Pueden realizar una accion cuando se cambian los datos, como generar un evento o cambiar el valor
          de otros campos.
    
        Las propiedades se declaran el el bloque de codigo de una definicion de clase. Las propiedades se
        declaran especificando el nivel de acceso del campo, seguido del tipo de la propiedad, seguido del
        nombre de la propiedad, seguido del bloque de codigo que declara un descriptor de acceso "get" o un
        descriptor de acceso "set".
    */

    // 2) DESCRIPTOR DE ACCESO "GET"

    /* El cuerpo del descriptor de acceso "get" es similar al del metodo. Debe devolver un valor del tipo
       de propiedad. El compilador de C# y el compilador Just-In-Time (JIT) detectan patrones comunes
       para implementar el descriptor de acceso "get" y optimizar para esos patrones.
        
       Por ejemplo, es problable que un descriptor de acceso de "get" que devuelva un campo sin realizar
       ningun calculo este optimizado para una lectura de memoria de ese campo. Las propiedades implemen
       tadas automaticamente, que se examinan en la siguiente unidad de este modulo, siguen este patron
       y se benefician de estas optimizaciones. Sin embargo, no se puede insertar un metodo de descriptor
       de acceso de "get" virtual porque el compilador no conoce en tiempo de compilacion que metodo
       podria llamarse realmente en tiempo de ejecucion.
       
       En el ejemplo siguiente se muestra un descriptor de acceso "get" que devuelve un valor de campo
       privado _name
     */

    public class Employee
    {
        private string _name = "unknown"; // The same field

        public string Name
        {
            get { return _name;  } // The Name property
        }
    }

    /*  En este ejemplo la clase Employee incluye un campo privado y una propiedad publica. Esta es una
        explicacion de la definicion de clase Employee:
    
        * La clase Employee se define con el modificador de acceso publico, lo que significa que es
          accesible desde cualquier otro codigo del mismo ensamblado u otro ensamblado que haga referencia
          a el.
    
        * El _name de campo privado se declara con el tipo string y se le asigna un valor predeterminado
          "unknown".
    
        * La propiedad publica "Name" se declara con el tipo string. La propiedad incluye un descriptor
          de acceso "get" que devuelve el valor del campo "_name"

        Nota: Los campos que proporcionan valores para los descriptores de acceso de propiedad a menudo
        se les denomina "campos de respaldo"

        El bloque de codigo de un descriptor de acceso "get" tambien se puede usar para devolver un valor
        calculado. Esto puede ser util cuando desea asegurarse de que una propiedad siempre devuelve un
        valor distinto de NULL. Por ejemplo
    */

    public class Manager
    {
        private string? _name;
        public string Name
        {
            get
            {
                return _name != null ? _name : "NA";
            }
        }
    }

    // 3) DESCRIPTOR DE ACCESO "SET"

    /* 
        El descriptor de acceso "set" es similar a un metodo cuyo tipo de valor devuelto es void. Usa un
        parametro implicito denominado value, cuyo tipo es el tipo de la propiedad. El compilador y el
        compilador JIT tambien reconocen patrones comunes para un descriptor de acceso "set" o "ini".
        Estos patrones comunes estan optimizados, escribiendo directamente la memoria para el cambio de
        respaldo. En el ejmplo siguiente, se agrega un descriptor de acceso "set" a la propiedad "Name":
    */

    class Student
    {
        private string? _name; //The name field
        public string Name 
        {
            get
            {
                return _name != null ? _name : "NA";
            }

            set
            {
                _name = value;
            }
        }
    }

    // 4) DESCRIPTOR DE ACCESO INIT

    /*  El codigo para crear un descriptor de acceso "init" es el mismo que el codigo para crear un
        descriptor de acceso "set", excepto que se usa la palabra clave "init" en lugar de "set". La 
        diferencia es que el descriptor de acceso "init" solo se puede usar en el constructor o mediante
        un inicializador de objeto.
    */

    // DECLARAR Y USAR PROPIEDADES DE LECTURA Y ESCRITURA

    /*  Las propiedades proporcionan la comodidad de los miembros de datos publicos sin los riesgos que
        conllevan acceso desprotegido, no controlado y no comprobado a los datos de un objeto. Propiedades
        declara descriptores de acceso: metodos especiales que asignan y recuperan valores del miembro de
        datos subyacente. El descriptor de acceso "set" permite asignar miembros de datos y el descriptor
        de acceso "get" recupera los valores de los miembros de datos.
    
        En este ejemplo se muestra una clase Person que tiene dos propiedades: Name (string) y Age (Int)
        Ambas propiedades proporcionan "get" y descriptores de acceso "set", por lo que se consideran
        propiedades de lectura y escritura
    */

    class Person
    {
        private string _name = "N/A";
        private int _age = 0;

        // Declara la propiedad Name de tipo string:
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        // Declara la propiedad Age de tipo int:
        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                _age = value;
            }
        }
    }

    // MIEMBROS CON FORMA DE EXPRESION

    /*  Los miembros con forma de expresion proporcionan una sintaxis mas concisa para escribir descriptores
        de acceso de propiedad de una sola linea

        Nota: Los miembros con forma de expresion tambien se pueden aplicar a metodos, indexadores y descrip
        tores de acceso a eventos.

        Los descriptores de acceso de propiedad suele constar de instrucciones de una sola linea que asignan
        o devuelven el resultado de una expresion. La clase Person que ha examinado anteriormente en esta 
        unidad es un buen ejemplo:
    */

    class Student1
    {
        private string? _name;
        
        public string Name
        {
            /*get
            {
                return _name != null ? _name : "NA";
            }

            set
            {
                _name = value;
            }*/

            /*  Una definicion de cuerpo de expresion consta del token => seguido de la expresion que
                se usa para asignar o recuperar el valor de la propiedad. Dado que los descriptores de
                acceso de la case Student1 implementan una instruccion de una sola linea, es un buen
                candidato para la actualizacion mediante definiciones de cuerpo de expresion
            */

            get => _name ?? "NA";
            set => _name = value;
        }
    }

    // 5) PROPIEDADES RESPALDADAS POR CAMPOS

    /*  A partir de C# 13, puede agregar validaciones u otra logica en el descriptor de acceso para una
        propiedad mediante la caracteristica de vista previa de palabras clave "field". La palabra
        clave "field" accede al campo de respaldo sintetizado del compilador para una propiedad. Permite
        escribir un descriptor de acceso de propiedad sin declarar explicitamente un campo de respaldo
        independiente
    */

    /*public class Person2
    {   
        private 
        public string? FirstName
        {
            get;
            set => field = value.Trim();
        }

        // Ommited for brevity
    }*/

    //IMPORTANTE:

    /*  La palabra clave "field" es una caracteristica en version preliminar de C#. Debe usar .Net 9 y
        establecer el elemento <LangVersion> para obtener una vista previa en el archivo de proyecto
        para poder usar la palabra clave contextual "field"
        
        Debe tener cuidado con el uso de la caracteristica de palabra clave field en una clase que tenga
        un campo denominado field. La nueva palabra clave "field" sombrea un campo denominado "field"
        en el ambito de un descriptor de acceso de propiedad. Puede cambiar el nombre de la variable "field"
        o usar el token de "@" para hacer referencia al identificador de campo como "@field".
     */

    // PROPIEDADES NECESARIAS

    /*  En el ejemplo anterior se permite que un autor de la llamada cree un Person mediante el constructor
        predeterminado. Sin establecer la propiedad FirstName. El tipo de propiedad se establece en una
        cadena que acepta valores NULL. A partir de C# 11, puede requerir autores de llamadas establezcan
        una propiedad
    */

    public class Person3
    {
        public Person3() { }

        [SetsRequiredMembers]
        public Person3(string firstName) => FirstName = firstName;

        public required string FirstName { get; init; }
    }

    /*  El codigo anterior realiza dos cambios en la clase Person3. En primer lugar, la declaracion de
        propiedad "FirstName" incluye el modificador required. Esto significa que cualquier codigo que
        cree un nuevo Person3 debe establecer esta propiedad mediante un inicializador de objeto. En
        segundo lugar, el constructor que toma un parametro firstName tiene el atributo:
    
        "System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute" 
    
        Este atributo informa al compilador de que este constructor establece todos los miembros necesarios
        los autores de llamadas que usan este constructor no son necesarios para establecer propiedades
        "required" con un inicializador de objeto.

        // IMPORTANTE:
        
        No confunda "required" con valores que NO aceptan valores NULL. Es valido establecer una propiedad
        de required en null o default. Si el tipo no acepta valores NULL, como string en estos ejemplos,
        el compilador emite una advertencia
    */
}
