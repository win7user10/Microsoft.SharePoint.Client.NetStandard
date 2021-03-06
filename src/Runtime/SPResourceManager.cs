using System;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Threading;

namespace Microsoft.SharePoint.Client.NetStandard.Runtime
{
    public class SPResourceManager : ResourceManager
    {
        private const string DlsKeyName = "SOFTWARE\\Microsoft\\Shared Tools\\Web Server Extensions\\16.0\\Dls";

        private static volatile bool dlsLoaded = false;

        private static MethodInfo dlsCreateResourceManager = null;

        private ResourceManager innerResourceManager;

        private MethodInfo innerOverrideStringMethod;

#pragma warning disable 414
        private static readonly string DlsResourceManagerFactoryTypeValueName = "ResourceManagerFactoryType";
#pragma warning restore 414

        internal static bool LoadDls()
        {
            if (!SPResourceManager.dlsLoaded)
            {
                Interlocked.CompareExchange<MethodInfo>(ref SPResourceManager.dlsCreateResourceManager, SPResourceManager.FindDls(), null);
                SPResourceManager.dlsLoaded = true;
            }
            return SPResourceManager.dlsCreateResourceManager != null;
        }

        public SPResourceManager(string baseName, Assembly assembly) : base(baseName, assembly)
        {
            if (SPResourceManager.LoadDls())
            {
                try
                {
                    this.innerResourceManager = (ResourceManager)SPResourceManager.dlsCreateResourceManager.Invoke(null, new object[]
                    {
                        baseName,
                        assembly
                    });
                }
                catch (Exception ex)
                {
                    if (!(ex is TargetException) && !(ex is ArgumentException) && !(ex is TargetInvocationException) && !(ex is TargetParameterCountException) && !(ex is MethodAccessException) && !(ex is InvalidOperationException))
                    {
                        throw;
                    }
                    this.innerResourceManager = null;
                }
            }
        }

        public override string GetString(string name, CultureInfo culture)
        {
            try
            {
                if (this.innerResourceManager != null)
                {
                    return this.innerResourceManager.GetString(name, culture);
                }
                return base.GetString(name, culture);
            }
            catch
            {
                return name;
            }
        }

        //Edited for .NET Core
        //public override object GetObject(string name, CultureInfo culture)
        //{
        //    if (this.innerResourceManager != null)
        //    {
        //        return this.innerResourceManager.GetObject(name, culture);
        //    }
        //    return base.GetObject(name, culture);
        //}

        private static MethodInfo FindDls()
        {
            //Edited for .NET Core - no registry in .NET Core
            //MethodInfo result;
            MethodInfo result = null;

            //using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Shared Tools\\Web Server Extensions\\16.0\\Dls", false))
            //{
            //    if (registryKey != null)
            //    {
            //        string text = registryKey.GetValue(SPResourceManager.DlsResourceManagerFactoryTypeValueName) as string;
            //        if (!string.IsNullOrWhiteSpace(text))
            //        {
            //            try
            //            {
            //                result = Type.GetType(text, true, false).GetMethod("CreateResourceManager");
            //                return result;
            //            }
            //            catch (FileLoadException)
            //            {
            //            }
            //            catch (BadImageFormatException)
            //            {
            //            }
            //            catch (AmbiguousMatchException)
            //            {
            //            }
            //            catch (TypeInitializationException)
            //            {
            //            }
            //        }
            //    }
            //    result = null;
            //}
            return result;
        }

        internal bool OverrideString(string name, CultureInfo culture, ref string value)
        {
            if (this.innerResourceManager == null)
            {
                return false;
            }
            //Edited for .NET Core
            //Interlocked.CompareExchange<MethodInfo>(ref this.innerOverrideStringMethod, this.innerResourceManager.GetType().GetMethod("OverrideString"), null);
            Interlocked.CompareExchange<MethodInfo>(ref this.innerOverrideStringMethod, this.innerResourceManager.GetType().GetRuntimeMethod("OverrideString", null), null);
            if (this.innerOverrideStringMethod == null)
            {
                return false;
            }
            object[] array = new object[]
            {
                name,
                culture,
                value
            };
            if (!(bool)this.innerOverrideStringMethod.Invoke(this.innerResourceManager, array))
            {
                return false;
            }
            value = (array[2] as string);
            return true;
        }
    }
}
