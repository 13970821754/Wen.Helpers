﻿#region namespaces

using System;
using System.Configuration;

#endregion

namespace Wen.Helpers.Configuration
{
    public static class ConfigurationHelper
    {
        public static string GetAppSettingValue(string keyName)
        {
            if (string.IsNullOrEmpty(keyName))
                throw new ArgumentException();

            return ConfigurationManager.AppSettings[keyName];
        }
    }
}