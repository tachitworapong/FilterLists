﻿using System;
using JetBrains.Annotations;

namespace FilterLists.Agent.AppSettings
{
    public class FilterListsApiSettings
    {
        public Uri BaseUrl { get; [UsedImplicitly] set; }
        public string ClientUserAgent { get; [UsedImplicitly] set; }
    }
}