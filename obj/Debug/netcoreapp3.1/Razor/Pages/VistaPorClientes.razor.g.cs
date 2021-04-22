#pragma checksum "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\VistaPorClientes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99995f838a69022485caed333f46ce34cd9fb774"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/BeneficioDeuda")]
    public partial class VistaPorClientes : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n  \r\n        ");
                __builder2.AddMarkupContent(3, "<header>\r\n            <h1 class=\"text-center\">Listado de los Clientes</h1>\r\n            <hr>\r\n        </header>\r\n\r\n          ");
                __builder2.AddMarkupContent(4, "<div class=\"row\">\r\n            <div class=\"col-md-6\">\r\n                <a class=\"btn btn-primary\" href=\"/Beneficios\"><i class=\"fas fa-backward\"></i>  Volver atrás</a>\r\n            </div>\r\n        </div>\r\n\r\n        <br>\r\n        ");
                __builder2.OpenElement(5, "table");
                __builder2.AddAttribute(6, "class", "table table-bordered table-hover table-striped");
                __builder2.AddAttribute(7, "id", "example");
                __builder2.AddMarkupContent(8, "\r\n            ");
                __builder2.AddMarkupContent(9, @"<thead class=""thead-dark"">
                <tr>
                    <th>ID</th>
                    <th>Cedula</th>
                    <th>Nombre</th>
                    <th>Apellido</th>
                    <th>Codigo Factura</th>
                    <th>Monto Pendiente</th>
                    <th>Vehiculo</th>
                    <th>Tipo</th>
                    <th>Matricula</th>
                </tr>
            </thead>
            ");
                __builder2.OpenElement(10, "tbody");
                __builder2.AddMarkupContent(11, "\r\n");
#nullable restore
#line 36 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\VistaPorClientes.razor"
                 if (FacturaModels == null)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(12, "                    ");
                __builder2.AddMarkupContent(13, "<tr>\r\n                        <td colspan=\"12\">\r\n                            No Records to display\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 43 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\VistaPorClientes.razor"
                }
                else
                {
                    foreach (var cliente in FacturaModels)
                    {
                        if(cliente.Monto_pagar >= 1)
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(14, "                        ");
                __builder2.OpenElement(15, "tr");
                __builder2.AddMarkupContent(16, "\r\n                            ");
                __builder2.OpenElement(17, "td");
                __builder2.AddContent(18, 
#nullable restore
#line 51 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\VistaPorClientes.razor"
                                 cliente.ID_Cliente

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n                            ");
                __builder2.OpenElement(20, "td");
                __builder2.AddContent(21, 
#nullable restore
#line 52 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\VistaPorClientes.razor"
                                 cliente.Cedula_Cliente

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n                            ");
                __builder2.OpenElement(23, "td");
                __builder2.AddContent(24, 
#nullable restore
#line 53 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\VistaPorClientes.razor"
                                 cliente.Nombre_Cliente

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n                            ");
                __builder2.OpenElement(26, "td");
                __builder2.AddContent(27, 
#nullable restore
#line 54 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\VistaPorClientes.razor"
                                 cliente.Apellido_Cliente

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n                            ");
                __builder2.OpenElement(29, "td");
                __builder2.AddContent(30, 
#nullable restore
#line 55 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\VistaPorClientes.razor"
                                 cliente.ID_Factura

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                            ");
                __builder2.OpenElement(32, "td");
                __builder2.AddContent(33, 
#nullable restore
#line 56 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\VistaPorClientes.razor"
                                 cliente.Monto_pagar.ToString("C",new CultureInfo("es-DO"))

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n                            ");
                __builder2.OpenElement(35, "td");
                __builder2.AddContent(36, 
#nullable restore
#line 57 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\VistaPorClientes.razor"
                                 cliente.Marca

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n                            ");
                __builder2.OpenElement(38, "td");
                __builder2.AddContent(39, 
#nullable restore
#line 58 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\VistaPorClientes.razor"
                                 cliente.Tipo

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n                            ");
                __builder2.OpenElement(41, "td");
                __builder2.AddContent(42, 
#nullable restore
#line 59 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\VistaPorClientes.razor"
                                 cliente.Matricula

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n");
#nullable restore
#line 61 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\VistaPorClientes.razor"
                        }
                        
                    }
                }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(45, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\VistaPorClientes.razor"
       

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
        String name = await localStorage.GetItemAsync<string>("ID_Institucion");
        FacturaModels = await ReservaManager.ListAll(name);
    }

    //Metodos para poder implementar el Datatable
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await JSRuntime.InvokeAsync<object>("TestDataTablesAdd", "#example");
    }

    void IDisposable.Dispose()
    {
        JSRuntime.InvokeAsync<object>("TestDataTablesRemove", "#example");
    }

    protected  async Task ModuloPago(string id,double pago,string nombre, string apellido)
    {
        ID = id;
        valor = pago;
        SeleccionFactura = true;
        Nombre = nombre;
        Apellido = apellido;
        //await ReservaManager.AltualizarPago(id,pago);

    }
    protected  async Task EnviarRestante()
    {
        double Restante = valor - Convert.ToDouble(ValoPagado);

        await ReservaManager.AltualizarPago(ID,Restante);

        String name = await localStorage.GetItemAsync<string>("ID_Institucion");
        FacturaModels = await ReservaManager.ListAll(name);

        SeleccionFactura = false;
        ValoPagado = 0;

    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IReservaManager ReservaManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClientesManager ClientesManager { get; set; }
    }
}
#pragma warning restore 1591
