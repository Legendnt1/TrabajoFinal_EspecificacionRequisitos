Feature: Creación de eventos sociales
  Como usuario de la plataforma
  Quiero crear eventos sociales e invitar amigos
  Para organizar actividades y compartir tiempo juntos.

  @EventoCreadoExitosamente
  Scenario: Evento creado exitosamente
    Given que el usuario desea crear un evento
    When completa los detalles del evento ("nombre", "fecha", "hora", "ubicación")
    Then se muestra el mensaje "Evento creado con éxito"

  @ErrorPorDatosFaltantes
  Scenario: Error por datos faltantes
    Given que el usuario no completa los campos obligatorios
    Then se muestra el mensaje "Por favor complete todos los campos obligatorios"
