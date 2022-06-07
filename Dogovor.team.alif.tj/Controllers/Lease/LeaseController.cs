using ConnectionProvider.Context;
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
        private readonly IWebHostEnvironment _environment;
        private readonly AppDbContext _context;

        public LeaseController(ILeaseContractService leaseService, IWebHostEnvironment environment, AppDbContext context)
        {
            _leaseService = leaseService;
            _environment = environment;
            _context = context;
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
        [HttpPost("FirstStep NonResidentalLease")]
        public async Task<IActionResult> InsertNonResidentalLease(NonresidentalLeaseDTO dto)
        {
            var message = await _leaseService.InsertNonresidentalLease(dto);
            if (!message.Contains(200.ToString()))
                return BadRequest(message);
            else return Ok(message);
        }
        [HttpPost("SecondStep RoomInfo")]
        public async Task<IActionResult> InsertRoomInfo(RoomInfoDTO dto)
        {
            var message = await _leaseService.InsertRoomInfo(dto);
            if (!message.Contains(200.ToString()))
                return BadRequest(message);
            else return Ok(message);
        }
        [HttpPost("ThirdStep RentalPayment")]
        public async Task<IActionResult> InsertRoomInfo(RentalPaymentDTO dto)
        {
            var message = await _leaseService.AddRentalPayment(dto);
            if (!message.Contains(200.ToString()))
                return BadRequest(message);
            else return Ok(message);
        }
        [HttpPost("StepFour Subrental")]
        public async Task<IActionResult> InsertSubrental(RentalPaymentDTO dto)
        {
            var message = await _leaseService.AddRentalPayment(dto);
            if (!message.Contains(200.ToString()))
                return BadRequest(message);
            else return Ok(message);
        }
        [HttpPost("StepFive Taxes")]
        public async Task<IActionResult> InsertTaxes(TaxesDTO dto)
        {
            var message = await _leaseService.AddTaxes(dto);
            if (!message.Contains(200.ToString()))
                return BadRequest(message);
            else return Ok(message);
        }
        [HttpPost("StepSix Taxes")]
        public async Task<IActionResult> InsertAddresses(AddressesDTO dto)
        {
            var message = await _leaseService.AddAddresses(dto);
            if (!message.Contains(200.ToString()))
                return BadRequest(message);
            else return Ok(message);
        }
    }
}
