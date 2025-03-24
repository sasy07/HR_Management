﻿using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using HR_Management.Application.Features.LeaveAllocations.Requests.Commands;
using HR_Management.Application.Persistence.Contracts;
using MediatR;

namespace HR_Management.Application.Features.LeaveAllocations.Handlers.Commands
{
    public class UpdateLeaveAllocationCommandHandler : IRequestHandler<UpdateLeaveAllocationCommand, Unit>
    {
        #region ctor

        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly IMapper _mapper;

        public UpdateLeaveAllocationCommandHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
            _mapper = mapper;
        }

        #endregion

        public async Task<Unit> Handle(UpdateLeaveAllocationCommand request, CancellationToken cancellationToken)
        {
            var leaveAllocation = await _leaveAllocationRepository.Get(request.LeaveAllocationDto.Id);
            _mapper.Map(request.LeaveAllocationDto, leaveAllocation);
            await _leaveAllocationRepository.Update(leaveAllocation);
            return Unit.Value;
        }
    }
}