#pragma checksum "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7950ac939c7bd06170f22761492897b579fdae56"
// <auto-generated/>
#pragma warning disable 1591
namespace PtoyectoFinal.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<PtoyectoFinal.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "id", "main");
            __builder.AddAttribute(7, "class", "main");
            __builder.AddMarkupContent(8, "\r\n\r\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "conten");
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "nav");
            __builder.AddAttribute(13, "class", "navbar navbar-expand-lg navbar-light bg-dark rounded");
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.AddMarkupContent(15, @"<a class=""navbar-brand"" href style=""font-size:2.5rem; color:white;"">
                    <img src=""images/Rapid Car Logo.PNG"" width=""100"" height=""50"" class=""d-inline-block align-top"" alt loading=""lazy"">
                    <strong>Rapid <span style=""color:  #db1212;"">Car</span></strong>
                </a>
                ");
            __builder.AddMarkupContent(16, @"<div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
                    <ul class=""nav navbar-nav ml-auto"">
                        <li class=""nav-item active"" style=""font-size:1.5rem;"">

                        </li>
                    </ul>
                </div>
                ");
            __builder.OpenElement(17, "a");
            __builder.AddAttribute(18, "href", "/login");
            __builder.AddAttribute(19, "class", "text-white");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\Shared\MainLayout.razor"
                                                               Cerrar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(21, "<strong>Cerrar Seccion</strong>");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                \r\n\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\r\n            <br>\r\n\r\n            ");
            __builder.AddContent(24, 
#nullable restore
#line 32 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(25, "\r\n\r\n            <br>\r\n\r\n            ");
            __builder.AddMarkupContent(26, "<footer class=\"footer-distributed rounded\">\r\n\r\n                <div class=\"footer-left\">\r\n                    <h3>Rapid <span>Car</span></h3>\r\n\r\n                    <p class=\"footer-links\">\r\n                        <a href=\"#Home\">Home</a>\r\n                        ·\r\n                        <a href=\"#Blog\">Blog</a>\r\n                        ·\r\n                        <a href=\"#Contenido\">Contenido</a>\r\n                        ·\r\n                        <a href=\"#Sobre\">Sobre</a>\r\n                        ·\r\n                        <a href=\"#Contacto\">Contacto</a>\r\n                    </p>\r\n\r\n                    <p class=\"footer-company-name\">Rapid_Car © 2021</p>\r\n\r\n                    <div class=\"footer-icons\">\r\n\r\n                        <a href=\"https://www.facebook.com/gabrielernesto.delarosapaniagua\" Target=\"_blank\"><i class=\"fab fa-facebook\"></i></a>\r\n                        <a href Target=\"_blank\"><i class=\"fab fa-twitter\"></i></a>\r\n                        <a href=\"https://www.instagram.com/gabriel_7729/\" Target=\"_blank\"><i class=\"fab fa-instagram\"></i></a>\r\n                        <a href=\"https://github.com/Lusan7729/Proyecto-Final-P3\" Target=\"_blank\"><i class=\"fab fa-github\"></i></a>\r\n\r\n                    </div>\r\n\r\n                </div>\r\n\r\n                <div class=\"footer-center\">\r\n                    <div class=\"footer-icons\">\r\n                        <a><i class=\"fas fa-map-marker-alt\"></i></a>\r\n                        <p><span>444 S. Cedros Ave</span> Solana Beach, California</p>\r\n                        <br><br><br>\r\n\r\n                        <a><i class=\"fas fa-phone\"></i></a>\r\n                        <p>809-894-8877</p>\r\n                        <br><br><br>\r\n\r\n                        <a><i class=\"far fa-envelope\"></i></a>\r\n                        <p><a style=\"background-color:rgb(39, 38, 38);\" href=\"mailto:equiposuperE@gmail.com\">equiposuperE@gmail.com</a></p>\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"footer-right\">\r\n                    s\r\n                    <p class=\"footer-company-about\">\r\n                        <span>Sobre nosotros</span>\r\n                        Este es un sistema el cuál se basa en el alquiler de carros para cierto clientes. Cada institución/usuario que ingrese al sistema, podrá crear y añadir sus propios clientes y carros, y que de esta manera solo ellos puedan ver sus propios clientes, carros, facturas y alquileres.\r\n                    </p>\r\n                </div>\r\n            </footer>\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 97 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Proyecto Final\Proyecto-Final-P3\Shared\MainLayout.razor"
      

    bool Registrado = false;
    async Task Cerrar()
    {
        navigationManager.NavigateTo("/login");
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        // String name = await localStorage.GetItemAsync<string>("id_login");

        if (await localStorage.ContainKeyAsync("ID_login"))
        {

            Registrado = true;
        }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
    }
}
#pragma warning restore 1591
