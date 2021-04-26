using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chia_rest_api.Model
{
    public class GetBlockRequest
    {
        public string header_hash { get; set; }
    }

    public class ChallengeChainIpProof
    {
        public bool normalized_to_identity { get; set; }
        public string witness { get; set; }
        public int witness_type { get; set; }
    }

    public class ChallengeChainSpProof
    {
        public bool normalized_to_identity { get; set; }
        public string witness { get; set; }
        public int witness_type { get; set; }
    }

    public class PoolTarget
    {
        public int max_height { get; set; }
        public string puzzle_hash { get; set; }
    }

    public class FoliageBlockData
    {
        public string extension_data { get; set; }
        public string farmer_reward_puzzle_hash { get; set; }
        public string pool_signature { get; set; }
        public PoolTarget pool_target { get; set; }
        public string unfinished_reward_block_hash { get; set; }
    }

    public class Foliage
    {
        public FoliageBlockData foliage_block_data { get; set; }
        public string foliage_block_data_signature { get; set; }
        public string foliage_transaction_block_hash { get; set; }
        public string foliage_transaction_block_signature { get; set; }
        public string prev_block_hash { get; set; }
        public string reward_block_hash { get; set; }
    }

    public class FoliageTransactionBlock
    {
        public string additions_root { get; set; }
        public string filter_hash { get; set; }
        public string prev_transaction_block_hash { get; set; }
        public string removals_root { get; set; }
        public string timestamp { get; set; }
        public string transactions_info_hash { get; set; }
    }

    public class InfusedChallengeChainIpProof
    {
        public bool normalized_to_identity { get; set; }
        public string witness { get; set; }
        public int witness_type { get; set; }
    }

    public class Output
    {
        public string data { get; set; }
    }

    public class ChallengeChainIpVdf
    {
        public string challenge { get; set; }
        public string number_of_iterations { get; set; }
        public Output output { get; set; }
    }

    public class ChallengeChainSpVdf
    {
        public string challenge { get; set; }
        public string number_of_iterations { get; set; }
        public Output output { get; set; }
    }

    public class InfusedChallengeChainIpVdf
    {
        public string challenge { get; set; }
        public string number_of_iterations { get; set; }
        public Output output { get; set; }
    }

    public class ProofOfSpace
    {
        public string challenge { get; set; }
        public string plot_public_key { get; set; }
        public object pool_contract_puzzle_hash { get; set; }
        public string pool_public_key { get; set; }
        public string proof { get; set; }
        public int size { get; set; }
    }

    public class RewardChainIpVdf
    {
        public string challenge { get; set; }
        public string number_of_iterations { get; set; }
        public Output output { get; set; }
    }

    public class RewardChainSpVdf
    {
        public string challenge { get; set; }
        public string number_of_iterations { get; set; }
        public Output output { get; set; }
    }

    public class RewardChainBlock
    {
        public ChallengeChainIpVdf challenge_chain_ip_vdf { get; set; }
        public string challenge_chain_sp_signature { get; set; }
        public ChallengeChainSpVdf challenge_chain_sp_vdf { get; set; }
        public int height { get; set; }
        public InfusedChallengeChainIpVdf infused_challenge_chain_ip_vdf { get; set; }
        public bool is_transaction_block { get; set; }
        public string pos_ss_cc_challenge_hash { get; set; }
        public ProofOfSpace proof_of_space { get; set; }
        public RewardChainIpVdf reward_chain_ip_vdf { get; set; }
        public string reward_chain_sp_signature { get; set; }
        public RewardChainSpVdf reward_chain_sp_vdf { get; set; }
        public int signage_point_index { get; set; }
        public string total_iters { get; set; }
        public string weight { get; set; }
    }

    public class RewardChainIpProof
    {
        public bool normalized_to_identity { get; set; }
        public string witness { get; set; }
        public int witness_type { get; set; }
    }

    public class RewardChainSpProof
    {
        public bool normalized_to_identity { get; set; }
        public string witness { get; set; }
        public int witness_type { get; set; }
    }

    public class RewardClaimsIncorporated
    {
        public string amount { get; set; }
        public string parent_coin_info { get; set; }
        public string puzzle_hash { get; set; }
    }

    public class TransactionsInfo
    {
        public string aggregated_signature { get; set; }
        public string cost { get; set; }
        public string fees { get; set; }
        public string generator_refs_root { get; set; }
        public string generator_root { get; set; }
        public List<RewardClaimsIncorporated> reward_claims_incorporated { get; set; }
    }

    public class Block
    {
        public ChallengeChainIpProof challenge_chain_ip_proof { get; set; }
        public ChallengeChainSpProof challenge_chain_sp_proof { get; set; }
        public List<object> finished_sub_slots { get; set; }
        public Foliage foliage { get; set; }
        public FoliageTransactionBlock foliage_transaction_block { get; set; }
        public string header_hash { get; set; }
        public InfusedChallengeChainIpProof infused_challenge_chain_ip_proof { get; set; }
        public RewardChainBlock reward_chain_block { get; set; }
        public RewardChainIpProof reward_chain_ip_proof { get; set; }
        public RewardChainSpProof reward_chain_sp_proof { get; set; }
        public object transactions_generator { get; set; }
        public List<object> transactions_generator_ref_list { get; set; }
        public TransactionsInfo transactions_info { get; set; }
    }

    public class GetBlockResult
    {
        public Block block { get; set; }
        public bool success { get; set; }
    }

    public class GetBlocksRequest
    {
        public string start { get; set; }
        public string end { get; set; }
        public bool exclude_header_hash { get; set; }
    }

    public class GetBlocksResult
    {
        public List<Block> blocks { get; set; }
        public bool success { get; set; }
    }
}
