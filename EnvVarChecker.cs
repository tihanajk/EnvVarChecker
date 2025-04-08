using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Reflection;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace EnvVarChecker
{
    // Do not forget to update version number and author (company attribute) in AssemblyInfo.cs class
    // To generate Base64 string for Images below, you can use https://www.base64-image.de/
    [Export(typeof(IXrmToolBoxPlugin)),
        ExportMetadata("Name", "Environment Variable Checker"),
        ExportMetadata("Description", "Get environment varible info and compare in up to 3 environments - for example, you have DEV, UAT and PROD environments and need compare their values"),
        // Please specify the base64 content of a 32x32 pixels image
        ExportMetadata("SmallImageBase64", "/9j/4AAQSkZJRgABAQEAYABgAAD/4QAiRXhpZgAATU0AKgAAAAgAAQESAAMAAAABAAEAAAAAAAD/2wBDAAYEBQYFBAYGBQYHBwYIChAKCgkJChQODwwQFxQYGBcUFhYaHSUfGhsjHBYWICwgIyYnKSopGR8tMC0oMCUoKSj/2wBDAQcHBwoIChMKChMoGhYaKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCj/wAARCAAgACADASIAAhEBAxEB/8QAHwAAAQUBAQEBAQEAAAAAAAAAAAECAwQFBgcICQoL/8QAtRAAAgEDAwIEAwUFBAQAAAF9AQIDAAQRBRIhMUEGE1FhByJxFDKBkaEII0KxwRVS0fAkM2JyggkKFhcYGRolJicoKSo0NTY3ODk6Q0RFRkdISUpTVFVWV1hZWmNkZWZnaGlqc3R1dnd4eXqDhIWGh4iJipKTlJWWl5iZmqKjpKWmp6ipqrKztLW2t7i5usLDxMXGx8jJytLT1NXW19jZ2uHi4+Tl5ufo6erx8vP09fb3+Pn6/8QAHwEAAwEBAQEBAQEBAQAAAAAAAAECAwQFBgcICQoL/8QAtREAAgECBAQDBAcFBAQAAQJ3AAECAxEEBSExBhJBUQdhcRMiMoEIFEKRobHBCSMzUvAVYnLRChYkNOEl8RcYGRomJygpKjU2Nzg5OkNERUZHSElKU1RVVldYWVpjZGVmZ2hpanN0dXZ3eHl6goOEhYaHiImKkpOUlZaXmJmaoqOkpaanqKmqsrO0tba3uLm6wsPExcbHyMnK0tPU1dbX2Nna4uPk5ebn6Onq8vP09fb3+Pn6/9oADAMBAAIRAxEAPwD3XxnrGpWnivQ9NsJLxLe6tLu4m+x2yTSZje3VfvdF/etnGTnFdlHkRruJLYGSRgmsvW/Duma3PbzajA7zW6ukUkc8kTKrlSwyjA4JReP9kUyHW7OCOxjkWWGO5u2sLct8250D9TzgHy2AJ6nHc07O1xcyvY2aKzH1qDYzxJJJHHeLZSMBja5IXIz1AZgDj39K06OV2uCkm7CMAykHkEYNcvqHh64u/CE+lRPFBdQy+dYTElljdJPMgY98AhQR3APJzXU0U1JqLiJxTkpHNWugT2/hPT9HklW5lDxNeTuxXzTvEkrDv8zbuO27rxXQxzRSO6RyI7JwyqwJX6+lNvo5ZrK4jt5PKmeNljk/uMRwfwNct4Dj8m1tLa48O3Gn39rZrDcXUqR4dxtDKsgYs+4jdnGDjnB4ocm4qPYFFKTl1Z//2Q=="),
        // Please specify the base64 content of a 80x80 pixels image
        ExportMetadata("BigImageBase64", "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"),
        ExportMetadata("BackgroundColor", "Lightblue"),
        ExportMetadata("PrimaryFontColor", "Black"),
        ExportMetadata("SecondaryFontColor", "Gray")]
    public class EnvVarChecker : PluginBase
    {
        public override IXrmToolBoxPluginControl GetControl()
        {
            return new EnvVarCheckerControl();
        }

        /// <summary>
        /// Constructor 
        /// </summary>
        public EnvVarChecker()
        {
            // If you have external assemblies that you need to load, uncomment the following to 
            // hook into the event that will fire when an Assembly fails to resolve
            // AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(AssemblyResolveEventHandler);
        }

        /// <summary>
        /// Event fired by CLR when an assembly reference fails to load
        /// Assumes that related assemblies will be loaded from a subfolder named the same as the Plugin
        /// For example, a folder named Sample.XrmToolBox.MyPlugin 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        private Assembly AssemblyResolveEventHandler(object sender, ResolveEventArgs args)
        {
            Assembly loadAssembly = null;
            Assembly currAssembly = Assembly.GetExecutingAssembly();

            // base name of the assembly that failed to resolve
            var argName = args.Name.Substring(0, args.Name.IndexOf(","));

            // check to see if the failing assembly is one that we reference.
            List<AssemblyName> refAssemblies = currAssembly.GetReferencedAssemblies().ToList();
            var refAssembly = refAssemblies.Where(a => a.Name == argName).FirstOrDefault();

            // if the current unresolved assembly is referenced by our plugin, attempt to load
            if (refAssembly != null)
            {
                // load from the path to this plugin assembly, not host executable
                string dir = Path.GetDirectoryName(currAssembly.Location).ToLower();
                string folder = Path.GetFileNameWithoutExtension(currAssembly.Location);
                dir = Path.Combine(dir, folder);

                var assmbPath = Path.Combine(dir, $"{argName}.dll");

                if (File.Exists(assmbPath))
                {
                    loadAssembly = Assembly.LoadFrom(assmbPath);
                }
                else
                {
                    throw new FileNotFoundException($"Unable to locate dependency: {assmbPath}");
                }
            }

            return loadAssembly;
        }
    }
}