using Entity;
using Entity.DTOs;
using Entity.ResponseMessage;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ContractRepository
{
    public interface ILeaseContractRepository
    {
        public Task<Response> InsertPlaceAndDateofRelease(PlaceAndDateofReleaseDTO releaseDTO);
        public Task<Response> InsertBankSignatoryData(BankSignatoryDataDTO releaseDTO);
        public Task<Response> InsertContragentInfo(ContragentInfoDTO contragentInfo);
    }
}
