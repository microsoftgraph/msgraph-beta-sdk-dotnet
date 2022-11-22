using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The user experience work from anywhere Cloud management devices summary.</summary>
    public class UserExperienceAnalyticsCloudManagementDevicesSummary : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Total number of  co-managed devices.</summary>
        public int? CoManagedDeviceCount {
            get { return BackingStore?.Get<int?>("coManagedDeviceCount"); }
            set { BackingStore?.Set("coManagedDeviceCount", value); }
        }
        /// <summary>The count of intune devices that are not autopilot registerd.</summary>
        public int? IntuneDeviceCount {
            get { return BackingStore?.Get<int?>("intuneDeviceCount"); }
            set { BackingStore?.Set("intuneDeviceCount", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>Total count of tenant attach devices.</summary>
        public int? TenantAttachDeviceCount {
            get { return BackingStore?.Get<int?>("tenantAttachDeviceCount"); }
            set { BackingStore?.Set("tenantAttachDeviceCount", value); }
        }
        /// <summary>
        /// Instantiates a new userExperienceAnalyticsCloudManagementDevicesSummary and sets the default values.
        /// </summary>
        public UserExperienceAnalyticsCloudManagementDevicesSummary() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UserExperienceAnalyticsCloudManagementDevicesSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsCloudManagementDevicesSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"coManagedDeviceCount", n => { CoManagedDeviceCount = n.GetIntValue(); } },
                {"intuneDeviceCount", n => { IntuneDeviceCount = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"tenantAttachDeviceCount", n => { TenantAttachDeviceCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("coManagedDeviceCount", CoManagedDeviceCount);
            writer.WriteIntValue("intuneDeviceCount", IntuneDeviceCount);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("tenantAttachDeviceCount", TenantAttachDeviceCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
