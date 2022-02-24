using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.RoleManagement.Directory.RoleEligibilitySchedules {
    public class RoleEligibilitySchedulesResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string NextLink { get; set; }
        public List<UnifiedRoleEligibilitySchedule> Value { get; set; }
        /// <summary>
        /// Instantiates a new roleEligibilitySchedulesResponse and sets the default values.
        /// </summary>
        public RoleEligibilitySchedulesResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"@odata.nextLink", (o,n) => { (o as RoleEligibilitySchedulesResponse).NextLink = n.GetStringValue(); } },
                {"value", (o,n) => { (o as RoleEligibilitySchedulesResponse).Value = n.GetCollectionOfObjectValues<UnifiedRoleEligibilitySchedule>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.nextLink", NextLink);
            writer.WriteCollectionOfObjectValues<UnifiedRoleEligibilitySchedule>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
