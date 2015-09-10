Favor de explicar el Patron de este directorio a nuestros visitantes.
Clasificación:

Patrón Estructural.

Propósito:

Compartir   estados para  soportar  un  gran  número de  objetos  pequeños aumentando la eficiencia en espacio.

Intención:

 Reduce la redundancia cuando gran cantidad de objetos poseen idéntica información.

Motivación:

Describe cómo almacenar un  gran  número  de  objetos   sin  un   gran coste, para conseguir esto se utilizan objetos que almacenan  los estados  compartidos y que pueden   ser   usados  por   varios   objetos simultáneamente.

Aplicabilidad:

 Cuando se cumplan las siguientes características:
    Se utiliza un gran número de objetos.
    El coste de almacenamiento es alto debido a la cantidad de objetos.
    La mayoría de los estados de los objetos pueden ser creados como comunes.
    Muchos objetos pueden ser reemplazados por unos pocos una vez que han sido borrados los estados no comunes.
    La mayor parte del estado del objeto puede ser extrínseco. 
