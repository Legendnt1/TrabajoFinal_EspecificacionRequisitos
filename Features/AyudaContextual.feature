Feature: Ayuda contextual en elementos interactivos
  Como usuario nuevo en la plataforma
  Quiero que haya instrucciones y ayudas contextuales en los elementos interactivos
  Para entender fácilmente su uso y propósito sin esfuerzo adicional.

  @AyudaBotones
  Scenario: Visualización de ayudas en los botones
    Given que el usuario está en cualquier página con botones interactivos
    When pasa el cursor sobre un botón o ícono
    Then debe aparecer una ayuda contextual breve describiendo la acción que realiza

  @AyudaFormularios
  Scenario: Textos de ayuda en formularios
    Given que el usuario completa un formulario
    When enfoca un campo de entrada
    Then debe aparecer una descripción sobre el tipo de información que debe ingresar
