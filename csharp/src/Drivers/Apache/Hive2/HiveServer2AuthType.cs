﻿/*
 * Licensed to the Apache Software Foundation (ASF) under one or more
 * contributor license agreements.  See the NOTICE file distributed with
 * this work for additional information regarding copyright ownership.
 * The ASF licenses this file to You under the Apache License, Version 2.0
 * (the "License"); you may not use this file except in compliance with
 * the License.  You may obtain a copy of the License at
 *
 *    http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

namespace Apache.Arrow.Adbc.Drivers.Apache.Hive2
{
    internal enum HiveServer2AuthType
    {
        None,
        UsernameOnly,
        Basic,
        Empty = int.MaxValue,
    }

    internal static class HiveServer2AuthTypeParser
    {
        internal static bool TryParse(string? authType, out HiveServer2AuthType authTypeValue)
        {
            switch (authType?.Trim().ToLowerInvariant())
            {
                case null:
                case "":
                    authTypeValue = HiveServer2AuthType.Empty;
                    return true;
                case HiveServer2AuthTypeConstants.None:
                    authTypeValue = HiveServer2AuthType.None;
                    return true;
                case HiveServer2AuthTypeConstants.UsernameOnly:
                    authTypeValue = HiveServer2AuthType.UsernameOnly;
                    return true;
                case HiveServer2AuthTypeConstants.Basic:
                    authTypeValue = HiveServer2AuthType.Basic;
                    return true;
                default:
                    authTypeValue = default;
                    return false;
            }
        }
    }
}
