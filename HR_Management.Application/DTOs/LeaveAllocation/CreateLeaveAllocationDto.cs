﻿using HR_Management.Application.DTOs.Common;

namespace HR_Management.Application.DTOs
{
    public class CreateLeaveAllocationDto : BaseDto
    {
        public int NumberOfDays { get; set; }
        public int LeaveTypeId { get; set; }
        public int Priod { get; set; }
    }
}