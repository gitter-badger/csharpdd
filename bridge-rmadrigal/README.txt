El patrón Bridge, también conocido como Handle/Body, es una técnica usada en programación para desacoplar
 una abstracción de su implementación, de manera que ambas puedan ser modificadas independientemente sin 
necesidad de alterar por ello la otra.Esto es, se desacopla una abstracción de su implementación para que 
puedan variar independientemente.

Se usa el patrón Bridge cuando:

Se desea evitar un enlace permanente entre la abstracción y su implementación. Esto puede ser debido a que la implementación debe ser 
seleccionada o cambiada en tiempo de ejecución.
Tanto las abstracciones como sus implementaciones deben ser extensibles por medio de subclases. En este caso, el patrón Bridge permite 
combinar abstracciones e implementaciones diferentes y extenderlas independientemente.
Cambios en la implementación de una abstracción no deben impactar en los clientes, es decir, su código no debe tener que ser recompilado.
(En C++) Se desea esconder la implementación de una abstracción completamente a los clientes. En C++, la representación de una clase es 
visible en la interface de la clase.
Se desea compartir una implementación entre múltiples objetos (quizá usando contadores), y este hecho debe ser escondido a los clientes.