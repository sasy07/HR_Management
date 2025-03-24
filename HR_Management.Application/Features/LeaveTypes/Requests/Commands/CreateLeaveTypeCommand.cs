﻿using HR_Management.Application.DTOs;
using MediatR;

namespace HR_Management.Application.Features.LeaveTypes.Requests.Commands
{
    public class CreateLeaveTypeCommand:IRequest<int>
    {
        public LeaveTypeDto LeaveTypeDto { get; set; }
    }
}