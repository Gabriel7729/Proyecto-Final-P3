#pragma checksum "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\VistaPorMapa.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35b11bcb6ff1fcc2b17cd4bc46b56e15803b6686"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/BeneficiosMapa")]
    public partial class VistaPorMapa : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<header>\r\n            <h1 class=\"text-center\">Listado de  Mapa</h1>\r\n            <hr>\r\n        </header>\r\n\r\n        ");
            __builder.AddMarkupContent(1, "<h3 class=\"text-center\">Seleccione su latitud y longitud</h3>\r\n\r\n        ");
            __builder.OpenComponent<Radzen.Blazor.RadzenGoogleMap>(2);
            __builder.AddAttribute(3, "style", "height: 400px;");
            __builder.AddAttribute(4, "Zoom", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 16 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\VistaPorMapa.razor"
                                                      zoom

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "Center", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.GoogleMapPosition>(
#nullable restore
#line 16 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\VistaPorMapa.razor"
                                                                    new GoogleMapPosition() { Lat = 18.94983041735482, Lng = -70.74993105485618 }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "MapClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.GoogleMapClickEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.GoogleMapClickEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\VistaPorMapa.razor"
                                                                                                                                                             OnMapClick

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "Markers", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(8, " \r\n            ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\a\OneDrive\Escritorio\PF\Proyecto-Final-P3\Pages\VistaPorMapa.razor"
          

        string foto;
        string marca;
        string modelo;
        string color;
        string año;

        int zoom = 6;

         //Instancia una lista de la clase de vehiculos
        List<Vehiculos> VehiculosModel;

        //Instancia de la clase Vehiculos
        Vehiculos VehiculosEntity = new Vehiculos();

         //Metodo que se ejecuta de inicio y que muestra la lista de los vehiculos, filtrandola por el id de institucion
        protected override async Task OnInitializedAsync()
        {
            String name = await localStorage.GetItemAsync<string>("ID_Institucion");
            VehiculosModel = await VehiculosManager.ListAll(name);
        }

            //Metodo para manejar el click del mapa
        void OnMapClick(GoogleMapClickEventArgs args)
        {
  
        }

        void OnMarkerClick(RadzenGoogleMapMarker marker)
        {
            foreach (var vehiculo in VehiculosModel)
            {
                if( vehiculo.Marca == marker.Title)
                {
                        foto = vehiculo.Foto;
                        marca = vehiculo.Marca;
                        modelo = vehiculo.Modelo;
                        año = vehiculo.Año;
                        color = vehiculo.Color;
                }
            }
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
