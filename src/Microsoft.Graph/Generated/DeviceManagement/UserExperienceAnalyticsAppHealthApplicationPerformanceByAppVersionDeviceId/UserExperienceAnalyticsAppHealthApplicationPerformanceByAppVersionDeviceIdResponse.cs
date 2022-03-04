using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.DeviceManagement.UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId {
    public class UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceIdResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string NextLink { get; set; }
        public List<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId> Value { get; set; }
        /// <summary>
        /// Instantiates a new userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceIdResponse and sets the default values.
        /// </summary>
        public UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceIdResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceIdResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceIdResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"@odata.nextLink", (o,n) => { (o as UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceIdResponse).NextLink = n.GetStringValue(); } },
                {"value", (o,n) => { (o as UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceIdResponse).Value = n.GetCollectionOfObjectValues<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId>(UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.nextLink", NextLink);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
