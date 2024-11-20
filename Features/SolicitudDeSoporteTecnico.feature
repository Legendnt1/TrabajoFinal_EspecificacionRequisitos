Feature: Solicitud de Soporte Técnico
  Como usuario
  Quiero poder enviar una solicitud de soporte técnico
  Para resolver problemas específicos que no puedo solucionar por mi cuenta.

  @FormularioSoporte
  Scenario: El usuario ingresa un formulario para solicitar soporte técnico
    Given que el usuario está en el formulario de solicitud de soporte
    When completa todos los campos requeridos y envía el formulario
    And elige la prioridad
    Then debe recibir una confirmación por correo electrónico con un número de ticket

  @ConfirmacionSoporte
  Scenario: Después de enviar la solicitud, el usuario debe recibir una confirmación por correo electrónico
    Given que ha enviado una solicitud de soporte
    When revise mi correo
    And busque el mensaje de confirmación
    Then debe encontrar el tiempo estimado de respuesta incluido en el correo
