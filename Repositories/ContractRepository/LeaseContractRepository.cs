using ConnectionProvider.Context;
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
    public class LeaseContractRepository : ILeaseContractRepository
    {
        private readonly AppDbContext _context;

        public LeaseContractRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Response> AddPlaceAndDateofRelease(PlaceAndDateofReleaseDTO releaseDTO)
        {
                EntityEntry<PlaceAndDateofRelease> data = null;
                EntityEntry<LeaseContract> formApplication;
            try
            {
                data = await _context.PlacesAndDatesofRelease.AddAsync(new PlaceAndDateofRelease
                {
                    CityId = releaseDTO.CityId,
                    DateOfRelease = releaseDTO.DateOfRelease,
                    DocumentNumber = releaseDTO.DocumentNumber
                });
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return new Response { Status = "400 || Error while adding into rote InsertPlaceAndDateofRelease!", Message = ex.InnerException.ToString() };
            }
            finally
            {
                formApplication = await _context.LeaseContracts.AddAsync(new LeaseContract
                {
                      PlaceAndDateOfReleaseId = data.Entity.Id
                });
                await _context.SaveChangesAsync();
            }
            return new Response { Status = "200", Message = $"OrderId => {formApplication.Entity.Id}" };
        }

        public async Task<Response> AddBankSignatoryData(BankSignatoryDataDTO releaseDTO)
        {
            var findOrder = await _context.LeaseContracts.FindAsync(releaseDTO.OrderId);
            EntityEntry<BankSignatoryData> data = null;
            try
            {
                if (findOrder == null)
                    return new Response { Status = "400", Message = $"order => {releaseDTO.OrderId} wasn't found!" };
                data = await _context.BankSignatoryDatas.AddAsync(new BankSignatoryData
                {
                    ContracterId = releaseDTO.ContracterId,
                    WorkersFullName = releaseDTO.WorkersFullName,
                    CityzenshipId = releaseDTO.CityzenshipId,
                    PositionId = releaseDTO.PositionId,
                    attorney = releaseDTO.attorney,
                    charter = releaseDTO.charter,
                    DocumentNumber = releaseDTO.DocumentNumber,
                    DateofRelease = releaseDTO.DateofRelease,
                });
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return new Response { Status = "400 || Error while adding into rote InsertBankSignatoryData!", Message = ex.InnerException.ToString() };
            }
            finally
            {
                findOrder.BankSignatoryDataId = data.Entity.Id; 
                await _context.SaveChangesAsync();
            }
            return new Response { Status = "200", Message = "Success!" };
        }
        public async Task<Response> AddContragentInfo(ContragentInfoDTO contragentInfo)
        {
            var findOrder = await _context.LeaseContracts.FindAsync(contragentInfo.OrderId);
            EntityEntry<ContragentInfo> data = null;
            try
            {
                data = await _context.ContragentInfos.AddAsync(new ContragentInfo
                {
                    FullName = contragentInfo.FullName,
                    PassportId = contragentInfo.PassportId,
                    AuthorityIssuingName = contragentInfo.AuthorityIssuingName,
                    CitizenshipId = contragentInfo.CitizenshipId,
                    PassportNumber = contragentInfo.PassportNumber,
                    DateofRelease = contragentInfo.DateofRelease,
                });
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return new Response { Status = "400 || Error while adding into rote InsertContragentInfo!", Message = ex.InnerException.ToString() };
            }
            finally
            {
                findOrder.ContrAgentInfoId = data.Entity.Id;
                await _context.SaveChangesAsync();
            }
            return new Response { Status = "200", Message = "Success!" };
        }

        public async Task<Response> AddNonresidentalLease(NonresidentalLeaseDTO dto)
        {
            EntityEntry<NonResidentalLease> lease = null;
            EntityEntry<FinalizedInformationLease> FinalizedLease;
            try
            {
                lease = await _context.NonResidentalLeases.AddAsync(new NonResidentalLease
                {
                    DucumentNumber = dto.DucumentNumber,
                    IndividualId = dto.IndividualId,
                    Individual = dto.Individual,
                    IndividualEnterpreneurId = dto.IndividualEnterpreneurId,
                    IndividualEnterpreneur = dto.IndividualEnterpreneur,
                    LegalEntityId = dto.LegalEntityId,
                    LegalEntity = dto.LegalEntity,
                });
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return new Response { Status = "400 || Error while adding into route Insert Into Document!", Message = ex.InnerException.ToString() };
            }
            finally
            {
                FinalizedLease = await _context.FinalizedInformationLeases.AddAsync(new FinalizedInformationLease
                {
                    NonResidentalLeaseId = lease.Entity.Id
                });
                await _context.SaveChangesAsync();
            }
            return new Response { Status = "200", Message = $"PathId => {FinalizedLease.Entity.Id}" };
        }

        public async Task<Response> AddRoomInfo(RoomInfoDTO dto)
        {
            var findPath = await _context.FinalizedInformationLeases.FindAsync(dto.PathId);
            EntityEntry<RoomInfo> roomInfo = null;
            try
            {
                if (findPath == null)
                    return new Response { Status = "400", Message = $"PathId => {dto.PathId} wasn't found!" };
                roomInfo = await _context.RoomInfos.AddAsync(new RoomInfo
                {
                    Address = dto.Address,
                    OwningReason = dto.OwningReason,
                    ContractDeadline = dto.ContractDeadline,
                    Quadrature = dto.Quadrature,
                    DocumentDate = dto.DocumentDate,
                });
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return new Response { Status = "400 || Error while adding into route Insert Room Info!", Message = ex.InnerException.ToString() };
            }
            finally
            {
                findPath.RoomInfoId = roomInfo.Entity.Id;
                await _context.SaveChangesAsync();
            }
            return new Response { Status = "200", Message = "Success!" };
        }

        public async Task<Response> AddRentalPayment(RentalPaymentDTO dto)
        {
            var findPath = await _context.FinalizedInformationLeases.FindAsync(dto.PathId);
            EntityEntry<RentalPayment> rentalPayment = null;
            try
            {
                if (findPath == null)
                    return new Response { Status = "400", Message = $"PathId => {dto.PathId} wasn't found!" };
                rentalPayment = await _context.RentalPayment.AddAsync(new RentalPayment
                {
                    AreTaxesIncluded = dto.AreTaxesIncluded,
                    RentalPrice = dto.RentalPrice,
                    MonthlyPayment = dto.MonthlyPayment,
                    PrePayment = dto.PrePayment,
                    PrePaymentDeadline = dto.PrePaymentDeadline,
                    MonthlyPaymentDeadline = dto.MonthlyPaymentDeadline,
                    PaymentWayId = dto.PaymentWayId,
                });
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return new Response { Status = "400 || Error while adding into route Add Rental Payment!", Message = ex.InnerException.ToString() };
            }
            finally
            {
                findPath.RoomInfoId = rentalPayment.Entity.Id;
                await _context.SaveChangesAsync();
            }
            return new Response { Status = "200", Message = "Success!" };
        }

        public async Task<Response> AddSubrental(SubrentalDTO dto)
        {
            var findPath = await _context.FinalizedInformationLeases.FindAsync(dto.PathId);
            EntityEntry<Subrental> subrental = null;
            try
            {
                if (findPath == null)
                    return new Response { Status = "400", Message = $"PathId => {dto.PathId} wasn't found!" };
                subrental = await _context.Subrentals.AddAsync(new Subrental
                {
                    possibleSubrental = dto.possibleSubrental
                });
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return new Response { Status = "400 || Error while adding into route Add Subrental!", Message = ex.InnerException.ToString() };
            }
            finally
            {
                findPath.RoomInfoId = subrental.Entity.Id;
                await _context.SaveChangesAsync();
            }
            return new Response { Status = "200", Message = "Success!" };
        }

        public async Task<Response> AddTaxes(TaxesDTO dto)
        {
            var findPath = await _context.FinalizedInformationLeases.FindAsync(dto.PathId);
            EntityEntry<Taxes> taxes = null;
            try
            {
                if (findPath == null)
                    return new Response { Status = "400", Message = $"PathId => {dto.PathId} wasn't found!" };
                taxes = await _context.Taxes.AddAsync(new Taxes
                {
                    BankWithholdTaxes = dto.BankWithholdTaxes,
                     OwnerPaysTaxes = dto.OwnerPaysTaxes
                });
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return new Response { Status = "400 || Error while adding into route Add Taxes!", Message = ex.InnerException.ToString() };
            }
            finally
            {
                findPath.RoomInfoId = taxes.Entity.Id;
                await _context.SaveChangesAsync();
            }
            return new Response { Status = "200", Message = "Success!" };
        }

        public async Task<Response> AddAddresses(AddressesDTO dto)
        {
            var findPath = await _context.FinalizedInformationLeases.FindAsync(dto.PathId);
            EntityEntry<Address> address = null;
            try
            {
                if (findPath == null)
                    return new Response { Status = "400", Message = $"PathId => {dto.PathId} wasn't found!" };
                address = await _context.Addresses.AddAsync(new Address
                {
                     HomeAddress = dto.HomeAddress,
                      OwnerINN = dto.OwnerINN
                });
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return new Response { Status = "400 || Error while adding into route Add Addresses!", Message = ex.InnerException.ToString() };
            }
            finally
            {
                findPath.RoomInfoId = address.Entity.Id;
                await _context.SaveChangesAsync();
            }
            return new Response { Status = "200", Message = "Success!" };
        }
    }
}
