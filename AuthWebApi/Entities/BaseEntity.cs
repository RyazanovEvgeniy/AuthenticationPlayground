using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace AuthWebApi.Entities;

[Serializable]
[DataContract(IsReference = true)]
public abstract class BaseEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [DataMember]
    [Column("id", Order = 0)]
    public long Id { get; set; }
}