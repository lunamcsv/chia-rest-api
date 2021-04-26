using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chia_rest_api.Model
{
    public class GetUnfinishedBlockHeadersResponse
    {
        public List<object> headers { get; set; }
        public bool success { get; set; }
    }
}
