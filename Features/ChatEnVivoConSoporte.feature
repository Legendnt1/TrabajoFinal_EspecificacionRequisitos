Feature: Chat en Vivo con Soporte
  Como usuario
  Quiero tener la opción de chatear en vivo con un agente de soporte
  Para recibir ayuda inmediata con mis problemas.

  @ChatDisponible
  Scenario: El chat en vivo debe estar disponible
    Given que el usuario está en el centro de ayuda
    When busque la opción de chat en vivo
    And vea que un agente está disponible
    Then debe poder iniciar una conversación inmediatamente

  @CalificarChat
  Scenario: El usuario debe poder calificar la experiencia
    Given que el usuario ha terminado una sesión de chat
    When se le pide calificar la experiencia
    And proporcione sus comentarios
    Then esos comentarios deben ser registrados para mejorar el servicio
