using HR_Management.Application.DTOs.LeaveRequest;
using HR_Management.Domain;
using MediatR;

namespace HR_Management.Application.Features.LeaveRequests.Requests.Queries
{
    public class GetLeaveRequestDetailRequest:IRequest<LeaveRequestDto>
    {
        public int Id { get; set; }   
    }
}