Feature: Aceptación y rechazo de solicitudes de amistad
  Como usuario
  Quiero aceptar o rechazar solicitudes de amistad
  Para decidir con quién quiero conectarme en la plataforma.

  @Solicitud_Aceptada
  Scenario: Solicitud aceptada exitosamente
    Given que el usuario recibe una solicitud de amistad
    When hace clic en "Aceptar"
    Then se muestra el mensaje "Ahora son amigos"

  @Solicitud_Rechazada
  Scenario: Solicitud rechazada
    Given que el usuario no desea aceptar la solicitud
    When hace clic en "Rechazar"
    Then se elimina la solicitud y se muestra el mensaje "Solicitud rechazada"
