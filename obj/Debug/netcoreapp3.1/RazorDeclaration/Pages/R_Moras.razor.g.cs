#pragma checksum "C:\Prog. Aplicada2\RegistroPrestamos\Pages\R_Moras.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65603431710d2badd67408f901b9c72146f29fac"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace RegistroPrestamos.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Prog. Aplicada2\RegistroPrestamos\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Prog. Aplicada2\RegistroPrestamos\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Prog. Aplicada2\RegistroPrestamos\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Prog. Aplicada2\RegistroPrestamos\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Prog. Aplicada2\RegistroPrestamos\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Prog. Aplicada2\RegistroPrestamos\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Prog. Aplicada2\RegistroPrestamos\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Prog. Aplicada2\RegistroPrestamos\_Imports.razor"
using RegistroPrestamos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Prog. Aplicada2\RegistroPrestamos\_Imports.razor"
using RegistroPrestamos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Prog. Aplicada2\RegistroPrestamos\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Prog. Aplicada2\RegistroPrestamos\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Prog. Aplicada2\RegistroPrestamos\Pages\R_Moras.razor"
using RegistroPrestamos.BLL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Prog. Aplicada2\RegistroPrestamos\Pages\R_Moras.razor"
using RegistroPrestamos.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/moras")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/moras/{MoraId:int}")]
    public partial class R_Moras : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 121 "C:\Prog. Aplicada2\RegistroPrestamos\Pages\R_Moras.razor"
       

    [Parameter]
    public int MoraId { get; set; }

    public int prestamoSeleccionado { get; set; }
    public decimal valorColocado { get; set; }
    public string nombrePersona { get; set; }

    Moras mora = new Moras();
    List<Prestamos> listaPrestamo = new List<Prestamos>();

    protected override void OnInitialized()
    {
        Nuevo();
        if (MoraId > 0)
        {
            var auxMora = MorasBLL.Buscar(MoraId);
            if (auxMora != null)
                this.mora = auxMora;
            else
                toast.ShowWarning("No encontrado.");
        }

        listaPrestamo = PrestamosBLL.GetList(p => true);
    }

    private void Buscar()
    {
        var encontrado = MorasBLL.Buscar(mora.MoraId);
        if (encontrado != null)
        {
            this.mora = encontrado;
        }
        else
            toast.ShowWarning("No encontrado");

    }


    private void Nuevo()
    {
        this.mora = new Moras();
        prestamoSeleccionado = 0;
        valorColocado = 0;
        nombrePersona = string.Empty;
        
    }

    private void MostrarNombrePersona()
    {
        string auxNombre = string.Empty;

        var auxPrestamo = PrestamosBLL.Buscar(prestamoSeleccionado);
        if (auxPrestamo != null)
        {
            auxNombre = PersonasBLL.Buscar(auxPrestamo.PersonaId).Nombre;
            nombrePersona = auxNombre;
        }
    }

    private void AgregarMora()
    {
        if(prestamoSeleccionado == 0)
        {
            toast.ShowWarning("Debe seleccionar el Id del prestamo.");
            return;
        }

        if (valorColocado <= 0)
        {
            toast.ShowWarning("El valor debe ser mayor a 0.");
            return;
        }
        else
        {
            this.mora.MorasDetalle.Add(new MorasDetalle
            {
                MoraDetalleId = 0,
                MoraId = mora.MoraId,
                PrestamoId = prestamoSeleccionado,
                Valor = valorColocado
            });
            prestamoSeleccionado = 0;
            valorColocado = 0;
            nombrePersona = string.Empty;
        }
        CalcularTotal();

    }

    private void CalcularTotal()
    {
        decimal total = 0;
        foreach (var item in mora.MorasDetalle)
        {
            total += item.Valor;
        }
        mora.Total = total;
    }


    private void Guardar()
    {
        bool paso;
        if (mora.MorasDetalle.Count == 0)
        {
            toast.ShowWarning("Debes agregar al menos 1 elemto a la lista", "La lista esta vacia");
            return;
        }
        else
        {
            paso = MorasBLL.Guardar(mora);

            if (paso)
            {
                Nuevo();
                toast.ShowSuccess("Guardado correctamente");
            }
            else
            {
                toast.ShowError("No fue posible guardar");
            }
        }

    }

    private void Eliminar()
    {
        bool elimino;

        elimino = MorasBLL.Eliminar(mora.MoraId);

        if (elimino)
        {
            Nuevo();
            toast.ShowSuccess("Eliminado correctamente");
        }
        else
            toast.ShowError("No fue posible eliminar");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toast { get; set; }
    }
}
#pragma warning restore 1591
