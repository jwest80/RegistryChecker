using Microsoft.Win32;

namespace RegistryChecker
{
    internal class Program
    {
        // Registry Location.
        const string userRoot = "HKEY_CURRENT_USER";
        const string subkey = "Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings";
        const string keyName = "AutoConfigURL";
        const string key = userRoot + "\\" + subkey;

        // Pac File Locations
        const string localPacFile = "C:\\Utils\\proxy.pac";
        const string moaPacFile = "http://pacfile.mutual.local/proxy.pac";

        static int Main(string[] args)
        {

            if (args.Length == 0)
            {
                Console.WriteLine(manPage);
                return 1;
            }

            switch (args[0])
            {
                case "-l":
                case "-local":
                    Registry.SetValue(key, keyName, localPacFile);
                    break;
                case "-m":
                case "-moa":
                    Registry.SetValue(key, keyName, moaPacFile);
                    break;
                case "-s":
                case "-show":
                    WriteKeyValue();
                    break;
                default:
                    Console.WriteLine(manPage);
                    break;
            }
            return 0;
        }

        public static void WriteKeyValue()
        {
            // Get Value
            string value = (string)Registry.GetValue(key, keyName, "");
            Console.WriteLine($"{keyName}: {value}");
        }

        const string manPage = """
            usage: rc [command]

            commands:
              -l, -local (sets to local pac file)
              -m, -moa   (sets to moa pac file)
              -s, -show  (display current value)
            """;
    }
}