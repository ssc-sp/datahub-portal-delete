using Elemental.Components;
using System.ComponentModel.DataAnnotations;

namespace Datahub.Core.EFCore
{
    public class GeoObjectShare
    {
        [AeFormIgnore]
        [Key]
        [StringLength(40)]
        public string GeoObjectShare_ID { get; set; }
        
        [Required]
        public string Json_TXT { get; set; }

        [Required]
        [StringLength(128)]
        public string Email_Contact_TXT { get; set; }

        public int ApprovalForm_ID { get; set; }
        public GeoObjectShareStatus ShareStatus { get; set; }
        public string Approval_Document_URL { get; set; }
        public string Publication_ID { get; set; }
        public bool Deleted { get; set; }
    }

    public enum GeoObjectShareStatus
    {
        FillApprovalForm,
        SubmitApprovalForm,
        WaitingForApproval,
        PublishDataset,
        DatasetPublished
    }
}
