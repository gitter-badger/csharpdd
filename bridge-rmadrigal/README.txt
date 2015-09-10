El patr�n Bridge, tambi�n conocido como Handle/Body, es una t�cnica usada en programaci�n para desacoplar
 una abstracci�n de su implementaci�n, de manera que ambas puedan ser modificadas independientemente sin 
necesidad de alterar por ello la otra.Esto es, se desacopla una abstracci�n de su implementaci�n para que 
puedan variar independientemente.

Se usa el patr�n Bridge cuando:

Se desea evitar un enlace permanente entre la abstracci�n y su implementaci�n. Esto puede ser debido a que la implementaci�n debe ser 
seleccionada o cambiada en tiempo de ejecuci�n.
Tanto las abstracciones como sus implementaciones deben ser extensibles por medio de subclases. En este caso, el patr�n Bridge permite 
combinar abstracciones e implementaciones diferentes y extenderlas independientemente.
Cambios en la implementaci�n de una abstracci�n no deben impactar en los clientes, es decir, su c�digo no debe tener que ser recompilado.
(En C++) Se desea esconder la implementaci�n de una abstracci�n completamente a los clientes. En C++, la representaci�n de una clase es 
visible en la interface de la clase.
Se desea compartir una implementaci�n entre m�ltiples objetos (quiz� usando contadores), y este hecho debe ser escondido a los clientes.