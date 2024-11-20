Feature: Navegación con teclado mejorada
  Como usuario con discapacidad motora
  Quiero poder navegar por toda la plataforma usando solo el teclado
  Para no depender de un mouse o pantalla táctil.

  @NavegacionGeneral
  Scenario: Navegación general de la interfaz
    Given que el usuario está en cualquier página de la plataforma
    When utiliza las teclas de navegación del teclado
    And presiona "Tab" para moverse entre elementos interactivos
    Then todos los elementos de la interfaz deben poder seleccionarse secuencialmente

  @NavegacionRapida
  Scenario: Saltos de navegación rápida
    Given que el usuario está en la página principal
    When presiona "Shift + Tab" en combinación con la tecla de flechas
    Then debe poder saltar a secciones principales (menú, contenido principal, pie de página) sin dificultad
