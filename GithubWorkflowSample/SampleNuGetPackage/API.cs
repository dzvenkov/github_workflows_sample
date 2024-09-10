using System.Reflection;

namespace SampleNuGetPackage
{
    public class API
    {
        public static string GetVersion()
        {
            // Get the Assembly which contains the code that is currently executing.
            var assembly = Assembly.GetExecutingAssembly();

            // Get the version attribute and return the version as a string.
            var versionAttribute = assembly.GetCustomAttribute<AssemblyFileVersionAttribute>();
            return versionAttribute?.Version ?? "Version not found";
        }
    }
}
