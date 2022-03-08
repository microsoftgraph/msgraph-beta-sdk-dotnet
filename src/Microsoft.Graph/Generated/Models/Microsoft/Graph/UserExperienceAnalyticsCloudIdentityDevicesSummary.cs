using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to call the userExperienceAnalyticsSummarizeWorkFromAnywhereDevices method.</summary>
    public class UserExperienceAnalyticsCloudIdentityDevicesSummary : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The count of devices that are not cloud identity.</summary>
        public int? DeviceWithoutCloudIdentityCount { get; set; }
        /// <summary>
        /// Instantiates a new userExperienceAnalyticsCloudIdentityDevicesSummary and sets the default values.
        /// </summary>
        public UserExperienceAnalyticsCloudIdentityDevicesSummary() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UserExperienceAnalyticsCloudIdentityDevicesSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsCloudIdentityDevicesSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"deviceWithoutCloudIdentityCount", (o,n) => { (o as UserExperienceAnalyticsCloudIdentityDevicesSummary).DeviceWithoutCloudIdentityCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("deviceWithoutCloudIdentityCount", DeviceWithoutCloudIdentityCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
