#pragma checksum "C:\Prog. Aplicada2\RegistroPrestamos\Pages\R_Prestamos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5788dff4ee46ab0344849fc980c8e072c44c4d1f"
// <auto-generated/>
#pragma warning disable 1591
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
#line 4 "C:\Prog. Aplicada2\RegistroPrestamos\Pages\R_Prestamos.razor"
using RegistroPrestamos.BLL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Prog. Aplicada2\RegistroPrestamos\Pages\R_Prestamos.razor"
using RegistroPrestamos.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/prestamos")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/prestamos/{PrestamosId:int}")]
    public partial class R_Prestamos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Prog. Aplicada2\RegistroPrestamos\Pages\R_Prestamos.razor"
                 prestamo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Prog. Aplicada2\RegistroPrestamos\Pages\R_Prestamos.razor"
                                          Guardar

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddContent(4, " ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n\r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "card");
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.AddMarkupContent(10, "<div class=\"card-header\">\r\n            <h3>Registro de prestamos</h3>\r\n        </div>\r\n\r\n        ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "card-body");
                __builder2.AddMarkupContent(13, "\r\n            ");
                __builder2.OpenElement(14, "form");
                __builder2.AddMarkupContent(15, "\r\n                ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "form-row align-items-center");
                __builder2.AddMarkupContent(18, "\r\n                    ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "col");
                __builder2.AddMarkupContent(21, "\r\n                        ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "form-group");
                __builder2.AddMarkupContent(24, "\r\n                            ");
                __builder2.AddMarkupContent(25, "<label>PrestamoId</label>\r\n                            ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "input-group");
                __builder2.AddMarkupContent(28, "\r\n                                ");
                __Blazor.RegistroPrestamos.Pages.R_Prestamos.TypeInference.CreateInputNumber_0(__builder2, 29, 30, "form-control col-4", 31, 
#nullable restore
#line 24 "C:\Prog. Aplicada2\RegistroPrestamos\Pages\R_Prestamos.razor"
                                                          prestamo.PrestamosId

#line default
#line hidden
#nullable disable
                , 32, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => prestamo.PrestamosId = __value, prestamo.PrestamosId)), 33, () => prestamo.PrestamosId);
                __builder2.AddMarkupContent(34, "\r\n                                ");
                __Blazor.RegistroPrestamos.Pages.R_Prestamos.TypeInference.CreateValidationMessage_1(__builder2, 35, 36, 
#nullable restore
#line 25 "C:\Prog. Aplicada2\RegistroPrestamos\Pages\R_Prestamos.razor"
                                                        (() => prestamo.PrestamosId)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(37, "\r\n                                ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "input-group-append");
                __builder2.AddMarkupContent(40, "\r\n                                    ");
                __builder2.OpenElement(41, "button");
                __builder2.AddAttribute(42, "type", "button");
                __builder2.AddAttribute(43, "class", "btn btn-primary input-group-text");
                __builder2.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Prog. Aplicada2\RegistroPrestamos\Pages\R_Prestamos.razor"
                                                                                                             Buscar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(45, "Buscar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n\r\n                ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "form-group");
                __builder2.AddMarkupContent(54, "\r\n                    ");
                __builder2.AddMarkupContent(55, "<label>Fecha</label>\r\n                    ");
                __Blazor.RegistroPrestamos.Pages.R_Prestamos.TypeInference.CreateInputDate_2(__builder2, 56, 57, "form-control", 58, 
#nullable restore
#line 36 "C:\Prog. Aplicada2\RegistroPrestamos\Pages\R_Prestamos.razor"
                                            prestamo.Fecha

#line default
#line hidden
#nullable disable
                , 59, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => prestamo.Fecha = __value, prestamo.Fecha)), 60, () => prestamo.Fecha);
                __builder2.AddMarkupContent(61, "\r\n                    ");
                __Blazor.RegistroPrestamos.Pages.R_Prestamos.TypeInference.CreateValidationMessage_3(__builder2, 62, 63, 
#nullable restore
#line 37 "C:\Prog. Aplicada2\RegistroPrestamos\Pages\R_Prestamos.razor"
                                              () => prestamo.Fecha

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(64, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n\r\n                ");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "form-group");
                __builder2.AddMarkupContent(68, "\r\n                    ");
                __builder2.AddMarkupContent(69, "<label for=\"persona_select\">Persona</label>\r\n                    ");
                __builder2.OpenElement(70, "select");
                __builder2.AddAttribute(71, "id", "persona_select");
                __builder2.AddAttribute(72, "class", "form-control");
                __builder2.AddAttribute(73, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 42 "C:\Prog. Aplicada2\RegistroPrestamos\Pages\R_Prestamos.razor"
                                                       prestamo.PersonaId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(74, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => prestamo.PersonaId = __value, prestamo.PersonaId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(75, "\r\n                        ");
                __builder2.OpenElement(76, "option");
                __builder2.AddAttribute(77, "value", true);
                __builder2.AddAttribute(78, "disabled", true);
                __builder2.AddAttribute(79, "selected", true);
                __builder2.AddContent(80, "Elija una Persona");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n");
#nullable restore
#line 44 "C:\Prog. Aplicada2\RegistroPrestamos\Pages\R_Prestamos.razor"
                         foreach (var item in listaPersona)
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(82, "                            ");
                __builder2.OpenElement(83, "option");
                __builder2.AddAttribute(84, "value", 
#nullable restore
#line 46 "C:\Prog. Aplicada2\RegistroPrestamos\Pages\R_Prestamos.razor"
                                            item.PersonaId

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(85, 
#nullable restore
#line 46 "C:\Prog. Aplicada2\RegistroPrestamos\Pages\R_Prestamos.razor"
                                                             item.Nombre

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n");
#nullable restore
#line 47 "C:\Prog. Aplicada2\RegistroPrestamos\Pages\R_Prestamos.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(87, "                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\r\n\r\n                ");
                __builder2.OpenElement(90, "div");
                __builder2.AddAttribute(91, "class", "form-group");
                __builder2.AddMarkupContent(92, "\r\n                    ");
                __builder2.AddMarkupContent(93, "<label>Concepto</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(94);
                __builder2.AddAttribute(95, "class", "form-control");
                __builder2.AddAttribute(96, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 53 "C:\Prog. Aplicada2\RegistroPrestamos\Pages\R_Prestamos.razor"
                                            prestamo.Concepto

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(97, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => prestamo.Concepto = __value, prestamo.Concepto))));
                __builder2.AddAttribute(98, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => prestamo.Concepto));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(99, "\r\n                    ");
                __Blazor.RegistroPrestamos.Pages.R_Prestamos.TypeInference.CreateValidationMessage_4(__builder2, 100, 101, 
#nullable restore
#line 54 "C:\Prog. Aplicada2\RegistroPrestamos\Pages\R_Prestamos.razor"
                                              () => prestamo.Concepto

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(102, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n\r\n                ");
                __builder2.OpenElement(104, "div");
                __builder2.AddAttribute(105, "class", "form-group");
                __builder2.AddMarkupContent(106, "\r\n                    ");
                __builder2.AddMarkupContent(107, "<label>Monto</label>\r\n                    ");
                __Blazor.RegistroPrestamos.Pages.R_Prestamos.TypeInference.CreateInputNumber_5(__builder2, 108, 109, "0.2", 110, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 59 "C:\Prog. Aplicada2\RegistroPrestamos\Pages\R_Prestamos.razor"
                                                                                      IgualarMontoBalance

#line default
#line hidden
#nullable disable
                ), 111, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 59 "C:\Prog. Aplicada2\RegistroPrestamos\Pages\R_Prestamos.razor"
                                                                                                                       IgualarMontoBalance

#line default
#line hidden
#nullable disable
                ), 112, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Prog. Aplicada2\RegistroPrestamos\Pages\R_Prestamos.razor"
                                                                                                                                                      IgualarMontoBalance

#line default
#line hidden
#nullable disable
                ), 113, "form-control", 114, 
#nullable restore
#line 59 "C:\Prog. Aplicada2\RegistroPrestamos\Pages\R_Prestamos.razor"
                                              prestamo.Monto

#line default
#line hidden
#nullable disable
                , 115, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => prestamo.Monto = __value, prestamo.Monto)), 116, () => prestamo.Monto);
                __builder2.AddMarkupContent(117, "\r\n                    ");
                __Blazor.RegistroPrestamos.Pages.R_Prestamos.TypeInference.CreateValidationMessage_6(__builder2, 118, 119, 
#nullable restore
#line 60 "C:\Prog. Aplicada2\RegistroPrestamos\Pages\R_Prestamos.razor"
                                              () => prestamo.Monto

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(120, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(121, "\r\n \r\n                ");
                __builder2.OpenElement(122, "div");
                __builder2.AddAttribute(123, "class", "form-group");
                __builder2.AddMarkupContent(124, "\r\n                    ");
                __builder2.AddMarkupContent(125, "<label>Balance</label>\r\n                    ");
                __Blazor.RegistroPrestamos.Pages.R_Prestamos.TypeInference.CreateInputNumber_7(__builder2, 126, 127, true, 128, "form-control", 129, 
#nullable restore
#line 65 "C:\Prog. Aplicada2\RegistroPrestamos\Pages\R_Prestamos.razor"
                                              prestamo.Balance

#line default
#line hidden
#nullable disable
                , 130, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => prestamo.Balance = __value, prestamo.Balance)), 131, () => prestamo.Balance);
                __builder2.AddMarkupContent(132, "\r\n                    ");
                __Blazor.RegistroPrestamos.Pages.R_Prestamos.TypeInference.CreateValidationMessage_8(__builder2, 133, 134, 
#nullable restore
#line 66 "C:\Prog. Aplicada2\RegistroPrestamos\Pages\R_Prestamos.razor"
                                              () => prestamo.Balance

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(135, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(136, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(137, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(138, "\r\n        ");
                __builder2.OpenElement(139, "div");
                __builder2.AddAttribute(140, "class", "card-footer");
                __builder2.AddMarkupContent(141, "\r\n            ");
                __builder2.OpenElement(142, "div");
                __builder2.AddAttribute(143, "class", "form-group text-center");
                __builder2.AddAttribute(144, "display:", true);
                __builder2.AddAttribute(145, "inline-block", true);
                __builder2.AddMarkupContent(146, "\r\n                ");
                __builder2.OpenElement(147, "button");
                __builder2.AddAttribute(148, "type", "button");
                __builder2.AddAttribute(149, "class", "btn btn-lg btn-secondary");
                __builder2.AddAttribute(150, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 72 "C:\Prog. Aplicada2\RegistroPrestamos\Pages\R_Prestamos.razor"
                                                                                 Nuevo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(151, "Nuevo");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(152, "\r\n                ");
                __builder2.AddMarkupContent(153, "<button type=\"submit\" class=\"btn btn-lg btn-success\">Guardar</button>\r\n                ");
                __builder2.OpenElement(154, "button");
                __builder2.AddAttribute(155, "type", "button");
                __builder2.AddAttribute(156, "class", "btn btn-lg btn-danger");
                __builder2.AddAttribute(157, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 74 "C:\Prog. Aplicada2\RegistroPrestamos\Pages\R_Prestamos.razor"
                                                                              Eliminar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(158, "Eliminar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(159, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(160, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(161, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(162, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 80 "C:\Prog. Aplicada2\RegistroPrestamos\Pages\R_Prestamos.razor"
       

    Prestamos prestamo = new Prestamos();

    [Parameter]
    public int PrestamosId { get; set; }

    private List<Personas> listaPersona = new List<Personas>();



    protected override void OnInitialized()
    {
        Nuevo();
        if (PrestamosId > 0)
        {
            var auxPretamo = PrestamosBLL.Buscar(PrestamosId);
            if (auxPretamo != null)
                this.prestamo = auxPretamo;
            else
                toast.ShowWarning("No encontrado.");
        }

        listaPersona = PersonasBLL.GetList(p => true);
    }

    private void Buscar()
    {
        var encontrado = PrestamosBLL.Buscar(prestamo.PrestamosId);
        if (encontrado != null)
        {
            this.prestamo = encontrado;
        }
        else
            toast.ShowWarning("No encontrado");

    }


    private void IgualarMontoBalance()
    {
        decimal auxMonto = prestamo.Monto;
        prestamo.Balance = auxMonto;
    }

    private void Nuevo()
    {
        this.prestamo = new Prestamos();
    }


    private void Guardar()
    {
        bool paso;
        paso = PrestamosBLL.Guardar(prestamo);

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

    private void Eliminar()
    {
        bool elimino;

        elimino = PrestamosBLL.Eliminar(prestamo.PrestamosId);

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
namespace __Blazor.RegistroPrestamos.Pages.R_Prestamos
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.Object __arg1, int __seq2, global::System.Object __arg2, int __seq3, global::System.Object __arg3, int __seq4, System.Object __arg4, int __seq5, TValue __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg6, int __seq7, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg7)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "step", __arg0);
        __builder.AddAttribute(__seq1, "onfocusout", __arg1);
        __builder.AddAttribute(__seq2, "onfocusin", __arg2);
        __builder.AddAttribute(__seq3, "onclick", __arg3);
        __builder.AddAttribute(__seq4, "class", __arg4);
        __builder.AddAttribute(__seq5, "Value", __arg5);
        __builder.AddAttribute(__seq6, "ValueChanged", __arg6);
        __builder.AddAttribute(__seq7, "ValueExpression", __arg7);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "readonly", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591