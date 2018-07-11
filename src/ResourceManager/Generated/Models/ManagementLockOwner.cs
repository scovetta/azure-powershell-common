// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Internal.Resources.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Lock owner properties.
    /// </summary>
    public partial class ManagementLockOwner
    {
        /// <summary>
        /// Initializes a new instance of the ManagementLockOwner class.
        /// </summary>
        public ManagementLockOwner() { }

        /// <summary>
        /// Initializes a new instance of the ManagementLockOwner class.
        /// </summary>
        public ManagementLockOwner(string applicationId = default(string))
        {
            ApplicationId = applicationId;
        }

        /// <summary>
        /// The application ID of the lock owner.
        /// </summary>
        [JsonProperty(PropertyName = "applicationId")]
        public string ApplicationId { get; set; }

    }
}