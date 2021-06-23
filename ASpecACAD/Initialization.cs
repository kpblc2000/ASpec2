using Autodesk.AutoCAD.Runtime;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ASpecACAD
{
    public class Initialization : IExtensionApplication
    {
        public void Initialize()
        {
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
        }

        public void Terminate()
        {
        }

        private Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            string name = GetAssemblyName(args);
            string assemblyPath = Path.Combine(Directory.GetCurrentDirectory(), name + ".dll");
            if (File.Exists(assemblyPath))
            {
                Assembly assembly = Assembly.LoadFrom(assemblyPath);
                if (assembly.FullName == args.Name)
                {
                    return assembly;
                }
            }
            return null;
        }

        private string GetAssemblyName(ResolveEventArgs args)
        {
            if (args.Name.IndexOf(",") > -1)
            {
                return args.Name.Substring(0, args.Name.IndexOf(","));
            }
            else
            {
                return args.Name;
            }
        }
    }
}
