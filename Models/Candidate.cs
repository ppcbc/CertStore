using System.ComponentModel.DataAnnotations;
using CertStore.Data.Enums;

namespace CertStore.Models;

public class Candidate
{
    [Key]
    [Required]
    public int CandidateId { get; set; }
    
    public  int UserId { get; set; }
    
    [Required]
    public string CandidateName { get; set; }   =   string.Empty;
    
    [Required]
    public string CandidateMiddleName   { get; set; } =   string.Empty;

    [Required]
    public string CandidateLastName { get; set; } = string.Empty;
    
    [Required]
    public Gender Gender { get; set; }
    
    public string NativeLanguage { get; set; } = string.Empty;
    
    [Required]
    public DateTime DateOfBirth { get; set; }
    
    [Required]
    public int PhotoIdType { get; set; }

    [Required]
    public string PhotoIdNumber { get; set; } = string.Empty;
    
    [Required]
    public DateTime PhotoIdIssueDate { get; set; } 
    
    [Required]
    public string Address { get; set; } = string.Empty;
    
    public string AddressLine2 { get; set; } = string.Empty;
    
    public string CountryOfResidence { get; set; } = string.Empty;
    
    public string StateProvince { get; set; } = string.Empty;
    
    [Required]
    public string City { get; set; } = string.Empty;
    
    [Required]
    public string PostalCode { get; set; } = string.Empty;
    
    public string LandlinePhone { get; set; } = string.Empty;
    
    [Required]
    public string MobileNumber { get; set; } = string.Empty; //cv
    
}