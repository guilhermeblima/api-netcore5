﻿using System;
using System.Diagnostics.CodeAnalysis;

namespace Api.Domain.Dtos.Phone
{
    [ExcludeFromCodeCoverage]
    public class PhoneDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Number { get; set; }
    }
}
