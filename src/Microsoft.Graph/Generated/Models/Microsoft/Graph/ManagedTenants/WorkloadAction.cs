using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedTenants {
    public class WorkloadAction : IAdditionalDataHolder, IParsable {
        /// <summary>The unique identifier for the workload action. Required. Read-only.</summary>
        public string ActionId { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The category for the workload action. Possible values are: automated, manual, unknownFutureValue. Optional. Read-only.</summary>
        public WorkloadActionCategory? Category { get; set; }
        /// <summary>The description for the workload action. Optional. Read-only.</summary>
        public string Description { get; set; }
        /// <summary>The display name for the workload action. Optional. Read-only.</summary>
        public string DisplayName { get; set; }
        /// <summary>The licenses property</summary>
        public List<string> Licenses { get; set; }
        /// <summary>The service associated with workload action. Optional. Read-only.</summary>
        public string Service { get; set; }
        /// <summary>The collection of settings associated with the workload action. Optional. Read-only.</summary>
        public List<Setting> Settings { get; set; }
        /// <summary>
        /// Instantiates a new workloadAction and sets the default values.
        /// </summary>
        public WorkloadAction() {
            AdditionalData = new Dictionary<string, object>();
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
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"actionId", (o,n) => { (o as WorkloadAction).ActionId = n.GetStringValue(); } },
                {"category", (o,n) => { (o as WorkloadAction).Category = n.GetEnumValue<WorkloadActionCategory>(); } },
                {"description", (o,n) => { (o as WorkloadAction).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as WorkloadAction).DisplayName = n.GetStringValue(); } },
                {"licenses", (o,n) => { (o as WorkloadAction).Licenses = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"service", (o,n) => { (o as WorkloadAction).Service = n.GetStringValue(); } },
                {"settings", (o,n) => { (o as WorkloadAction).Settings = n.GetCollectionOfObjectValues<Setting>(Setting.CreateFromDiscriminatorValue).ToList(); } },
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
            writer.WriteStringValue("service", Service);
            writer.WriteCollectionOfObjectValues<Setting>("settings", Settings);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
