Feature: Iniciar y Finalizar una Videoconferencia
  Como usuario de la red social
  Quiero poder iniciar y finalizar videoconferencias
  Para organizar reuniones o eventos en los que otros usuarios puedan unirse y participar.

  @IniciarVideoconferencia
  Scenario: Iniciar una videoconferencia con éxito
    Given que el usuario desea crear una videoconferencia
    When navega a "Videoconferencias" y presiona el botón "Crear Videoconferencia"
    And completa los detalles como nombre de la sala y participantes invitados
    Then la videoconferencia se inicia y los otros usuarios pueden unirse

  @FinalizarVideoconferencia
  Scenario: Finalizar una videoconferencia
    Given que el usuario es el anfitrión de una videoconferencia activa
    When presiona el botón "Finalizar Videoconferencia"
    Then todos los participantes son desconectados y la sesión de videoconferencia se cierra
