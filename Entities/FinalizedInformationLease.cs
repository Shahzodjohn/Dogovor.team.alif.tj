using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class FinalizedInformationLease
    {
        public int Id { get; set; }
        public int? LeaseContractId {get; set; }
        public int? AddressId { get; set; }
        public int? IndividualId { get; set; }
        public int? IndividualEnterpreneurId { get; set; }
        public int? LegalEntityId { get; set; }
        public int? NonResidentalLeaseId { get; set; }
        public int? PaymentWayId { get; set; }
        public int? PremisesOwnerId { get; set; }
        public int? RentalPaymentId { get; set; }
        public int? RoomInfoId { get; set; }
        public int? SubrentalId { get; set; }
        public int? TaxesId { get; set; }



        public virtual LeaseContract LeaseContract { get; set; }
        public virtual Address Address { get; set; }
        public virtual Individual Individual { get; set; }
        public virtual IndividualEnterpreneur IndividualEnterpreneur { get; set; }
        public virtual LegalEntity LegalEntity { get; set; }
        public virtual NonResidentalLease NonResidentalLease { get; set; }
        public virtual PaymentWays PaymentWays { get; set; }
        public virtual PremisesOwner PremisesOwner { get; set; }
        public virtual RentalPayment RentalPayment { get; set; }
        public virtual RoomInfo RoomInfo { get; set; }
        public virtual Subrental Subrental { get; set; }
        public virtual Taxes Taxes { get; set; }

    }
}
