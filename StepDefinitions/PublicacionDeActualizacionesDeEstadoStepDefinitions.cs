using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class PublicacionDeActualizacionesDeEstadoStepDefinitions
    {
        [Given(@"que el usuario desea compartir una actualización")]
        public void GivenQueElUsuarioDeseaCompartirUnaActualizacion()
        {
            throw new PendingStepException();
        }

        [When(@"ingresa su estado y hace clic en ""([^""]*)""")]
        public void WhenIngresaSuEstadoYHaceClicEn(string publicar)
        {
            throw new PendingStepException();
        }

        [Given(@"que hay problemas de conexión")]
        public void GivenQueHayProblemasDeConexion()
        {
            throw new PendingStepException();
        }
    }
}
