Feature: Desarrollo de Control de Acceso Basado en Roles
  Como administrador de la red social
  Quiero definir permisos específicos para cada rol
  Para que cada usuario solo acceda a la información y herramientas permitidas.

  @AccesoPermitido
  Scenario: Acceso permitido según rol
    Given que un usuario intenta acceder a una sección protegida
    When el sistema valida su rol
    Then se le concede acceso si tiene los permisos necesarios
    And se registra el acceso en los logs de seguridad

  @AccesoDenegado
  Scenario: Acceso denegado por rol no autorizado
    Given que un usuario intenta acceder a una sección sin permisos adecuados
    When el sistema verifica su rol y encuentra que no es autorizado
    Then se le muestra un mensaje de "Acceso denegado"
    And se registra el intento en los logs de seguridad
