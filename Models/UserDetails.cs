using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CertStore.Data.Enum;

namespace CertStore.Models;

public class UserDetails
{
    [Key]
    public int DetailId { get; set; }
    
    public string? Id {get; set;}
    
    [Required]
    public string Name { get; set; }   =   string.Empty;
    
  
    public string MiddleName   { get; set; } =   string.Empty;

    [Required]
    public string LastName { get; set; } = string.Empty;
    
    [Required]
    public Gender Gender { get; set; } 
    
    public string NativeLanguage { get; set; } = string.Empty;
    
   
    public DateTime DateOfBirth { get; set; }
    
   
    public int PhotoIdType { get; set; }
    
    public string PhotoIdNumber { get; set; } = string.Empty;
    
    public DateTime PhotoIdIssueDate { get; set; } 
    
    public string Address { get; set; } = string.Empty;
    
    public string AddressLine2 { get; set; } = string.Empty;
    
    public string CountryOfResidence { get; set; } = string.Empty;
    
    public string StateProvince { get; set; } = string.Empty;
    
    public string City { get; set; } = string.Empty;
    
    public string PostalCode { get; set; } = string.Empty;
    
    public string LandlinePhone { get; set; } = string.Empty;
    
    public string MobileNumber { get; set; } = string.Empty; 
    
}