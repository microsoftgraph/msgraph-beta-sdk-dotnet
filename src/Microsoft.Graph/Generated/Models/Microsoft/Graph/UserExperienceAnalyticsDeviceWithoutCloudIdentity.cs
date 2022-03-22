using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class UserExperienceAnalyticsDeviceWithoutCloudIdentity : Entity, IParsable {
        /// <summary>Azure Active Directory Device Id</summary>
        public string AzureAdDeviceId { get; set; }
        /// <summary>The tenant attach device's name.</summary>
        public string DeviceName { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserExperienceAnalyticsDeviceWithoutCloudIdentity CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsDeviceWithoutCloudIdentity();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"azureAdDeviceId", (o,n) => { (o as UserExperienceAnalyticsDeviceWithoutCloudIdentity).AzureAdDeviceId = n.GetStringValue(); } },
                {"deviceName", (o,n) => { (o as UserExperienceAnalyticsDeviceWithoutCloudIdentity).DeviceName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("azureAdDeviceId", AzureAdDeviceId);
            writer.WriteStringValue("deviceName", DeviceName);
        }
    }
}
