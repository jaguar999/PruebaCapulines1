Imports System.Web.Optimization

Public Module BundleConfig
    ' Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
    Public Sub RegisterBundles(ByVal bundles As BundleCollection)

        bundles.Add(New ScriptBundle("~/bundles/jquery").Include(
                    "~/Scripts/jquery-{version}.js"))

        bundles.Add(New ScriptBundle("~/bundles/jqueryval").Include(
                    "~/Scripts/jquery.validate*"))

        ' Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
        ' para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
        bundles.Add(New ScriptBundle("~/bundles/modernizr").Include(
                    "~/Scripts/modernizr-*"))

        bundles.Add(New ScriptBundle("~/bundles/bootstrap").Include(
                  "~/Content/js/vendor/jquery-2.2.4.min.js",
                  "~/Content/js/vendor/bootstrap.min.js",
                  "~/Content/js/owl.carousel.min.js",
                  "~/Content/js/jquery.ajaxchimp.min.js",
                  "~/Content/js/jquery.sticky.js",
                  "~/Content/js/parallax.min.js",
                  "~/Content/js/jquery.magnific-popup.min.js",
                  "~/Content/js/main.js"))

        bundles.Add(New StyleBundle("~/Content/css").Include(
                  "~/Content/css/linearicons.css",
                  "~/Content/css/owl.carousel.css",
                  "~/Content/css/font-awesome.min.css",
                  "~/Content/css/magnific-popup.css",
                  "~/Content/css/bootstrap.css",
                  "~/Content/css/main.css"))
    End Sub
End Module

