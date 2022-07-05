using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public class Printer : PrinterBase, IParsable {
        /// <summary>The acceptingJobs property</summary>
        public bool? AcceptingJobs {
            get { return BackingStore?.Get<bool?>(nameof(AcceptingJobs)); }
            set { BackingStore?.Set(nameof(AcceptingJobs), value); }
        }
        /// <summary>The connectors that are associated with the printer.</summary>
        public List<PrintConnector> Connectors {
            get { return BackingStore?.Get<List<PrintConnector>>(nameof(Connectors)); }
            set { BackingStore?.Set(nameof(Connectors), value); }
        }
        /// <summary>True if the printer has a physical device for printing. Read-only.</summary>
        public bool? HasPhysicalDevice {
            get { return BackingStore?.Get<bool?>(nameof(HasPhysicalDevice)); }
            set { BackingStore?.Set(nameof(HasPhysicalDevice), value); }
        }
        /// <summary>True if the printer is shared; false otherwise. Read-only.</summary>
        public bool? IsShared {
            get { return BackingStore?.Get<bool?>(nameof(IsShared)); }
            set { BackingStore?.Set(nameof(IsShared), value); }
        }
        /// <summary>The most recent dateTimeOffset when a printer interacted with Universal Print. Read-only.</summary>
        public DateTimeOffset? LastSeenDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastSeenDateTime)); }
            set { BackingStore?.Set(nameof(LastSeenDateTime), value); }
        }
        /// <summary>The DateTimeOffset when the printer was registered. Read-only.</summary>
        public DateTimeOffset? RegisteredDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(RegisteredDateTime)); }
            set { BackingStore?.Set(nameof(RegisteredDateTime), value); }
        }
        /// <summary>The share property</summary>
        public PrinterShare Share {
            get { return BackingStore?.Get<PrinterShare>(nameof(Share)); }
            set { BackingStore?.Set(nameof(Share), value); }
        }
        /// <summary>The list of printerShares that are associated with the printer. Currently, only one printerShare can be associated with the printer. Read-only. Nullable.</summary>
        public List<PrinterShare> Shares {
            get { return BackingStore?.Get<List<PrinterShare>>(nameof(Shares)); }
            set { BackingStore?.Set(nameof(Shares), value); }
        }
        /// <summary>A list of task triggers that are associated with the printer.</summary>
        public List<PrintTaskTrigger> TaskTriggers {
            get { return BackingStore?.Get<List<PrintTaskTrigger>>(nameof(TaskTriggers)); }
            set { BackingStore?.Set(nameof(TaskTriggers), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Printer CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Printer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"acceptingJobs", n => { AcceptingJobs = n.GetBoolValue(); } },
                {"connectors", n => { Connectors = n.GetCollectionOfObjectValues<PrintConnector>(PrintConnector.CreateFromDiscriminatorValue).ToList(); } },
                {"hasPhysicalDevice", n => { HasPhysicalDevice = n.GetBoolValue(); } },
                {"isShared", n => { IsShared = n.GetBoolValue(); } },
                {"lastSeenDateTime", n => { LastSeenDateTime = n.GetDateTimeOffsetValue(); } },
                {"registeredDateTime", n => { RegisteredDateTime = n.GetDateTimeOffsetValue(); } },
                {"share", n => { Share = n.GetObjectValue<PrinterShare>(PrinterShare.CreateFromDiscriminatorValue); } },
                {"shares", n => { Shares = n.GetCollectionOfObjectValues<PrinterShare>(PrinterShare.CreateFromDiscriminatorValue).ToList(); } },
                {"taskTriggers", n => { TaskTriggers = n.GetCollectionOfObjectValues<PrintTaskTrigger>(PrintTaskTrigger.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("acceptingJobs", AcceptingJobs);
            writer.WriteCollectionOfObjectValues<PrintConnector>("connectors", Connectors);
            writer.WriteBoolValue("hasPhysicalDevice", HasPhysicalDevice);
            writer.WriteBoolValue("isShared", IsShared);
            writer.WriteDateTimeOffsetValue("lastSeenDateTime", LastSeenDateTime);
            writer.WriteDateTimeOffsetValue("registeredDateTime", RegisteredDateTime);
            writer.WriteObjectValue<PrinterShare>("share", Share);
            writer.WriteCollectionOfObjectValues<PrinterShare>("shares", Shares);
            writer.WriteCollectionOfObjectValues<PrintTaskTrigger>("taskTriggers", TaskTriggers);
        }
    }
}
