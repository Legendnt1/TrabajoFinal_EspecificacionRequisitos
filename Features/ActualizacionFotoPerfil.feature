Feature: Integración de la funcionalidad para cargar y actualizar foto de perfil
  Como usuario de la red social
  Quiero subir una foto de perfil
  Para que mis amigos agregados puedan reconocerme fácilmente en la plataforma.

  @Subir_Foto_Exitosa
  Scenario: Subir foto de perfil exitosamente
    Given que el usuario desea agregar una imagen a su perfil
    When selecciona una imagen válida desde su dispositivo
    And presiona el botón "Subir"
    Then el sistema verifica que el archivo sea válido
    And el sistema muestra la nueva foto en su perfil con el mensaje "Foto de perfil actualizada exitosamente"

  @Error_Archivo_No_Soportado
  Scenario: Error al subir un archivo no soportado
    Given que el usuario intenta cambiar su foto de perfil
    When selecciona un archivo que no es una imagen válida (por ejemplo, un documento de Word)
    And presiona el botón "Subir"
    Then el sistema muestra una alerta "Formato de archivo no soportado, por favor seleccione una imagen en formato .jpg o .png"
