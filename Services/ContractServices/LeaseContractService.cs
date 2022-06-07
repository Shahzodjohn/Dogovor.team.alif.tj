using ConnectionProvider.Context;
using Entity.DTOs;
using Entity.ResponseMessage;
using Repository.ContractRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ContractServices
{
    public class LeaseContractService : ILeaseContractService
    {
        private readonly ILeaseContractRepository _leaseContractRepository;

        public LeaseContractService(ILeaseContractRepository leaseContractRepository)
        {
            _leaseContractRepository = leaseContractRepository;
        }
        Response response = new Response();
        public async Task<string> InsertPlaceAndDateofRelease(PlaceAndDateofReleaseDTO releaseDTO)
        {
            var message = await _leaseContractRepository.AddPlaceAndDateofRelease(releaseDTO);
            if (message == null)
                return response.ToLog("400", "Error! Entity was not added!");
            if (message.Status == 200.ToString())
                return message.Status + ", " + message.Message;
            else
                return response.ToLog(message.Status, message.Message);
        }
        public async Task<string> InsertBankSignatoryData(BankSignatoryDataDTO releaseDTO)
        {
            var message = await _leaseContractRepository.AddBankSignatoryData(releaseDTO);
            if (message == null)
                return response.ToLog("400", "Error! Entities are null!");
            return message.Status + ", " + message.Message;
        }
        public async Task<string> InsertContragentInfo(ContragentInfoDTO contragentInfo)
        {
            var message = await _leaseContractRepository.AddContragentInfo(contragentInfo);
            if (message == null)
                return response.ToLog("400", "Error! Entities are null!");
            return message.Status + ", " + message.Message;
        }

        public async Task<string> InsertNonresidentalLease(NonresidentalLeaseDTO dto)
        {
            var message = await _leaseContractRepository.AddNonresidentalLease(dto);
            if (message == null)
                return response.ToLog("400", "Entity was not saved!");
            if (message.Status == "200")
                return message.Status + ", " + message.Message;
            else
                return response.ToLog(message.Status, message.Message);
        }

        public async Task<string> InsertRoomInfo(RoomInfoDTO dto)
        {
            var message = await _leaseContractRepository.AddRoomInfo(dto);
            if (message == null)
                return response.ToLog("400", "Entity was not saved!");
            if (message.Status == "200")
                return message.Status + ", " + message.Message;
            else
                return response.ToLog(message.Status, message.Message);
        }

        public async Task<string> AddRentalPayment(RentalPaymentDTO dto)
        {
            var message = await _leaseContractRepository.AddRentalPayment(dto);
            if (message == null)
                return response.ToLog("400", "Entity was not saved!");
            if (message.Status == "200")
                return message.Status + ", " + message.Message;
            else
                return response.ToLog(message.Status, message.Message);
        }

        public async Task<string> AddSubrental(SubrentalDTO dto)
        {
            var message = await _leaseContractRepository.AddSubrental(dto);
            if (message == null)
                return response.ToLog("400", "Entity was not saved!");
            if (message.Status == "200")
                return message.Status + ", " + message.Message;
            else
                return response.ToLog(message.Status, message.Message);
        }

        public async Task<string> AddTaxes(TaxesDTO dto)
        {
            var message = await _leaseContractRepository.AddTaxes(dto);
            if (message == null)
                return response.ToLog("400", "Entity was not saved!");
            if (message.Status == "200")
                return message.Status + ", " + message.Message;
            else
                return response.ToLog(message.Status, message.Message);
        }

        public async Task<string> AddAddresses(AddressesDTO dto)
        {
            var message = await _leaseContractRepository.AddAddresses(dto);
            if (message == null)
                return response.ToLog("400", "Entity was not saved!");
            if (message.Status == "200")
                return message.Status + ", " + message.Message;
            else
                return response.ToLog(message.Status, message.Message);
        }
    }
}
