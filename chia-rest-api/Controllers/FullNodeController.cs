using chia_rest_api.Interfaces;
using chia_rest_api.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace chia_rest_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FullNodeController
    {
        private const string EMPTY_REQUEST = "{\"\":\"\"}";
        private readonly ICurlService _curlService;

        public FullNodeController(ICurlService curlService)
        {
            _curlService = curlService;
            _curlService.Initialize(@"https://localhost", 8555, Path.GetFullPath(@"private_full_node.crt"), Path.GetFullPath(@"private_full_node.key"));
        }

        [HttpGet]
        [Route(nameof(get_blockchain_state))]
        public GetBlockChainStateResult get_blockchain_state()
        {
            string result = _curlService.Execute(nameof(get_blockchain_state), EMPTY_REQUEST);

            return JsonSerializer.Deserialize<GetBlockChainStateResult>(result);
        }

        [HttpGet]
        [Route(nameof(get_block))]
        public GetBlockResult get_block(string header_hash)
        {
            GetBlockRequest request = new() { header_hash = header_hash };
            string result = _curlService.Execute(nameof(get_block), JsonSerializer.Serialize(request));

            return JsonSerializer.Deserialize<GetBlockResult>(result);
        }

        [HttpGet]
        [Route(nameof(get_blocks))]
        public GetBlocksResult get_blocks(string start, string end, bool exclude_header_hash)
        {
            GetBlocksRequest request = new() { start = start, end = end, exclude_header_hash = exclude_header_hash };
            string result = _curlService.Execute(nameof(get_blocks), JsonSerializer.Serialize(request));

            return JsonSerializer.Deserialize<GetBlocksResult>(result);
        }

        [HttpGet]
        [Route(nameof(get_block_record_by_height))]
        public GetBlockRecordResult get_block_record_by_height(string height)
        {
            GetBlockRecordByHeightRequest request = new() { height = height };
            string result = _curlService.Execute(nameof(get_block_record_by_height), JsonSerializer.Serialize(request));

            return JsonSerializer.Deserialize<GetBlockRecordResult>(result);
        }

        [HttpGet]
        [Route(nameof(get_block_record))]
        public GetBlockRecordResult get_block_record(string header_hash)
        {
            GetBlockRecordRequest request = new() { header_hash = header_hash };
            string result = _curlService.Execute(nameof(get_block_record), JsonSerializer.Serialize(request));

            return JsonSerializer.Deserialize<GetBlockRecordResult>(result);
        }

        [HttpGet]
        [Route(nameof(get_block_records))]
        public GetBlockRecordsResult get_block_records(string start, string end)
        {
            GetBlockRecordsRequest request = new() { start = start, end = end };
            string result = _curlService.Execute(nameof(get_block_records), JsonSerializer.Serialize(request));

            return JsonSerializer.Deserialize<GetBlockRecordsResult>(result);
        }

        [HttpGet]
        [Route(nameof(get_unfinished_block_headers))]
        public GetUnfinishedBlockHeadersResponse get_unfinished_block_headers()
        {
            string result = _curlService.Execute(nameof(get_unfinished_block_headers), EMPTY_REQUEST);
            return JsonSerializer.Deserialize<GetUnfinishedBlockHeadersResponse>(result);
        }

        [HttpGet]
        [Route(nameof(get_network_space))]
        public GetNetworkSpaceResult get_network_space(string older_block_header_hash, string newer_block_header_hash)
        {
            GetNetworkSpaceRequest request = new() { older_block_header_hash = older_block_header_hash, newer_block_header_hash = newer_block_header_hash };
            string result = _curlService.Execute(nameof(get_network_space), JsonSerializer.Serialize(request));
            return JsonSerializer.Deserialize<GetNetworkSpaceResult>(result);
        }
    }
}
