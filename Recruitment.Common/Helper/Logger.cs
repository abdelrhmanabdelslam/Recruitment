
using System;
using System.Collections.Generic;
using System.Text;
using UUL.Logger;
using UUL.Logger.DTOs;
using static UUL.Logger.UUL.Core.UUL.Common.Enums.Enums;

namespace Recruitment.Common.Helper
{
    public sealed class Logger
    {
        private static UUL.Logger.Logger instance;
        private static Logger _logger;
        private static LogConfigurations config = LogConfigurations.LoggerConfigurations;
        private static readonly object _syncLock = new object();
        public static UUL.Logger.Logger Instance
        {
            get
            {
                if (_logger == null && instance == null)
                {
                    lock (_syncLock)
                    {
                        if (_logger == null && instance == null)
                        {
                            LoggerConfig();
                            instance = new UUL.Logger.Logger(config);
                        }
                    }
                }
                return instance;
            }
        }
        private static LogConfigurations LoggerConfig()
        {
            config.MainLogPath = "D:\\EventLog";
            config.FilePathOptions = FilePathOptions.FilePerHour;
            config.FileCapacity = FileCapacity.AllMessagesAtTheDefinedPeriod;
            config.ErrorLogEnabled = true;
            config.DebugLogEnabled = true;
            config.WarningLogEnabled = true;
            config.InfoLogEnabled = true;
            return config;
        }
    }
}