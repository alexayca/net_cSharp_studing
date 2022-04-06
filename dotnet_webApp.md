# Curso de WebApps y Logic Apps en Azure

## Crear un sitio web local
Se ignoran sincronizar con git los archivos generados para la prueba del sitio ASP.NET Azure personal test project.

Iniciando un proyecto con linea de comandos utilizando la platilla *ASP.NET Core Empty*
```dotnet new web -n "Nombre_Proyecto_WebApp"```

Utilizando la plantilla
ASP.NET Core Web App (Model-View-Controller)
```dotnet new mvc -n "Nombre_Proyecto_WebAppMVC"```

Para poner a funcionar el sitio web en local ejecutamos, para parar la ejecucion presiona ctrl+c
```
cd Nombre_Proyecto_WebApp
dotnet run
```

Para integrar el proyecto a se solia utilizar el archivo xml "Obtener perfil de publicacion" con extension *AppWebAzure*.PublishSettings en el sitio web de AppService.
En el archivo tenemos:
 - Direccion FTP publishUrl
 - nombre de usuario userName
 - password userPWD

Para facilitar la tarea se utiliza la integracion continua, en lugar de subir los archivos por FTP.
Para llevarla a cabo en Azure utilizo Deployment Center dentro del recurso AppService.
 - Configuracion, Origen. Seleccionamos el sistema de control de versiones.
 - Registros, 
 - Credenciales FTPS, 
 Configuración del flujo de trabajo
 