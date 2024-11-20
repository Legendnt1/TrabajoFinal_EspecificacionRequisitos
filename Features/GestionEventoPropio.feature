Feature: Gestión de un evento propio
  Como usuario
  Quiero tener la posibilidad de organizar mi propia actividad
  Para coordinar y gestionar eventos según mis necesidades.

  @OrganizacionExitosa
  Scenario: Organización exitosa
    Given que el usuario desea organizar su propia actividad
    When desee hacerlo
    Then se le habilitará una opción de organizador

  @OrganizacionFallida
  Scenario: Organización fallida
    Given que el usuario no cumple con los requisitos
    Then no se le puede habilitar dicha opción
