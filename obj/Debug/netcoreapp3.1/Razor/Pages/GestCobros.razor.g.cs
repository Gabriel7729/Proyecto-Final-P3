#pragma checksum "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\Pages\GestCobros.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "535d0f3684c102116b21ace7c19332722b4b0753"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/AnularRegistro")]
    public partial class GestCobros : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n\r\n    ");
                __builder2.AddMarkupContent(3, "<header>\r\n        <h1 class=\"text-center\">Listado de los Clientes</h1>\r\n        <hr>\r\n    </header>\r\n    <br>\r\n    ");
                __builder2.OpenElement(4, "table");
                __builder2.AddAttribute(5, "class", "table table-bordered table-hover table-striped");
                __builder2.AddAttribute(6, "id", "example");
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.AddMarkupContent(8, @"<thead class=""thead-dark"">
            <tr>
                <th>ID</th>
                <th>Cedula</th>
                <th>Nombre</th>
                <th>Apellido</th>
                <th>Fecha Inicio</th>
                <th>Fecha Fin</th>
                <th>Monto Pendiente</th>
                <th>Info Vehiculo</th>
                <th>Accion</th>
            </tr>
        </thead>
        ");
                __builder2.OpenElement(9, "tbody");
                __builder2.AddMarkupContent(10, "\r\n");
#nullable restore
#line 34 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\Pages\GestCobros.razor"
             if (FacturaModels == null)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(11, "                ");
                __builder2.AddMarkupContent(12, "<tr>\r\n                    <td colspan=\"12\">\r\n                        No Records to display\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 41 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\Pages\GestCobros.razor"
            }
            else
            {
                foreach (var cliente in FacturaModels)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(13, "                    ");
                __builder2.OpenElement(14, "tr");
                __builder2.AddMarkupContent(15, "\r\n                        ");
                __builder2.OpenElement(16, "td");
                __builder2.AddContent(17, 
#nullable restore
#line 47 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\Pages\GestCobros.razor"
                             cliente.ID_Factura

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n                        ");
                __builder2.OpenElement(19, "td");
                __builder2.AddContent(20, 
#nullable restore
#line 48 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\Pages\GestCobros.razor"
                             cliente.Cedula_Cliente

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n                        ");
                __builder2.OpenElement(22, "td");
                __builder2.AddContent(23, 
#nullable restore
#line 49 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\Pages\GestCobros.razor"
                             cliente.Nombre_Cliente

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n                        ");
                __builder2.OpenElement(25, "td");
                __builder2.AddContent(26, 
#nullable restore
#line 50 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\Pages\GestCobros.razor"
                             cliente.Apellido_Cliente

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n                        ");
                __builder2.OpenElement(28, "td");
                __builder2.AddContent(29, 
#nullable restore
#line 51 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\Pages\GestCobros.razor"
                             cliente.Fecha_Inc

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                        ");
                __builder2.OpenElement(31, "td");
                __builder2.AddContent(32, 
#nullable restore
#line 52 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\Pages\GestCobros.razor"
                             cliente.Fecha_Fin

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n                        ");
                __builder2.OpenElement(34, "td");
                __builder2.AddContent(35, 
#nullable restore
#line 53 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\Pages\GestCobros.razor"
                             cliente.Monto_pagar.ToString("C", new CultureInfo("es-DO"))

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n                        ");
                __builder2.OpenElement(37, "td");
                __builder2.AddMarkupContent(38, "\r\n                            ");
                __builder2.AddContent(39, 
#nullable restore
#line 55 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\Pages\GestCobros.razor"
                             cliente.Tipo

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(40, "\r\n                            ");
                __builder2.AddContent(41, 
#nullable restore
#line 56 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\Pages\GestCobros.razor"
                             cliente.Marca

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(42, " <br>\r\n                            ");
                __builder2.AddContent(43, 
#nullable restore
#line 57 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\Pages\GestCobros.razor"
                             cliente.Matricula

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(44, " <br>\r\n\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n                        ");
                __builder2.OpenElement(46, "td");
                __builder2.AddMarkupContent(47, "\r\n");
#nullable restore
#line 61 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\Pages\GestCobros.razor"
                             if (cliente.Monto_pagar <= 0)
                            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(48, "                                ");
                __builder2.AddMarkupContent(49, "<div class=\"alert alert-success text-center\">Pagada</div>\r\n");
#nullable restore
#line 64 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\Pages\GestCobros.razor"

                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(50, "                                ");
                __builder2.OpenElement(51, "button");
                __builder2.AddAttribute(52, "class", "btn btn-warning btn-block");
                __builder2.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 68 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\Pages\GestCobros.razor"
                                                                                    () => ModuloPago(cliente.ID_Factura, cliente.Monto_pagar,cliente.Nombre_Cliente,cliente.Apellido_Cliente)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(54, "Pagar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n");
#nullable restore
#line 69 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\Pages\GestCobros.razor"

                            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(56, "                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n");
#nullable restore
#line 73 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\Pages\GestCobros.razor"
                }
            }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(59, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n    <br>\r\n    <br>\r\n    <br>\r\n");
#nullable restore
#line 81 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\Pages\GestCobros.razor"
     if (SeleccionFactura)
    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(62, "        ");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "container");
                __builder2.AddAttribute(65, "style", "position:fixed;left:40%;padding-top:10%");
                __builder2.AddMarkupContent(66, "\r\n            ");
                __builder2.OpenElement(67, "div");
                __builder2.AddAttribute(68, "class", "row");
                __builder2.AddMarkupContent(69, "\r\n                ");
                __builder2.OpenElement(70, "div");
                __builder2.AddAttribute(71, "class", "col-md-4 shadow border rounded");
                __builder2.AddAttribute(72, "style", "background-color:aquamarine; padding-top:10px");
                __builder2.AddMarkupContent(73, "\r\n                    ");
                __builder2.OpenElement(74, "h5");
                __builder2.AddAttribute(75, "class", "text-center");
                __builder2.AddContent(76, 
#nullable restore
#line 86 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\Pages\GestCobros.razor"
                                             Nombre

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(77, " ");
                __builder2.AddContent(78, 
#nullable restore
#line 86 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\Pages\GestCobros.razor"
                                                     Apellido

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(79, " debe un total de ");
                __builder2.AddContent(80, 
#nullable restore
#line 86 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\Pages\GestCobros.razor"
                                                                                valor

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n                    ");
                __builder2.AddMarkupContent(82, "<label>Monto a pagar</label>\r\n                    ");
                __builder2.OpenElement(83, "input");
                __builder2.AddAttribute(84, "class", "form-check form-control");
                __builder2.AddAttribute(85, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 88 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\Pages\GestCobros.razor"
                                         ValoPagado

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(86, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ValoPagado = __value, ValoPagado));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n                    <br>\r\n                    ");
                __builder2.OpenElement(88, "button");
                __builder2.AddAttribute(89, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 90 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\Pages\GestCobros.razor"
                                      ()=> EnviarRestante()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(90, "class", "btn btn-success btn-block");
                __builder2.AddContent(91, "Pagar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n                    <br>\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n");
#nullable restore
#line 95 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\Pages\GestCobros.razor"
    }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 99 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\Pages\GestCobros.razor"
       

    int Open = 0;
    bool SeleccionFactura = false;
    String MSJ;
    String ID;
    double valor;
    double ValoPagado;

    String Nombre;
    String Apellido;
    //Instancia una lista de la clase de Clientes
    List<Factura> FacturaModels;

    //Instancia de la clase Clientes
    Factura FacturaEntity = new Factura();

    //Metodo para borrar un Cliente con los parametros del ID normal y el ID de institucion
    protected async Task DeleteClientes(int id, string id_institucion)
    {
        await ClientesManager.Delete(id, id_institucion);
        // ClientesModel = await ClientesManager.ListarClientes(id_institucion);
    }

    //Metodo que se ejecuta de inicio y que muestra la lista de los Clientes, filtrandola por el id de institucion
    protected override async Task OnInitializedAsync()
    {

    }

    //Metodos para poder implementar el Datatable
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            if (!await localStorage.ContainKeyAsync("ID_login"))
            {
                navigationManager.NavigateTo("/Main");
            }

            String name = await localStorage.GetItemAsync<string>("ID_Institucion");
            FacturaModels = await ReservaManager.ListAll(name);
            StateHasChanged();
        }
        await JSRuntime.InvokeAsync<object>("TestDataTablesAdd", "#example");
    }

    void IDisposable.Dispose()
    {
        JSRuntime.InvokeAsync<object>("TestDataTablesRemove", "#example");
    }

    protected async Task ModuloPago(string id, double pago, string nombre, string apellido)
    {
        ID = id;
        valor = pago;
        SeleccionFactura = true;
        Nombre = nombre;
        Apellido = apellido;
        //await ReservaManager.AltualizarPago(id,pago);

    }
    protected async Task EnviarRestante()
    {
        double Restante = valor - Convert.ToDouble(ValoPagado);

        await ReservaManager.AltualizarPago(ID, Restante);

        String name = await localStorage.GetItemAsync<string>("ID_Institucion");
        FacturaModels = await ReservaManager.ListAll(name);

        SeleccionFactura = false;
        ValoPagado = 0;

    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IReservaManager ReservaManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClientesManager ClientesManager { get; set; }
    }
}
#pragma warning restore 1591
