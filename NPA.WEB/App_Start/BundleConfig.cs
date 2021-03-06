﻿using System.Web.Optimization;

namespace NPA.WEB
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.js",
                "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/site.css",
                "~/Content/SortableGrid.css",
                "~/Content/angular-block-ui.min.css",
                "~/Content/font-awesome.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                "~/Scripts/angular.min.js",
                "~/Scripts/angular-route.min.js",
                "~/Scripts/angular-sanitize.min.js",
                "~/Scripts/angular-ui.min.js",
                "~/Scripts/angular-ui/ui-bootstrap.min.js",
                "~/Scripts/angular-ui/ui-bootstrap-tpls.min.js",
                "~/Scripts/angular-ui.min.js",
                "~/Scripts/angular-block-ui.min.js",
                "~/Scripts/angular-animate.min.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/ng-file-upload").Include(
                "~/Scripts/ng-file-upload.min.js"
                ));


            bundles.Add(new ScriptBundle("~/bundles/shared").Include(
                "~/Views/Shared/NpaAngularJSBootStrap.js",
                "~/Views/Shared/AjaxService.js",
                "~/Views/Shared/AlertService.js",
                "~/Views/Shared/DataGridService.js",
                "~/Views/Shared/MasterController.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/routing").Include(
                "~/Views/Shared/NpaAngularJSRouting.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/home").Include(
                "~/Views/Home/IndexController.js"
                ));


            bundles.Add(new ScriptBundle("~/bundles/persons").Include(
                "~/Views/Persons/PersonHandlingController.js",
                "~/Views/Persons/PersonRegistryController.js"
                ));
        }
    }
}
