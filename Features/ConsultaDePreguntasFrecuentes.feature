Feature: Consulta de Preguntas Frecuentes
  Como usuario
  Quiero acceder a una sección de preguntas frecuentes
  Para resolver mis dudas comunes sin necesidad de contactar al soporte.

  @AccesoPreguntasFrecuentes
  Scenario: La sección de preguntas frecuentes debe estar fácilmente accesible
    Given que el usuario está en la página principal del centro de ayuda
    When busque la sección de preguntas frecuentes
    And la seleccione
    Then debo poder ver una lista de preguntas organizadas por categorías

  @PreguntasOrganizadas
  Scenario: Las preguntas frecuentes deben estar organizadas
    Given que el usuario está en la sección de preguntas frecuentes
    When seleccione una categoría
    And visualice las preguntas
    Then debo poder acceder a la respuesta detallada de cada pregunta
