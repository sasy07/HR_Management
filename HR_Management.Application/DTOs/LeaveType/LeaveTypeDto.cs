﻿using HR_Management.Application.DTOs.Common;

namespace HR_Management.Application.DTOs
{
    public class LeaveTypeDto:BaseDto
    {
        public string Name { get; set; }
        public int DefaultDay { get; set; }
    }
}