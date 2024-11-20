using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class NotificacionDeNuevasActividadesStepDefinitions
    {
        [Given(@"que el usuario desea estar al tanto")]
        public void GivenQueElUsuarioDeseaEstarAlTanto()
        {
            throw new PendingStepException();
        }

        [When(@"se organice una nueva actividad")]
        public void WhenSeOrganiceUnaNuevaActividad()
        {
            throw new PendingStepException();
        }

        [Then(@"se le enviará una notificación a su celular y a su correo")]
        public void ThenSeLeEnviaraUnaNotificacionASuCelularYASuCorreo()
        {
            throw new PendingStepException();
        }

        [Given(@"que el sistema se ha caído")]
        public void GivenQueElSistemaSeHaCaido()
        {
            throw new PendingStepException();
        }

        [Then(@"no se ha logrado enviar la notificación de un nuevo evento")]
        public void ThenNoSeHaLogradoEnviarLaNotificacionDeUnNuevoEvento()
        {
            throw new PendingStepException();
        }
    }
}
