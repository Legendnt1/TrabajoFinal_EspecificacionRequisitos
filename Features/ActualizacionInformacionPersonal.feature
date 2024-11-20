Feature: Actualización y gestión de información personal del usuario
  Como usuario de la red social
  Quiero actualizar mi información personal en mi perfil
  Para mantener mis datos actualizados y correctos.

  @Actualizacion_Exitosa
  Scenario: Actualización exitosa de información personal
    Given que el usuario desea actualizar su información personal
    When edita los campos "Nombre", "Correo Electrónico" y "Número de Teléfono" en su perfil
    And presiona el botón "Guardar Cambios"
    Then el sistema verifica que todos los datos ingresados en los campos sean válidos
    And el sistema muestra el mensaje "Tu información ha sido actualizada exitosamente"

  @Actualizacion_Fallida
  Scenario: Error al actualizar información debido a datos inválidos
    Given que el usuario intenta actualizar su información personal con datos incorrectos
    When intenta guardar los cambios
    Then el sistema muestra una alerta "Por favor ingrese información válida en todos los campos"
