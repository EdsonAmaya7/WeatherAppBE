# Proyecto .NET 7

## Requisitos

Antes de ejecutar este proyecto, asegúrate de tener instalados los siguientes requisitos:

1. **SDK de .NET 7**

   - Descarga e instala desde: [https://dotnet.microsoft.com/en-us/download/dotnet/7.0](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)
   - Verifica la instalación ejecutando:
     ```sh
     dotnet --version
     ```

2. **Editor de código o IDE** (Opcional pero recomendado)

   - [Visual Studio 2022](https://visualstudio.microsoft.com/) (Seleccionar ".NET y desarrollo web" en la instalación)
   - [Visual Studio Code](https://code.visualstudio.com/) (Instalar la extensión C#)

3. **Git** (Si vas a clonar un repositorio)

   - Descarga e instala desde: [https://git-scm.com/](https://git-scm.com/)
   - Verifica la instalación ejecutando:
     ```sh
     git --version
     ```

## Instalación

### 1. Clonar el proyecto

Si el proyecto está en un repositorio Git, clónalo con:

```sh
git clone <URL-del-repositorio>
cd <nombre-del-proyecto>
```

### 2. Restaurar dependencias

Ejecuta el siguiente comando para restaurar las dependencias del proyecto:

```sh
dotnet restore
```

### 3. Configurar la base de datos (si aplica)

Si el proyecto usa Entity Framework Core y requiere migraciones, ejecuta:

```sh
dotnet ef database update
```

Si no tienes la herramienta EF instalada, agrégala con:

```sh
dotnet tool install --global dotnet-ef
```

## Ejecución

### 1. Compilar el proyecto

```sh
dotnet build
```

### 2. Ejecutar el proyecto

```sh
dotnet run
```

Por defecto, la aplicación estará disponible en `https://localhost:5001` o `http://localhost:5000`.

## Depuración

Si usas **Visual Studio Code**:

1. Instala la extensión **C# (Omnisharp)**.
2. Abre la carpeta del proyecto y presiona `F5` para iniciar la depuración.

Si usas **Visual Studio**:

1. Abre el archivo `.sln`.
2. Presiona `F5` o selecciona `Ejecutar` → `Iniciar depuración`.

## Comandos adicionales

### Publicar el proyecto

```sh
dotnet publish -c Release -o ./publish
```

### Ejecutar pruebas unitarias

```sh
dotnet test
```

## Contribución

Si deseas contribuir al proyecto, por favor sigue estos pasos:

1. Realiza un fork del repositorio.
2. Crea una nueva rama (`git checkout -b feature/nueva-feature`).
3. Realiza tus cambios y haz un commit (`git commit -m "Descripción del cambio"`).
4. Envía los cambios al repositorio (`git push origin feature/nueva-feature`).
5. Abre un Pull Request.

---

¡Listo! Ahora puedes ejecutar y desarrollar sobre este proyecto en .NET 7 🚀.

