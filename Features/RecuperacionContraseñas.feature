Feature: Mecanismo de recuperación y restablecimiento de contraseñas
  Como usuario de la red social
  Quiero recuperar mi contraseña en caso de olvidarla
  Para poder restablecer el acceso a mi cuenta de forma segura.

  @Recuperar_Contrasena
  Scenario: Solicitar restablecimiento de contraseña
    Given que el usuario ha olvidado su contraseña
    When hace clic en el enlace "¿Olvidaste tu contraseña?" en la página de inicio de sesión
    And ingresa su "Correo Electrónico" registrado
    And presiona el botón "Enviar"
    Then el sistema verifica que el correo esté registrado
    And el sistema muestra el mensaje "Hemos enviado un enlace de restablecimiento a tu correo electrónico"
    And el sistema envía un correo con instrucciones para restablecer la contraseña

  @Restablecer_Contrasena
  Scenario: Restablecer contraseña con éxito
    Given que el usuario ha recibido el correo de restablecimiento
    When hace clic en el enlace proporcionado
    And ingresa una "Nueva Contraseña" válida en los campos "Nueva Contraseña" y "Confirmar Contraseña"
    And presiona el botón "Restablecer"
    Then el sistema muestra el mensaje "Tu contraseña ha sido actualizada exitosamente"
    And el usuario puede iniciar sesión con su nueva contraseña
