using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class ConfiguracionDeAlertasDeActividadSospechosaStepDefinitions
    {
        [Given(@"que un usuario intenta iniciar sesión desde un dispositivo no registrado")]
        public void GivenQueUnUsuarioIntentaIniciarSesionDesdeUnDispositivoNoRegistrado()
        {
            throw new PendingStepException();
        }

        [When(@"el sistema detecta el dispositivo como nuevo")]
        public void WhenElSistemaDetectaElDispositivoComoNuevo()
        {
            throw new PendingStepException();
        }

        [Then(@"se envía una alerta al correo del usuario")]
        public void ThenSeEnviaUnaAlertaAlCorreoDelUsuario()
        {
            throw new PendingStepException();
        }

        [Then(@"se le solicita confirmar la actividad")]
        public void ThenSeLeSolicitaConfirmarLaActividad()
        {
            throw new PendingStepException();
        }

        [Given(@"que se realizan varios intentos fallidos de inicio de sesión en una cuenta")]
        public void GivenQueSeRealizanVariosIntentosFallidosDeInicioDeSesionEnUnaCuenta()
        {
            throw new PendingStepException();
        }

        [When(@"el número de intentos fallidos alcanza el límite preestablecido")]
        public void WhenElNumeroDeIntentosFallidosAlcanzaElLimitePreestablecido()
        {
            throw new PendingStepException();
        }

        [Then(@"el sistema bloquea temporalmente el acceso")]
        public void ThenElSistemaBloqueaTemporalmenteElAcceso()
        {
            throw new PendingStepException();
        }

        [Then(@"se envía una alerta al usuario para informarle del bloqueo")]
        public void ThenSeEnviaUnaAlertaAlUsuarioParaInformarleDelBloqueo()
        {
            throw new PendingStepException();
        }
    }
}
