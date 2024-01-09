### Login

- El programa se desarrrollo en  C#  con una conexion de BBDD Sqlserver.
- El software  esta conformado con una arquitectura de 3  capas  que es conformada por C. de datos, C. Entidad , C. de Negocio ,Capa Presentacion.
- El Login fue desarrollado con  la pantilla  de  Aplicación de Windows Form.
- EL 	diseño minimalista fue hecho con un paquete NuGet llamada FontAwesome.Sharp.
-


![](https://ibb.co/yNDw9pC)





##Creacion de la Base de datos.
####Code Blocks (SqlServer)



``` SqlServer
create database DBSYSTEM_SALES

```


##Creacion de las Tablas 

####Code Blocks (SqlServer)



```SqlServer
CREATE TABLE USERS(
Id_user int primary key identity,
identification_card varchar (50),
Full_name varchar (50),
Email varchar(50),
Password_ varchar (50),
Id_rol int references ROL(Id_rol),
State_ bit,
Registration_date datetime default getdate()
)
go 

CREATE TABLE ROL (
Id_rol  int primary key identity,
Descripcion varchar(50),
Registration_date datetime default getdate()
)

```

> "	Logo de la	Empresa	", [Link](https://ibb.co/yNDw9pC)。
<p>
Espero que el programa les sea de utilidad ,bendiciones.
No	olviden que todas mienten.
</p>


###End
