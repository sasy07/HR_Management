﻿using System;
using HR_Management.Domain.Common;

namespace HR_Management.Domain
{
    public class LeaveRequest:BaseDomainEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime DateRequested { get; set; }
        public string RequestComments { get; set; }
        public DateTime? DateActioned { get; set; }
        public bool? Aoorived { get; set; }
        public bool Cancelled { get; set; }
    }
}