Feature: Compatibilidad con dispositivos antiguos
  Como usuario,
  Quiero que la plataforma funcione en mi dispositivo antiguo,
  Para poder participar en actividades sin necesidad de comprar un dispositivo nuevo.

  @CompatibilidadDispositivosAntiguos
  Scenario: La plataforma es compatible con dispositivos antiguos
    Given que el usuario tiene un dispositivo antiguo
    When accede a la plataforma desde su dispositivo
    Then el sistema se carga correctamente y las funcionalidades clave están disponibles

  @InternetBasico
  Scenario: La plataforma funciona con conexiones de internet básicas
    Given que el usuario tiene una conexión de internet limitada
    When accede a la plataforma y participa en videollamadas
    Then la plataforma debe ajustarse automáticamente para no consumir demasiados datos y ofrecer una experiencia fluida
