﻿using HR_Management.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;
using HR_Management.Application.DTOs.LeaveType;

namespace HR_Management.Application.DTOs.LeaveRequest
{
    public class LeaveRequestListDto : BaseDto
    {
        public LeaveTypeDto LeaveType { get; set; }
        public DateTime? DateRequested { get; set; }
        public bool? Aoorived { get; set; }
    }
}
