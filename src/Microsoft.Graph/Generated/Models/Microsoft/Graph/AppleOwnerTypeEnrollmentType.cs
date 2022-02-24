using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class AppleOwnerTypeEnrollmentType : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The enrollment type. Possible values are: unknown, device, user.</summary>
        public AppleUserInitiatedEnrollmentType? EnrollmentType { get; set; }
        /// <summary>The owner type. Possible values are: unknown, company, personal.</summary>
        public ManagedDeviceOwnerType? OwnerType { get; set; }
        /// <summary>
        /// Instantiates a new appleOwnerTypeEnrollmentType and sets the default values.
        /// </summary>
        public AppleOwnerTypeEnrollmentType() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"enrollmentType", (o,n) => { (o as AppleOwnerTypeEnrollmentType).EnrollmentType = n.GetEnumValue<AppleUserInitiatedEnrollmentType>(); } },
                {"ownerType", (o,n) => { (o as AppleOwnerTypeEnrollmentType).OwnerType = n.GetEnumValue<ManagedDeviceOwnerType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<AppleUserInitiatedEnrollmentType>("enrollmentType", EnrollmentType);
            writer.WriteEnumValue<ManagedDeviceOwnerType>("ownerType", OwnerType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
