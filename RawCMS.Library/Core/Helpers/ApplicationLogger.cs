﻿using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace RawCMS.Library.Core.Helpers
{
    public class ApplicationLogger
    {
        private static ILoggerFactory _loggerFactory;

        public static ILoggerFactory LoggerFactory { get => _loggerFactory; set => _loggerFactory = value; }

        public static void SetLogFactory(ILoggerFactory loggerFactory)
        {
            LoggerFactory = loggerFactory;
        }

        public static ILogger CreateLogger<T>()
        {
            return LoggerFactory.CreateLogger<T>();
        }

        public static ILogger CreateLogger(string name)
        {
            return LoggerFactory.CreateLogger( name);
        }

        

    }
}
