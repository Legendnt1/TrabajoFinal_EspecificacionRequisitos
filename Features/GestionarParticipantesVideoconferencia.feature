Feature: Gestionar Participantes Durante una Videoconferencia
  Como anfitrión de una videoconferencia
  Quiero poder gestionar la participación de los usuarios, para silenciar, expulsar o asignar permisos a los participantes
  Para así mantener el control de la reunión.

  @SilenciarParticipante
  Scenario: Silenciar a un participante
    Given que el anfitrión está gestionando una videoconferencia
    When selecciona un participante y presiona "Silenciar"
    Then el micrófono del participante se desactiva
    And el anfitrión recibe una confirmación de que el participante ha sido silenciado

  @ExpulsarParticipante
  Scenario: Expulsar a un participante
    Given que el anfitrión necesita expulsar a un participante de la videoconferencia
    When selecciona un participante y presiona "Expulsar"
    Then el participante es desconectado de la videoconferencia
    And no puede volver a unirse a la misma sesión
