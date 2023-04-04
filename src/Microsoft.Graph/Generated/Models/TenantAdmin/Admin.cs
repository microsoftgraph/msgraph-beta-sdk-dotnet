using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.TenantAdmin {
    public class Admin : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>A container for Microsoft Edge resources. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Edge? Edge {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Edge?>("edge"); }
            set { BackingStore?.Set("edge", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Edge Edge {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Edge>("edge"); }
            set { BackingStore?.Set("edge", value); }
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
        /// <summary>A container for administrative resources to manage reports.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.AdminReportSettings? ReportSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AdminReportSettings?>("reportSettings"); }
            set { BackingStore?.Set("reportSettings", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.AdminReportSettings ReportSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AdminReportSettings>("reportSettings"); }
            set { BackingStore?.Set("reportSettings", value); }
        }
#endif
        /// <summary>A container for service communications resources. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.ServiceAnnouncement? ServiceAnnouncement {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ServiceAnnouncement?>("serviceAnnouncement"); }
            set { BackingStore?.Set("serviceAnnouncement", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.ServiceAnnouncement ServiceAnnouncement {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ServiceAnnouncement>("serviceAnnouncement"); }
            set { BackingStore?.Set("serviceAnnouncement", value); }
        }
#endif
        /// <summary>A container for administrative resources to manage tenant-level settings for SharePoint and OneDrive.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.TenantAdmin.Sharepoint? Sharepoint {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TenantAdmin.Sharepoint?>("sharepoint"); }
            set { BackingStore?.Set("sharepoint", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.TenantAdmin.Sharepoint Sharepoint {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TenantAdmin.Sharepoint>("sharepoint"); }
            set { BackingStore?.Set("sharepoint", value); }
        }
#endif
        /// <summary>A container for all Windows administrator functionalities. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.AdminWindows? Windows {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AdminWindows?>("windows"); }
            set { BackingStore?.Set("windows", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.AdminWindows Windows {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AdminWindows>("windows"); }
            set { BackingStore?.Set("windows", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new Admin and sets the default values.
        /// </summary>
        public Admin() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Admin CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Admin();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"edge", n => { Edge = n.GetObjectValue<Microsoft.Graph.Beta.Models.Edge>(Microsoft.Graph.Beta.Models.Edge.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"reportSettings", n => { ReportSettings = n.GetObjectValue<Microsoft.Graph.Beta.Models.AdminReportSettings>(Microsoft.Graph.Beta.Models.AdminReportSettings.CreateFromDiscriminatorValue); } },
                {"serviceAnnouncement", n => { ServiceAnnouncement = n.GetObjectValue<Microsoft.Graph.Beta.Models.ServiceAnnouncement>(Microsoft.Graph.Beta.Models.ServiceAnnouncement.CreateFromDiscriminatorValue); } },
                {"sharepoint", n => { Sharepoint = n.GetObjectValue<Microsoft.Graph.Beta.Models.TenantAdmin.Sharepoint>(Microsoft.Graph.Beta.Models.TenantAdmin.Sharepoint.CreateFromDiscriminatorValue); } },
                {"windows", n => { Windows = n.GetObjectValue<Microsoft.Graph.Beta.Models.AdminWindows>(Microsoft.Graph.Beta.Models.AdminWindows.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Edge>("edge", Edge);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AdminReportSettings>("reportSettings", ReportSettings);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ServiceAnnouncement>("serviceAnnouncement", ServiceAnnouncement);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.TenantAdmin.Sharepoint>("sharepoint", Sharepoint);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AdminWindows>("windows", Windows);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
