Feature: Notificaciones de usuarios cercanos
  Como usuario
  Quiero saber que otros usuarios con gustos similares viven cerca de mí
  Para conectarme con personas afines en mi comunidad.

  @NotificacionExitosa
  Scenario: Notificación exitosa
    Given que el usuario desea estar al tanto de otros usuarios cercanos a él
    When uno nuevo se una a la app
    Then se le enviará una notificación a su celular

  @NotificacionFallida
  Scenario: Notificación fallida
    Given que el usuario tiene las notificaciones bloqueadas
    Then no se ha logrado enviar la notificación de un nuevo usuario
