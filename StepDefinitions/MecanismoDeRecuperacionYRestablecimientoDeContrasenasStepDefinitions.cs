using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class MecanismoDeRecuperacionYRestablecimientoDeContrasenasStepDefinitions
    {
        [Given(@"que el usuario ha olvidado su contraseña")]
        public void GivenQueElUsuarioHaOlvidadoSuContrasena()
        {
            throw new PendingStepException();
        }

        [When(@"hace clic en el enlace ""([^""]*)"" en la página de inicio de sesión")]
        public void WhenHaceClicEnElEnlaceEnLaPaginaDeInicioDeSesion(string p0)
        {
            throw new PendingStepException();
        }

        [When(@"ingresa su ""([^""]*)"" registrado")]
        public void WhenIngresaSuRegistrado(string p0)
        {
            throw new PendingStepException();
        }

        [When(@"presiona el botón ""([^""]*)""")]
        public void WhenPresionaElBoton(string enviar)
        {
            throw new PendingStepException();
        }

        [Then(@"el sistema verifica que el correo esté registrado")]
        public void ThenElSistemaVerificaQueElCorreoEsteRegistrado()
        {
            throw new PendingStepException();
        }

        [Then(@"el sistema envía un correo con instrucciones para restablecer la contraseña")]
        public void ThenElSistemaEnviaUnCorreoConInstruccionesParaRestablecerLaContrasena()
        {
            throw new PendingStepException();
        }

        [Given(@"que el usuario ha recibido el correo de restablecimiento")]
        public void GivenQueElUsuarioHaRecibidoElCorreoDeRestablecimiento()
        {
            throw new PendingStepException();
        }

        [When(@"hace clic en el enlace proporcionado")]
        public void WhenHaceClicEnElEnlaceProporcionado()
        {
            throw new PendingStepException();
        }

        [When(@"ingresa una ""([^""]*)"" válida en los campos ""([^""]*)"" y ""([^""]*)""")]
        public void WhenIngresaUnaValidaEnLosCamposY(string p0, string p1, string p2)
        {
            throw new PendingStepException();
        }

        [When(@"presiona el botón ""([^""]*)""")]
        public void WhenPresionaElBoton(string restablecer)
        {
            throw new PendingStepException();
        }

        [Then(@"el usuario puede iniciar sesión con su nueva contraseña")]
        public void ThenElUsuarioPuedeIniciarSesionConSuNuevaContrasena()
        {
            throw new PendingStepException();
        }
    }
}
