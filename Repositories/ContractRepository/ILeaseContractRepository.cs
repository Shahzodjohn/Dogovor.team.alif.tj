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
        public Task<Response> AddPlaceAndDateofRelease(PlaceAndDateofReleaseDTO releaseDTO);
        public Task<Response> AddBankSignatoryData(BankSignatoryDataDTO releaseDTO);
        public Task<Response> AddContragentInfo(ContragentInfoDTO contragentInfo);
        public Task<Response> AddNonresidentalLease(NonresidentalLeaseDTO dto);
        public Task<Response> AddRoomInfo(RoomInfoDTO dto);
        public Task<Response> AddRentalPayment(RentalPaymentDTO dto);
        public Task<Response> AddSubrental(SubrentalDTO dto);
        public Task<Response> AddTaxes(TaxesDTO dto);
        public Task<Response> AddAddresses(AddressesDTO dto);
    }
}
