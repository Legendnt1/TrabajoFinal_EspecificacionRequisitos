using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class DesarrolloDeControlDeAccesoBasadoEnRolesStepDefinitions
    {
        [Given(@"que un usuario intenta acceder a una sección protegida")]
        public void GivenQueUnUsuarioIntentaAccederAUnaSeccionProtegida()
        {
            throw new PendingStepException();
        }

        [When(@"el sistema valida su rol")]
        public void WhenElSistemaValidaSuRol()
        {
            throw new PendingStepException();
        }

        [Then(@"se le concede acceso si tiene los permisos necesarios")]
        public void ThenSeLeConcedeAccesoSiTieneLosPermisosNecesarios()
        {
            throw new PendingStepException();
        }

        [Then(@"se registra el acceso en los logs de seguridad")]
        public void ThenSeRegistraElAccesoEnLosLogsDeSeguridad()
        {
            throw new PendingStepException();
        }

        [Given(@"que un usuario intenta acceder a una sección sin permisos adecuados")]
        public void GivenQueUnUsuarioIntentaAccederAUnaSeccionSinPermisosAdecuados()
        {
            throw new PendingStepException();
        }

        [When(@"el sistema verifica su rol y encuentra que no es autorizado")]
        public void WhenElSistemaVerificaSuRolYEncuentraQueNoEsAutorizado()
        {
            throw new PendingStepException();
        }

        [Then(@"se le muestra un mensaje de ""([^""]*)""")]
        public void ThenSeLeMuestraUnMensajeDe(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"se registra el intento en los logs de seguridad")]
        public void ThenSeRegistraElIntentoEnLosLogsDeSeguridad()
        {
            throw new PendingStepException();
        }
    }
}
