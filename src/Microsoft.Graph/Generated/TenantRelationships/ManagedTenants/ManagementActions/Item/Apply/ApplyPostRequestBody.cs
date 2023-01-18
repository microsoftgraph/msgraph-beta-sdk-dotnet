using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.ManagementActions.Item.Apply {
    public class ApplyPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The excludeGroups property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<string>? ExcludeGroups {
            get { return BackingStore?.Get<List<string>?>("excludeGroups"); }
            set { BackingStore?.Set("excludeGroups", value); }
        }
#else
        public List<string> ExcludeGroups {
            get { return BackingStore?.Get<List<string>>("excludeGroups"); }
            set { BackingStore?.Set("excludeGroups", value); }
        }
#endif
        /// <summary>The includeAllUsers property</summary>
        public bool? IncludeAllUsers {
            get { return BackingStore?.Get<bool?>("includeAllUsers"); }
            set { BackingStore?.Set("includeAllUsers", value); }
        }
        /// <summary>The includeGroups property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<string>? IncludeGroups {
            get { return BackingStore?.Get<List<string>?>("includeGroups"); }
            set { BackingStore?.Set("includeGroups", value); }
        }
#else
        public List<string> IncludeGroups {
            get { return BackingStore?.Get<List<string>>("includeGroups"); }
            set { BackingStore?.Set("includeGroups", value); }
        }
#endif
        /// <summary>The managementTemplateId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? ManagementTemplateId {
            get { return BackingStore?.Get<string?>("managementTemplateId"); }
            set { BackingStore?.Set("managementTemplateId", value); }
        }
#else
        public string ManagementTemplateId {
            get { return BackingStore?.Get<string>("managementTemplateId"); }
            set { BackingStore?.Set("managementTemplateId", value); }
        }
#endif
        /// <summary>The tenantGroupId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? TenantGroupId {
            get { return BackingStore?.Get<string?>("tenantGroupId"); }
            set { BackingStore?.Set("tenantGroupId", value); }
        }
#else
        public string TenantGroupId {
            get { return BackingStore?.Get<string>("tenantGroupId"); }
            set { BackingStore?.Set("tenantGroupId", value); }
        }
#endif
        /// <summary>The tenantId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? TenantId {
            get { return BackingStore?.Get<string?>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
#else
        public string TenantId {
            get { return BackingStore?.Get<string>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new applyPostRequestBody and sets the default values.
        /// </summary>
        public ApplyPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ApplyPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ApplyPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"excludeGroups", n => { ExcludeGroups = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"includeAllUsers", n => { IncludeAllUsers = n.GetBoolValue(); } },
                {"includeGroups", n => { IncludeGroups = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"managementTemplateId", n => { ManagementTemplateId = n.GetStringValue(); } },
                {"tenantGroupId", n => { TenantGroupId = n.GetStringValue(); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("excludeGroups", ExcludeGroups);
            writer.WriteBoolValue("includeAllUsers", IncludeAllUsers);
            writer.WriteCollectionOfPrimitiveValues<string>("includeGroups", IncludeGroups);
            writer.WriteStringValue("managementTemplateId", ManagementTemplateId);
            writer.WriteStringValue("tenantGroupId", TenantGroupId);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
