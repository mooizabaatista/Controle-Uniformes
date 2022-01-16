#pragma checksum "C:\Requisicao_RSS\Requisicao_RSS\Requisicao_RSS.WebUi\Views\Graficos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2360ede5c7e5a47b2e6b2c864f3fdb674c28d37a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Graficos_Index), @"mvc.1.0.view", @"/Views/Graficos/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Requisicao_RSS\Requisicao_RSS\Requisicao_RSS.WebUi\Views\_ViewImports.cshtml"
using Requisicao_RSS.WebUi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Requisicao_RSS\Requisicao_RSS\Requisicao_RSS.WebUi\Views\_ViewImports.cshtml"
using Requisicao_RSS.WebUi.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Requisicao_RSS\Requisicao_RSS\Requisicao_RSS.WebUi\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Requisicao_RSS\Requisicao_RSS\Requisicao_RSS.WebUi\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2360ede5c7e5a47b2e6b2c864f3fdb674c28d37a", @"/Views/Graficos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61a06fe337c209599986bc332774917a82fa35ed", @"/Views/_ViewImports.cshtml")]
    public class Views_Graficos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""container"">
    <div class=""row"">
        <!-- Estatísticas Camisetas-->
        <div class=""col-12 mt-3 mb-5 text-center"">
            <h3 style=""font-weight:100; letter-spacing:5px;"" class=""mb-3"">Camisetas</h3>
            <hr style=""width:50%;"" />
            <canvas id=""myChart"" width=""300"" height=""55""></canvas>
        </div>
        <!-- Estatísticas Calças-->
        <div class=""col-12 mt-1 text-center"">
            <h3 style=""font-weight:100; letter-spacing:5px;"" class=""mb-3"">Calças</h3>
            <hr style=""width:50%;"" />
            <canvas id=""myChartCalcas"" width=""300"" height=""55""></canvas>
        </div>
    </div>
</div>



<script src=""https://cdn.jsdelivr.net/npm/chart.js""></script>
");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <!-- Script Gráfico Camisetas-->
    <script>
        var ctx = document.getElementById('myChart');
        var myChart = new Chart(ctx, {
            type: 'bar',
            data: {
                labels: ['Camisa P', 'Camisa M', 'CamisaG', 'Camisa GG', 'Camisa XG'],
                datasets: [{
                    label: 'Estatísticas Camisetas',
                    data: [");
#nullable restore
#line 33 "C:\Requisicao_RSS\Requisicao_RSS\Requisicao_RSS.WebUi\Views\Graficos\Index.cshtml"
                      Write(ViewBag.QtdCamisaP);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 33 "C:\Requisicao_RSS\Requisicao_RSS\Requisicao_RSS.WebUi\Views\Graficos\Index.cshtml"
                                           Write(ViewBag.QtdCamisaM);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 33 "C:\Requisicao_RSS\Requisicao_RSS\Requisicao_RSS.WebUi\Views\Graficos\Index.cshtml"
                                                                Write(ViewBag.QtdCamisaG);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 33 "C:\Requisicao_RSS\Requisicao_RSS\Requisicao_RSS.WebUi\Views\Graficos\Index.cshtml"
                                                                                     Write(ViewBag.QtdCamisaGG);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 33 "C:\Requisicao_RSS\Requisicao_RSS\Requisicao_RSS.WebUi\Views\Graficos\Index.cshtml"
                                                                                                           Write(ViewBag.QtdCamisaXG);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"],
                    backgroundColor: [
                        'rgba(255, 99, 132, 0.2)',
                        'rgba(54, 162, 235, 0.2)',
                        'rgba(255, 206, 86, 0.2)',
                        'rgba(75, 192, 192, 0.2)',
                        'rgba(153, 102, 255, 0.2)',
                    ],
                    borderColor: [

                        'rgba(54, 162, 235, 1)',
                        'rgba(255, 206, 86, 1)',
                        'rgba(75, 192, 192, 1)',
                        'rgba(153, 102, 255, 1)',
                        'rgba(255, 159, 64, 1)'
                    ],
                    borderWidth: 0.5
                }]
            },
            options: {
                scales: {
                    y: {
                        beginAtZero: true
                    }
                }
            }
        });
    </script>

    <!-- Script Gráfico Calças-->
    <script>
        var ctx = document.getElementById('myChartCal");
                WriteLiteral(@"cas');
        var myChart = new Chart(ctx, {
            type: 'bar',
            data: {
                labels: ['Calça P', 'Calça M', 'Calça G', 'Calça GG', 'Calça XG'],
                datasets: [{
                    label: 'Estatísticas Calças',
                    data: [");
#nullable restore
#line 71 "C:\Requisicao_RSS\Requisicao_RSS\Requisicao_RSS.WebUi\Views\Graficos\Index.cshtml"
                      Write(ViewBag.QtdCalcaP);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 71 "C:\Requisicao_RSS\Requisicao_RSS\Requisicao_RSS.WebUi\Views\Graficos\Index.cshtml"
                                          Write(ViewBag.QtdCalcaM);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 71 "C:\Requisicao_RSS\Requisicao_RSS\Requisicao_RSS.WebUi\Views\Graficos\Index.cshtml"
                                                              Write(ViewBag.QtdCalcaG);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 71 "C:\Requisicao_RSS\Requisicao_RSS\Requisicao_RSS.WebUi\Views\Graficos\Index.cshtml"
                                                                                  Write(ViewBag.QtdCalcaGG);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 71 "C:\Requisicao_RSS\Requisicao_RSS\Requisicao_RSS.WebUi\Views\Graficos\Index.cshtml"
                                                                                                       Write(ViewBag.QtdCalcaXG);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"],
                    backgroundColor: [
                        'rgba(255, 99, 132, 0.2)',
                        'rgba(54, 162, 235, 0.2)',
                        'rgba(255, 206, 86, 0.2)',
                        'rgba(75, 192, 192, 0.2)',
                        'rgba(153, 102, 255, 0.2)',
                    ],
                    borderColor: [

                        'rgba(54, 162, 235, 1)',
                        'rgba(255, 206, 86, 1)',
                        'rgba(75, 192, 192, 1)',
                        'rgba(153, 102, 255, 1)',
                        'rgba(255, 159, 64, 1)'
                    ],
                    borderWidth: 0.5
                }]
            },
            options: {
                scales: {
                    y: {
                        beginAtZero: true
                    }
                }
            }
        });
    </script>
");
            }
            );
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591