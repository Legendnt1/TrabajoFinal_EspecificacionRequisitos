Feature: Reacciones y comentarios en publicaciones
  Como usuario
  Quiero reaccionar y comentar en las publicaciones de mis amigos
  Para expresar mis opiniones y mantener conversaciones activas.

  @ReaccionComentarioExitoso
  Scenario: Reacción y comentario exitosos
    Given que el usuario desea reaccionar o comentar en una publicación
    When selecciona una reacción o ingresa un comentario y hace clic en "Enviar"
    Then se muestra la reacción o el comentario en la publicación seleccionada

  @ErrorAlEnviarComentario
  Scenario: Error al enviar comentario
    Given que la conexión es inestable
    Then se muestra el mensaje "No se pudo enviar el comentario. Intente más tarde."
