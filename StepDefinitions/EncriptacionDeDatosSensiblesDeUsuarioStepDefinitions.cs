using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class EncriptacionDeDatosSensiblesDeUsuarioStepDefinitions
    {
        [Given(@"que el usuario proporciona datos como su correo electrónico y contraseña")]
        public void GivenQueElUsuarioProporcionaDatosComoSuCorreoElectronicoYContrasena()
        {
            throw new PendingStepException();
        }

        [When(@"el sistema almacena esta información")]
        public void WhenElSistemaAlmacenaEstaInformacion()
        {
            throw new PendingStepException();
        }

        [Then(@"se encripta antes de ser guardada en la base de datos")]
        public void ThenSeEncriptaAntesDeSerGuardadaEnLaBaseDeDatos()
        {
            throw new PendingStepException();
        }

        [Then(@"cumple con los estándares de seguridad establecidos")]
        public void ThenCumpleConLosEstandaresDeSeguridadEstablecidos()
        {
            throw new PendingStepException();
        }

        [Given(@"que el sistema necesita recuperar datos sensibles del usuario")]
        public void GivenQueElSistemaNecesitaRecuperarDatosSensiblesDelUsuario()
        {
            throw new PendingStepException();
        }

        [When(@"se accede a estos datos")]
        public void WhenSeAccedeAEstosDatos()
        {
            throw new PendingStepException();
        }

        [Then(@"el sistema asegura que la información se desencripte solo temporalmente para su uso")]
        public void ThenElSistemaAseguraQueLaInformacionSeDesencripteSoloTemporalmenteParaSuUso()
        {
            throw new PendingStepException();
        }

        [Then(@"no se almacena en texto claro en ninguna parte del sistema")]
        public void ThenNoSeAlmacenaEnTextoClaroEnNingunaParteDelSistema()
        {
            throw new PendingStepException();
        }
    }
}
