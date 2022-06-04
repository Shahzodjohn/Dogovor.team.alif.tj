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
            var message = await _leaseContractRepository.InsertPlaceAndDateofRelease(releaseDTO);
            if (message == null)
                return response.ToLog("400", "Error! Entity was not added!");
            if (message.Status == 200.ToString())
                return message.Status + ", " + message.Message;
            else
                return response.ToLog(message.Status, message.Message);
        }
        public async Task<string> InsertBankSignatoryData(BankSignatoryDataDTO releaseDTO)
        {
            var message = await _leaseContractRepository.InsertBankSignatoryData(releaseDTO);
            if (message == null)
                return response.ToLog("400", "Error! Entities are null!");
            return message.Status + ", " + message.Message;
        }
        public async Task<string> InsertContragentInfo(ContragentInfoDTO contragentInfo)
        {
            var message = await _leaseContractRepository.InsertContragentInfo(contragentInfo);
            if (message == null)
                return response.ToLog("400", "Error! Entities are null!");
            return message.Status + ", " + message.Message;
        }
    }
}
