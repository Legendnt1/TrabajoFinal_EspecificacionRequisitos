Feature: Seguimiento de Tickets de Soporte
  Como usuario,
  Quiero poder ver el estado de las solicitudes de soporte
  Para saber cuándo se resolverán los problemas.

  @VisualizacionDeTickets
  Scenario: Los usuarios deben poder acceder a un panel donde puedan ver todos sus tickets de soporte y su estado actual
    Given que el usuario está en mi panel de usuario
    When acceda a la sección de tickets de soporte
    And visualice mis solicitudes
    Then debe poder ver el estado actual de cada ticket

  @NotificacionDeActualizaciones
  Scenario: El sistema debe enviar notificaciones automáticas por correo electrónico cuando haya actualizaciones en el estado del ticket
    Given que el usuario tiene una actualización en el estado de mi ticket
    When revise su correo
    And encuentre una notificación
    Then la notificación debe incluir detalles sobre el nuevo estado y cualquier acción requerida de mi parte
