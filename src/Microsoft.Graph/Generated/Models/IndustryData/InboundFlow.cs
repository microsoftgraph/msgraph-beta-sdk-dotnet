using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.IndustryData {
    public class InboundFlow : IndustryDataActivity, IParsable {
        /// <summary>The dataConnector property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IndustryDataConnector? DataConnector {
            get { return BackingStore?.Get<IndustryDataConnector?>("dataConnector"); }
            set { BackingStore?.Set("dataConnector", value); }
        }
#nullable restore
#else
        public IndustryDataConnector DataConnector {
            get { return BackingStore?.Get<IndustryDataConnector>("dataConnector"); }
            set { BackingStore?.Set("dataConnector", value); }
        }
#endif
        /// <summary>The dataDomain property</summary>
        public InboundDomain? DataDomain {
            get { return BackingStore?.Get<InboundDomain?>("dataDomain"); }
            set { BackingStore?.Set("dataDomain", value); }
        }
        /// <summary>The start of the time window when the flow is allowed to run. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? EffectiveDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("effectiveDateTime"); }
            set { BackingStore?.Set("effectiveDateTime", value); }
        }
        /// <summary>The end of the time window when the flow is allowed to run. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? ExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("expirationDateTime"); }
            set { BackingStore?.Set("expirationDateTime", value); }
        }
        /// <summary>The year property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public YearTimePeriodDefinition? Year {
            get { return BackingStore?.Get<YearTimePeriodDefinition?>("year"); }
            set { BackingStore?.Set("year", value); }
        }
#nullable restore
#else
        public YearTimePeriodDefinition Year {
            get { return BackingStore?.Get<YearTimePeriodDefinition>("year"); }
            set { BackingStore?.Set("year", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new inboundFlow and sets the default values.
        /// </summary>
        public InboundFlow() : base() {
            OdataType = "#microsoft.graph.industryData.inboundFlow";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new InboundFlow CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.industryData.inboundFileFlow" => new InboundFileFlow(),
                _ => new InboundFlow(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"dataConnector", n => { DataConnector = n.GetObjectValue<IndustryDataConnector>(IndustryDataConnector.CreateFromDiscriminatorValue); } },
                {"dataDomain", n => { DataDomain = n.GetEnumValue<InboundDomain>(); } },
                {"effectiveDateTime", n => { EffectiveDateTime = n.GetDateTimeOffsetValue(); } },
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"year", n => { Year = n.GetObjectValue<YearTimePeriodDefinition>(YearTimePeriodDefinition.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<IndustryDataConnector>("dataConnector", DataConnector);
            writer.WriteEnumValue<InboundDomain>("dataDomain", DataDomain);
            writer.WriteDateTimeOffsetValue("effectiveDateTime", EffectiveDateTime);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteObjectValue<YearTimePeriodDefinition>("year", Year);
        }
    }
}
