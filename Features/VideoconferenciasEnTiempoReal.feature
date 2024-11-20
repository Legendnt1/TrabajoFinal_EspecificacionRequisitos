Feature: Acceso y Uso de Videoconferencias en Tiempo Real
  Como usuario de la red social
  Quiero poder unirme y participar en videoconferencias en tiempo real
  Para interactuar con otros usuarios de manera visual y mejorar la comunicación en reuniones, talleres o actividades grupales.

  @UnirseAVideoconferencia
  Scenario: Unirse a una videoconferencia con éxito
    Given que el usuario desea unirse a una videoconferencia activa
    When navega a "Videoconferencias" y selecciona una sala activa
    And presiona el botón "Unirse a la Videoconferencia"
    Then la videoconferencia se carga y el usuario puede ver y escuchar a los otros participantes en tiempo real
    And el usuario puede activar o desactivar su cámara y micrófono durante la sesión

  @AyudaFormularios
  Scenario: Textos de ayuda en formularios
    Given que el usuario completa un formulario
    When enfoca un campo de entrada
    Then debe aparecer una descripción sobre el tipo de información que debe ingresar
