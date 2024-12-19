using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CertStore.Data.Enums;
using Microsoft.AspNetCore.Identity;

namespace CertStore.Models;

public class Candidate
{
    [Key]
    [Required]
    public int CandidateId { get; set; }
    
    [Required]
    public string CandidateName { get; set; }   =   string.Empty;
    
  
    public string CandidateMiddleName   { get; set; } =   string.Empty;

    [Required]
    public string CandidateLastName { get; set; } = string.Empty;
    
   
    public Gender Gender { get; set; }
    
    public string NativeLanguage { get; set; } = string.Empty;
    
   
    public DateTime DateOfBirth { get; set; }
    
   
    public int PhotoIdType { get; set; }

    
    public string PhotoIdNumber { get; set; } = string.Empty;
    
    [Required]
    public DateTime PhotoIdIssueDate { get; set; } 
    
    public string Address { get; set; } = string.Empty;
    
    public string AddressLine2 { get; set; } = string.Empty;
    
    public string CountryOfResidence { get; set; } = string.Empty;
    
    public string StateProvince { get; set; } = string.Empty;
    
    public string City { get; set; } = string.Empty;
    
    public string PostalCode { get; set; } = string.Empty;
    
    public string LandlinePhone { get; set; } = string.Empty;
    
    [Required]
    public string MobileNumber { get; set; } = string.Empty; 
    
    // [ForeignKey(nameof(Id))]
    // public AspNetUser User { get; set; }
    
}