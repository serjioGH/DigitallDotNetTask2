﻿using Cloth.Application.Models.Dto;
using MediatR;

namespace Cloth.Application.Features.Commands.Order.OrderCreate;

public record OrderCreateCommand(Guid StatusId, Guid PaymentId, Guid UserId, List<OrderLineCreateDto> OrderLines) : IRequest<CreateOrderDto>;