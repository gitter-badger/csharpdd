Patrón de diseño Factory Method,

El patrón de diseño Factory Method se define como una interfaz para la creación de cierto tipo de objeto, permitiendo que las subclases decidan que clase concreta necesitan instanciar.

El objetivo de este patrón es proveer un método abstracto de creación de un objeto delegando en las subclases concretas su creación efectiva. Es importante que en el programa exista cierta flexilibidad, ya que es lo que permite que esta cree el tipo de objeto, de esta manera los objetos pueden ser extendidos en subclases. Al momento de usar Factory Method, el cliente delega responsabilidades a las subclases en jerarquias paralelas.

