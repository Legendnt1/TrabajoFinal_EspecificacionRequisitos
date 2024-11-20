using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class AceptacionYRechazoDeSolicitudesDeAmistadStepDefinitions
    {
        [Given(@"que el usuario recibe una solicitud de amistad")]
        public void GivenQueElUsuarioRecibeUnaSolicitudDeAmistad()
        {
            throw new PendingStepException();
        }

        [When(@"hace clic en ""([^""]*)""")]
        public void WhenHaceClicEn(string aceptar)
        {
            throw new PendingStepException();
        }

        [Given(@"que el usuario no desea aceptar la solicitud")]
        public void GivenQueElUsuarioNoDeseaAceptarLaSolicitud()
        {
            throw new PendingStepException();
        }

        [When(@"hace clic en ""([^""]*)""")]
        public void WhenHaceClicEn(string rechazar)
        {
            throw new PendingStepException();
        }

        [Then(@"se elimina la solicitud y se muestra el mensaje ""([^""]*)""")]
        public void ThenSeEliminaLaSolicitudYSeMuestraElMensaje(string p0)
        {
            throw new PendingStepException();
        }
    }
}
