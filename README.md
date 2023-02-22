# Aprendiendo CSharp

Está solución contiene una gran diversidad de proyectos realizados con CSharp con la finalidad
de aprender del lenguaje y su framework .NET.

En este archivo se podrá encontrar la documentación de cada uno de los temas vistos en clases de la plataforma
Platzi para ser un desarrollador .NET.

## Proyecto ToDo

Un proyecto de consola realizado con la finalidad de guardar en memoria en tiempo de ejecución el listado
de tareas pendientes registradas por el usuario. De igual forma tiene su lógica para visualizar, actualizar
y eliminar las tareas.

### Temas vistos en el proyecto ToDo.

¿Qué es Code Smells?

> "Code smells" es un término utilizado en programación para referirse a señales o indicios de que existe un problema o deficiencia en el diseño o implementación del código fuente. Los "code smells" no son errores en sí mismos, sino que son signos de que algo podría estar mal y podrían conducir a problemas en el futuro. Los "code smells" pueden ser detectados por los programadores, herramientas de análisis de código estático y otros medios. Ejemplos comunes de "code smells" incluyen: Duplicación de código. Código largo y complejo. Código repetitivo. Código mal estructurado o difícil de entender. Falta de pruebas unitarias. La identificación temprana de los "code smells" es importante ya que puede ayudar a los desarrolladores a mejorar la calidad del código, reducir la cantidad de errores y facilitar el mantenimiento del software. Además, corregir los "code smells" puede hacer que el código sea más legible y fácil de entender, lo que puede ahorrar tiempo y esfuerzo en el futuro.

¿Qué es el principio DRY?

> El principio DRY (Don't Repeat Yourself) es un principio de diseño de software que enfatiza la importancia de evitar la repetición innecesaria de código en un sistema de software. Según el principio DRY, cada pieza de conocimiento en un sistema debe tener una única representación autoritativa, lo que significa que el código debe ser modular y reutilizable, y que no debería haber duplicación de funcionalidad o lógica. El principio DRY ayuda a mantener el código limpio, conciso y fácil de mantener. Al seguir el principio DRY, los desarrolladores pueden reducir el acoplamiento entre los diferentes componentes del sistema, lo que facilita la comprensión del código y reduce la probabilidad de errores. Además, el principio DRY puede ayudar a los desarrolladores a ahorrar tiempo y esfuerzo al reducir la cantidad de código que necesitan escribir y mantener. En lugar de escribir el mismo código repetidamente en diferentes partes del sistema, los desarrolladores pueden escribirlo una vez y reutilizarlo en múltiples lugares. En resumen, el principio DRY es una buena práctica de diseño de software que ayuda a los desarrolladores a escribir código más limpio, conciso y fácil de mantener.

¿Qué es el principio KISS?

> El principio KISS (Keep It Simple, Stupid) es un principio de diseño de software que enfatiza la importancia de mantener las cosas simples y fáciles de entender. Según el principio KISS, las soluciones simples suelen ser mejores que las complejas y que, por lo tanto, los desarrolladores deben buscar la simplicidad en el diseño de sus sistemas de software. El principio KISS puede ayudar a los desarrolladores a evitar la sobrecarga de funcionalidades y características innecesarias en el software. Al mantener las cosas simples, los desarrolladores pueden reducir la complejidad del software y facilitar su comprensión y mantenimiento. Esto puede conducir a sistemas más fáciles de usar, más confiables y con menos errores. Sin embargo, el principio KISS no significa que el software deba ser simplista o que deba faltar funcionalidad. En lugar de eso, se trata de encontrar el equilibrio adecuado entre la simplicidad y la funcionalidad. Los desarrolladores deben esforzarse por encontrar soluciones simples y elegantes que satisfagan las necesidades de los usuarios y del negocio. En resumen, el principio KISS es una buena práctica de diseño de software que enfatiza la importancia de mantener las cosas simples y fáciles de entender. Al seguir este principio, los desarrolladores pueden mejorar la calidad del software, reducir la complejidad y facilitar su comprensión y mantenimiento.


## Proyecto PrincipioSOLID

Un poryecto de consola realizado con la finalidad de poner en práctica los principios SOLID
en varios casos de uso. En este archivo se podrá encontrar de manera bien documentada cada una de las partes que conforma la palabra SOLID y un caso de uso.

### Temas vistos en el proyecto SOLID.

Los principios S.O.L.I.D nos indican cómo organizar nuestras funciones y estructuras de datos
en componentes y cómo dichos componentes deben ser interconectados.

La palabra S.O.L.I.D. significa lo siguiente:

S <strong>Single Responsability -  SRP</strong> (Responsabilidad única)

O <strong>Open and Close -  OCP</strong> (Abierto & cerrado)

L <strong>Liskov substitution - LSP</strong> (Sustitución de Liskov)

I <strong>Interface segregation - ISP</strong> (Segregación de interfaz)

D <strong>Dependency version - DIP</strong> (Inversión de dependencias)

¿Qué significa SRP?

> Tener una única responsabilidad no es igual a hacer una única cosa para las clases. Debemos evitar en todo momento crear una lógica incoherente que le corresponda a la clase que estamos desarrollando.

¿Qué significa OCP?

> Establece que las entidades de software (clases, módulos, métodos, etc.) deben estar abiertas para la extensión, pero cerradas para la modificación. El principio de abierto/cerrado también se puede lograr de muchas otras maneras, incluso el uso de la herencia o mediante patrones de diseño de composición como el patrón de estrategia.

¿Qué significa LSP?

> El principio de sustitución de Liskov establece que una clase derivada debe poder ser utilizada en lugar de su clase base sin alterar el comportamiento deseado del programa. Esto significa que cualquier función que trabaje con objetos de la clase base a través de punteros o referencias, debería poder trabajar con objetos de las clases derivadas sin conocer su identidad específica. En otras palabras, los objetos de las clases derivadas deben ser compatibles con las funciones que trabajan con objetos de la clase base, sin generar comportamientos no deseados o errores en el tiempo de ejecución. Este principio es fundamental en la programación orientada a objetos para garantizar la coherencia y fiabilidad de los programas y facilitar su mantenimiento y extensión en el tiempo.

¿Qué es ISP?

> Es un principio que está estrictamente familiarizado con el principio de responsabilidad única y el principio Liskov. Mantener las interfaces simples y sencillas, ayuda a respetar este principio.

¿Qué es DIP?

> Este principio establece que los módulos de alto nivel no deben depender de módulos de bajo nivel, sino que ambos deben depender de abstracciones. Además, las abstracciones no deben depender de detalles, sino que los detalles deben depender de las abstracciones. En resumen, este principio sugiere que la dependencia debe establecerse en términos de abstracciones y no en términos de detalles concretos.