# SQLServer-Databases

En este repositorio, se encuentran las BBDD de ejemplo propiedad de Microsoft "Northwind y Pubs" con la finalidad de usarlas en cursos y tutoriales relacionados con formacion en EntityFramework y .NET

Se incluyen tanto los ficheros scripts como los ficheros MDF/LDF:

- **instSchool.sql**: contiene los scripts con la definición y carga de datos de "School Database"

- **instpubs.sql**: contiene los scripts con la definición y carga de datos de "Pubs Database"

- **instnwnd.sql**: contiene los scripts con la definición y carga de datosde "Northwind Database"

- **School.mdf y School_log.ldf**: BBDD ya preparada con los datos y logs de "School Database"  

- **Pubs.mdf y pubs_log.ldf**: BBDD ya preparada con los datos y logs de "Pubs Database"  

- **Northwind.mdf y northwind.ldf**: BBDD ya preparada con los datos y logs de "Northwind Database"  

## Archivos MDF y LDF
Cuando se crea una nueva BBDD, SQL Server crea los archivos MDF y LDF correspondientes 

- MDF es Master Database Files, el archivo de datos principal para MSSQL. 
- MDF es el archivo maestro con toda la definicion de tablas, esquema y los datos en su interior.
- MDF contiene toda la información vital y necesaria de la base de datos.

    
- LDF es Log Database Files, el archivo con las transacciones para actualizar datos.
- LDF es un archivo auxiliar y se caracteriza como un archivo de registro de transacciones del servidor.
- LDF contiene todas las acciones que incluyen transacciones y cambios realizados en el archivo MDF.


## Problemas con archivos scripts SQL en formato Unicode
Los "archivos.sql" pueden tener formato "Unicode" y dar problemas al abrirlos con SQL Management Studio.
Para solucionarlo, abrir el "archivo.sql" con Block de Notas y volverlo a guardar con formato "UTF-8".

![notepad](convertir-UTF8.jpg)
