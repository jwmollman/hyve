﻿using System.ComponentModel.DataAnnotations;

namespace HackerNewsClone.ViewModels.Home {
    public class RegisterViewModel {
        [Required(ErrorMessage = "Enter your desired username")]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Enter your email address")]
        [Display(Name = "Email")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Enter your password")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm your password")]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Passwords must match.")]
        public string PasswordConfirm { get; set; }
    }
}