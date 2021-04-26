using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chia_rest_api.Model
{
    public class GetBlockRecordByHeightRequest
    {
        public string height { get; set; }
    }

    public class GetBlockRecordRequest
    {
        public string header_hash { get; set; }
    }

    public class GetBlockRecordsRequest
    {
        public string start { get; set; }
        public string end { get; set; }
    }

    public class BlockRecord
    {
        public string challenge_block_info_hash { get; set; }
        public ChallengeVdfOutput challenge_vdf_output { get; set; }
        public int deficit { get; set; }
        public string farmer_puzzle_hash { get; set; }
        public object fees { get; set; }
        public object finished_challenge_slot_hashes { get; set; }
        public object finished_infused_challenge_slot_hashes { get; set; }
        public object finished_reward_slot_hashes { get; set; }
        public string header_hash { get; set; }
        public int height { get; set; }
        public InfusedChallengeVdfOutput infused_challenge_vdf_output { get; set; }
        public bool overflow { get; set; }
        public string pool_puzzle_hash { get; set; }
        public string prev_hash { get; set; }
        public object prev_transaction_block_hash { get; set; }
        public int prev_transaction_block_height { get; set; }
        public string required_iters { get; set; }
        public object reward_claims_incorporated { get; set; }
        public string reward_infusion_new_challenge { get; set; }
        public int signage_point_index { get; set; }
        public object sub_epoch_summary_included { get; set; }
        public string sub_slot_iters { get; set; }
        public object timestamp { get; set; }
        public string total_iters { get; set; }
        public string weight { get; set; }
    }

    public class GetBlockRecordResult
    {
        public BlockRecord block_record { get; set; }
        public bool success { get; set; }
    }

    public class GetBlockRecordsResult
    {
        public List<BlockRecord> block_records { get; set; }
        public bool success { get; set; }
    }
}
