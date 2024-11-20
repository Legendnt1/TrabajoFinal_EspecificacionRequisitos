Feature: Autenticación de usuario
  Como usuario registrado
  Quiero iniciar sesión utilizando mi correo electrónico y contraseña
  Para acceder a mi cuenta personal y funcionalidades exclusivas.

  @Exitoso
  Scenario: Inicio de sesión exitoso con credenciales correctas
    Given el usuario registrado desea acceder a su cuenta
    When ingresa su "Correo Electrónico" y "Contraseña" correctos
    And hace clic en el botón "Iniciar Sesión"
    Then el sistema verifica que las credenciales sean correctas
    And el usuario es redirigido a su página de perfil con acceso a su información personal

  @Fallido
  Scenario: Inicio de sesión fallido por credenciales incorrectas
    Given el usuario intenta iniciar sesión
    When ingresa un "Correo Electrónico" o "Contraseña" incorrectos
    And hace clic en el botón "Iniciar Sesión"
    Then el sistema muestra una alerta: "Correo electrónico o contraseña incorrectos, por favor intente nuevamente."