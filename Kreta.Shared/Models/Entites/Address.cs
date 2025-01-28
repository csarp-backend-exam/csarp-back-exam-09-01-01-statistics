using Kreta.Shared.Models.Entites.SchoolCitizens;
using System.Drawing;

namespace Kreta.Shared.Models.Entites
{
    public class Address : IDbEntity<Address>
    {
        public Guid Id { get; set; }
        public Guid? PublicScapeID { get; set; }
        public string City { get; set; }
        public string PublicSpaceName { get; set; }
        public int House { get; set; }
        public int Floor { get; set; }
        public int Door { get; set; }
        public int PostalCode { get; set; }
        public Guid StudentId { get; set; }
        public Guid TeacherId { get; set; }
        public Guid ParentId { get; set; }
        public virtual Student? Student { get; set; }
        public virtual Teacher? Teacher { get; set; }
        public virtual Parent? Parent { get; set; }

        public bool HasId => Id != Guid.Empty;
    }
}
