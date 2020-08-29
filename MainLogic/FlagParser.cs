using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFileTool.MainLogic
{
    public static class FlagParser
    {
        public static Dictionary<string, bool> ParseFlags(string flags)
        {
            if (string.IsNullOrWhiteSpace(flags))
                return default;

            var args = new Dictionary<string, bool>() { { "Hidden", false }, { "Readonly", false }, { "System", false } };

            foreach (var arg in flags.Split(' '))
            {
                if (string.IsNullOrWhiteSpace(arg)) continue;

                if (arg.Trim().Contains('-'))
                {
                    switch (arg)
                    {
                        case "-h":
                            args["Hidden"] = true;
                            break;
                        case "-r":
                            args["Readonly"] = true;
                            break;
                        case "-s":
                            args["System"] = true;
                            break;

                        default:
                            break;
                    }
                }
            }

            return args;
        }
    }
}
