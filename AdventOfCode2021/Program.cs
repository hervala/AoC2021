﻿await new CliFx.CliApplicationBuilder()
    .AddCommandsFromThisAssembly()
    .Build()
    .RunAsync();