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
        public Task<string> InsertNonresidentalLease(NonresidentalLeaseDTO dto);
        public Task<string> InsertRoomInfo(RoomInfoDTO dto);
        public Task<string> AddRentalPayment(RentalPaymentDTO dto);
        public Task<string> AddSubrental(SubrentalDTO dto);
        public Task<string> AddTaxes(TaxesDTO dto);
        public Task<string> AddAddresses(AddressesDTO dto);
    }
}
