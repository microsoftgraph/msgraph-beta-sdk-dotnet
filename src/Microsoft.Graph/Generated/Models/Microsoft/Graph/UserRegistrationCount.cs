using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class UserRegistrationCount : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Provides the registration count for your tenant.</summary>
        public long? RegistrationCount { get; set; }
        /// <summary>Represents the status of user registration. Possible values are: registered, enabled, capable, and mfaRegistered.</summary>
        public RegistrationStatusType? RegistrationStatus { get; set; }
        /// <summary>
        /// Instantiates a new userRegistrationCount and sets the default values.
        /// </summary>
        public UserRegistrationCount() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UserRegistrationCount CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserRegistrationCount();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"registrationCount", (o,n) => { (o as UserRegistrationCount).RegistrationCount = n.GetLongValue(); } },
                {"registrationStatus", (o,n) => { (o as UserRegistrationCount).RegistrationStatus = n.GetEnumValue<RegistrationStatusType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteLongValue("registrationCount", RegistrationCount);
            writer.WriteEnumValue<RegistrationStatusType>("registrationStatus", RegistrationStatus);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
