using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace AuthWebApi.Entities;

[Serializable]
[DataContract]
[Table("users", Schema = "public")]
public class User : BaseEntity
{
    [DataMember]
    [Column("name")]
    [Required]
    public string Name { get; set; } = string.Empty;

    [DataMember]
    [Column("password_hash")]
    [Required]
    public byte[] PasswordHash { get; set; } = [];

    [DataMember]
    [Column("password_salt")]
    [Required]
    public byte[] PasswordSalt { get; set; } = [];
}