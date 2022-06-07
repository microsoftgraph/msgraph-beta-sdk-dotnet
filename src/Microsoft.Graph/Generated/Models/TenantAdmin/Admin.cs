using Microsoft.Graph.Beta.Models.WindowsUpdates;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.TenantAdmin {
    public class Admin : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>A container for service communications resources. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.ServiceAnnouncement ServiceAnnouncement {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ServiceAnnouncement>(nameof(ServiceAnnouncement)); }
            set { BackingStore?.Set(nameof(ServiceAnnouncement), value); }
        }
        /// <summary>A container for administrative resources to manage tenant-level settings for SharePoint and OneDrive.</summary>
        public Microsoft.Graph.Beta.Models.TenantAdmin.Sharepoint Sharepoint {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TenantAdmin.Sharepoint>(nameof(Sharepoint)); }
            set { BackingStore?.Set(nameof(Sharepoint), value); }
        }
        /// <summary>A container for all Windows Update for Business deployment service functionality. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.WindowsUpdates.Windows Windows {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsUpdates.Windows>(nameof(Windows)); }
            set { BackingStore?.Set(nameof(Windows), value); }
        }
        /// <summary>
        /// Instantiates a new Admin and sets the default values.
        /// </summary>
        public Admin() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static Admin CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Admin();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"serviceAnnouncement", n => { ServiceAnnouncement = n.GetObjectValue<Microsoft.Graph.Beta.Models.ServiceAnnouncement>(Microsoft.Graph.Beta.Models.ServiceAnnouncement.CreateFromDiscriminatorValue); } },
                {"sharepoint", n => { Sharepoint = n.GetObjectValue<Microsoft.Graph.Beta.Models.TenantAdmin.Sharepoint>(Microsoft.Graph.Beta.Models.TenantAdmin.Sharepoint.CreateFromDiscriminatorValue); } },
                {"windows", n => { Windows = n.GetObjectValue<Microsoft.Graph.Beta.Models.WindowsUpdates.Windows>(Microsoft.Graph.Beta.Models.WindowsUpdates.Windows.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ServiceAnnouncement>("serviceAnnouncement", ServiceAnnouncement);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.TenantAdmin.Sharepoint>("sharepoint", Sharepoint);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.WindowsUpdates.Windows>("windows", Windows);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
