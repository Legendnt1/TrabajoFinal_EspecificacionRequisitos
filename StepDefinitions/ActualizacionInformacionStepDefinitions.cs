using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class ActualizacionInformacionStepDefinitions
    {
        [Given(@"que el usuario desea actualizar su información personal")]
        public void GivenQueElUsuarioDeseaActualizarSuInformacionPersonal()
        {
            throw new PendingStepException();
        }

        [When(@"edita los campos ""([^""]*)"", ""([^""]*)"" y ""([^""]*)"" en su perfil")]
        public void WhenEditaLosCamposYEnSuPerfil(string nombre, string p1, string p2)
        {
            throw new PendingStepException();
        }

        [When(@"presiona el botón ""([^""]*)""")]
        public void WhenPresionaElBoton(string p0)
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

        [Given(@"que el usuario intenta actualizar su información personal con datos incorrectos")]
        public void GivenQueElUsuarioIntentaActualizarSuInformacionPersonalConDatosIncorrectos()
        {
            throw new PendingStepException();
        }

        [When(@"intenta guardar los cambios")]
        public void WhenIntentaGuardarLosCambios()
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
