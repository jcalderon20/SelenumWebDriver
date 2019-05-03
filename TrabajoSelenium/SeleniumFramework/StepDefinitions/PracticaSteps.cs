using SeleniumFramework.Pages;
using System;
using TechTalk.SpecFlow;

namespace SeleniumFramework.StepDefinitions
{
    [Binding]
    public class PracticaSteps
    {
        BuscarProductoPagePrincipal buscarproducto = new BuscarProductoPagePrincipal();
        ResultBusquedaPage resultproducto = new ResultBusquedaPage();
        Producto1Page rproduc1 = new Producto1Page();
        CarritoComprasPage verificar = new CarritoComprasPage();

        [Given(@"ingresa a la pagina web ""(.*)""")]
        public void GivenIngresaALaPaginaWeb(string url)
        {
            buscarproducto.Navigate(url);
        }

        [When(@"ingresa la caja de texto de busqueda ""(.*)""")]
        public void WhenIngresaLaCajaDeTextoDeBusqueda(string text)
        {
            buscarproducto.ingresar_busqueda(text);
        }

        [When(@"click boton buscar")]
        public void WhenClickBotonBuscar()
        {
            buscarproducto.clic_buscar();
        }

        [When(@"sobrepongo el mouse en el contro")]
        public void WhenSobrepongoElMouseEnElContro()
        {
            resultproducto.mouse_lista();
        }

        [When(@"click en lista")]
        public void WhenClickEnLista()
        {
            resultproducto.cliclista();
        }

        [When(@"click producto")]
        public void WhenClickProducto()
        {
            resultproducto.clic_link();
        }

        [When(@"click en seleccionar color ""(.*)""")]
        public void WhenClickEnSeleccionarColor(string location)
        {
            rproduc1.select_color(location);
        }

        [When(@"click en seleccionar size ""(.*)""")]
        public void WhenClickEnSeleccionarSize(string location)
        {
            rproduc1.select_size(location);
        }

        [When(@"click agregar a carrito")]
        public void WhenClickAgregarACarrito()
        {
            rproduc1.clic_agregar();
        }

        [When(@"click en link del producto")]
        public void WhenClickEnLinkDelProducto()
        {
            resultproducto.clic_link2();
        }

        [When(@"click en select color ""(.*)""")]
        public void WhenClickEnSelectColor(string location)
        {
            rproduc1.select_color(location);
        }

        [When(@"click en select size ""(.*)""")]
        public void WhenClickEnSelectSize(string location)
        {
            rproduc1.select_size2(location);
        }
        [Then(@"verificar name del producto ""(.*)""")]
        public void ThenVerificarNameDelProducto(string text)
        {
        }
    }
}
