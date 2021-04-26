using chia_rest_api.Interfaces;
using chia_rest_api.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace chia_rest_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HarvesterController
    {
        private const string EMPTY_REQUEST = "{\"\":\"\"}";
        private readonly ICurlService _curlService;

        public HarvesterController(ICurlService curlService)
        {
            _curlService = curlService;
            _curlService.Initialize(@"https://localhost", 8560, Path.GetFullPath(@"private_full_node.crt"), Path.GetFullPath(@"private_full_node.key"));
        }

        [HttpGet]
        [Route(nameof(get_plots))]
        public GetPlotsResult get_plots()
        {
            string result = _curlService.Execute(nameof(get_plots), EMPTY_REQUEST);

            return JsonSerializer.Deserialize<GetPlotsResult>(result);
        }

        [HttpGet]
        [Route(nameof(refresh_plots))]
        public string refresh_plots()
        {
            string result = _curlService.Execute(nameof(refresh_plots), EMPTY_REQUEST);
            return result;
            //return JsonSerializer.Deserialize<GetPlotsResult>(result);
        }

        [HttpGet]
        [Route(nameof(add_plot_directory))]
        public string add_plot_directory(string dirname)
        {
            PlotDirectoryRequest request = new() { dirname = dirname };
            string result = _curlService.Execute(nameof(add_plot_directory), JsonSerializer.Serialize(request));
            return result;
            //return JsonSerializer.Deserialize<GetPlotsResult>(result);
        }

        [HttpGet]
        [Route(nameof(get_plot_directories))]
        public GetPlotDirectoriesResult get_plot_directories()
        {
            string result = _curlService.Execute(nameof(get_plot_directories), EMPTY_REQUEST);

            return JsonSerializer.Deserialize<GetPlotDirectoriesResult>(result);
        }

        [HttpGet]
        [Route(nameof(remove_plot_directory))]
        public string remove_plot_directory(string dirname)
        {
            PlotDirectoryRequest request = new() { dirname = dirname };
            string result = _curlService.Execute(nameof(remove_plot_directory), JsonSerializer.Serialize(request));
            return result;
            //return JsonSerializer.Deserialize<GetPlotsResult>(result);
        }

        [HttpGet]
        [Route(nameof(delete_plot))]
        public string delete_plot(string filename)
        {
            PlotFileRequest request = new() { filename = filename };
            string result = _curlService.Execute(nameof(delete_plot), JsonSerializer.Serialize(request));
            return result;
            //return JsonSerializer.Deserialize<GetPlotsResult>(result);
        }
    }
}