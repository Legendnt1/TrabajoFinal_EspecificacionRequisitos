Feature: Acceso a Tutoriales y Guías
  Como usuario
  Quiero acceder a tutoriales y guías que me enseñen a utilizar las funciones de la plataforma
  Para maximizar mi experiencia.

  @BusquedaDeTutoriales
  Scenario: Los tutoriales y guías deben estar organizados por temas y ser fáciles de buscar
    Given que el usuario está en la sección de tutoriales
    When busque un tema específico
    And utilice la función de búsqueda
    Then debe encontrar resultados relevantes que se ajusten a mi búsqueda

  @VisualizacionDeTutoriales
  Scenario: Cada tutorial debe incluir un video o una serie de imágenes que ilustren los pasos a seguir
    Given que el usuario ha seleccionado un tutorial
    When lo visualice
    And siga las instrucciones
    Then debe ser capaz de completar el proceso descrito sin confusiones
