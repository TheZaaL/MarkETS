using System;
using System.Collections.Generic;
using Microsoft.Win32;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition;
using System.IO;
using MarkETS.Models.Traders;

namespace MarkETS.AssemblyResolvers
{
    internal class TraderAssembilesResolver
    {
        private CompositionContainer _container;
        private AggregateCatalog _aggregate;

        public TraderAssembilesResolver()
        {
            _aggregate = new AggregateCatalog();
            _container = new CompositionContainer(_aggregate);
        }

        public void loadAssemblies(params object[] targets)
        {
            foreach (var location in GetAssembliesLocation())
            {
                try
                {
                    DirectoryCatalog dirCatalog = new DirectoryCatalog(Path.GetDirectoryName(location), Path.GetFileName(location));
                    var filtCatalog = new FilteredCatalog(dirCatalog,
                        filter => filter.ExportDefinitions.Any(
                            definition => definition.ContractName == typeof(ITrader).AssemblyQualifiedName));

                    if(filtCatalog.Any())
                        _aggregate.Catalogs.Add(filtCatalog);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

            try
            {
                _container.ComposeParts(targets);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private List<string> GetAssembliesLocation()
        {
            var list = new List<string>();

            try
            {
                string traderskeyName = Environment.Is64BitProcess ? @"SOFTWARE\WOW6432Node\MarkETS\Traders" : @"SOFTWARE\MarkETS\Traders";
                RegistryKey tradersKey = Registry.LocalMachine.OpenSubKey(traderskeyName, false);

                var traders = tradersKey?.GetSubKeyNames();

                foreach (var trader in traders)
                {
                    var traderKey = tradersKey.OpenSubKey(trader);
                    if (traderKey == null) continue;

                    Boolean.TryParse(traderKey.GetValue("Enabled")?.ToString(), out bool isEnabled);

                    if (isEnabled)
                    {
                        var traderLocation = traderKey.GetValue("Path")?.ToString();
                        if (!string.IsNullOrWhiteSpace(traderLocation)) list.Add(traderLocation);
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

            return list;
        }
    }
}
