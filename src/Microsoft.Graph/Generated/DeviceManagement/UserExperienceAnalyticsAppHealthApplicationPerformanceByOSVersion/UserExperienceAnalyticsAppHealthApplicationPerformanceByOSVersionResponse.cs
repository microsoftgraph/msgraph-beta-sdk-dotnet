using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraph.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.DeviceManagement.UserExperienceAnalyticsAppHealthApplicationPerformanceByOSVersion {
    public class UserExperienceAnalyticsAppHealthApplicationPerformanceByOSVersionResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string NextLink { get; set; }
        public List<UserExperienceAnalyticsAppHealthAppPerformanceByOSVersion> Value { get; set; }
        /// <summary>
        /// Instantiates a new userExperienceAnalyticsAppHealthApplicationPerformanceByOSVersionResponse and sets the default values.
        /// </summary>
        public UserExperienceAnalyticsAppHealthApplicationPerformanceByOSVersionResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"@odata.nextLink", (o,n) => { (o as UserExperienceAnalyticsAppHealthApplicationPerformanceByOSVersionResponse).NextLink = n.GetStringValue(); } },
                {"value", (o,n) => { (o as UserExperienceAnalyticsAppHealthApplicationPerformanceByOSVersionResponse).Value = n.GetCollectionOfObjectValues<UserExperienceAnalyticsAppHealthAppPerformanceByOSVersion>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.nextLink", NextLink);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsAppHealthAppPerformanceByOSVersion>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
