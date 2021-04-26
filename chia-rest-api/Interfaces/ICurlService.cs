using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chia_rest_api.Interfaces
{
    public interface ICurlService
    {
        void Initialize(string url, int port, string certPath, string keyPath);
        string Execute(string command, string jsonBody);
    }
}
