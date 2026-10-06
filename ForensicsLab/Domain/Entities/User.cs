using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class User
    {
        public Guid Id { get; private set; }

        public string Username { get; private set; } = null!;
        public string Email { get; private set; } = null!;

        public UserRole Role { get; private set; }

        public DateTime CreatedAt { get; private set; }
        public bool IsActive { get; private set; }

        private User() { }

        public User(
            string username,
            string email,
            UserRole role)
        {
            Id = Guid.NewGuid();
            Username = username;
            Email = email;
            Role = role;
            CreatedAt = DateTime.UtcNow;
            IsActive = true;
        }

    }
}
