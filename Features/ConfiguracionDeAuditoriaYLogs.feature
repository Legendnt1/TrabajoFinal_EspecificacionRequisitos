Feature: Configuración de Auditoría y Logs de Seguridad
  Como administrador del sistema
  Quiero revisar los logs de actividad
  Para poder identificar y analizar posibles problemas de seguridad.

  @RegistroActividad
  Scenario: Registro de actividad de usuario en los logs
    Given que un usuario realiza acciones en la plataforma
    When se detecta una acción relevante (inicio de sesión, cambio de perfil, etc.)
    Then el sistema guarda los detalles en los logs de seguridad
    And el administrador puede acceder a ellos cuando lo requiera

  @NotificacionActividadAnomala
  Scenario: Notificación de actividad anómala en los logs
    Given que el sistema detecta una actividad que coincide con patrones sospechosos
    When esta actividad se registra en los logs
    Then se genera una notificación automática para el administrador
    And se marca el registro como de "alta prioridad" para su revisión inmediata
