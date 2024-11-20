using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class CreacionDeEventosSocialesStepDefinitions
    {
        [Given(@"que el usuario desea crear un evento")]
        public void GivenQueElUsuarioDeseaCrearUnEvento()
        {
            throw new PendingStepException();
        }

        [When(@"completa los detalles del evento \(""([^""]*)"", ""([^""]*)"", ""([^""]*)"", ""([^""]*)""\)")]
        public void WhenCompletaLosDetallesDelEvento(string nombre, string fecha, string hora, string ubicación)
        {
            throw new PendingStepException();
        }

        [Given(@"que el usuario no completa los campos obligatorios")]
        public void GivenQueElUsuarioNoCompletaLosCamposObligatorios()
        {
            throw new PendingStepException();
        }
    }
}
