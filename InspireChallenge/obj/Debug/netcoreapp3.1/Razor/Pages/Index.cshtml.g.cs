#pragma checksum "C:\Users\devan\source\repos\InspireChallenge\InspireChallenge\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02d9dc1ec5a92794ee57a55406f9eb1fdfc9584d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(InspireChallenge.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace InspireChallenge.Pages
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
#line 1 "C:\Users\devan\source\repos\InspireChallenge\InspireChallenge\Pages\_ViewImports.cshtml"
using InspireChallenge;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02d9dc1ec5a92794ee57a55406f9eb1fdfc9584d", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48c3c55334ea514173dc1d0c1711cc5bb39bb95d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\devan\source\repos\InspireChallenge\InspireChallenge\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";
    DateTime localDate = DateTime.Now;

    int index = Model.counter;
    int hour = localDate.Hour;
    string timeMessage = "Good Morning";
    string widgetColor = "#fcd14d";
    if (hour >= 12 && hour < 17) { timeMessage = "Good Afternoon"; widgetColor = "#EF810E"; }
    if (hour >= 17 && hour < 22) { timeMessage = "Good Evening"; widgetColor = "#053752"; }
    if (hour >= 22 && hour < 24) { timeMessage = "Good Night"; widgetColor = "#001A26"; }
    if (hour >= 0 && hour < 6) { timeMessage = "Good Night"; widgetColor = "#001A26"; }


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Head", async() => {
                WriteLiteral("\r\n    <style>\r\n    body {\r\n        /* The image used */\r\n        background-image: url(");
#nullable restore
#line 22 "C:\Users\devan\source\repos\InspireChallenge\InspireChallenge\Pages\Index.cshtml"
                          Write(Model.image.url);

#line default
#line hidden
#nullable disable
                WriteLiteral(@");
        /* Full height */
        height: 100%;
        /* Center and scale the image nicely */
        background-position: center;
        background-repeat: no-repeat;
        background-size: cover;
    }

    .widget a:link {
        text-decoration:none;
        color: white;
    }

    #drag-1, #drag-2, #drag-3 {
        width: 20%;
        min-height: 6.5em;
        margin: 1rem 0 0 1rem;
        background-color: ");
#nullable restore
#line 40 "C:\Users\devan\source\repos\InspireChallenge\InspireChallenge\Pages\Index.cshtml"
                      Write(widgetColor);

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
        color: white;
        border-radius: 0.75em;
        padding: 4%;
        touch-action: none;
        user-select: none;
        -webkit-transform: translate(0px, 0px);
        transform: translate(0px, 0px);
    }

    button {
        background: none;
        border: none;
        margin: 0;
        padding: 0;
        cursor: pointer;
        color: white;
    }

    #changeBackground {
        background-color: ");
#nullable restore
#line 60 "C:\Users\devan\source\repos\InspireChallenge\InspireChallenge\Pages\Index.cshtml"
                      Write(widgetColor);

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n        color: white;\r\n    }\r\n\r\n    </style>\r\n");
            }
            );
            WriteLiteral(@"

<div class=""text-center"">

    <div class=""widget"">

        <div id=""drag-1"" class=""draggable"">
            <div class=""row weather"">
                <div class=""col"">
                    <h3 id=""set-weather""></h3>
                    <p id=""set-weather-min""></p>
                    <p id=""set-weather-max""></p>
                </div>
                <div class=""col"">
                    <img id=""set-weather-image"" />
                    <p id=""set-weather-desc""></p>
                    <button id=""changeTempF""></button>
                    <button id=""changeTempC""></button>
                </div>
            </div>
        </div>

        <div id=""drag-2"" class=""draggable"">
            <div>
                <div id=""quote-content"">
                    ");
#nullable restore
#line 91 "C:\Users\devan\source\repos\InspireChallenge\InspireChallenge\Pages\Index.cshtml"
               Write(Html.Raw(Model.quotes[index].content.rendered));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <h5><i id=\"title\">- ");
#nullable restore
#line 93 "C:\Users\devan\source\repos\InspireChallenge\InspireChallenge\Pages\Index.cshtml"
                               Write(Model.quotes[index].title.rendered);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></h5>\r\n            </div>\r\n            <button id=\"updateQuote\">New Quote?</button>\r\n        </div>\r\n\r\n        <div id=\"drag-3\" class=\"draggable\">\r\n            <h5><button id=\"change\"></button></h5>\r\n            <h3 id=\"time\"></h3>\r\n            <h5>");
#nullable restore
#line 101 "C:\Users\devan\source\repos\InspireChallenge\InspireChallenge\Pages\Index.cshtml"
            Write(timeMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        </div>\r\n\r\n        <div id=\"drag-4\" class=\"draggable\">\r\n            <button id=\"changeBackground\" class=\"btn\">New Image?</button>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
    var dragEvents = (function () {
            function initialize() {
                window.dragMoveListener = dragMoveListener;

                interact('.draggable')
                    .draggable({
                        // enable inertial throwing
                        inertia: true,
                        // keep the element within the area of it's parent
                        modifiers: [
                            interact.modifiers.restrictRect({
                                restriction: 'parent',
                                endOnly: true
                            })
                        ],
                        // enable autoScroll
                        autoScroll: true,

                        listeners: {
                            // call this function on every dragmove event
                            move: dragMoveListener,

                        }
                    })
           }



           function dragMoveListen");
                WriteLiteral(@"er(event) {
               var target = event.target
               // keep the dragged position in the data-x/data-y attributes
               var x = (parseFloat(target.getAttribute('data-x')) || 0) + event.dx
               var y = (parseFloat(target.getAttribute('data-y')) || 0) + event.dy

               // translate the element
               target.style.webkitTransform =
                   target.style.transform =
                   'translate(' + x + 'px, ' + y + 'px)'

               // update the posiion attributes
               target.setAttribute('data-x', x)
               target.setAttribute('data-y', y)
           }

            return {
                Init: initialize
            }
    })();

    var currentPage = (function () {
        //Global Variables
        var timer;
        var clockFormat;
        var currentQuote = ");
#nullable restore
#line 166 "C:\Users\devan\source\repos\InspireChallenge\InspireChallenge\Pages\Index.cshtml"
                       Write(index);

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
        var city;
        var stateID;
        var countryID;
        function initialize() {
                 startClock(0);
                 getLocation(""imperial"");

                $('#changeBackground').click(function () {
                    updateBackground();
                });

                $('#changeTempC').click(function () {
                    updateTemp(""metric"");
                });

                $('#changeTempF').click(function () {
                    updateTemp(""imperial"");
                });

                $('#updateQuote').click(function () {
                    changeQuote();
                });

                 $('#change').click(function () {
                     clearInterval(timer);
                     if (clockFormat == 0) {
                         startClock(1);
                     } else {
                         startClock(0);
                     }
                 });
        }

         /* Change Background Image */
        fu");
                WriteLiteral(@"nction updateBackground() {
            // Uses the server as a rest api to call my RandomImage function
            $.get(""?handler=RandomImage"").then(function (d) {
                $(""body"").css(""background-image"", ""url("" + d.url + "")"");
            });
        }

        /* Grab Location For Weather */
        function getLocation(tempType) {
            if (navigator.geolocation) {
                $.ajax({
                    url: ""https://geolocation-db.com/jsonp"",
                    jsonpCallback: ""callback"",
                    dataType: ""jsonp"",
                    success: function (location) {
                        countryID = location.country_code;
                        city = location.city;
                        stateID = ""ID"";
                        //location.state
                        updateTemp(tempType);
                    }
                });
            } else {
                //Defualts
                countryID = ""US"";
                stateID = ""TX"";");
                WriteLiteral(@"
                city = ""Dallas"";
                updateTemp(tempType);
            }
        }

        /* Change Temperature */
        function updateTemp(tempType) {
            // Local Variables
            var iconURL = ""https://openweathermap.org/img/wn/"";
            var iconType = "".png"";

            var symbol = tempType == ""imperial"" ? symbol = ""<span>&#8457;</span>"" : symbol = ""<span>&#8451;</span>"";

            // Uses the server as a rest api to call my ChangeWeather function
            $.get(""?handler=ChangeWeather"", { city: city, stateID: stateID, countryID: countryID, tempType: tempType }).then(function (d) {
                $(""#set-weather"").html(d.main.temp.toFixed(0) + symbol);
                $(""#set-weather-min"").html(""Low: "" + d.main.temp_min.toFixed(0));
                $(""#set-weather-max"").html(""High: "" + d.main.temp_max.toFixed(0));
                $(""#set-weather-image"").attr(""src"", iconURL + d.weather[0].icon + iconType);
                $(""#set-weather-des");
                WriteLiteral(@"c"").html(d.weather[0].description);
                $(""#changeTempF"").html(""<span>&#8457;</span>"");
                $(""#changeTempC"").html(""<span>&#8451;</span>"");

            });
         }

        /* Clock Functionality */
        function startClock(format) {
             var d = new Date();
             ap = ""am"";
             h = d.getHours();
             m = d.getMinutes();
             s = d.getSeconds();
             if (format == 0) {
                 clockFormat = 0;
                 if (h > 11) { ap = ""pm""; }
                 if (h > 12) { h = h - 12; }
                 if (h == 0) { h = 12; }
                 if (m < 10) { m = ""0"" + m; }
                 if (s < 10) { s = ""0"" + s; }
                 $('#change').html(""12 Hour Clock"");
                 $('#time').html(h + "":"" + m + "":"" + s + "" "" + ap);
             } else {
                 clockFormat = 1;
                 if (m < 10) { m = ""0"" + m; }
                 if (s < 10) { s = ""0"" + s; }
                 $('#");
                WriteLiteral(@"change').html(""Military Time"");
                 $('#time').html(h + "":"" + m + "":"" + s);
             }
             timer = setTimeout(function () {
                 startClock(format);
             }, 500);
         };

        /* Change Quote */
        function changeQuote() {
            // Local Variables
            var quotes = ");
#nullable restore
#line 284 "C:\Users\devan\source\repos\InspireChallenge\InspireChallenge\Pages\Index.cshtml"
                     Write(Json.Serialize(Model.quotes));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n            var quoteLength = ");
#nullable restore
#line 285 "C:\Users\devan\source\repos\InspireChallenge\InspireChallenge\Pages\Index.cshtml"
                          Write(Model.quotes.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral(@";

            currentQuote++; // Increment quote index
            currentQuote = currentQuote >= quoteLength ? currentQuote = 0 : currentQuote; //Check quote length
            var quote = quotes[currentQuote];
            $('#quote-content').html(quote.content.rendered);
            $('#title').html(quote.title.rendered);
        };

                return {
                    Init: initialize
                }
     })();

    $(document).ready(function () {
        currentPage.Init();
        dragEvents.Init();
    });
    </script>
");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
