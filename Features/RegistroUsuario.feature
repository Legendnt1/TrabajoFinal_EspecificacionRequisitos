Feature: Registro de usuario
  Como nuevo usuario
  Quiero registrarme en la plataforma
  Para poder acceder a las funcionalidades de la red social.

  @Registro_Exitoso
  Scenario: Registro exitoso con información válida
    Given que el usuario desea registrarse en la plataforma
    When llena los campos obligatorios "Nombre", "Correo Electrónico", "Contraseña" y "Número de Teléfono" con información válida
    And hace clic en el botón "Listo"
    Then el sistema verifica que todos los datos ingresados en los campos sean válidos
    And el sistema muestra el mensaje "Registro exitoso, por favor verifica tu correo electrónico"
    And el sistema envía un correo de verificación al usuario

  @Registro_Fallido
  Scenario: Registro fallido por información incompleta o inválida
    Given que el usuario intenta registrarse con datos incompletos o inválidos
    When no llena todos los campos obligatorios o ingresa información incorrecta
    And hace clic en el botón "Listo"
    Then el sistema muestra una alerta "Por favor complete todos los campos obligatorios con información válida"
