TP6
¿String es una tipo por valor o un tipo por referencia?
Son el mismo tipo. En realidad, de todas maneras String no es un tipo por valor, pero es aceptado como si lo fuera. Por eso tiene un alias en ambos casos, pero en realidad es siempre el mismo tipo por referencia.


¿Qué secuencias de escape tiene el tipo string?
\a: campana.
\b: retroceso. Produce el mismo efecto que pulsar la tecla de Retroceso destructivo.
\c: comilla. Provoca la introducción de una comilla.
\f: salto de página. ...
\n: nueva línea. ...
\r: retorno de carro. ...
\t: tabulador. ...
\v: tabulador Vertical.


¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
En C#, el carácter "@" antes de una cadena de texto se utiliza para crear una cadena de texto literal. Esto significa que el texto dentro de la cadena será interpretado literalmente, lo que incluye mantener los caracteres de escape sin interpretar.
Por otro lado, el carácter "$" antes de una cadena de texto indica que se trata de una cadena interpolada. Las cadenas interpoladas permiten incrustar expresiones dentro de la cadena utilizando la sintaxis "${}".