using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ContractServices
{
    public interface ILeaseContractService
    {
        public Task<string> InsertPlaceAndDateofRelease(PlaceAndDateofReleaseDTO releaseDTO);
        public Task<string> InsertBankSignatoryData(BankSignatoryDataDTO releaseDTO);
        public Task<string> InsertContragentInfo(ContragentInfoDTO contragentInfo);
    }
}
