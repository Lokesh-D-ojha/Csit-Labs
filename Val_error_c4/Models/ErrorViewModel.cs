using System;
using System.ComponentModel.DataAnnotations;

namespace Val_error_c4.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

    public class User
    {
        [Required(ErrorMessage = "The Name field is required.")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "The Name must be between 3 and 50 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Email field is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        [StringLength(50, ErrorMessage = "The Email must not exceed 100 characters.")]
        public string Email { get; set; }
    }
}
