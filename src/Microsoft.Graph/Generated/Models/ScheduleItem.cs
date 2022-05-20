using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ScheduleItem : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The date, time, and time zone that the corresponding event ends.</summary>
        public DateTimeTimeZone End {
            get { return BackingStore?.Get<DateTimeTimeZone>(nameof(End)); }
            set { BackingStore?.Set(nameof(End), value); }
        }
        /// <summary>The sensitivity of the corresponding event. True if the event is marked private, false otherwise. Optional.</summary>
        public bool? IsPrivate {
            get { return BackingStore?.Get<bool?>(nameof(IsPrivate)); }
            set { BackingStore?.Set(nameof(IsPrivate), value); }
        }
        /// <summary>The location where the corresponding event is held or attended from. Optional.</summary>
        public string Location {
            get { return BackingStore?.Get<string>(nameof(Location)); }
            set { BackingStore?.Set(nameof(Location), value); }
        }
        /// <summary>The date, time, and time zone that the corresponding event starts.</summary>
        public DateTimeTimeZone Start {
            get { return BackingStore?.Get<DateTimeTimeZone>(nameof(Start)); }
            set { BackingStore?.Set(nameof(Start), value); }
        }
        /// <summary>The availability status of the user or resource during the corresponding event. The possible values are: free, tentative, busy, oof, workingElsewhere, unknown.</summary>
        public FreeBusyStatus? Status {
            get { return BackingStore?.Get<FreeBusyStatus?>(nameof(Status)); }
            set { BackingStore?.Set(nameof(Status), value); }
        }
        /// <summary>The corresponding event&apos;s subject line. Optional.</summary>
        public string Subject {
            get { return BackingStore?.Get<string>(nameof(Subject)); }
            set { BackingStore?.Set(nameof(Subject), value); }
        }
        /// <summary>
        /// Instantiates a new scheduleItem and sets the default values.
        /// </summary>
        public ScheduleItem() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ScheduleItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ScheduleItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"end", n => { End = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"isPrivate", n => { IsPrivate = n.GetBoolValue(); } },
                {"location", n => { Location = n.GetStringValue(); } },
                {"start", n => { Start = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"status", n => { Status = n.GetEnumValue<FreeBusyStatus>(); } },
                {"subject", n => { Subject = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<DateTimeTimeZone>("end", End);
            writer.WriteBoolValue("isPrivate", IsPrivate);
            writer.WriteStringValue("location", Location);
            writer.WriteObjectValue<DateTimeTimeZone>("start", Start);
            writer.WriteEnumValue<FreeBusyStatus>("status", Status);
            writer.WriteStringValue("subject", Subject);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
