# FarmaciaApp

FarmaciaApp es una aplicación integral diseñada para gestionar las operaciones de una farmacia. Este proyecto está estructurado en múltiples capas, incluyendo la Capa de Lógica de Negocio (BLL), la Capa de Datos, Servicios Compartidos y una API Web.

## Empezando

### Requisitos Previos

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) o [Visual Studio Code](https://code.visualstudio.com/)

### Instalación

1. Clona el repositorio:
    ```sh
    git clone https://github.com/yourusername/FarmaciaApp.git
    cd FarmaciaApp
    ```

2. Restaura las dependencias:
    ```sh
    dotnet restore
    ```

### Compilando el Proyecto

Para compilar el proyecto, ejecuta el siguiente comando en el directorio raíz:
```sh
dotnet build
```
### Ejecutando la Aplicación

Para ejecutar la aplicación, navega al directorio de FarmaciaApp y usa el siguiente comando:

```sh
dotnet run
```
## Capas del Proyecto

BLL (Business Logic Layer): Contiene la lógica de negocio de la aplicación.
DataLayer: Gestiona el acceso y almacenamiento de datos.
FarmaciaApp: El proyecto principal de la aplicación que contiene la interfaz de usuario y la lógica principal.
Shared: Contiene modelos y servicios compartidos usados en diferentes capas.
WebAPI: Proporciona los endpoints de la API para la aplicación.

---
## License

FarmaciaApp © 2024 by Herberth Andrés Alfaro Vega is licensed under [CC BY-NC 4.0](https://creativecommons.org/licenses/by-nc/4.0/).

