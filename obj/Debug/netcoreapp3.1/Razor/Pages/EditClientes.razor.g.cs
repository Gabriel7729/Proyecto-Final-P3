#pragma checksum "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditClientes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa9aee8f6e06e53b4363fc5b2a5a31fc5371546f"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditClientes/{ID}")]
    public partial class EditClientes : Microsoft.AspNetCore.Components.ComponentBase
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
                    __builder3.AddMarkupContent(12, "<h1 class=\"text-center\">Editar Clientes</h1>\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTemplateForm<Clientes>>(13);
                    __builder3.AddAttribute(14, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Clientes>(
#nullable restore
#line 14 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditClientes.razor"
                                                           cliente

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(15, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Clientes>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Clientes>(this, 
#nullable restore
#line 14 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditClientes.razor"
                                                                           UpdateClientes

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(16, "InvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.FormInvalidSubmitEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.FormInvalidSubmitEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditClientes.razor"
                                                                                                         UpdateClientes

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder4) => {
                        __builder4.AddMarkupContent(18, "\r\n                    ");
                        __builder4.OpenElement(19, "div");
                        __builder4.AddAttribute(20, "class", "form-group");
                        __builder4.AddMarkupContent(21, "\r\n\r\n                        ");
                        __builder4.AddMarkupContent(22, "<label for=\"Cedula\" class=\"control-label\">Escriba la cedula del cliente:</label>\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenMask>(23);
                        __builder4.AddAttribute(24, "class", "form-control");
                        __builder4.AddAttribute(25, "Mask", "***-*******-*");
                        __builder4.AddAttribute(26, "Pattern", "[^0-9]");
                        __builder4.AddAttribute(27, "id", "Cedula");
                        __builder4.AddAttribute(28, "Placeholder", "Cedula");
                        __builder4.AddAttribute(29, "value", 
#nullable restore
#line 18 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditClientes.razor"
                                                                                                                         cliente.Cedula

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddAttribute(30, "valueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.Cedula = __value, cliente.Cedula));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(31, "\r\n\r\n                        ");
                        __builder4.AddMarkupContent(32, "<label for=\"Nombre\" class=\"control-label\">Escriba el nombre del cliente:</label>\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenTextBox>(33);
                        __builder4.AddAttribute(34, "class", "form-control");
                        __builder4.AddAttribute(35, "id", "Nombre");
                        __builder4.AddAttribute(36, "Placeholder", "Nombre");
                        __builder4.AddAttribute(37, "value", 
#nullable restore
#line 21 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditClientes.razor"
                                                                                      cliente.Nombre

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddAttribute(38, "valueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.Nombre = __value, cliente.Nombre));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(39, "\r\n\r\n                        ");
                        __builder4.AddMarkupContent(40, "<label for=\"Apellido\" class=\"control-label\">Escriba el apellido del cliente:</label>\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenTextBox>(41);
                        __builder4.AddAttribute(42, "class", "form-control");
                        __builder4.AddAttribute(43, "id", "Apellido");
                        __builder4.AddAttribute(44, "Placeholder", "Apellido");
                        __builder4.AddAttribute(45, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditClientes.razor"
                                                                                       cliente.Apellido

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(46, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.Apellido = __value, cliente.Apellido))));
                        __builder4.AddAttribute(47, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cliente.Apellido));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(48, "\r\n\r\n                        ");
                        __builder4.AddMarkupContent(49, "<label for=\"email\" class=\"control-label\">Escriba el correo del cliente:</label>\r\n                        ");
                        __builder4.OpenElement(50, "input");
                        __builder4.AddAttribute(51, "class", "form-control");
                        __builder4.AddAttribute(52, "type", "email");
                        __builder4.AddAttribute(53, "id", "email");
                        __builder4.AddAttribute(54, "Placeholder", "Email");
                        __builder4.AddAttribute(55, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditClientes.razor"
                                                                                    cliente.Correo

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(56, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cliente.Correo = __value, cliente.Correo));
                        __builder4.SetUpdatesAttributeName("value");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(57, "\r\n\r\n                        ");
                        __builder4.AddMarkupContent(58, "<label for=\"Licencia\">Tipo de Licencia:</label>\r\n                        ");
                        __builder4.OpenElement(59, "select");
                        __builder4.AddAttribute(60, "class", "form-control");
                        __builder4.AddAttribute(61, "id", "Licencia");
                        __builder4.AddAttribute(62, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditClientes.razor"
                                                                              TipoDeLicencia

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddMarkupContent(63, "\r\n                            ");
                        __builder4.OpenElement(64, "option");
                        __builder4.AddContent(65, " -- Sin seleccionar -- ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(66, "\r\n                            ");
                        __builder4.OpenElement(67, "option");
                        __builder4.AddContent(68, "Conductor");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(69, "\r\n                            ");
                        __builder4.OpenElement(70, "option");
                        __builder4.AddContent(71, "Conductor de Motociclos");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(72, "\r\n                            ");
                        __builder4.OpenElement(73, "option");
                        __builder4.AddMarkupContent(74, "Conductor de vehículos Pesados");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(75, "\r\n                        ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(76, "\r\n\r\n                        ");
                        __builder4.AddMarkupContent(77, "<label for=\"Nacionalidad\" class=\"control-label\">Escriba la nacionalidad del cliente:</label>\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenTextBox>(78);
                        __builder4.AddAttribute(79, "class", "form-control");
                        __builder4.AddAttribute(80, "id", "Nacionalidad");
                        __builder4.AddAttribute(81, "Placeholder", "Nacionalidad");
                        __builder4.AddAttribute(82, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditClientes.razor"
                                                                                           cliente.Nacionalidad

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(83, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.Nacionalidad = __value, cliente.Nacionalidad))));
                        __builder4.AddAttribute(84, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cliente.Nacionalidad));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(85, "\r\n\r\n                        ");
                        __builder4.AddMarkupContent(86, "<label for=\"Tipo_Sangre\">Tipo de Sangre:</label>\r\n                        ");
                        __builder4.OpenElement(87, "select");
                        __builder4.AddAttribute(88, "class", "form-control");
                        __builder4.AddAttribute(89, "id", "Tipo_Sangre");
                        __builder4.AddAttribute(90, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditClientes.razor"
                                                                                 TipoDeSangre

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddMarkupContent(91, "\r\n                            ");
                        __builder4.OpenElement(92, "option");
                        __builder4.AddContent(93, " -- Sin seleccionar -- ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(94, "\r\n                            ");
                        __builder4.OpenElement(95, "option");
                        __builder4.AddContent(96, "O Negativo");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(97, "\r\n                            ");
                        __builder4.OpenElement(98, "option");
                        __builder4.AddContent(99, "O Positivo");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(100, "\r\n                            ");
                        __builder4.OpenElement(101, "option");
                        __builder4.AddContent(102, "A negativo");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(103, "\r\n                            ");
                        __builder4.OpenElement(104, "option");
                        __builder4.AddContent(105, "A positivo");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(106, "\r\n                            ");
                        __builder4.OpenElement(107, "option");
                        __builder4.AddContent(108, "B negativo");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(109, "\r\n                            ");
                        __builder4.OpenElement(110, "option");
                        __builder4.AddContent(111, "B positivo");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(112, "\r\n                            ");
                        __builder4.OpenElement(113, "option");
                        __builder4.AddContent(114, "AB negativo");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(115, "\r\n                            ");
                        __builder4.OpenElement(116, "option");
                        __builder4.AddContent(117, "AB positivo");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(118, "\r\n                        ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(119, "\r\n\r\n                        ");
                        __builder4.AddMarkupContent(120, "<label for=\"Foto Persona\" class=\"control-label\">Escriba el URL de la foto del cliente:</label>\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenTextBox>(121);
                        __builder4.AddAttribute(122, "class", "form-control");
                        __builder4.AddAttribute(123, "id", "Foto Persona");
                        __builder4.AddAttribute(124, "Placeholder", "Foto Persona");
                        __builder4.AddAttribute(125, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 54 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditClientes.razor"
                                                                                           cliente.Foto_Persona

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(126, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.Foto_Persona = __value, cliente.Foto_Persona))));
                        __builder4.AddAttribute(127, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cliente.Foto_Persona));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(128, "\r\n\r\n                        ");
                        __builder4.AddMarkupContent(129, "<label for=\"Foto Licencia\" class=\"control-label\">Escriba el URL de la foto de la licencia del cliente:</label>\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenTextBox>(130);
                        __builder4.AddAttribute(131, "class", "form-control");
                        __builder4.AddAttribute(132, "id", "Foto Licencia");
                        __builder4.AddAttribute(133, "Placeholder", "Foto Licencia");
                        __builder4.AddAttribute(134, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 57 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditClientes.razor"
                                                                                            cliente.Foto_Licencia

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(135, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.Foto_Licencia = __value, cliente.Foto_Licencia))));
                        __builder4.AddAttribute(136, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cliente.Foto_Licencia));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(137, "\r\n\r\n                    ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(138, "\r\n\r\n");
#nullable restore
#line 61 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditClientes.razor"
                     if (ValidarInputs)
                    {

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(139, "                        ");
                        __builder4.OpenElement(140, "div");
                        __builder4.AddAttribute(141, "class", "alert alert-danger");
                        __builder4.AddMarkupContent(142, "\r\n                            ");
                        __builder4.AddContent(143, 
#nullable restore
#line 64 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditClientes.razor"
                             MensajeError

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddMarkupContent(144, "\r\n                        ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(145, "\r\n");
#nullable restore
#line 66 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditClientes.razor"
                    }

#line default
#line hidden
#nullable disable
                        __builder4.AddMarkupContent(146, "\r\n                    ");
                        __builder4.OpenElement(147, "div");
                        __builder4.AddAttribute(148, "class", "d-grid gap-2");
                        __builder4.AddMarkupContent(149, "\r\n                        ");
                        __builder4.OpenElement(150, "button");
                        __builder4.AddAttribute(151, "type", "button");
                        __builder4.AddAttribute(152, "class", "btn btn-success btn-block");
                        __builder4.AddAttribute(153, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 69 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditClientes.razor"
                                                                                          () => UpdateClientes()

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddContent(154, "Editar");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(155, "\r\n                        ");
                        __builder4.OpenElement(156, "button");
                        __builder4.AddAttribute(157, "type", "button");
                        __builder4.AddAttribute(158, "class", "btn btn-danger btn-block");
                        __builder4.AddAttribute(159, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 70 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditClientes.razor"
                                                                                         () => cancel()

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddContent(160, "Cancelar");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(161, "\r\n                    ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(162, "\r\n\r\n                ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(163, "\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(164, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(165, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(166, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 79 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditClientes.razor"
        
    //Id que se recibe como parametro
    [Parameter]
    public string ID { get; set; }

    //Variables para validar los campos de los inputs
    string MensajeError;
    bool ValidarInputs = false;

    //Strings de los select del tipo de sangre y del tipo de la licencia
    String TipoSangre = "-- Sin seleccionar --";
    String TipoLicencia = "-- Sin seleccionar --";

    //Instancia de la Clase Clientes
    Clientes cliente = new Clientes();

    //Metodo que cuando se carga la vista, el mismo carga por medio del ID cada uno de los inputs con el cliente requerido
    protected override async Task OnInitializedAsync()
    {
        //Se obtiene el ID por medio del LocalStorage
        String id = await localStorage.GetItemAsync<string>("ID_Institucion");
        cliente.ID_Institucion = id;
        cliente = await ClientesManager.GetById(Convert.ToInt32(ID), cliente.ID_Institucion);
    }

    //Metodo para actualizar los clientes
    protected async Task UpdateClientes()
    {
        cliente.Tipo_Sangre = TipoSangre;
        cliente.Licencia = TipoLicencia;

        //if para validar si cada uno de los inputs o de los campos estan llenos y no se estan pasando nulls
        if (cliente.Cedula == null || cliente.Nombre == null || cliente.Apellido == null || cliente.Correo == null || cliente.Licencia == "-- Sin seleccionar --" || cliente.Nacionalidad == "" || cliente.Tipo_Sangre == "-- Sin seleccionar --" || cliente.Foto_Persona == null || cliente.Foto_Licencia == null)
        {
            MensajeError = "Todos los campos son necesarios...";
            ValidarInputs = true;
            return;
        }
        await ClientesManager.Update(cliente);
        navigationManager.NavigateTo("/CRUDClientes");
    }

    //Metodo para cancelar y volver a la lista de los clientes
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
