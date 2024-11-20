using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class RegistroDeUsuarioStepDefinitions
    {
        [Given(@"que el usuario desea registrarse en la plataforma")]
        public void GivenQueElUsuarioDeseaRegistrarseEnLaPlataforma()
        {
            throw new PendingStepException();
        }

        [When(@"llena los campos obligatorios ""([^""]*)"", ""([^""]*)"", ""([^""]*)"" y ""([^""]*)"" con información válida")]
        public void WhenLlenaLosCamposObligatoriosYConInformacionValida(string nombre, string p1, string contraseña, string p3)
        {
            throw new PendingStepException();
        }

        [Then(@"el sistema verifica que todos los datos ingresados en los campos sean válidos")]
        public void ThenElSistemaVerificaQueTodosLosDatosIngresadosEnLosCamposSeanValidos()
        {
            throw new PendingStepException();
        }

        [Then(@"el sistema muestra el mensaje ""([^""]*)""")]
        public void ThenElSistemaMuestraElMensaje(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"el sistema envía un correo de verificación al usuario")]
        public void ThenElSistemaEnviaUnCorreoDeVerificacionAlUsuario()
        {
            throw new PendingStepException();
        }

        [Given(@"que el usuario intenta registrarse con datos incompletos o inválidos")]
        public void GivenQueElUsuarioIntentaRegistrarseConDatosIncompletosOInvalidos()
        {
            throw new PendingStepException();
        }

        [When(@"no llena todos los campos obligatorios o ingresa información incorrecta")]
        public void WhenNoLlenaTodosLosCamposObligatoriosOIngresaInformacionIncorrecta()
        {
            throw new PendingStepException();
        }

        [Then(@"el sistema muestra una alerta ""([^""]*)""")]
        public void ThenElSistemaMuestraUnaAlerta(string p0)
        {
            throw new PendingStepException();
        }
    }
}
