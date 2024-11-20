Feature: Publicación de actualizaciones de estado
  Como usuario
  Quiero publicar actualizaciones de estado
  Para compartir pensamientos y actividades con mis amigos.

  @PublicacionExitosa
  Scenario: Publicación exitosa
    Given que el usuario desea compartir una actualización
    When ingresa su estado y hace clic en "Publicar"
    Then se muestra el mensaje "Estado publicado con éxito"

  @ErrorAlPublicar
  Scenario: Error al publicar
    Given que hay problemas de conexión
    Then se muestra el mensaje "No se pudo publicar el estado. Intente de nuevo más tarde."
