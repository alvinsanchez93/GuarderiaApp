# GuarderíaApp

**GuarderíaApp** es una aplicación de escritorio desarrollada en **WPF (Windows Presentation Foundation)** con C#. Su propósito es gestionar las operaciones diarias de una guardería, dividiendo sus funcionalidades entre administración y usuarios. 

## Funcionalidades principales

### Administración
- Gestión de alumnos: Crear, editar y eliminar registros de alumnos.
- Gestión de personal: Control del personal administrativo y docente.
- Gestión de pagos: Registro de cuotas y control de estados de pagos.

### Usuario
- Inicio de sesión seguro basado en roles.
- Navegación entre secciones mediante un panel principal.

## Tecnologías utilizadas

- **Lenguaje:** C#
- **Framework:** WPF
- **Base de datos:** SQL Server
- **Patrón de diseño:** Separación de vistas (MVVM en futuras versiones).

## Requisitos previos

1. **Visual Studio 2022 o superior** con soporte para .NET.
2. **SQL Server** para la base de datos.
3. **Clonar el repositorio**:
   ```bash
   git clone https://github.com/tu-usuario/GuarderiaApp.git
   ```

## Instalación y configuración

1. **Configurar la base de datos:**
   - Ejecuta el script `DatabaseScript.sql` en SQL Server para crear las tablas necesarias.

2. **Abrir el proyecto:**
   - Abre el archivo de solución `GuarderiaApp.sln` en Visual Studio.

3. **Configurar la conexión a la base de datos:**
   - En el archivo `App.config`, actualiza la cadena de conexión:
     ```xml
     <connectionStrings>
         <add name="DefaultConnection" connectionString="Server=TU_SERVIDOR;Database=GuarderiaDB;Trusted_Connection=True;" providerName="System.Data.SqlClient"/>
     </connectionStrings>
     ```

4. **Ejecutar la aplicación:**
   - Compila y ejecuta la solución presionando `F5`.

## Estructura del proyecto

```
GuarderiaApp
│   GuarderiaApp.sln
│
├───Views
│       LoginView.xaml
│       MainView.xaml
│
├───Styles
│       Styles.xaml
│
├───Models
│       Usuario.cs
│       Alumno.cs
│
├───Data
│       DatabaseScript.sql
│       ConnectionHelper.cs
```

## Próximos pasos
- Implementar vistas funcionales para la gestión de alumnos, personal y pagos.
- Mejorar la seguridad del inicio de sesión con encriptación de contraseñas.
- Añadir soporte para reportes y estadísticas.

## Contribuciones
¡Contribuciones son bienvenidas! Por favor, abre un issue o envía un pull request con tus mejoras.

## Licencia
Este proyecto está bajo la [Licencia MIT](LICENSE).
