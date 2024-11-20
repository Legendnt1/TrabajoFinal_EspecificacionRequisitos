Feature: Acceso a la plataforma desde diferentes dispositivos
  Como usuario de la red social,
  Quiero acceder a la plataforma desde mi laptop y mi teléfono móvil,
  Para poder seguir participando en las actividades sin importar el dispositivo que utilice.

  @SincronizacionDispositivos
  Scenario: El usuario accede desde múltiples dispositivos
    Given que el usuario registrado quiere usar la plataforma desde diferentes dispositivos
    When el usuario inicia sesión desde su laptop
    And luego intenta acceder desde su móvil sin cerrar la sesión en la laptop
    Then la sesión en ambos dispositivos está sincronizada y el usuario puede continuar con las mismas actividades

  @AdaptacionInterfaz
  Scenario: El usuario tiene una experiencia consistente en diferentes dispositivos
    Given que el usuario registrado inicia sesión en la plataforma desde su laptop
    When cambia a su teléfono móvil
    Then la interfaz de usuario debe adaptarse automáticamente al tamaño de pantalla y las funcionalidades deben estar intactas
