#pragma checksum "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\Pages\HabilitarClientes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1355e0cb251f524fea3d7e4f693a1c1e426f360e"
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
#line 1 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\_Imports.razor"
using PtoyectoFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\_Imports.razor"
using PtoyectoFinal.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\_Imports.razor"
using PtoyectoFinal.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\_Imports.razor"
using PtoyectoFinal.Contracts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\_Imports.razor"
using PtoyectoFinal.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\_Imports.razor"
using PtoyectoFinal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\_Imports.razor"
using PtoyectoFinal.DataAccess;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\_Imports.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/HabilitarClientes/{ID}")]
    public partial class HabilitarClientes : Microsoft.AspNetCore.Components.ComponentBase
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
                __builder2.OpenElement(6, "center");
                __builder2.AddMarkupContent(7, "\r\n            ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "col-md-8");
                __builder2.AddMarkupContent(10, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenCard>(11);
                __builder2.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(13, "\r\n                    ");
                    __builder3.OpenElement(14, "h1");
                    __builder3.AddAttribute(15, "class", "text-center");
                    __builder3.AddContent(16, "Habilitar Vehiculo ");
                    __builder3.AddContent(17, 
#nullable restore
#line 12 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\Pages\HabilitarClientes.razor"
                                                                clientes.Nombre

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(18, " ");
                    __builder3.AddContent(19, 
#nullable restore
#line 12 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\Pages\HabilitarClientes.razor"
                                                                                 clientes.Apellido

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(20, "\r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTemplateForm<Clientes>>(21);
                    __builder3.AddAttribute(22, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Clientes>(
#nullable restore
#line 13 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\Pages\HabilitarClientes.razor"
                                                               clientes

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(23, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Clientes>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Clientes>(this, 
#nullable restore
#line 13 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\Pages\HabilitarClientes.razor"
                                                                                HabilitarCliente

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(24, "InvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.FormInvalidSubmitEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.FormInvalidSubmitEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\Pages\HabilitarClientes.razor"
                                                                                                                HabilitarCliente

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder4) => {
                        __builder4.AddMarkupContent(26, "\r\n\r\n                        ");
                        __builder4.AddMarkupContent(27, "<h3 class=\"text-center\">¿Está seguro de que quiere Habilitar este Vehiculo?</h3>\r\n\r\n                        ");
                        __builder4.OpenElement(28, "div");
                        __builder4.AddAttribute(29, "class", "d-grid gap-2");
                        __builder4.AddMarkupContent(30, "\r\n                            ");
                        __builder4.OpenElement(31, "button");
                        __builder4.AddAttribute(32, "type", "button");
                        __builder4.AddAttribute(33, "class", "btn btn-info btn-block");
                        __builder4.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\Pages\HabilitarClientes.razor"
                                                                                           () => HabilitarCliente()

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddContent(35, "Habilitar");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(36, "\r\n                            ");
                        __builder4.OpenElement(37, "button");
                        __builder4.AddAttribute(38, "type", "button");
                        __builder4.AddAttribute(39, "class", "btn btn-danger btn-block");
                        __builder4.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\Pages\HabilitarClientes.razor"
                                                                                             () => cancel()

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddContent(41, "Cancelar");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(42, "\r\n                        ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(43, "\r\n\r\n                    ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(44, "\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(45, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\Pages\HabilitarClientes.razor"
        
    //Id que se recibe como parametro
    [Parameter]
    public string ID { get; set; }

    //Instancia de la Clase Clientes
    Clientes clientes = new Clientes();

    //Metodo que cuando se carga la vista, el mismo carga por medio del ID cada uno de los inputs
    protected override async Task OnInitializedAsync()
    {
        //Se obtiene el ID por medio del LocalStorage
        String name = await localStorage.GetItemAsync<string>("ID_Institucion");
        clientes.ID_Institucion = name;
        clientes = await ClientesManager.GetById(Convert.ToInt32(ID), clientes.ID_Institucion);
    }

    //Metodo para actualizar los clientes
    protected async Task HabilitarCliente()
    {
        clientes.Estado = "Habilitado";
        await ClientesManager.HabilitarCliente(clientes);
        navigationManager.NavigateTo("/CRUDClientes");
    }

    //Metodo para cancelar y volver a la lista de los clientes
    void cancel()
    {
        navigationManager.NavigateTo("/CRUDClientes");
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
