using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace chia_rest_api.Model
{
    public class Plot
    {
        public object file_size { get; set; }
        public string filename { get; set; }

        [JsonPropertyName("plot-seed")]
        public string PlotSeed { get; set; }
        public string plot_public_key { get; set; }
        public object pool_contract_puzzle_hash { get; set; }
        public string pool_public_key { get; set; }
        public int size { get; set; }
        public double time_modified { get; set; }
    }

    public class GetPlotsResult
    {
        public List<string> failed_to_open_filenames { get; set; }
        public List<string> not_found_filenames { get; set; }
        public List<Plot> plots { get; set; }
        public bool success { get; set; }
    }

    public class PlotDirectoryRequest
    {
        public string dirname { get; set; }
    }

    public class PlotFileRequest
    {
        public string filename { get; set; }
    }

    public class GetPlotDirectoriesResult
    {
        public List<string> directories { get; set; }
        public bool success { get; set; }
    }
}
