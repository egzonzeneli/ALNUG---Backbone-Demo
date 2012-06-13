using System.Web;
using System.Web.Optimization;
using ALNUG.WebEv2012.Contacs.Infrastructure;

namespace ALNUG.WebEv2012.Contacs
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Public/js/libs/jquery-1.*"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Public/js/libs/jquery-ui*"));

            #region scr - jqueryVal - commented

            /*
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));
            */

            #endregion

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Public/js/libs/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/backbone").Include(
                         "~/Public/js/libs/underscore.js",
                         "~/Public/js/libs/backbone.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                         "~/Public/js/libs/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/less").Include("~/Public/js/libs/less*"));

            bundles.Add(new ScriptBundle("~/bundles/myScript").Include("~/Public/js/alnug.*"));

            bundles.Add(new ScriptBundle("~/bundles/test").Include("~/Public/js/test.js"));
            
            bundles.Add(new ScriptBundle("~/bundles/jsrender").Include("~/Public/js/libs/jsrender.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Public/stylesheets/site.css"));
            bundles.Add(new StyleBundle("~/Content/less").Include(
                        "~/Public/stylesheets/bootstrap.min.css",
                        "~/Public/stylesheets/bootstrap-responsive.min.css"));


           


            //var lessBundel = new Bundle("~/Content/Less")
            //                .Include("~/Public/stylesheets/twtboot/bootstrap.less");
            //lessBundel.Transforms.Add(new LessTransform());
            //lessBundel.Transforms.Add(new CssMinify());
            //bundles.Add(lessBundel);

            #region css - jquery - commented
            /*
            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));
             */
            #endregion

        }
    }
}