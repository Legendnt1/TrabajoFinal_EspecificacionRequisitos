using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class IntegracionDeLaFuncionalidadParaCargarYActualizarFotoDePerfilStepDefinitions
    {
        [Given(@"que el usuario desea agregar una imagen a su perfil")]
        public void GivenQueElUsuarioDeseaAgregarUnaImagenASuPerfil()
        {
            throw new PendingStepException();
        }

        [When(@"selecciona una imagen válida desde su dispositivo")]
        public void WhenSeleccionaUnaImagenValidaDesdeSuDispositivo()
        {
            throw new PendingStepException();
        }

        [When(@"presiona el botón ""([^""]*)""")]
        public void WhenPresionaElBoton(string subir)
        {
            throw new PendingStepException();
        }

        [Then(@"el sistema verifica que el archivo sea válido")]
        public void ThenElSistemaVerificaQueElArchivoSeaValido()
        {
            throw new PendingStepException();
        }

        [Then(@"el sistema muestra la nueva foto en su perfil con el mensaje ""([^""]*)""")]
        public void ThenElSistemaMuestraLaNuevaFotoEnSuPerfilConElMensaje(string p0)
        {
            throw new PendingStepException();
        }

        [Given(@"que el usuario intenta cambiar su foto de perfil")]
        public void GivenQueElUsuarioIntentaCambiarSuFotoDePerfil()
        {
            throw new PendingStepException();
        }

        [When(@"selecciona un archivo que no es una imagen válida \(por ejemplo, un documento de Word\)")]
        public void WhenSeleccionaUnArchivoQueNoEsUnaImagenValidaPorEjemploUnDocumentoDeWord()
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
