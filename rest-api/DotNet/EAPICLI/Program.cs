using SSoTme.Default.Lib.CLIHandler;
using System;
using System.IO;
using System.Reflection;

namespace EAPICLI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CheckPATHEnvironmentVariable();
                EAPICLIHandler.HandleRequest(args);
            }
            catch (Exception ex)
            {
                Console.WriteLine("EXCEPTION: ");
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Stacktrace............................");
                Console.WriteLine(ex.StackTrace);
                Environment.ExitCode = -1;
            }
        }


        private static void CheckPATHEnvironmentVariable()
        {
            var ea = Assembly.GetExecutingAssembly();
            var fi = new FileInfo(ea.Location);
            var finalPath = fi.Directory.FullName;
            var noPathTxt = new FileInfo(Path.Combine(finalPath, "nopath.txt"));
            if (!noPathTxt.Exists)
            {
                try
                {
                    AddPathSegments(finalPath);
                    File.WriteAllText(noPathTxt.FullName, "");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Run as administrator to update path: {noPathTxt.FullName}");
                }
            }
        }

        /// <summary>
        /// Adds an environment path segments (the PATH varialbe).
        /// </summary>
        /// <param name="pathSegment">The path segment.</param>
        public static void AddPathSegments(string pathSegment)
        {
            string allPaths = Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.Machine);
            if (allPaths != null)
            {
                if (!allPaths.Contains(pathSegment))
                {
                    Console.WriteLine("Would you like to update the path? (Y/n)");
                    var key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Y)
                    {
                        allPaths = pathSegment + "; " + allPaths;
                    }
                    else return;
                }
            }
            else allPaths = pathSegment;
            Environment.SetEnvironmentVariable("PATH", allPaths, EnvironmentVariableTarget.Machine);
        }

    }
}
