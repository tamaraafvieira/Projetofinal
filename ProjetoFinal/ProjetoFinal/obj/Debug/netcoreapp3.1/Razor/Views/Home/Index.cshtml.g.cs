#pragma checksum "C:\Users\izaqu\OneDrive\Área de Trabalho\ProjetoFinal\ProjetoFinal\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed16cd05aa41390f3686e6ccbc047c10ce077e24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\izaqu\OneDrive\Área de Trabalho\ProjetoFinal\ProjetoFinal\Views\_ViewImports.cshtml"
using ProjetoFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\izaqu\OneDrive\Área de Trabalho\ProjetoFinal\ProjetoFinal\Views\_ViewImports.cshtml"
using ProjetoFinal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed16cd05aa41390f3686e6ccbc047c10ce077e24", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e0c9d640be634173df9fcea737cdae6910dcdad", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("cor-secundaria"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Categories", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Categories", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration: none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Conteudos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Materias", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Podcasts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\izaqu\OneDrive\Área de Trabalho\ProjetoFinal\ProjetoFinal\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">

    <!--Inicio de estrutura da pagina 1-->
    <section>
        <div class=""row"">
            <div class=""col-12 linha-1""></div>
        </div>
        <div class=""row"">
            <div class=""col-12 linha-2"">
                <div class=""container my-4 texto-principal"">
                    1 &nbsp &nbsp//Olá Mundo!
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-12 linha-3"">
                <div class=""container my-4 texto-principal"">
                    2 &nbsp<span class=""cor-secundaria-texto text-justify"">Somos a BCB</span> <span class=""cor-terciaria-mais-clara"">=</span> &lt;<span class=""cor-terciaria-texto"">Black Code Brasil</span>&gt;;
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-12 linha-4"">
                <div class=""container my-2 texto-principal"">
                    3 &nbspAmamos <span class=""cor-secundaria-texto ");
            WriteLiteral(@"text-justify"">inclur</span> pessoas negras no mundo da <span class=""cor-terciaria-mais-clara"">Tecnologia</span> e <span class=""cor-terciaria-mais-clara"">Programação</span> = &lt;<span class=""cor-terciaria-texto"">Inclusão</span>&gt;;
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-12 linha-5"">
                <div class=""container my-4 texto-principal"">
                    4 &nbsp<span class=""cor-secundaria-texto text-justify"">Temos os melhores talentos</span> para sua empresa crescer com mais <span class=""cor-terciaria"">DIVERSIDADE</span> e <span class=""cor-terciaria-texto"">INCLUSÃO</span> no seu time (!);
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-12 linha-6""></div>
        </div>
        <div class=""row"">
            <div class=""col-12 linha-7""></div>
        </div>
        <div class=""row"">
            <div class=""col-12 d-flex justify-content-center"">
      ");
            WriteLiteral(@"          <div class=""col-11 col-sm-8 col-md-7 col-lg-6 linha-8 d-flex justify-content-around"">
                    <span class=""cor-terciaria titulo-terciario my-4 mx-4"">Conheça o nosso banco de talentos</span>
                    <button class=""button titulo-terciario"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed16cd05aa41390f3686e6ccbc047c10ce077e248305", async() => {
                WriteLiteral("Vamos Lá");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</button>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-12 linha-9""></div>
        </div>
    </section>
    <!--Fim de estrutura da pagina 1-->
    <!--Inicio de estrutura da pagina 2-->
    <article>
        <div class=""row container-black-code"">
            <div class=""col-10 col-sm-9 col-md-6 col-lg-5 linha-10"">
                <h2 class=""titulo-principal cor-terciaria-texto text-center"">BLACK CODE BRASIL</h2><br>
                <p class=""texto-terciario cor-secundaria text-justify mb-5"">
                    Conectamos pessoas negras da área de tecnologia com recrutadores e empresas
                    interessadas em contratar essa força de trabalho.<br><br>

                    O objetivo é colaborar com a erradicação do racismo sistêmico estrutural enraizado  no mercado de trabalho brasileiro.<br><br>

                    Dessa forma pretendemos ampliar a participação da população negra no setor da Tecnologia da Infor");
            WriteLiteral(@"mação e Comunicação (TICs),
                    auxiliando também na redução das desigualdades sociais no Brasil.
                </p>
            </div>
        </div>
    </article>
    <!--Fim de estrutura da pagina 2-->
    <!--Inicio de estrutura da pagina 3 parte 1-->
    <div class=""row contratar container-titulo-contratar"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12 d-flex justify-content-center"">
                    <div class=""col-12 col-sm-12 col-md-12 col-lg-10"">
                        <h1 class=""titulo-secundario text-center my-5"">
                            <strong>Nossos profissionais estão conectados com as principais tendências na área de tecnologia</strong>
                        </h1>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!--Fim de estrutura da pagina 3 parte 1-->
    <!--Inicio de estrutura da pagina 3 parte 2-->
    <section class=""row contratar con");
            WriteLiteral(@"tainer-nossos-profisionais"">
        <div class=""container"" style=""margin-top: 120px;"">
            <div class=""row g-3 d-flex justify-content-center"">
                <div class=""col-8 col-sm-6 col-md-6 col-lg-3 my-4"">
                    <div class=""card my-5"">
                        <div class=""row"">
                            <div class="" col-12 col-sm-12 col-md-12 col-lg-12 d-flex justify-content-center"">
                                <img class=""card-img-top img-poligono"" src=""./img/home/icone-servicos-1.png"" alt=""Card image"">
                            </div>
                        </div>
                        <div class=""card-body text-center"">
                            <h4 class=""card-title titulo-card"">Dev Full Stack</h4>
                            <p class=""card-text"">
                                PEQUENO RESUMO
                                Curabitur sed iaculis dolor. Maecenas imperdiet ante eget hendrerit posuere. Nunc urna dolor
                            </p>
 ");
            WriteLiteral(@"                           <a href=""#"" class=""btn btn-block cor-secundaria"" style=""background-color: #292C36;"">Quero contratar</a>
                        </div>
                    </div>
                </div>
                <div class=""col-8 col-sm-6 col-md-6 col-lg-3 my-4"">
                    <div class=""card my-5"">
                        <div class=""row"">
                            <div class="" col-12 col-sm-12 col-md-12 col-lg-12 d-flex justify-content-center"">
                                <img class=""card-img-top img-poligono"" src=""./img/home/icone-servicos-2.png"" alt=""Card image"">
                            </div>
                        </div>
                        <div class=""card-body text-center"">
                            <h4 class=""card-title titulo-card"">Dev Front End</h4>
                            <p class=""card-text"">
                                PEQUENO RESUMO
                                Curabitur sed iaculis dolor. Maecenas imperdiet ante eget hendrerit p");
            WriteLiteral(@"osuere. Nunc urna dolor
                            </p>
                            <a href=""#"" class=""btn btn-block cor-secundaria"" style=""background-color: #292C36;"">Quero contratar</a>
                        </div>
                    </div>
                </div>
                <div class=""col-8 col-sm-6 col-md-6 col-lg-3 my-4"">
                    <div class=""card my-5"">
                        <div class=""row"">
                            <div class="" col-12 col-sm-12 col-md-12 col-lg-12 d-flex justify-content-center"">
                                <img class=""card-img-top img-poligono"" src=""./img/home/icone-servicos-3.png"" alt=""Card image"">
                            </div>
                        </div>
                        <div class=""card-body text-center"">
                            <h4 class=""card-title titulo-card"">Dev Back end</h4>
                            <p class=""card-text"">
                                PEQUENO RESUMO
                                Curabitur ");
            WriteLiteral(@"sed iaculis dolor. Maecenas imperdiet ante eget hendrerit posuere. Nunc urna dolor
                            </p>
                            <a href=""#"" class=""btn btn-block cor-secundaria"" style=""background-color: #292C36;"">Quero contratar</a>
                        </div>
                    </div>
                </div>
                <div class=""col-8 col-sm-6 col-md-6 col-lg-3 my-4"">
                    <div class=""card my-5"">
                        <div class=""row"">
                            <div class="" col-12 col-sm-12 col-md-12 col-lg-12 d-flex justify-content-center"">
                                <img class=""card-img-top img-poligono"" src=""./img/home/icone-servicos-4.png"" alt=""Card image"">
                            </div>
                        </div>
                        <div class=""card-body text-center"">
                            <h4 class=""card-title titulo-card"">Dev Jogos</h4>
                            <p class=""card-text"">
                                PE");
            WriteLiteral(@"QUENO RESUMO
                                Curabitur sed iaculis dolor. Maecenas imperdiet ante eget hendrerit posuere. Nunc urna dolor
                            </p>
                            <a href=""#"" class=""btn btn-block cor-secundaria"" style=""background-color: #292C36;"">Quero contratar</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!--Fim de estrutura da pagina 3 parte 2-->
    <!--Inicio de estrutura da pagina 4-->
    <section>
        <div class=""container"">
            <div class=""row"">
                <div class=""col-sm-12 col-md-12 col-lg-8 titulo-pq-investir text-center"">
                    <h1 class=""titulo-principal cor-terciaria"">
                        <strong>//PORQUE INVESTIR EM DIVERSIDADE E CONTRATAR PESSOAS NEGRAS (?);</strong>
                    </h1>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-11 col-sm-12");
            WriteLiteral(@" col-md-12 col-lg-7 text-white texto-pq-investir text-justify"">
                    <p class=""titulo-terciario"">
                        <span class=""cor-terciaria-texto"">&lt;P</span> Empresas que investem em diversidade aumentam a competitividade no mercado e melhoram
                        sua performance financeira<span class=""cor-terciaria-texto"">/&gt;</span>;
                    </p>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-12 my-5"">
                    <div class=""row g-1"">
                        <img class=""col-sm-12 col-md-12 col-lg-6"" src=""./img/home/diversidade.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 10327, "\"", 10333, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""col-sm-12 col-md-12 col-lg-6 text-white"">
                            <h3 class=""titulo-terciario text-justify ml-3 my-4"">1. <span class=""cor-terciaria"">&lt;h2</span> Ambientes de trabalho mais feliz <span class=""cor-terciaria"">&gt;</span> = &lt; <span class=""cor-terciaria-texto"">Retenção de Talentos</span> &gt;; </h3>
                            <p class=""texto-terciario texto-ambientes-de-trabalho text-justify ml-4"">
                                <span class=""cor-terciaria"">&lt;P</span> uma saúde organizacional mais sólida quanto em resultados: empresas que adotam a diversidade têm uma probabilidade
                                significativamente maior de alcançar uma performance financeira superior à de seus pare24s que não o fazem<span class=""cor-terciaria"">/&gt;</span>.
                            </p>
                            <div class=""row"">
                                <div class=""col-12 container-button"">
                                    <");
            WriteLiteral(@"button class=""button-veja-mais titulo-terciario my-5"">Veja Mais</button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-12 my-5"">
                    <div class=""row"">
                        <div class=""col-sm-12 col-md-12 col-lg-6 text-white mt-4"">
                            <h3 class=""titulo-terciario text-justify mt-2"">2.<span class=""cor-terciaria"">&lt;h2</span> Alta nível de Inovação e Colaboração<span class=""cor-terciaria"">/&gt;</span> = &lt;<span class=""cor-terciaria-texto"">Alta performance</span>&gt;; </h3>
                            <p class=""texto-terciario texto-ambientes-de-trabalho text-justify mt-4 "">
                                <span class=""cor-terciaria"">&lt;P</span> Essas pessoas têm a probabilidade de : <span class=""cor-terciaria-texto"">152%</span> maior de afirmar que podem propor novas");
            WriteLiteral(@" ideias e tentar novas formas de fazer as coisas/&gt;.<br><br>
                                <span class=""cor-terciaria-texto"">77%</span> maior de concordar que a organização aplica ideias externas para melhorar sua performance<span class=""cor-terciaria"">/></span>.
                            </p>
                            <div class=""row"">
                                <div class=""col-12 container-button"">
                                    <button class=""button-veja-mais titulo-terciario my-5"">Veja Mais</button>
                                </div>
                            </div>
                        </div>
                        <img class=""col-sm-12 col-md-12 col-lg-6"" src=""./img/home/colaboracao.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 13121, "\"", 13127, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""filter: contrast(75%)"">
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-12 container-button"">
                    <button class=""button-saiba-mais titulo-terciario"">Saiba Mais</button>
                </div>
            </div>
        </div>
    </section>
    <!--Fim de estrutura da pagina 4-->
    <!--Inicio de estrutura da pagina 5-->
    <section class=""row contratar"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <h1 class=""titulo-principal text-center cor-terciaria-mais-clara mt-5"">
                        <strong>//CONTEÚDOS</strong>
                    </h1>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-11 col-sm-10 col-md-10 col-lg-9 text-justify texto-conteudo"">
                    <p class=""titulo-terciario"">
                        <span class=""cor-tercia");
            WriteLiteral(@"ria"">&ltP</span> Promovemos debates permanentes sobre a importância das empresas contratarem pessoas negras para suas equipes e implementarem
                        a cultura da diversidade em todos os setores de suas organizações. Em nossas publicações divulgamos entrevistas com especialias,
                        pesquisas e informações sobre diversidade nas empresas<span class=""cor-terciaria"">/&gt;</span>.
                    </p>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-12"">
                    <h1 class=""titulo-principal"">//Matérias</h1>
                </div>
            </div>
            <div class=""row g-3 mt-4"">
                <div class=""col-sm-6 col-md-4 col-lg-4 my-3"">
                    <h3 class=""titulo-secundario cor-terciaria-mais-clara"">CATEGORIA</h3>
                    <p class=""texto-secundario mt-4"">Brasil perde R$ 1 Trilhão por remuneração desigual a Negros e Pardos</p>
                    <div class=""card");
            WriteLiteral(@" text-center"">
                        <img class=""card-img-top"" src=""./img/home/fundo-filtro(pagina-2-cortada).png"" alt=""Card image"" style=""width:100%"">
                        <div class=""card-body text-center"">
                            <a href=""#"" class=""btn btn-link cor-terciaria-mais-clara titulo-terciario"">Saiba Mais</a>
                        </div>
                    </div>
                </div>
                <div class=""col-sm-6 col-md-4 col-lg-4 my-3"">
                    <h3 class=""titulo-secundario cor-terciaria-mais-clara"">CATEGORIA</h3>
                    <p class=""texto-secundario mt-4"">Brasil perde R$ 1 Trilhão por remuneração desigual a Negros e Pardos</p>
                    <div class=""card text-center"">
                        <img class=""card-img-top"" src=""./img/home/fundo-filtro(pagina-2-cortada).png"" alt=""Card image"" style=""width:100%"">
                        <div class=""card-body"">
                            <a href=""#"" class=""btn btn-link cor-terciaria-mais-cla");
            WriteLiteral(@"ra titulo-terciario"">Saiba Mais</a>
                        </div>
                    </div>
                </div>
                <div class=""col-sm-6 col-md-4 col-lg-4 my-3"">
                    <h3 class=""titulo-secundario cor-terciaria-mais-clara"">CATEGORIA</h3>
                    <p class=""texto-secundario mt-4"">Brasil perde R$ 1 Trilhão por remuneração desigual a Negros e Pardos</p>
                    <div class=""card text-center"">
                        <img class=""card-img-top"" src=""./img/home/fundo-filtro(pagina-2-cortada).png"" alt=""Card image"" style=""width:100%"">
                        <div class=""card-body text-center"">
                            <a href=""#"" class=""btn btn-link cor-terciaria-mais-clara titulo-terciario"">Saiba Mais</a>
                        </div>
                    </div>
                </div>
                <div class=""col-12 d-flex justify-content-center"">
                    <button class=""button-materias texto-secundario"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed16cd05aa41390f3686e6ccbc047c10ce077e2425704", async() => {
                WriteLiteral("VER TODAS AS MATÉRIAS");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</button>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-12"">
                    <h1 class=""titulo-principal"">//Podcasts</h1>
                </div>
            </div>
            <div class=""row g-3 mt-4"">
                <div class=""col-sm-6 col-md-4 col-lg-4 my-3"">
                    <h3 class=""titulo-secundario cor-terciaria-mais-clara"">CATEGORIA</h3>
                    <p class=""texto-secundario mt-4"">Brasil perde R$ 1 Trilhão por remuneração desigual a Negros e Pardos</p>
                    <div class=""card text-center"">
                        <img class=""card-img-top"" src=""./img/home/fundo-filtro(pagina-2-cortada).png"" alt=""Card image"" style=""width:100%"">
                        <div class=""card-body text-center"">
                            <a href=""#"" class=""btn btn-link cor-terciaria-mais-clara titulo-terciario"">Saiba Mais</a>
                        </div>
                    </div>
                </div>
             ");
            WriteLiteral(@"   <div class=""col-sm-6 col-md-4 col-lg-4 my-3"">
                    <h3 class=""titulo-secundario cor-terciaria-mais-clara"">CATEGORIA</h3>
                    <p class=""texto-secundario mt-4"">Brasil perde R$ 1 Trilhão por remuneração desigual a Negros e Pardos</p>
                    <div class=""card text-center"">
                        <img class=""card-img-top"" src=""./img/home/fundo-filtro(pagina-2-cortada).png"" alt=""Card image"" style=""width:100%"">
                        <div class=""card-body text-center"">
                            <a href=""#"" class=""btn btn-link cor-terciaria-mais-clara titulo-terciario"">Saiba Mais</a>
                        </div>
                    </div>
                </div>
                <div class=""col-sm-6 col-md-4 col-lg-4 my-3"">
                    <h3 class=""titulo-secundario cor-terciaria-mais-clara"">CATEGORIA</h3>
                    <p class=""texto-secundario mt-4"">Brasil perde R$ 1 Trilhão por remuneração desigual a Negros e Pardos</p>
                   ");
            WriteLiteral(@" <div class=""card text-center"">
                        <img class=""card-img-top"" src=""./img/home/fundo-filtro(pagina-2-cortada).png"" alt=""Card image"" style=""width:100%"">
                        <div class=""card-body text-center"">
                            <a href=""#"" class=""btn btn-link cor-terciaria-mais-clara titulo-terciario"">Saiba Mais</a>
                        </div>
                    </div>
                </div>
                <div class=""col-12 d-flex justify-content-center"">
                    <button class=""button-podcasts texto-secundario"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed16cd05aa41390f3686e6ccbc047c10ce077e2430208", async() => {
                WriteLiteral("OUVIR TODOS OS PODCASTS");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</button>
                </div>
            </div>
        </div>
    </section>
    <!--Fim de estrutura da pagina 5-->
    <!--Inicio de estrutura da pagina 6-->

    <!--Fim de estrutura da pagina 6-->
    <!--Inicio de estrutura da pagina 7-->
    <!--Fim de estrutura da pagina 7-->
    <!--Inicio de estrutura da pagina 8-->
    <aside class=""row container-equipe"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12 text-center"">
                    <h2 class=""titulo-principal titulo-equipe"">
                        <strong>//EQUIPE</strong>
                    </h2>
                </div>
            </div>
            <div class=""row mt-4 d-flex justify-content-center"">
                <div class=""col-sm-6 col-md-4 col-lg-2 my-3"">
                    <div class=""card conteudo-equipe"">
                        <img class=""card-img-top img-equipe"" src=""./img/home/equipe/andre.jpg"" alt=""Card image"">
                        <div class=""ca");
            WriteLiteral(@"rd-body"">
                            <h4 class=""card-title text-center""><a class=""link"" href=""https://www.linkedin.com/in/andrelmmiranda/"" target=""_blanck"">André Miranda</a></h4>
                        </div>
                    </div>
                </div>
                <div class=""col-sm-6 col-md-4 col-lg-2 my-3"">
                    <div class=""card conteudo-equipe"">
                        <img class=""card-img-top img-equipe"" src=""./img/home/equipe/julio.jpg"" alt=""Card image"">
                        <div class=""card-body"">
                            <h4 class=""card-title text-center""><a class=""link"" href=""https://www.linkedin.com/in/julio-henrique-diaz-viana-dos-santos-209009201/"" target=""_blanck"">Julio Santos</a></h4>
                        </div>
                    </div>
                </div>
                <div class=""col-sm-6 col-md-4 col-lg-2 my-3"">
                    <div class=""card conteudo-equipe"">
                        <img class=""card-img-top img-equipe"" src=""./img");
            WriteLiteral(@"/home/equipe/sandro.jpg"" alt=""Card image"">
                        <div class=""card-body"">
                            <h4 class=""card-title text-center""><a class=""link"" href=""https://www.linkedin.com/in/sandro-rodrigues-barros/"" target=""_blanck"">Sandro Barros</a></h4>
                        </div>
                    </div>
                </div>
                <div class=""col-sm-6 col-md-4 col-lg-2 my-3"">
                    <div class=""card conteudo-equipe"">
                        <img class=""card-img-top img-equipe"" src=""./img/home/equipe/tamara.jpg"" alt=""Card image"">
                        <div class=""card-body"">
                            <h4 class=""card-title text-center""><a class=""link"" href=""https://www.linkedin.com/in/tamara-vieira-38ba2715a/"" target=""_blanck"">Tamara Vieira</a></h4>
                        </div>
                    </div>
                </div>
                <div class=""col-sm-6 col-md-4 col-lg-2 my-3"">
                    <div class=""card conteudo-equipe"">
 ");
            WriteLiteral(@"                       <img class=""card-img-top img-equipe"" src=""./img/home/equipe/thais.jpg"" alt=""Card image"">
                        <div class=""card-body"">
                            <h4 class=""card-title text-center""><a class=""link"" href=""https://www.linkedin.com/in/thais-dos-santos-9858701b2/"" target=""_blanck"">Thais dos Santos</a></h4>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </aside>
    <!--Fim de estrutura da pagina 8-->
    <!--Inicio do svg-->
    <svg class=""mask"">
        <clipPath id=""svgMask"">
            <path d=""M119.39 10.1144C124.139 7.54709 129.861 7.54709 134.61 10.1144L180.24 34.7856L224.421 61.967C229.019 64.7955 231.88 69.7516 232.031 75.1474L233.48 127L232.031 178.853C231.88 184.248 229.019 189.204 224.421 192.033L180.24 219.214L134.61 243.886C129.861 246.453 124.139 246.453 119.39 243.886L73.76 219.214L29.579 192.033C24.9814 189.204 22.1201 184.248 21.9692 178.853L20.52 127L21.9692 75.1474C22.");
            WriteLiteral(@"1201 69.7516 24.9814 64.7955 29.579 61.967L73.76 34.7856L119.39 10.1144Z"" fill=""#C4C4C4"" />
        </clipPath>
    </svg>
    <!--Fim do svg-->
    <!--Observacao: Esse svg é utilizado como mascara nas imagens das profissoes da pagina 3 parte 2-->
    <!--Link do bootstrap-->
</div>");
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