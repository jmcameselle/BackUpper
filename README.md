# BackUpper
Aplicación de escritorio para facilitar la creación de copias de seguridad en los procesos de actualización de Bugs/Features en versiones de producción de aplicaciones web.

##Objetivo
Cuando tienes que subir a producción el resultado de el arreglo de un bug, o el del desarrollo de alguna nueva característica, es conveniente realizar una copia de los archivos que se van a sobreescribir por si algo falla y tenemos que revertir rápidamente los cambios. Por mucho que se prueben los cambios a realizar en entornos de pre-producción, se pasen tests unitarios o cualquier tipo de pruebas, es una buena práctica tener estas copias de respaldo. Siempre pueden pasar desapercibidos errores que sólo se descubren en entornos de producción. 

Este proceso, cuando son pocos archivos, se hace rápidamente de modo manual. Pero cuando la resolución del bug o feature en cuestión implica actualizar muchos archivos, y éstos están alojados en estructuras de carpetas de muchos niveles, puede ser muy tedioso de realizar a mano.

Con esta pequeña aplicación podremos generar rápidamente estas copias de archivos de modo que podremos revertir rápidamente al estado anterior a la actualización si lo necesitamos.


##Manejo
  
Al ejecutar la aplicación nos aparecerá un pequeño formulario con tres botones habilitados. Cada uno de ellos lanzará el selector de carpetas de nuestro equipo. El cometido de cada una de estas carpetas es el siguiente:

- **Origen**: En esta ubicación deberemos seleccionar la raíz de la carpeta con los archivos de **producción**. Es decir, aquí escogeremos la raíz de la estructura de la que se copiarán los archivos para realizar la copia de respaldo. La carpeta de la aplicación a actualizar en el servidor.
- **Patrón**: Esta ubicación corresponde con la estructura que vamos a subir a producción. Es la estructura exportada de nuestra herramienta de control de código con la que hemos registrado los cambios en la resolución del Bug o de la Feature.
- **Destino**: Ubicación en la que deseamos alojar la copia de respaldo.

La aplicación lo que hará es ir procesando recursivamente las carpetas encontradas a partir de la ubicación **Patrón** e ir comparando los nombres de los archivos que se encuentren en la misma ubicación relativa en el **Origen**. Si encuentra un archivo coincidente en **Origen** lo copia en destino. 

Si cuando se va a realizar la copia del archivo en **Destino** aún no se encuentra allí la carpeta correspondiente a la ubicación relativa del mismo la crea. Para que se cree una carpeta en **Destino** debe existir al menos una coincidencia de archivos entre patrón y destino

###Nota
No se permite seleccionar orígenes idénticos en más de una ubicación. No tendría sentido hacerlo.

##Información

Se trata de un proyecto de Windows Form Apliccation, escrito en C# con Microsoft Visual Studio Community 2013

Version 12.0.31101.00 Update 4
Microsoft .NET Framework
Version 4.6.00079