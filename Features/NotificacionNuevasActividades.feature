Feature: Notificación de nuevas actividades
  Como usuario
  Quiero estar siempre al tanto de nuevas actividades que se vayan a realizar
  Para no perderme eventos importantes.

  @NotificacionExitosa
  Scenario: Notificación exitosa
    Given que el usuario desea estar al tanto
    When se organice una nueva actividad
    Then se le enviará una notificación a su celular y a su correo

  @NotificacionFallida
  Scenario: Notificación fallida
    Given que el sistema se ha caído
    Then no se ha logrado enviar la notificación de un nuevo evento
