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

        public async Task<Response> InsertPlaceAndDateofRelease(PlaceAndDateofReleaseDTO releaseDTO)
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

        public async Task<Response> InsertBankSignatoryData(BankSignatoryDataDTO releaseDTO)
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
        public async Task<Response> InsertContragentInfo(ContragentInfoDTO contragentInfo)
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
    }
}
