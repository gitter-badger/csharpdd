Abstract Factory
El patrón Abstract Factory nos permite crear, mediante una interfaz, conjuntos o familias de objetos (denominados productos) que dependen mutuamuente y todo esto sin especificar cual es el objeto concreto.

¿Que usos tiene el patrón Abstract Factory?
Este patrón se puede aplicar cuando:

Un sistema debe ser independiente de como sus objetos son creados.
Un sistema debe ser 'configurado' con una cierta familia de productos.
Se necesita reforzar la noción de dependencia mutua entre ciertos objetos.

Elementos del Patrón Abstract Factory

FabricaAbstracta*: Define un conjunto de métodos (interfaz) para la creación de productos abstractos.
FabricaConcreta1/2: Implementa la interfaz de la FabricaAbstracta para la creación de los distintos productos concretos.
ProductoAbstractoA*/B*: Define la interfaz de los objetos de tipo ProductoA/B.
ProductoConcretoA1/A2/B1/B2: Implementan su respectiva interfaz representando un producto concreto.

Pros/Contras del Patrón Abstract Factory
+ Brinda flexibilidad al aislar a las clases concretas.
+ Facilita cambiar las familias de productos.
- Para agregar nuevos productos se deben modificar tanto las fabricas abstractas como las concretas.
