using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    public class EventPropagationResult : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The name of the specific location in the workload associated with the event.</summary>
        public string Location {
            get { return BackingStore?.Get<string>(nameof(Location)); }
            set { BackingStore?.Set(nameof(Location), value); }
        }
        /// <summary>The name of the workload associated with the event.</summary>
        public string ServiceName {
            get { return BackingStore?.Get<string>(nameof(ServiceName)); }
            set { BackingStore?.Set(nameof(ServiceName), value); }
        }
        /// <summary>Indicates the status of the event creation request. The possible values are: none, inProcessing, failed, success.</summary>
        public EventPropagationStatus? Status {
            get { return BackingStore?.Get<EventPropagationStatus?>(nameof(Status)); }
            set { BackingStore?.Set(nameof(Status), value); }
        }
        /// <summary>Additional information about the status of the event creation request.</summary>
        public string StatusInformation {
            get { return BackingStore?.Get<string>(nameof(StatusInformation)); }
            set { BackingStore?.Set(nameof(StatusInformation), value); }
        }
        /// <summary>
        /// Instantiates a new eventPropagationResult and sets the default values.
        /// </summary>
        public EventPropagationResult() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static EventPropagationResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EventPropagationResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"location", n => { Location = n.GetStringValue(); } },
                {"serviceName", n => { ServiceName = n.GetStringValue(); } },
                {"status", n => { Status = n.GetEnumValue<EventPropagationStatus>(); } },
                {"statusInformation", n => { StatusInformation = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("location", Location);
            writer.WriteStringValue("serviceName", ServiceName);
            writer.WriteEnumValue<EventPropagationStatus>("status", Status);
            writer.WriteStringValue("statusInformation", StatusInformation);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
