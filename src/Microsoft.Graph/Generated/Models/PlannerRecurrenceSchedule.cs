using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PlannerRecurrenceSchedule : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The nextOccurrenceDateTime property</summary>
        public DateTimeOffset? NextOccurrenceDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("nextOccurrenceDateTime"); }
            set { BackingStore?.Set("nextOccurrenceDateTime", value); }
        }
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
        /// <summary>The pattern property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RecurrencePattern? Pattern {
            get { return BackingStore?.Get<RecurrencePattern?>("pattern"); }
            set { BackingStore?.Set("pattern", value); }
        }
#nullable restore
#else
        public RecurrencePattern Pattern {
            get { return BackingStore?.Get<RecurrencePattern>("pattern"); }
            set { BackingStore?.Set("pattern", value); }
        }
#endif
        /// <summary>The patternStartDateTime property</summary>
        public DateTimeOffset? PatternStartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("patternStartDateTime"); }
            set { BackingStore?.Set("patternStartDateTime", value); }
        }
        /// <summary>
        /// Instantiates a new plannerRecurrenceSchedule and sets the default values.
        /// </summary>
        public PlannerRecurrenceSchedule() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PlannerRecurrenceSchedule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PlannerRecurrenceSchedule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"nextOccurrenceDateTime", n => { NextOccurrenceDateTime = n.GetDateTimeOffsetValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"pattern", n => { Pattern = n.GetObjectValue<RecurrencePattern>(RecurrencePattern.CreateFromDiscriminatorValue); } },
                {"patternStartDateTime", n => { PatternStartDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("nextOccurrenceDateTime", NextOccurrenceDateTime);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<RecurrencePattern>("pattern", Pattern);
            writer.WriteDateTimeOffsetValue("patternStartDateTime", PatternStartDateTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
