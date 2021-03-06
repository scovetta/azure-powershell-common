// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.Common.Compute.Version2016_04_preview.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes a virtual machine scale set extension profile.
    /// </summary>
    public partial class VirtualMachineScaleSetExtensionProfile
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetExtensionProfile class.
        /// </summary>
        public VirtualMachineScaleSetExtensionProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetExtensionProfile class.
        /// </summary>
        /// <param name="extensions">The virtual machine scale set child
        /// extension resources.</param>
        public VirtualMachineScaleSetExtensionProfile(IList<VirtualMachineScaleSetExtension> extensions = default(IList<VirtualMachineScaleSetExtension>))
        {
            Extensions = extensions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the virtual machine scale set child extension
        /// resources.
        /// </summary>
        [JsonProperty(PropertyName = "extensions")]
        public IList<VirtualMachineScaleSetExtension> Extensions { get; set; }

    }
}
