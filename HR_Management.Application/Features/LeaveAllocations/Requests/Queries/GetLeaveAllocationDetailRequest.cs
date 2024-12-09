using HR_Management.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using HR_Management.Application.DTOs.LeaveAllocation;

namespace HR_Management.Application.Features.LeaveAllocations.Requests.Queries
{
    public class GetLeaveAllocationDetailRequest : IRequest<LeaveAllocationDto>
    {
        public int Id { get; set; }
    }
}
