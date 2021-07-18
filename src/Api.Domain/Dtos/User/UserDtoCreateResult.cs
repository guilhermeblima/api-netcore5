﻿using System;
using System.Diagnostics.CodeAnalysis;

namespace Api.Domain.Dtos.User
{
    [ExcludeFromCodeCoverage]
    public class UserDtoCreateResult
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Document { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
