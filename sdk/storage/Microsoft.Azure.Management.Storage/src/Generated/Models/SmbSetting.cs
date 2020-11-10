// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Setting for SMB protocol
    /// </summary>
    public partial class SmbSetting
    {
        /// <summary>
        /// Initializes a new instance of the SmbSetting class.
        /// </summary>
        public SmbSetting()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SmbSetting class.
        /// </summary>
        /// <param name="multichannel">Multichannel setting. Applies to Premium
        /// FileStorage only.</param>
        public SmbSetting(Multichannel multichannel = default(Multichannel))
        {
            Multichannel = multichannel;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets multichannel setting. Applies to Premium FileStorage
        /// only.
        /// </summary>
        [JsonProperty(PropertyName = "multichannel")]
        public Multichannel Multichannel { get; set; }

    }
}
