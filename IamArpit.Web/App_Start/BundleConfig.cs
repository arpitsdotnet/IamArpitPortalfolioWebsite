﻿using System.Web;
using System.Web.Optimization;

namespace IamArpit.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Resources/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Resources/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Resources/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Resources/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/others").Include(
                      "~/Resources/Scripts/carousel.js",
                      "~/Resources/Scripts/parallax.js",
                      "~/Resources/Scripts/rotate.js",
                      "~/Resources/Scripts/masonry.js",
                      "~/Resources/Scripts/masonry-4-col.js",
                      "~/Resources/Scripts/custom.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Resources/Content/bootstrap.css",
                      "~/Resources/Content/font-awesome.min.css",
                      "~/Resources/Content/carousel.css",
                      "~/Resources/Content/site.css"));
        }
    }
}
