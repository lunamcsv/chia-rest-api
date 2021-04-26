using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chia_rest_api.Model
{
    public class GetNetworkSpaceRequest
    {
        public string newer_block_header_hash { get; set; }
        public string older_block_header_hash { get; set; }
    }

    public class GetNetworkSpaceResult
    {
        public long space { get; set; }
        public long spaceKiB { get => space / 1024; }
        public long spaceMiB { get => spaceKiB / 1024; }
        public long spaceGiB { get => spaceMiB / 1024; }
        public long spaceTiB { get => spaceGiB / 1024; }
        public long spacePiB { get => spaceTiB / 1024; }
        public long spaceEiB { get => spacePiB / 1024; }
        public long spaceYiB { get => spaceEiB / 1024; }
        public bool success { get; set; }
    }
}
