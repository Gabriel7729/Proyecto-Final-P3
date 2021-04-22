#pragma checksum "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\ListadoVehiculosDeshabilitados.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70272d8fa0bea9aafe5cd2a75eee25a470ecba05"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/ListadoVehiculosDeshabilitados")]
    public partial class ListadoVehiculosDeshabilitados : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        ");
                __builder2.AddMarkupContent(3, "<header>\r\n            <h1 class=\"text-center\">Listado de Vehiculos deshabilitados</h1>\r\n            <hr>\r\n        </header>\r\n\r\n        ");
                __builder2.OpenElement(4, "table");
                __builder2.AddAttribute(5, "class", "table table-bordered table-hover");
                __builder2.AddAttribute(6, "id", "example");
                __builder2.AddMarkupContent(7, "\r\n            ");
                __builder2.AddMarkupContent(8, @"<thead class=""thead-dark"">
                <tr>
                    <th>ID</th>
                    <th>Marca</th>
                    <th>Modelo</th>
                    <th>Año</th>
                    <th>Color</th>
                    <th>Precio_Dia</th>
                    <th>Tipo</th>
                    <th>Cap_Carga</th>
                    <th>Pasajeros</th>
                    <th>Matricula</th>
                    <th>No_Seguro</th>
                    <th>Acciones</th>
                </tr>
            </thead>
            ");
                __builder2.OpenElement(9, "tbody");
                __builder2.AddMarkupContent(10, "\r\n");
#nullable restore
#line 31 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\ListadoVehiculosDeshabilitados.razor"
                 if (VehiculosModel == null)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(11, "                    ");
                __builder2.AddMarkupContent(12, "<tr>\r\n                        <td colspan=\"12\">\r\n                            No Records to display\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 38 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\ListadoVehiculosDeshabilitados.razor"
                }
                else
                {
                    foreach (var vehiculo in VehiculosModel)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(13, "                        ");
                __builder2.OpenElement(14, "tr");
                __builder2.AddMarkupContent(15, "\r\n                            ");
                __builder2.OpenElement(16, "td");
                __builder2.AddContent(17, 
#nullable restore
#line 44 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\ListadoVehiculosDeshabilitados.razor"
                                 vehiculo.ID

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n                            ");
                __builder2.OpenElement(19, "td");
                __builder2.AddContent(20, 
#nullable restore
#line 45 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\ListadoVehiculosDeshabilitados.razor"
                                 vehiculo.Marca

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n                            ");
                __builder2.OpenElement(22, "td");
                __builder2.AddContent(23, 
#nullable restore
#line 46 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\ListadoVehiculosDeshabilitados.razor"
                                 vehiculo.Modelo

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n                            ");
                __builder2.OpenElement(25, "td");
                __builder2.AddContent(26, 
#nullable restore
#line 47 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\ListadoVehiculosDeshabilitados.razor"
                                 vehiculo.Año

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n                            ");
                __builder2.OpenElement(28, "td");
                __builder2.AddContent(29, 
#nullable restore
#line 48 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\ListadoVehiculosDeshabilitados.razor"
                                 vehiculo.Color

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                            ");
                __builder2.OpenElement(31, "td");
                __builder2.AddContent(32, 
#nullable restore
#line 49 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\ListadoVehiculosDeshabilitados.razor"
                                 vehiculo.Precio_Dia.ToString("C", new CultureInfo("es-DO"))

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n                            ");
                __builder2.OpenElement(34, "td");
                __builder2.AddContent(35, 
#nullable restore
#line 50 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\ListadoVehiculosDeshabilitados.razor"
                                 vehiculo.Tipo

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n                            ");
                __builder2.OpenElement(37, "td");
                __builder2.AddContent(38, 
#nullable restore
#line 51 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\ListadoVehiculosDeshabilitados.razor"
                                 vehiculo.Capacidad_Carga

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(39, " Kg");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n                            ");
                __builder2.OpenElement(41, "td");
                __builder2.AddContent(42, 
#nullable restore
#line 52 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\ListadoVehiculosDeshabilitados.razor"
                                 vehiculo.Pasajeros

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n                            ");
                __builder2.OpenElement(44, "td");
                __builder2.AddContent(45, 
#nullable restore
#line 53 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\ListadoVehiculosDeshabilitados.razor"
                                 vehiculo.Matricula

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n                            ");
                __builder2.OpenElement(47, "td");
                __builder2.AddContent(48, 
#nullable restore
#line 54 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\ListadoVehiculosDeshabilitados.razor"
                                 vehiculo.No_Seguro

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n                            ");
                __builder2.OpenElement(50, "td");
                __builder2.AddMarkupContent(51, "\r\n                                ");
                __builder2.OpenElement(52, "a");
                __builder2.AddAttribute(53, "href", "/HabilitarVehiculos/" + (
#nullable restore
#line 56 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\ListadoVehiculosDeshabilitados.razor"
                                                              vehiculo.ID

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(54, "<i style=\"color:lawngreen;\" class=\"far fa-check-square\"></i>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, " |\r\n                                ");
                __builder2.OpenElement(56, "a");
                __builder2.AddAttribute(57, "href", "/ListadoVehiculosDeshabilitados");
                __builder2.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\ListadoVehiculosDeshabilitados.razor"
                                                                                    () => DeleteVehiculos(vehiculo.ID, vehiculo.ID_Institucion)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(59, "<i style=\"color:red;\" class=\"fas fa-trash-alt\"></i>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n");
#nullable restore
#line 60 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\ListadoVehiculosDeshabilitados.razor"
                    }
                }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(63, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n        <br>\r\n        ");
                __builder2.AddMarkupContent(66, "<div>\r\n            <center>\r\n                <a class=\"btn btn-primary\" href=\"/CRUDVehiculos\"><i class=\"fas fa-backward\"></i>  Volver atrás</a>\r\n            </center>\r\n        </div>\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\ListadoVehiculosDeshabilitados.razor"
           

        //Instancia una lista de la clase de vehiculos
        List<Vehiculos> VehiculosModel;

        //Instancia de la clase Vehiculos
        Vehiculos VehiculosEntity = new Vehiculos();

        //Metodo para borrar un vehiculo con los parametros del ID normal y el ID de institucion
        protected async Task DeleteVehiculos(int id, string id_institucion)
        {
            await VehiculosManager.Delete(id, id_institucion);
            VehiculosModel = await VehiculosManager.ListarVehiculosDeshabilitados(id_institucion);
        }

        //Metodo que se ejecuta de inicio y que muestra la lista de los vehiculos, filtrandola por el id de institucion
        protected override async Task OnInitializedAsync()
        {
            String name = await localStorage.GetItemAsync<string>("ID_Institucion");
            VehiculosModel = await VehiculosManager.ListarVehiculosDeshabilitados(name);
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

    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IVehiculosManager VehiculosManager { get; set; }
    }
}
#pragma warning restore 1591
