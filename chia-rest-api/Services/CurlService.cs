using chia_rest_api.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace chia_rest_api.Services
{
    public class CurlService : ICurlService
    {
        private string url;
        private string certPath;
        private string keyPath;
        private int port;

        public string Execute(string command, string jsonBody)
        {
            ProcessStartInfo processStartInfo = new()
            {
                FileName = @"curl",
                Arguments = $"-X POST {url}:{port}/{command}" +
                    $" --cert {certPath}" +
                    $" --key {keyPath}" +
                    " -H \"Content-Type: application/json\"" +
                    $" --insecure -d \"{jsonBody.Replace("\"","\\\"")}\"",
                RedirectStandardOutput = true
            };

            Process process = Process.Start(processStartInfo);
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            return output;
        }

        public void Initialize(string url, int port, string certPath, string keyPath)
        {
            this.url = url;
            this.certPath = certPath;
            this.keyPath = keyPath;
            this.port = port;
        }
    }
}
