using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStoreV10.Models;

public  class Customer
{
    public int CustomerId { get; set; }

    public string? Password { get; set; }

    public string? Imageurl { get; set; }

    [DataType(DataType.PhoneNumber)]
    [StringLength(10, ErrorMessage = "The phone number must be 10 digits long.")]
    //[RegularExpression("^[0-9]*$", ErrorMessage = "* Phone must contain only numeric characters.")]

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Gender { get; set; }

    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
