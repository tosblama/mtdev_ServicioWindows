# CREACIÓN DE UN SERVICIO DE WINDOWS EN VISUAL STUDIO

Se deben seguir los siguientes pasos:

* Crear proyecto en VisualStudio de tipo "Servicio de Windows"
* Arrastrar el objeto eventlog al diseñador y ponerle nombre
* Pulsar a "cambiar a vista de codigo"
* Cambiar nombre al servicio
* En Program.cs comprobar como se inicializará el servicio
* Quitar y ordenar usos
* Configurar y utilizar el eventLog
* Desarrollar las acciones a realizar en el servicio (en este ejemplo, un timer)
* En diseñador, boton derecho añadir instalador
* Verificar que la propiedad del instalador ServiceName tenga el mismo nombre que el servicio a instalar
* Doble click en ServiceInstallar para indicar como va a arrancar el servicio
* Compila genera un exe


## INSTALAR/DESINSTALAR SERVICIO

Ejecutar `cmd` como Administrador

### INSTALAR SERVICIO
`C:\Windows\Microsoft.NET\Framework64\v4.0.30319\installutil C:\Servicios\MTDEV_0019_ServicioWindows.exe`

### DESINSTALAR SERVICIO
`C:\Windows\Microsoft.NET\Framework64\v4.0.30319\installutil /u C:\Servicios\MTDEV_0019_ServicioWindows.exe`

Se pueden ver los servicios ejecutando services.msc, y los eventos en el visor de eventos, dentro del apartado Registros de windows - Aplicación.
