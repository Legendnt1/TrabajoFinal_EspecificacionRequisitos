Feature: Configuración de Alertas de Actividad Sospechosa
  Como usuario de la red social
  Quiero recibir alertas cuando se detecten actividades inusuales en mi cuenta
  Para que pueda tomar acciones y proteger mi información.

  @IntentoDeAccesoNoReconocido
  Scenario: Alerta por intento de acceso desde un dispositivo no reconocido
    Given que un usuario intenta iniciar sesión desde un dispositivo no registrado
    When el sistema detecta el dispositivo como nuevo
    Then se envía una alerta al correo del usuario
    And se le solicita confirmar la actividad

  @IntentosFallidosDeInicio
  Scenario: Alerta por múltiples intentos fallidos de inicio de sesión
    Given que se realizan varios intentos fallidos de inicio de sesión en una cuenta
    When el número de intentos fallidos alcanza el límite preestablecido
    Then el sistema bloquea temporalmente el acceso
    And se envía una alerta al usuario para informarle del bloqueo
