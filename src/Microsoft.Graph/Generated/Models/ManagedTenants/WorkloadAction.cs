using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    public class WorkloadAction : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>The unique identifier for the workload action. Required. Read-only.</summary>
        public string ActionId {
            get { return BackingStore?.Get<string>("actionId"); }
            set { BackingStore?.Set("actionId", value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The category for the workload action. Possible values are: automated, manual, unknownFutureValue. Optional. Read-only.</summary>
        public WorkloadActionCategory? Category {
            get { return BackingStore?.Get<WorkloadActionCategory?>("category"); }
            set { BackingStore?.Set("category", value); }
        }
        /// <summary>The description for the workload action. Optional. Read-only.</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>The display name for the workload action. Optional. Read-only.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The licenses property</summary>
        public List<string> Licenses {
            get { return BackingStore?.Get<List<string>>("licenses"); }
            set { BackingStore?.Set("licenses", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The service associated with workload action. Optional. Read-only.</summary>
        public string Service {
            get { return BackingStore?.Get<string>("service"); }
            set { BackingStore?.Set("service", value); }
        }
        /// <summary>The collection of settings associated with the workload action. Optional. Read-only.</summary>
        public List<Setting> Settings {
            get { return BackingStore?.Get<List<Setting>>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
        /// <summary>
        /// Instantiates a new workloadAction and sets the default values.
        /// </summary>
        public WorkloadAction() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.managedTenants.workloadAction";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static WorkloadAction CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkloadAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"actionId", n => { ActionId = n.GetStringValue(); } },
                {"category", n => { Category = n.GetEnumValue<WorkloadActionCategory>(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"licenses", n => { Licenses = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"service", n => { Service = n.GetStringValue(); } },
                {"settings", n => { Settings = n.GetCollectionOfObjectValues<Setting>(Setting.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("actionId", ActionId);
            writer.WriteEnumValue<WorkloadActionCategory>("category", Category);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfPrimitiveValues<string>("licenses", Licenses);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("service", Service);
            writer.WriteCollectionOfObjectValues<Setting>("settings", Settings);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
