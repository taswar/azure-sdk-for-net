// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> The UnknownRecoveryPoint. </summary>
    internal partial class UnknownRecoveryPoint : BackupGenericRecoveryPoint
    {
        /// <summary> Initializes a new instance of <see cref="UnknownRecoveryPoint"/>. </summary>
        /// <param name="objectType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownRecoveryPoint(string objectType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(objectType, serializedAdditionalRawData)
        {
            ObjectType = objectType ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownRecoveryPoint"/> for deserialization. </summary>
        internal UnknownRecoveryPoint()
        {
        }
    }
}
