Feature: Sincronización de actividades entre dispositivos
  Como usuario,
  Quiero que las actividades que realizo en la plataforma, como la participación en talleres o videollamadas,
  Se sincronicen automáticamente entre mis dispositivos para continuar sin interrupciones.

  @SincronizacionTalleres
  Scenario: Sincronización automática de talleres
    Given que el usuario está participando en un taller virtual desde su teléfono
    When decide continuar en su computadora
    Then el taller debe continuar desde el mismo punto sin interrupciones

  @SincronizacionVideollamadas
  Scenario: Sincronización de videollamadas entre dispositivos
    Given que el usuario está en una videollamada desde su teléfono
    When cambia a su computadora
    Then la videollamada debe continuar en el mismo estado sin desconexiones o pérdida de calidad
