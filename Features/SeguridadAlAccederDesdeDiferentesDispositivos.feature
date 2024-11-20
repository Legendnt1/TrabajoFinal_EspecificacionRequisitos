Feature: Seguridad al acceder desde diferentes dispositivos
  Como usuario,
  Quiero acceder a la plataforma de manera segura desde cualquier dispositivo,
  Para asegurarme de que mi información personal está protegida.

  @AutenticacionDosPasos
  Scenario: Autenticación en dos pasos
    Given que el usuario quiere asegurar su cuenta
    When inicia sesión desde un nuevo dispositivo
    Then se le solicita un código de verificación adicional enviado a su correo o teléfono

  @ProteccionDatos
  Scenario: Protección de datos en múltiples dispositivos
    Given que el usuario utiliza varios dispositivos
    When accede desde cualquier dispositivo
    Then su información personal debe estar encriptada durante la transmisión y el almacenamiento
