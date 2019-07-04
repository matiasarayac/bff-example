# Ejemplo de servicio BFF

# Ejecutar los servicios

```bash
$ git clone https://github.com/matiasarayac/bff-example.git
$ cd bff-example/bin/Debug/netcoreapp2.1
$ dotnet BFFExample.dll
```

# Configuracion de rutas

Es importante volver a configurar los puertos de los microservicios según donde se despliegue.  

En `Routes/AuthMS.cs` cambiar por el puerto correspondiente del microservicio de AuthMS.

```csharp
private static String url = "http://localhost:61965/";
```

En `Routes/CarsMS.cs` cambiar por el puerto correspondiente del microservicio de CarsMS.

```csharp
private static String url = "http://localhost:62828/";
```


