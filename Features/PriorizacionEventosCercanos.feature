Feature: Priorización de eventos cercanos
  Como usuario
  Quiero que en el listado se me ponga de prioridad los eventos más cercanos
  Para facilitar mi asistencia a eventos próximos.

  @PriorizacionExitosa
  Scenario: Priorización de eventos por distancia exitosa
    Given que el usuario desea tener en prioridad los eventos más cercanos
    When vea el listado de eventos
    Then habrá una opción de ordenamiento donde se le enseñará mediante la distancia los eventos

  @PriorizacionFallida
  Scenario: Priorización de eventos por distancia fallida
    Given que el usuario no ha activado la ubicación exacta para la app
    Then no se puede ordenar por distancia los eventos
