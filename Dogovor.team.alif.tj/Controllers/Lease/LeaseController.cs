using Entity.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.ContractServices;

namespace Dogovor.team.alif.tj.Controllers.Lease
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaseController : ControllerBase
    {
        private readonly ILeaseContractService _leaseService;

        public LeaseController(ILeaseContractService leaseService)
        {
            _leaseService = leaseService;
        }

        [HttpPost("Place And Date of Release")]
        public async Task<IActionResult> InsertPlaceAndDateofRelease(PlaceAndDateofReleaseDTO releaseDTO)
        {
            var request = await _leaseService.InsertPlaceAndDateofRelease(releaseDTO);
            if (request.Contains("200"))
                return Ok(request);
            return BadRequest(request);
        }
        [HttpPost("Bank Signatory Data")]
        public async Task <IActionResult> InsertBankSignatoryData(BankSignatoryDataDTO releaseDTO)
        {
            var request = await _leaseService.InsertBankSignatoryData(releaseDTO);
            if (request.Contains("200"))
                return Ok(request);
            return BadRequest(request);
        }
        [HttpPost("Contragent Info")]
        public async Task<IActionResult> InsertContragentInfo(ContragentInfoDTO releaseDTO)
        {
            var request = await _leaseService.InsertContragentInfo(releaseDTO);
            if (request.Contains("200"))
                return Ok(request);
            return BadRequest(request);
        }
    }
}
