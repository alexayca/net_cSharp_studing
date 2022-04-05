## Powershell
Con la consola podemos ejecutar muchas herramientas para desarrollo

```dotnet```
Verificamos si esta instalada la herramienta

```dotnet new```
Indica las diferentes variantes de software que podemos desarrollar

```dotnet new console```
```dotnet new console --output DesdeConsolaPS```
Crea una nueva aplicacion de consola, y crea varios archivos, entre ellos ```*.csproj``` que se refierea csharp project

```dotnet run```
```dotnet run --project DesdeConsolaPS```
Para ejecutar un programa en la carpeta actual con extension .cs, se autocompila

```dotnet build```
Compila el programa, generando el ejecutable nativo de netcore y varias carpetas, ```bin\Debug\framework``` con archivos ```*.dll``` que es el ejecutable. Para ejecutarlo escribimos:
```dotnet .\ejecutable.dll```

Ejecutables optimizados para determinado OS
```dotnet build -c Release -r win10-x64```
    *-c* codigo de produccion o de depuracion
        *Release* codigo de produccion
        *Debug* codigo de depuracion
    *-r* sistema operativo objetivo
        win7-x64
        win10-x64
        osx.10.11-x64
        ubuntu.16.04-x64


