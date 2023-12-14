﻿using ECommerceDotNet.Common.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceDotNet.Core.Application.DTOs.RequestDtos
{
    public class CartRequestDto:RequestDtoBase
    {
        //public DateTime CreatedAt { get; set; }
        public DateTime? CompletedAt { get; set; }
    }
}
