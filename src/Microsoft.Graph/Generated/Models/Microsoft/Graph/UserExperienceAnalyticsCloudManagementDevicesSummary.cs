using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to call the userExperienceAnalyticsSummarizeWorkFromAnywhereDevices method.</summary>
    public class UserExperienceAnalyticsCloudManagementDevicesSummary : IAdditionalDataHolder, IParsable {
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
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UserExperienceAnalyticsCloudManagementDevicesSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsCloudManagementDevicesSummary();
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
