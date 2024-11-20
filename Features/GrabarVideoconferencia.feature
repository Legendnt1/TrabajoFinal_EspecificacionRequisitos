Feature: Grabar una Videoconferencia
  Como usuario anfitrión de la red social
  Quiero poder grabar la videoconferencia completa
  Para revisarla más tarde o compartirla con los participantes que no pudieron asistir.

  @IniciarGrabacion
  Scenario: Iniciar la grabación de una videoconferencia
    Given que el usuario es el anfitrión de una videoconferencia activa
    When presiona el botón "Grabar Videoconferencia"
    Then la videoconferencia comienza a grabarse
    And aparece una notificación visible para todos los participantes indicando que la sesión está siendo grabada

  @FinalizarGrabacion
  Scenario: Finalizar la grabación de una videoconferencia
    Given que el usuario está grabando una videoconferencia activa
    When presiona el botón "Detener Grabación"
    Then la grabación se detiene
    And se guarda en el perfil del anfitrión
    And se genera un enlace para descargar o compartir el video
