#pragma checksum "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditVehiculos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a06a7527b3aa9dd7c0f61a10cb8172b8716d47fe"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditVehiculos/{ID}")]
    public partial class EditVehiculos : Microsoft.AspNetCore.Components.ComponentBase
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
                    __builder3.AddMarkupContent(12, "<h1 class=\"text-center\">Editar Vehiculo</h1>\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTemplateForm<Vehiculos>>(13);
                    __builder3.AddAttribute(14, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Vehiculos>(
#nullable restore
#line 11 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditVehiculos.razor"
                                                            vehiculo

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(15, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Vehiculos>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Vehiculos>(this, 
#nullable restore
#line 11 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditVehiculos.razor"
                                                                             UpdateVehiculos

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(16, "InvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.FormInvalidSubmitEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.FormInvalidSubmitEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditVehiculos.razor"
                                                                                                            UpdateVehiculos

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder4) => {
                        __builder4.AddMarkupContent(18, "\r\n                    ");
                        __builder4.OpenElement(19, "div");
                        __builder4.AddAttribute(20, "class", "form-group");
                        __builder4.AddMarkupContent(21, "\r\n\r\n                        ");
                        __builder4.AddMarkupContent(22, "<label for=\"Marca\" class=\"control-label\">Escriba la marca del vehiculo:</label>\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenTextBox>(23);
                        __builder4.AddAttribute(24, "class", "form-control");
                        __builder4.AddAttribute(25, "Name", "Marca");
                        __builder4.AddAttribute(26, "Placeholder", "Marca");
                        __builder4.AddAttribute(27, "value", 
#nullable restore
#line 15 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditVehiculos.razor"
                                                                                       vehiculo.Marca

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddAttribute(28, "valueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vehiculo.Marca = __value, vehiculo.Marca));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(29, "\r\n\r\n                        ");
                        __builder4.AddMarkupContent(30, "<label for=\"Modelo\" class=\"control-label\">Escriba el modelo del vehiculo:</label>\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenTextBox>(31);
                        __builder4.AddAttribute(32, "class", "form-control");
                        __builder4.AddAttribute(33, "id", "Modelo");
                        __builder4.AddAttribute(34, "Placeholder", "Modelo");
                        __builder4.AddAttribute(35, "value", 
#nullable restore
#line 18 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditVehiculos.razor"
                                                                                      vehiculo.Modelo

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddAttribute(36, "valueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vehiculo.Modelo = __value, vehiculo.Modelo));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(37, "\r\n\r\n                        ");
                        __builder4.AddMarkupContent(38, "<label for=\"Año\" class=\"control-label\">Escriba el Año del vehiculo:</label>\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenTextBox>(39);
                        __builder4.AddAttribute(40, "class", "form-control");
                        __builder4.AddAttribute(41, "id", "Año");
                        __builder4.AddAttribute(42, "Placeholder", "Año");
                        __builder4.AddAttribute(43, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditVehiculos.razor"
                                                                                  vehiculo.Año

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(44, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vehiculo.Año = __value, vehiculo.Año))));
                        __builder4.AddAttribute(45, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => vehiculo.Año));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(46, "\r\n\r\n                        ");
                        __builder4.AddMarkupContent(47, "<label for=\"Color\" class=\"control-label\">Escriba el color del vehiculo:</label>\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenTextBox>(48);
                        __builder4.AddAttribute(49, "class", "form-control");
                        __builder4.AddAttribute(50, "id", "Color");
                        __builder4.AddAttribute(51, "Placeholder", "Color");
                        __builder4.AddAttribute(52, "value", 
#nullable restore
#line 24 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditVehiculos.razor"
                                                                                     vehiculo.Color

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddAttribute(53, "valueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vehiculo.Color = __value, vehiculo.Color));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(54, "\r\n\r\n                        ");
                        __builder4.AddMarkupContent(55, "<label for=\"Precio_Dia\" class=\"control-label\">Escriba el Precio por día del vehiculo:</label>\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenNumeric<Double>>(56);
                        __builder4.AddAttribute(57, "class", "form-control");
                        __builder4.AddAttribute(58, "id", "Precio_Dia");
                        __builder4.AddAttribute(59, "ShowUpDown", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 27 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditVehiculos.razor"
                                                                                                                                         false

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(60, "Placeholder", "Precio por día");
                        __builder4.AddAttribute(61, "value", 
#nullable restore
#line 27 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditVehiculos.razor"
                                                                                                         vehiculo.Precio_Dia

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddAttribute(62, "valueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vehiculo.Precio_Dia = __value, vehiculo.Precio_Dia));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(63, "\r\n\r\n                        ");
                        __builder4.AddMarkupContent(64, "<label for=\"Tipo\" class=\"control-label\">Seleccione el tipo del vehiculo:</label>\r\n                        ");
                        __builder4.OpenElement(65, "select");
                        __builder4.AddAttribute(66, "class", "form-control");
                        __builder4.AddAttribute(67, "id", "Tipo");
                        __builder4.AddAttribute(68, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditVehiculos.razor"
                                                                          TipoVehiculo

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddMarkupContent(69, "\r\n                            ");
                        __builder4.OpenElement(70, "option");
                        __builder4.AddContent(71, " -- Sin seleccionar -- ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(72, "\r\n                            ");
                        __builder4.OpenElement(73, "option");
                        __builder4.AddContent(74, "Carro");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(75, "\r\n                            ");
                        __builder4.OpenElement(76, "option");
                        __builder4.AddContent(77, "Yipeta");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(78, "\r\n                            ");
                        __builder4.OpenElement(79, "option");
                        __builder4.AddContent(80, "Camioneta");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(81, "\r\n                            ");
                        __builder4.OpenElement(82, "option");
                        __builder4.AddMarkupContent(83, "Camión");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(84, "\r\n                            ");
                        __builder4.OpenElement(85, "option");
                        __builder4.AddContent(86, "Motocicleta");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(87, "\r\n                            ");
                        __builder4.OpenElement(88, "option");
                        __builder4.AddContent(89, "Barco");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(90, "\r\n                            ");
                        __builder4.OpenElement(91, "option");
                        __builder4.AddMarkupContent(92, "Avión");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(93, "\r\n                            ");
                        __builder4.OpenElement(94, "option");
                        __builder4.AddContent(95, "Nave Espacial (space X)");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(96, "\r\n                        ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(97, "\r\n\r\n                        ");
                        __builder4.AddMarkupContent(98, "<label for=\"Capacidad_Carga\" class=\"control-label\">Escriba la capacidad de carga del vehiculo:</label>\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenNumeric<Double>>(99);
                        __builder4.AddAttribute(100, "class", "form-control");
                        __builder4.AddAttribute(101, "id", "Capacidad_Carga");
                        __builder4.AddAttribute(102, "ShowUpDown", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 43 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditVehiculos.razor"
                                                                                                                                                   false

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(103, "Placeholder", "Capacidad_Carga");
                        __builder4.AddAttribute(104, "value", 
#nullable restore
#line 43 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditVehiculos.razor"
                                                                                                              vehiculo.Capacidad_Carga

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddAttribute(105, "valueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vehiculo.Capacidad_Carga = __value, vehiculo.Capacidad_Carga));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(106, "\r\n\r\n                        ");
                        __builder4.AddMarkupContent(107, "<label for=\"Pasajeros\" class=\"control-label\">Escriba la cantidad de pasajeros:</label>\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenNumeric<Int32>>(108);
                        __builder4.AddAttribute(109, "class", "form-control");
                        __builder4.AddAttribute(110, "id", "Pasajeros");
                        __builder4.AddAttribute(111, "ShowUpDown", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 46 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditVehiculos.razor"
                                                                                                                                      false

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(112, "Placeholder", "Pasajeros");
                        __builder4.AddAttribute(113, "value", 
#nullable restore
#line 46 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditVehiculos.razor"
                                                                                                       vehiculo.Pasajeros

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddAttribute(114, "valueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vehiculo.Pasajeros = __value, vehiculo.Pasajeros));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(115, "\r\n\r\n                        ");
                        __builder4.AddMarkupContent(116, "<label for=\"Matricula\" class=\"control-label\">Escriba la matricula del vehiculo:</label>\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenMask>(117);
                        __builder4.AddAttribute(118, "class", "form-control");
                        __builder4.AddAttribute(119, "Mask", "**-*****");
                        __builder4.AddAttribute(120, "Pattern", "[^0-9]");
                        __builder4.AddAttribute(121, "id", "Matricula");
                        __builder4.AddAttribute(122, "Placeholder", "Matricula");
                        __builder4.AddAttribute(123, "value", 
#nullable restore
#line 49 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditVehiculos.razor"
                                                                                                                       vehiculo.Matricula

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddAttribute(124, "valueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vehiculo.Matricula = __value, vehiculo.Matricula));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(125, "\r\n\r\n                        ");
                        __builder4.AddMarkupContent(126, "<label for=\"No_Seguro\" class=\"control-label\">Escriba el número de seguro del vehiculo:</label>\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenTextBox>(127);
                        __builder4.AddAttribute(128, "class", "form-control");
                        __builder4.AddAttribute(129, "id", "No_Seguro");
                        __builder4.AddAttribute(130, "Placeholder", "No_Seguro");
                        __builder4.AddAttribute(131, "value", 
#nullable restore
#line 52 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditVehiculos.razor"
                                                                                         vehiculo.No_Seguro

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddAttribute(132, "valueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vehiculo.No_Seguro = __value, vehiculo.No_Seguro));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(133, "\r\n\r\n                        ");
                        __builder4.AddMarkupContent(134, "<label for=\"Foto\" class=\"control-label\">Inserte la foto del vehiculo:</label>\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenTextBox>(135);
                        __builder4.AddAttribute(136, "class", "form-control");
                        __builder4.AddAttribute(137, "id", "Foto");
                        __builder4.AddAttribute(138, "Placeholder", "Foto");
                        __builder4.AddAttribute(139, "value", 
#nullable restore
#line 55 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditVehiculos.razor"
                                                                                    vehiculo.Foto

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddAttribute(140, "valueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vehiculo.Foto = __value, vehiculo.Foto));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(141, "\r\n\r\n                        ");
                        __builder4.AddMarkupContent(142, "<label for=\"Latitud\" class=\"control-label\">Escriba la Latitud del vehiculo:</label>\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenNumeric<Double>>(143);
                        __builder4.AddAttribute(144, "class", "form-control");
                        __builder4.AddAttribute(145, "id", "Latitud");
                        __builder4.AddAttribute(146, "ShowUpDown", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 58 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditVehiculos.razor"
                                                                                                                                   false

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(147, "Placeholder", "Latitud");
                        __builder4.AddAttribute(148, "value", 
#nullable restore
#line 58 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditVehiculos.razor"
                                                                                                      vehiculo.Latitud

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddAttribute(149, "valueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vehiculo.Latitud = __value, vehiculo.Latitud));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(150, "\r\n\r\n                        ");
                        __builder4.AddMarkupContent(151, "<label for=\"Longitud\" class=\"control-label\">Escriba la Longitud del vehiculo:</label>\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenNumeric<Double>>(152);
                        __builder4.AddAttribute(153, "class", "form-control");
                        __builder4.AddAttribute(154, "id", "Longitud");
                        __builder4.AddAttribute(155, "ShowUpDown", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 61 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditVehiculos.razor"
                                                                                                                                     false

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(156, "Placeholder", "Longitud");
                        __builder4.AddAttribute(157, "value", 
#nullable restore
#line 61 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditVehiculos.razor"
                                                                                                       vehiculo.Longitud

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddAttribute(158, "valueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vehiculo.Longitud = __value, vehiculo.Longitud));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(159, "\r\n\r\n                    ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(160, "\r\n\r\n");
#nullable restore
#line 65 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditVehiculos.razor"
                     if (ValidarInputs)
                    {

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(161, "                        ");
                        __builder4.OpenElement(162, "div");
                        __builder4.AddAttribute(163, "class", "alert alert-danger");
                        __builder4.AddMarkupContent(164, "\r\n                            ");
                        __builder4.AddContent(165, 
#nullable restore
#line 68 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditVehiculos.razor"
                             MensajeError

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddMarkupContent(166, "\r\n                        ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(167, "\r\n");
#nullable restore
#line 70 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditVehiculos.razor"
                    }

#line default
#line hidden
#nullable disable
                        __builder4.AddMarkupContent(168, "\r\n                    ");
                        __builder4.OpenElement(169, "div");
                        __builder4.AddAttribute(170, "class", "d-grid gap-2");
                        __builder4.AddMarkupContent(171, "\r\n                        ");
                        __builder4.OpenElement(172, "button");
                        __builder4.AddAttribute(173, "type", "button");
                        __builder4.AddAttribute(174, "class", "btn btn-success btn-block");
                        __builder4.AddAttribute(175, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditVehiculos.razor"
                                                                                          () => UpdateVehiculos()

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddContent(176, "Editar");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(177, "\r\n                        ");
                        __builder4.OpenElement(178, "button");
                        __builder4.AddAttribute(179, "type", "button");
                        __builder4.AddAttribute(180, "class", "btn btn-danger btn-block");
                        __builder4.AddAttribute(181, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 74 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditVehiculos.razor"
                                                                                         () => cancel()

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddContent(182, "Cancelar");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(183, "\r\n                    ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(184, "\r\n\r\n                ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(185, "\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(186, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(187, "\r\n        ");
                __builder2.OpenElement(188, "div");
                __builder2.AddAttribute(189, "class", "col-md-6");
                __builder2.AddMarkupContent(190, "\r\n            <br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br>\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenCard>(191);
                __builder2.AddAttribute(192, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(193, "\r\n                ");
                    __builder3.OpenElement(194, "p");
                    __builder3.AddContent(195, 
#nullable restore
#line 83 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditVehiculos.razor"
                    vehiculo.ID_Institucion

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(196, "\r\n                ");
                    __builder3.AddMarkupContent(197, "<h3 class=\"text-center\">Seleccione su latitud y longitud</h3>\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGoogleMap>(198);
                    __builder3.AddAttribute(199, "style", "height: 400px");
                    __builder3.AddAttribute(200, "Zoom", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 85 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditVehiculos.razor"
                                                             zoom

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(201, "Center", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.GoogleMapPosition>(
#nullable restore
#line 85 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditVehiculos.razor"
                                                                           new GoogleMapPosition() { Lat = 18.94983041735482, Lng = -70.74993105485618 }

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(202, "MapClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.GoogleMapClickEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.GoogleMapClickEventArgs>(this, 
#nullable restore
#line 85 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditVehiculos.razor"
                                                                                                                                                                    OnMapClick

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(203, "\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(204, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(205, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(206, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 91 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\EditVehiculos.razor"
        
    //Id que se recibe como parametro
    [Parameter]
    public string ID { get; set; }

    //Variables para validar los campos de los inputs
    string MensajeError;
    bool ValidarInputs = false;

    //String del Select
    String TipoDelVehiculo = "-- Sin seleccionar --";

    //String del id de la institucion
    string id;

    //Instancia de la Clase Vehiculo
    Vehiculos vehiculo = new Vehiculos();

    //Variable de tipo int, para manejar el zoom del mapa
    int zoom = 6;

    //Metodo que cuando se carga la vista, el mismo carga por medio del ID cada uno de los impus
    protected override async Task OnInitializedAsync()
    {
        //Se obtiene el ID por medio del LocalStorage
        TipoDelVehiculo = vehiculo.Tipo;
        String name = await localStorage.GetItemAsync<string>("ID_Institucion");
        vehiculo.ID_Institucion = name;
        vehiculo = await VehiculosManager.GetById(Convert.ToInt32(ID), vehiculo.ID_Institucion);
    }

    //Metodo para actualizar los vehiculos
    protected async Task UpdateVehiculos()
    {
        vehiculo.Tipo = TipoDelVehiculo;

        //If, para validar los campos de los inputs
        if (vehiculo.Marca == null || vehiculo.Modelo == null || vehiculo.Año == null || vehiculo.Color == null || vehiculo.Precio_Dia == 0 || vehiculo.Tipo == "-- Sin seleccionar --" || vehiculo.Capacidad_Carga == 0 || vehiculo.Matricula == null || vehiculo.No_Seguro == null || vehiculo.Foto == null || vehiculo.Latitud == 0 || vehiculo.Longitud == 0)
        {
            MensajeError = "Todos los campos son necesarios...";
            ValidarInputs = true;
            return;
        }
        await VehiculosManager.Update(vehiculo);
        navigationManager.NavigateTo("/CRUDVehiculos");
    }

    //Metodo para cancelar y volver a la lista de los Vehiculos
    void cancel()
    {
        navigationManager.NavigateTo("/CRUDVehiculos");
    }

    //Metodo para manejar el select de los tipos de Vehiculos
    public void TipoVehiculo(ChangeEventArgs e)
    {
        TipoDelVehiculo = e.Value.ToString();
    }

    //Metodo para manejar el click del mapa
    void OnMapClick(GoogleMapClickEventArgs args)
    {
        //Variables que cambian de valor cuando al mapa se le da un click en la Latitud y Longitud Deseada
        vehiculo.Latitud = args.Position.Lat;
        vehiculo.Longitud = args.Position.Lng;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IVehiculosManager VehiculosManager { get; set; }
    }
}
#pragma warning restore 1591
