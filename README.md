# 👀️ Repositorio todavia en construccion 👀️

# C# 🚀️

C# es un lenguaje orientado a objetos para el desarrollo de aplicaciones que corran en .NET Framework. Se puede usar para desarrollar web, mobile, aplicaciones de bases de datos, etc..

* Cualquier aplicacion de consola de C# debe tener su clase `main`, ya que es el entrypoint de la aplicacion.
* Para correr el codigo, simplemente hacemos **Ctrl + F5** (Se recomienda usar Visual Studio)
* Es fuertemente tipado.

### .NET Framework

Es un CLR (Common Language Runtime) y una libreria de clases de .NET.

* CLR maneja el codigo en tiempo de ejecucion (por ejemplo, administracion de la memoria)
* La Libreria .NET, por su parte, es una coleccion de clases, interfaces, tipos de valores, etc para trabajar.

#### Variables

* Cuando no se el tipo de variable, o quiero que el compilador lo averigue, uso la declaración `var variable = 0` el compilador sabrá por sí mismo que se trata de un int, para que esto funcione, debo sí o sí inicializarlo al momento de declararlo.

```csharp
int x = 42;
double pi = 3.14
char y = 'Z'
bool isOnline = true;
string firstName = "Dave"

 /* Identifica automaticamente que tipo de dato es, es Implicity Type Variable, 
debe ser inicializado si o si, si no, error */
var num = 15

// Constante
const double PI = 3.14;
```

#### Static

Las variables y métodos estáticos pertenecen a la clase y no a una instancia específica, se usa más que nada para que el método pueda ser accedido desde el main.
Corresponden a la clase, no importa que tantas hayan, la variable static es una sola. Es decir, tengo la clase Gato, y cada vez que la creo, quiero aumentar un contador en 1. No importa que tantas veces instancie al gato, el static mantendra su valor en sí mismo y se seguira modificando

```
class Cat {
public static int count = 0;
public Cat() {
count++; }
}
```

Puedo acceder a las variables staticas solo poniendo el nombre de la
clase, y no de la instancia, ya que es algo global de la misma

```
class Cat {
public static int count=0;

public Cat() {

count++;

}

}

static void Main(string[] args)

{

Cat c1 = new Cat();

Cat c2 = new Cat();

Console.WriteLine(Cat.count); // Devuelve 2

}
```

# MVC 🚀️

Crear un nuevo proyecto MVC desde la terminal => `dotnet new mvc`

### Model

Es el como se ve la página. Cómo se representan los datos y la lógica de negocio asociada

#### Modelos de Datos `home.cs`

* Un modelo es un conjunto de clases .net que representan a los objetos usados en un sitio web. Objetos con métodos, etc..
* Casi todas las páginas almacenan data en una base de datos, en MVC puedo programar en el modelo para que se escriben automáticamente datos en la base.
* El framework más usado es el entity framework.

### View

Es el HTML, la estructura de la página en general, interfaz de usuario

#### Vista y Razor `index.cshtml`

* La vista  es un archivo .`cshtml `o .`vbhtml`
* Generalmente expone al usuario las propiedades de una clase modelo
* Un motor de vistas interpreta el archivo, ejecuta el código del lado del servidor y general el html en el navegador, esto sería **Razor**.



### Controller

Me permite tener acciones sobre ciertos objetos, maneja la lógica de los elementos, interactúa con las solicitudes del usuario

#### Controladores y Acciones `homecontroller.cs`

* El controlador es una clase de .net que responde a las peticiones del navegador web.
* Por lo general hay una clase de controlador para cada clase modelo, estos controladores poseen acciones/métodos que responden ante una solicitud del usuario
* los controladores heredan de `System.Web.Mvc.Controller`
* Las acciones devuelven un objeto `System.Web.Mvc.ActionResult`
* Todo lo que hace el usuario es a través del controlador, como cambiar de página, etc.. `/Home (controlador)/About (acción)/...`



