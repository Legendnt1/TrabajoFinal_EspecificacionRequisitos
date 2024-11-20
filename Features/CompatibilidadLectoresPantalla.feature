Feature: Compatibilidad con lectores de pantalla
  Como usuario con discapacidad visual
  Quiero que todos los elementos de la interfaz sean leídos correctamente por los lectores de pantalla
  Para navegar y entender el contenido sin problemas de interpretación.

  @LecturaEtiquetasBotones
  Scenario: Lectura de etiquetas y botones
    Given que el usuario está en cualquier sección de la plataforma
    When un lector de pantalla enfoca un botón o enlace
    Then el lector debe leer la etiqueta correctamente y describir la función del botón

  @DescripcionImagenes
  Scenario: Descripción de imágenes
    Given que el usuario interactúa con una imagen
    When el lector de pantalla accede a la imagen
    Then debe proporcionar una descripción alternativa (alt text) clara y contextualizada del contenido visual
