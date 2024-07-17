﻿using MediatR;
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Services;
using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Data.Repository;
using MicroRabbit.Banking.Domain.CommandHandlers;
using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection service)
        {
            //domain bus
            service.AddTransient<IEventBus, RabbitMQBus>();

            //Domain Banking commands
            service.AddTransient<IRequestHandler<CreateTransferCommand,bool>, TransferCommandHandler>();

            //application services
            service.AddTransient<IAccountService, AccountService>();

            //data
            service.AddTransient<IAccountRepository, AccountRepository>();
            service.AddTransient<BankingDbContext>();


        }
    }
}
