// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
