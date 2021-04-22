#pragma checksum "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\AddClientes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "227b4b3864945d6be9ec6120c13afc3b1dae1efa"
// <auto-generated/>
#pragma warning disable 1591
namespace PtoyectoFinal.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\_Imports.razor"
using PtoyectoFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\_Imports.razor"
using PtoyectoFinal.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\_Imports.razor"
using PtoyectoFinal.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\_Imports.razor"
using PtoyectoFinal.Contracts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\_Imports.razor"
using PtoyectoFinal.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\_Imports.razor"
using PtoyectoFinal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\_Imports.razor"
using PtoyectoFinal.DataAccess;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\_Imports.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddClientes")]
    public partial class AddClientes : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n    ");
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "row");
                __builder2.AddMarkupContent(5, "\r\n        ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "col-md-6");
                __builder2.AddMarkupContent(8, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenCard>(9);
                __builder2.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(11, "\r\n                ");
                    __builder3.AddMarkupContent(12, "<h1 class=\"text-center\">Añadir Cliente</h1>\r\n                ");
                    __builder3.OpenElement(13, "form");
                    __builder3.AddMarkupContent(14, "\r\n                    ");
                    __builder3.OpenElement(15, "div");
                    __builder3.AddAttribute(16, "class", "form-group");
                    __builder3.AddMarkupContent(17, "\r\n\r\n                        ");
                    __builder3.AddMarkupContent(18, "<label for=\"Cedula\" class=\"control-label\">Escriba la cedula del cliente:</label>\r\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenMask>(19);
                    __builder3.AddAttribute(20, "class", "form-control");
                    __builder3.AddAttribute(21, "Mask", "***-*******-*");
                    __builder3.AddAttribute(22, "Pattern", "[^0-9]");
                    __builder3.AddAttribute(23, "id", "Cedula");
                    __builder3.AddAttribute(24, "Placeholder", "Cedula");
                    __builder3.AddAttribute(25, "value", 
#nullable restore
#line 18 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\AddClientes.razor"
                                                                                                                         cliente.Cedula

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(26, "valueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.Cedula = __value, cliente.Cedula));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\r\n\r\n                        ");
                    __builder3.AddMarkupContent(28, "<label for=\"Nombre\" class=\"control-label\">Escriba el nombre del cliente:</label>\r\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(29);
                    __builder3.AddAttribute(30, "class", "form-control");
                    __builder3.AddAttribute(31, "id", "Nombre");
                    __builder3.AddAttribute(32, "Placeholder", "Nombre");
                    __builder3.AddAttribute(33, "value", 
#nullable restore
#line 21 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\AddClientes.razor"
                                                                                      cliente.Nombre

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(34, "valueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.Nombre = __value, cliente.Nombre));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(35, "\r\n\r\n                        ");
                    __builder3.AddMarkupContent(36, "<label for=\"Apellido\" class=\"control-label\">Escriba el apellido del cliente:</label>\r\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(37);
                    __builder3.AddAttribute(38, "class", "form-control");
                    __builder3.AddAttribute(39, "id", "Apellido");
                    __builder3.AddAttribute(40, "Placeholder", "Apellido");
                    __builder3.AddAttribute(41, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\AddClientes.razor"
                                                                                       cliente.Apellido

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(42, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.Apellido = __value, cliente.Apellido))));
                    __builder3.AddAttribute(43, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cliente.Apellido));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(44, "\r\n\r\n                        ");
                    __builder3.AddMarkupContent(45, "<label for=\"email\" class=\"control-label\">Escriba el correo del cliente:</label>\r\n                        ");
                    __builder3.OpenElement(46, "input");
                    __builder3.AddAttribute(47, "class", "form-control");
                    __builder3.AddAttribute(48, "type", "email");
                    __builder3.AddAttribute(49, "id", "email");
                    __builder3.AddAttribute(50, "Placeholder", "Email");
                    __builder3.AddAttribute(51, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\AddClientes.razor"
                                                                                    cliente.Correo

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(52, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cliente.Correo = __value, cliente.Correo));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(53, "\r\n\r\n                        ");
                    __builder3.AddMarkupContent(54, "<label for=\"Licencia\">Tipo de Licencia:</label>\r\n                        ");
                    __builder3.OpenElement(55, "select");
                    __builder3.AddAttribute(56, "class", "form-control");
                    __builder3.AddAttribute(57, "id", "Licencia");
                    __builder3.AddAttribute(58, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\AddClientes.razor"
                                                                              TipoDeLicencia

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(59, "\r\n                            ");
                    __builder3.OpenElement(60, "option");
                    __builder3.AddContent(61, " -- Sin seleccionar -- ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(62, "\r\n                            ");
                    __builder3.OpenElement(63, "option");
                    __builder3.AddContent(64, "Conductor");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(65, "\r\n                            ");
                    __builder3.OpenElement(66, "option");
                    __builder3.AddContent(67, "Conductor de Motociclos");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(68, "\r\n                            ");
                    __builder3.OpenElement(69, "option");
                    __builder3.AddMarkupContent(70, "Conductor de vehículos Pesados");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(71, "\r\n                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(72, "\r\n\r\n                        ");
                    __builder3.AddMarkupContent(73, "<label for=\"Nacionalidad\" class=\"control-label\">Escriba la nacionalidad del cliente:</label>\r\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(74);
                    __builder3.AddAttribute(75, "class", "form-control");
                    __builder3.AddAttribute(76, "id", "Nacionalidad");
                    __builder3.AddAttribute(77, "Placeholder", "Nacionalidad");
                    __builder3.AddAttribute(78, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\AddClientes.razor"
                                                                                           cliente.Nacionalidad

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(79, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.Nacionalidad = __value, cliente.Nacionalidad))));
                    __builder3.AddAttribute(80, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cliente.Nacionalidad));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(81, "\r\n\r\n                        ");
                    __builder3.AddMarkupContent(82, "<label for=\"Tipo_Sangre\">Tipo de Sangre:</label>\r\n                        ");
                    __builder3.OpenElement(83, "select");
                    __builder3.AddAttribute(84, "class", "form-control");
                    __builder3.AddAttribute(85, "id", "Tipo_Sangre");
                    __builder3.AddAttribute(86, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\AddClientes.razor"
                                                                                 TipoDeSangre

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(87, "\r\n                            ");
                    __builder3.OpenElement(88, "option");
                    __builder3.AddContent(89, " -- Sin seleccionar -- ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(90, "\r\n                            ");
                    __builder3.OpenElement(91, "option");
                    __builder3.AddContent(92, "O Negativo");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(93, "\r\n                            ");
                    __builder3.OpenElement(94, "option");
                    __builder3.AddContent(95, "O Positivo");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(96, "\r\n                            ");
                    __builder3.OpenElement(97, "option");
                    __builder3.AddContent(98, "A negativo");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(99, "\r\n                            ");
                    __builder3.OpenElement(100, "option");
                    __builder3.AddContent(101, "A positivo");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(102, "\r\n                            ");
                    __builder3.OpenElement(103, "option");
                    __builder3.AddContent(104, "B negativo");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(105, "\r\n                            ");
                    __builder3.OpenElement(106, "option");
                    __builder3.AddContent(107, "B positivo");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(108, "\r\n                            ");
                    __builder3.OpenElement(109, "option");
                    __builder3.AddContent(110, "AB negativo");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(111, "\r\n                            ");
                    __builder3.OpenElement(112, "option");
                    __builder3.AddContent(113, "AB positivo");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(114, "\r\n                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(115, "\r\n\r\n                        ");
                    __builder3.AddMarkupContent(116, "<label for=\"Foto Persona\" class=\"control-label\">Escriba el URL de la foto del cliente:</label>\r\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(117);
                    __builder3.AddAttribute(118, "class", "form-control");
                    __builder3.AddAttribute(119, "id", "Foto Persona");
                    __builder3.AddAttribute(120, "Placeholder", "Foto Persona");
                    __builder3.AddAttribute(121, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 54 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\AddClientes.razor"
                                                                                           cliente.Foto_Persona

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(122, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.Foto_Persona = __value, cliente.Foto_Persona))));
                    __builder3.AddAttribute(123, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cliente.Foto_Persona));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(124, "\r\n\r\n                        ");
                    __builder3.AddMarkupContent(125, "<label for=\"Foto Licencia\" class=\"control-label\">Escriba el URL de la foto de la licencia del cliente:</label>\r\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(126);
                    __builder3.AddAttribute(127, "class", "form-control");
                    __builder3.AddAttribute(128, "id", "Foto Licencia");
                    __builder3.AddAttribute(129, "Placeholder", "Foto Licencia");
                    __builder3.AddAttribute(130, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 57 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\AddClientes.razor"
                                                                                            cliente.Foto_Licencia

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(131, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.Foto_Licencia = __value, cliente.Foto_Licencia))));
                    __builder3.AddAttribute(132, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cliente.Foto_Licencia));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(133, "\r\n\r\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(134, "\r\n\r\n");
#nullable restore
#line 61 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\AddClientes.razor"
                     if (ValidarInputs)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(135, "                        ");
                    __builder3.OpenElement(136, "div");
                    __builder3.AddAttribute(137, "class", "alert alert-danger");
                    __builder3.AddMarkupContent(138, "\r\n                            ");
                    __builder3.AddContent(139, 
#nullable restore
#line 64 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\AddClientes.razor"
                             MensajeError

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(140, "\r\n                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(141, "\r\n");
#nullable restore
#line 66 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\AddClientes.razor"
                    }

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(142, "\r\n                    ");
                    __builder3.OpenElement(143, "div");
                    __builder3.AddAttribute(144, "class", "d-grid gap-2");
                    __builder3.AddMarkupContent(145, "\r\n                        ");
                    __builder3.OpenElement(146, "button");
                    __builder3.AddAttribute(147, "type", "button");
                    __builder3.AddAttribute(148, "class", "btn btn-success btn-block");
                    __builder3.AddAttribute(149, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 69 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\AddClientes.razor"
                                                                                          () => CreateClientes()

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddContent(150, "Crear");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(151, "\r\n                        ");
                    __builder3.OpenElement(152, "button");
                    __builder3.AddAttribute(153, "type", "button");
                    __builder3.AddAttribute(154, "class", "btn btn-danger btn-block");
                    __builder3.AddAttribute(155, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 70 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\AddClientes.razor"
                                                                                         () => cancel()

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddContent(156, "Cancelar");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(157, "\r\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(158, "\r\n\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(159, "\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(160, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(161, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(162, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 79 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\AddClientes.razor"
       
    //Strings de los select del tipo de sangre y del tipo de la licencia
    String TipoSangre = "-- Sin seleccionar --";
    String TipoLicencia = "-- Sin seleccionar --";

    //variables para validar si todos los campos estan llenos
    string MensajeError;
    bool ValidarInputs = false;

    //String del id de la institucion
    string id;

    //Instancia de la Clase Clientes
    Clientes cliente = new Clientes();

    //Metodo que permite agregar los datos de los inputs a la tabla de clientes y después vuelve a la lista de clientes
    protected async Task CreateClientes()
    {
        //Metodo para validar si cada uno de los inputs o de los campos estan llenos y no se estan pasando nulls
        if (cliente.Cedula == null || cliente.Nombre == null || cliente.Apellido == null || cliente.Correo == null || cliente.Licencia == "-- Sin seleccionar --" || cliente.Nacionalidad == "" || cliente.Tipo_Sangre == "-- Sin seleccionar --" || cliente.Foto_Persona == null || cliente.Foto_Licencia == null)
        {
            MensajeError = "Todos los campos son necesarios...";
            ValidarInputs = true;
            return;
        }
        String name = await localStorage.GetItemAsync<string>("ID_Institucion");
        cliente.ID_Institucion = name;
        cliente.Estado = "Habilitado";
        cliente.Licencia = TipoLicencia;
        cliente.Tipo_Sangre = TipoSangre;
        await ClientesManager.Create(cliente);
        navigationManager.NavigateTo("/CRUDClientes");
    }

    //Metodo para cancelar la creaicon del cliente y volver a la lista de los clientes
    void cancel()
    {
        navigationManager.NavigateTo("/CRUDClientes");
    }

    //Metodo para manejar el select del tipo de Sangre del cliente
    public void TipoDeSangre(ChangeEventArgs e)
    {
        TipoSangre = e.Value.ToString();
    }

    //Metodo para manejar el select del tipo de licencia del cliente
    public void TipoDeLicencia(ChangeEventArgs e)
    {
        TipoLicencia = e.Value.ToString();
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClientesManager ClientesManager { get; set; }
    }
}
#pragma warning restore 1591
