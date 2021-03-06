﻿namespace Shuttle.Esb.Scheduling
{
    public interface ISchedulingConfiguration
    {
        string ConnectionString { get; set; }
        string ProviderName { get; set; }
        int SecondsBetweenScheduleChecks { get; set; }
    }
}