Feature: Modo de alto contraste
  Como usuario con baja visión
  Quiero activar un modo de alto contraste en la interfaz
  Para ver mejor los textos y elementos visuales de la plataforma.

  @ActivacionAltoContraste
  Scenario: Activación del modo de alto contraste
    Given que el usuario está en la configuración de accesibilidad
    When activa la opción de alto contraste
    Then todos los textos y botones deben cambiar a un esquema de color de alto contraste

  @PersistenciaConfiguracion
  Scenario: Persistencia de la configuración
    Given que el usuario activa el modo de alto contraste
    When cierra sesión y vuelve a iniciar
    Then la configuración debe mantenerse activada
