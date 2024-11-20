Feature: Interfaz de eventos
  Como usuario
  Quiero disponer de un listado de todos los eventos actuales a los cuales puedo asistir
  Para visualizar fácilmente las opciones disponibles.

  @InterfazExitosa
  Scenario: Interfaz exitosa
    Given que el usuario desea visualizar todas las opciones disponibles
    When hay diferentes actividades
    Then podrá ver la lista de eventos en una opción de la app

  @InterfazFallida
  Scenario: Interfaz fallida
    Given que el sistema se ha caído
    Then no se ha logrado desplegar la lista de eventos
