using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PrintJobStatus : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>The acquiredByPrinter property</summary>
        public bool? AcquiredByPrinter {
            get { return BackingStore?.Get<bool?>("acquiredByPrinter"); }
            set { BackingStore?.Set("acquiredByPrinter", value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>A human-readable description of the print job&apos;s current processing state. Read-only.</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>Additional details for print job state. Valid values are described in the following table. Read-only.</summary>
        public List<string> Details {
            get { return BackingStore?.Get<List<string>>("details"); }
            set { BackingStore?.Set("details", value); }
        }
        /// <summary>True if the job was acknowledged by a printer; false otherwise. Read-only.</summary>
        public bool? IsAcquiredByPrinter {
            get { return BackingStore?.Get<bool?>("isAcquiredByPrinter"); }
            set { BackingStore?.Set("isAcquiredByPrinter", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The processingState property</summary>
        public PrintJobProcessingState? ProcessingState {
            get { return BackingStore?.Get<PrintJobProcessingState?>("processingState"); }
            set { BackingStore?.Set("processingState", value); }
        }
        /// <summary>The processingStateDescription property</summary>
        public string ProcessingStateDescription {
            get { return BackingStore?.Get<string>("processingStateDescription"); }
            set { BackingStore?.Set("processingStateDescription", value); }
        }
        /// <summary>The state property</summary>
        public PrintJobProcessingState? State {
            get { return BackingStore?.Get<PrintJobProcessingState?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>
        /// Instantiates a new printJobStatus and sets the default values.
        /// </summary>
        public PrintJobStatus() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.printJobStatus";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static PrintJobStatus CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrintJobStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"acquiredByPrinter", n => { AcquiredByPrinter = n.GetBoolValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"details", n => { Details = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"isAcquiredByPrinter", n => { IsAcquiredByPrinter = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"processingState", n => { ProcessingState = n.GetEnumValue<PrintJobProcessingState>(); } },
                {"processingStateDescription", n => { ProcessingStateDescription = n.GetStringValue(); } },
                {"state", n => { State = n.GetEnumValue<PrintJobProcessingState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("acquiredByPrinter", AcquiredByPrinter);
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfPrimitiveValues<string>("details", Details);
            writer.WriteBoolValue("isAcquiredByPrinter", IsAcquiredByPrinter);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<PrintJobProcessingState>("processingState", ProcessingState);
            writer.WriteStringValue("processingStateDescription", ProcessingStateDescription);
            writer.WriteEnumValue<PrintJobProcessingState>("state", State);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
