﻿// --------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.
// --------------------------------------------------------------------------------------------

using AutoMapper;
using Edna.AssignmentLinks;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Edna.Bindings.User;

[assembly: FunctionsStartup(typeof(Startup))]

namespace Edna.AssignmentLinks
{
    public class Startup : IWebJobsStartup
    {
        public void Configure(IWebJobsBuilder builder)
        {
            builder.Services.AddLogging();

            builder.AddUserBinding();

            builder.Services.AddAutoMapper(GetType().Assembly);
        }
    }
}