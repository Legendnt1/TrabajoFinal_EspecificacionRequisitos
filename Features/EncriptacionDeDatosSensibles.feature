Feature: Encriptación de Datos Sensibles de Usuario
  Como usuario de la red social
  Quiero que mis datos personales estén encriptados
  Para que solo el sistema tenga acceso a ellos y se protejan en caso de un ataque.

  @EncriptacionExitosa
  Scenario: Encriptación exitosa de datos sensibles
    Given que el usuario proporciona datos como su correo electrónico y contraseña
    When el sistema almacena esta información
    Then se encripta antes de ser guardada en la base de datos
    And cumple con los estándares de seguridad establecidos

  @EncriptacionAlRecuperar
  Scenario: Encriptación de datos al ser recuperados
    Given que el sistema necesita recuperar datos sensibles del usuario
    When se accede a estos datos
    Then el sistema asegura que la información se desencripte solo temporalmente para su uso
    And no se almacena en texto claro en ninguna parte del sistema
