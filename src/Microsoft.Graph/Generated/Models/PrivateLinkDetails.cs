using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class PrivateLinkDetails : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
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
        /// <summary>The unique identifier for the Private Link policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PolicyId {
            get { return BackingStore?.Get<string?>("policyId"); }
            set { BackingStore?.Set("policyId", value); }
        }
#nullable restore
#else
        public string PolicyId {
            get { return BackingStore?.Get<string>("policyId"); }
            set { BackingStore?.Set("policyId", value); }
        }
#endif
        /// <summary>The name of the Private Link policy in Azure AD.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PolicyName {
            get { return BackingStore?.Get<string?>("policyName"); }
            set { BackingStore?.Set("policyName", value); }
        }
#nullable restore
#else
        public string PolicyName {
            get { return BackingStore?.Get<string>("policyName"); }
            set { BackingStore?.Set("policyName", value); }
        }
#endif
        /// <summary>The tenant identifier of the Azure AD tenant the Private Link policy belongs to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PolicyTenantId {
            get { return BackingStore?.Get<string?>("policyTenantId"); }
            set { BackingStore?.Set("policyTenantId", value); }
        }
#nullable restore
#else
        public string PolicyTenantId {
            get { return BackingStore?.Get<string>("policyTenantId"); }
            set { BackingStore?.Set("policyTenantId", value); }
        }
#endif
        /// <summary>The Azure Resource Manager (ARM) path for the Private Link policy resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceId {
            get { return BackingStore?.Get<string?>("resourceId"); }
            set { BackingStore?.Set("resourceId", value); }
        }
#nullable restore
#else
        public string ResourceId {
            get { return BackingStore?.Get<string>("resourceId"); }
            set { BackingStore?.Set("resourceId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new privateLinkDetails and sets the default values.
        /// </summary>
        public PrivateLinkDetails() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PrivateLinkDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrivateLinkDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"policyId", n => { PolicyId = n.GetStringValue(); } },
                {"policyName", n => { PolicyName = n.GetStringValue(); } },
                {"policyTenantId", n => { PolicyTenantId = n.GetStringValue(); } },
                {"resourceId", n => { ResourceId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("policyId", PolicyId);
            writer.WriteStringValue("policyName", PolicyName);
            writer.WriteStringValue("policyTenantId", PolicyTenantId);
            writer.WriteStringValue("resourceId", ResourceId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
