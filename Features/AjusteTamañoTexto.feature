Feature: Ajuste del tamaño de texto
  Como usuario con dificultades de visión
  Quiero poder ajustar el tamaño del texto en la interfaz
  Para leer la información de manera cómoda y sin esfuerzo.

  @CambioTamanoTexto
  Scenario: Cambios en el tamaño de texto
    Given que el usuario está en la configuración de accesibilidad
    When selecciona un tamaño de texto personalizado
    Then todos los textos de la plataforma deben cambiar de tamaño acorde a la selección

  @CompatibilidadDispositivos
  Scenario: Compatibilidad en todos los dispositivos
    Given que el usuario ajusta el tamaño de texto
    When accede a la plataforma desde diferentes dispositivos
    Then el ajuste de texto debe aplicarse correctamente en todos los dispositivos
