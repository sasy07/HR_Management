using HR_Management.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using HR_Management.Application.DTOs.LeaveType;

namespace HR_Management.Application.Features.LeaveTypes.Requests.Queries
{
    public class GetLeaveTypeDetailRequest : IRequest<LeaveTypeDto>
    {
        public int Id { get; set; }
    }
}
