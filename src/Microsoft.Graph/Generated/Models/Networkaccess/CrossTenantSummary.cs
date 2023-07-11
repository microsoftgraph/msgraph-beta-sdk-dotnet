using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Networkaccess {
    public class CrossTenantSummary : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Total numbers of authentication sessions in the time frame between startDateTime and endDateTime.</summary>
        public int? AuthTransactionCount {
            get { return BackingStore?.Get<int?>("authTransactionCount"); }
            set { BackingStore?.Set("authTransactionCount", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Count of unique devices that performed cross-tenant access, in the time frame between startDateTime and endDateTime.</summary>
        public int? DeviceCount {
            get { return BackingStore?.Get<int?>("deviceCount"); }
            set { BackingStore?.Set("deviceCount", value); }
        }
        /// <summary>Count of unique tenants that were accessed in the time frame between endDateTime to discoveryPivotDateTime, but haven&apos;t been accessed in the time frame between discoveryPivotDateTime to startDateTime.</summary>
        public int? NewTenantCount {
            get { return BackingStore?.Get<int?>("newTenantCount"); }
            set { BackingStore?.Set("newTenantCount", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Count of unique tenants that were accessed, that are different from the device&apos;s home tenant, in the time frame between startDateTime and endDateTime.</summary>
        public int? TenantCount {
            get { return BackingStore?.Get<int?>("tenantCount"); }
            set { BackingStore?.Set("tenantCount", value); }
        }
        /// <summary>Count of unique users that performed cross-tenant access, in the time frame between startDateTime and endDateTime.</summary>
        public int? UserCount {
            get { return BackingStore?.Get<int?>("userCount"); }
            set { BackingStore?.Set("userCount", value); }
        }
        /// <summary>
        /// Instantiates a new crossTenantSummary and sets the default values.
        /// </summary>
        public CrossTenantSummary() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CrossTenantSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CrossTenantSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"authTransactionCount", n => { AuthTransactionCount = n.GetIntValue(); } },
                {"deviceCount", n => { DeviceCount = n.GetIntValue(); } },
                {"newTenantCount", n => { NewTenantCount = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"tenantCount", n => { TenantCount = n.GetIntValue(); } },
                {"userCount", n => { UserCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("authTransactionCount", AuthTransactionCount);
            writer.WriteIntValue("deviceCount", DeviceCount);
            writer.WriteIntValue("newTenantCount", NewTenantCount);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("tenantCount", TenantCount);
            writer.WriteIntValue("userCount", UserCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
