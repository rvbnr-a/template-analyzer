﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System.Collections.Generic;
using Newtonsoft.Json;

namespace Microsoft.Azure.Templates.Analyzer.RuleEngines.JsonEngine.Schemas
{
    class InclusionsConfigurationsDefinition
    {
        /// <summary>
        /// Gets or sets the RuleIds property.
        /// </summary>
        [JsonProperty]
        public List<string> RuleIds { get; set; }
    }
}
