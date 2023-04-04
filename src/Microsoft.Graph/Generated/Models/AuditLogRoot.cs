using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class AuditLogRoot : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The directoryAudits property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DirectoryAudit>? DirectoryAudits {
            get { return BackingStore?.Get<List<DirectoryAudit>?>("directoryAudits"); }
            set { BackingStore?.Set("directoryAudits", value); }
        }
#nullable restore
#else
        public List<DirectoryAudit> DirectoryAudits {
            get { return BackingStore?.Get<List<DirectoryAudit>>("directoryAudits"); }
            set { BackingStore?.Set("directoryAudits", value); }
        }
#endif
        /// <summary>The directoryProvisioning property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ProvisioningObjectSummary>? DirectoryProvisioning {
            get { return BackingStore?.Get<List<ProvisioningObjectSummary>?>("directoryProvisioning"); }
            set { BackingStore?.Set("directoryProvisioning", value); }
        }
#nullable restore
#else
        public List<ProvisioningObjectSummary> DirectoryProvisioning {
            get { return BackingStore?.Get<List<ProvisioningObjectSummary>>("directoryProvisioning"); }
            set { BackingStore?.Set("directoryProvisioning", value); }
        }
#endif
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
        /// <summary>The provisioning property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ProvisioningObjectSummary>? Provisioning {
            get { return BackingStore?.Get<List<ProvisioningObjectSummary>?>("provisioning"); }
            set { BackingStore?.Set("provisioning", value); }
        }
#nullable restore
#else
        public List<ProvisioningObjectSummary> Provisioning {
            get { return BackingStore?.Get<List<ProvisioningObjectSummary>>("provisioning"); }
            set { BackingStore?.Set("provisioning", value); }
        }
#endif
        /// <summary>The signIns property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SignIn>? SignIns {
            get { return BackingStore?.Get<List<SignIn>?>("signIns"); }
            set { BackingStore?.Set("signIns", value); }
        }
#nullable restore
#else
        public List<SignIn> SignIns {
            get { return BackingStore?.Get<List<SignIn>>("signIns"); }
            set { BackingStore?.Set("signIns", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new AuditLogRoot and sets the default values.
        /// </summary>
        public AuditLogRoot() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AuditLogRoot CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AuditLogRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"directoryAudits", n => { DirectoryAudits = n.GetCollectionOfObjectValues<DirectoryAudit>(DirectoryAudit.CreateFromDiscriminatorValue)?.ToList(); } },
                {"directoryProvisioning", n => { DirectoryProvisioning = n.GetCollectionOfObjectValues<ProvisioningObjectSummary>(ProvisioningObjectSummary.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"provisioning", n => { Provisioning = n.GetCollectionOfObjectValues<ProvisioningObjectSummary>(ProvisioningObjectSummary.CreateFromDiscriminatorValue)?.ToList(); } },
                {"signIns", n => { SignIns = n.GetCollectionOfObjectValues<SignIn>(SignIn.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<DirectoryAudit>("directoryAudits", DirectoryAudits);
            writer.WriteCollectionOfObjectValues<ProvisioningObjectSummary>("directoryProvisioning", DirectoryProvisioning);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<ProvisioningObjectSummary>("provisioning", Provisioning);
            writer.WriteCollectionOfObjectValues<SignIn>("signIns", SignIns);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
