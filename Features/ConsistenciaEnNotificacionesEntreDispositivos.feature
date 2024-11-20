Feature: Consistencia en las notificaciones entre dispositivos
  Como usuario,
  Quiero recibir notificaciones consistentes en todos mis dispositivos,
  Para estar al tanto de las actividades y eventos sin importar el dispositivo que esté usando.

  @NotificacionesConsistentes
  Scenario: Recepción de notificaciones en todos los dispositivos
    Given que el usuario está registrado en la plataforma
    When se envía una notificación de un nuevo evento o mensaje
    Then la notificación debe aparecer en todos los dispositivos en los que el usuario haya iniciado sesión

  @SincronizacionNotificaciones
  Scenario: Sincronización de notificaciones leídas
    Given que el usuario ha leído una notificación en su teléfono
    When accede a la plataforma desde su computadora
    Then la notificación debe aparecer como leída en ambos dispositivos
