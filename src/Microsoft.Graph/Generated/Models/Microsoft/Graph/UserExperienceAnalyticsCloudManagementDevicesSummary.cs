using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class UserExperienceAnalyticsCloudManagementDevicesSummary : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Total number of  co-managed devices.</summary>
        public int? CoManagedDeviceCount { get; set; }
        /// <summary>The count of intune devices that are not autopilot registerd.</summary>
        public int? IntuneDeviceCount { get; set; }
        /// <summary>Total count of tenant attach devices.</summary>
        public int? TenantAttachDeviceCount { get; set; }
        /// <summary>
        /// Instantiates a new userExperienceAnalyticsCloudManagementDevicesSummary and sets the default values.
        /// </summary>
        public UserExperienceAnalyticsCloudManagementDevicesSummary() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"coManagedDeviceCount", (o,n) => { (o as UserExperienceAnalyticsCloudManagementDevicesSummary).CoManagedDeviceCount = n.GetIntValue(); } },
                {"intuneDeviceCount", (o,n) => { (o as UserExperienceAnalyticsCloudManagementDevicesSummary).IntuneDeviceCount = n.GetIntValue(); } },
                {"tenantAttachDeviceCount", (o,n) => { (o as UserExperienceAnalyticsCloudManagementDevicesSummary).TenantAttachDeviceCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("coManagedDeviceCount", CoManagedDeviceCount);
            writer.WriteIntValue("intuneDeviceCount", IntuneDeviceCount);
            writer.WriteIntValue("tenantAttachDeviceCount", TenantAttachDeviceCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
