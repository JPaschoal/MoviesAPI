﻿using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Data.Dtos;

public class CreateAddressDto
{
    [Required(ErrorMessage = "The field Street is required")]
    public string Street { get; set; }
    [Required(ErrorMessage = "The field Number is required")]
    public string Number { get; set; }
    [Required(ErrorMessage = "The field City is required")]
    public string City { get; set; }
    [Required(ErrorMessage = "The field State is required")]
    public string ZipCode { get; set; }
    [Required(ErrorMessage = "The field Country is required")]
    public string Country { get; set; }
}