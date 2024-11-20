Feature: Implementación de Respaldo Automático de Datos
  Como usuario de la red social
  Quiero que mis datos estén respaldados de forma automática
  Para que mi información esté segura y pueda recuperarse en caso de fallos.

  @RespaldoExitoso
  Scenario: Respaldo automático exitoso
    Given que los usuarios están utilizando la plataforma
    When el sistema detecta una ventana de inactividad programada
    Then realiza un respaldo automático de la información
    And envía una notificación al administrador confirmando el respaldo

  @FalloRespaldo
  Scenario: Fallo en el respaldo automático
    Given que el sistema intenta realizar un respaldo
    When ocurre un error en el proceso de respaldo
    Then se envía una alerta inmediata al administrador
    And se registra el fallo en los logs del sistema para futuras revisiones
