Feature: Enviar Mensajes de Texto Durante una Videoconferencia
  Como usuario de la red social
  Quiero poder enviar y recibir mensajes de texto durante una videoconferencia
  Para comunicarme sin interrumpir el audio o video de la llamada.

  @EnviarMensaje
  Scenario: Enviar un mensaje de texto durante la videoconferencia
    Given que el usuario está participando en una videoconferencia activa
    When presiona el botón "Chat" en la interfaz de la videoconferencia
    And escribe un mensaje en el campo de texto
    Then el mensaje aparece en el chat visible para todos los participantes sin interrumpir la videollamada

  @RecibirNotificacion
  Scenario: Recibir notificaciones de nuevos mensajes durante la videoconferencia
    Given que el usuario está participando en una videoconferencia
    When otro participante envía un mensaje de texto en el chat
    Then el usuario ve una notificación visual en la pantalla sin que se interrumpa el flujo de la videollamada
