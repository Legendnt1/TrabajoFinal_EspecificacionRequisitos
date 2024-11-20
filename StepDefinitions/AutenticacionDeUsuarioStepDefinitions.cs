using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class AutenticacionDeUsuarioStepDefinitions
    {
        [Given(@"el usuario registrado desea acceder a su cuenta")]
        public void GivenElUsuarioRegistradoDeseaAccederASuCuenta()
        {
            throw new PendingStepException();
        }

        [When(@"ingresa su ""([^""]*)"" y ""([^""]*)"" correctos")]
        public void WhenIngresaSuYCorrectos(string p0, string contraseña)
        {
            throw new PendingStepException();
        }

        [When(@"hace clic en el botón ""([^""]*)""")]
        public void WhenHaceClicEnElBoton(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"el sistema verifica que las credenciales sean correctas")]
        public void ThenElSistemaVerificaQueLasCredencialesSeanCorrectas()
        {
            throw new PendingStepException();
        }

        [Then(@"el usuario es redirigido a su página de perfil con acceso a su información personal")]
        public void ThenElUsuarioEsRedirigidoASuPaginaDePerfilConAccesoASuInformacionPersonal()
        {
            throw new PendingStepException();
        }

        [Given(@"el usuario intenta iniciar sesión")]
        public void GivenElUsuarioIntentaIniciarSesion()
        {
            throw new PendingStepException();
        }

        [When(@"ingresa un ""([^""]*)"" o ""([^""]*)"" incorrectos")]
        public void WhenIngresaUnOIncorrectos(string p0, string contraseña)
        {
            throw new PendingStepException();
        }

        [Then(@"el sistema muestra una alerta: ""([^""]*)""")]
        public void ThenElSistemaMuestraUnaAlerta(string p0)
        {
            throw new PendingStepException();
        }
    }
}
