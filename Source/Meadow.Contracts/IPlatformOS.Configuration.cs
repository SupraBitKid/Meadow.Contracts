﻿using System;
namespace Meadow
{
    public partial interface IPlatformOS
    {
        /// <summary>
        /// Enumeration indicating the possible configuration items that can be read / written.
        /// </summary>
        /// <remarks>It is critical that this enum matches the enum in the NuttX file hcom_nx_config_manager.h.</remarks>
        public enum ConfigurationValues
        {
            DeviceName = 0,
            Product,
            Model,
            OsVersion,
            BuildDate,
            ProcessorType,
            UniqueId,
            SerialNumber,
            CoprocessorType,
            CoprocessorFirmwareVersion,
            MonoVersion,
            AutomaticallyStartNetwork,
            AutomaticallyReconnect,
            MaximumNetworkRetryCount,
            GetTimeAtStartup,
            MacAddress,
            SoftApMacAddress,
            DefaultAccessPoint,
            ResetReason,
            RebootOnUnhandledException,
            InitializationTimeout,
            SdCardPresent
        };

        T GetConfigurationValue<T>(ConfigurationValues item) where T : struct;

        void SetConfigurationValue<T>(ConfigurationValues item, T value) where T : struct;

        // named properties
        string OSVersion { get; }
        string OSBuildDate { get; }
        string MonoVersion { get; }
        bool RebootOnUnhandledException { get; }
        uint InitializationTimeout { get; }
        bool SdCardPresent { get; }
    }
}
