Feature: Envío de solicitudes de amistad
  Como usuario de la plataforma
  Quiero enviar solicitudes de amistad a otros miembros
  Para poder conectarme con ellos y ver sus publicaciones.

  @Solicitud_Exitosa
  Scenario: Envío exitoso de solicitud
    Given que el usuario desea agregar a otra persona como amigo
    When selecciona "Agregar Amigo" en el perfil del otro usuario
    Then se muestra el mensaje "Solicitud de amistad enviada exitosamente"

  @Error_Enviar_Solicitud
  Scenario: Error al enviar la solicitud
    Given que ya existe una solicitud pendiente o el usuario está bloqueado
    Then se muestra el mensaje "No se puede enviar la solicitud en este momento"
