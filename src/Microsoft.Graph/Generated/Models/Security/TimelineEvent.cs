// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class TimelineEvent : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The date and time when the event occurred.</summary>
        public DateTimeOffset? EventDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("eventDateTime"); }
            set { BackingStore?.Set("eventDateTime", value); }
        }
        /// <summary>Additional details or context about the event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EventDetails
        {
            get { return BackingStore?.Get<string?>("eventDetails"); }
            set { BackingStore?.Set("eventDetails", value); }
        }
#nullable restore
#else
        public string EventDetails
        {
            get { return BackingStore?.Get<string>("eventDetails"); }
            set { BackingStore?.Set("eventDetails", value); }
        }
#endif
        /// <summary>The outcome or result of the event, such as delivery location or action taken.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EventResult
        {
            get { return BackingStore?.Get<string?>("eventResult"); }
            set { BackingStore?.Set("eventResult", value); }
        }
#nullable restore
#else
        public string EventResult
        {
            get { return BackingStore?.Get<string>("eventResult"); }
            set { BackingStore?.Set("eventResult", value); }
        }
#endif
        /// <summary>The origin or actor that triggered the event. The possible values are: system, admin, user, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Beta.Models.Security.EventSource? EventSource
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Security.EventSource?>("eventSource"); }
            set { BackingStore?.Set("eventSource", value); }
        }
        /// <summary>Collection of threats identified or associated with this event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? EventThreats
        {
            get { return BackingStore?.Get<List<string>?>("eventThreats"); }
            set { BackingStore?.Set("eventThreats", value); }
        }
#nullable restore
#else
        public List<string> EventThreats
        {
            get { return BackingStore?.Get<List<string>>("eventThreats"); }
            set { BackingStore?.Set("eventThreats", value); }
        }
#endif
        /// <summary>The type of event that occurred. The possible values are: originalDelivery, systemTimeTravel, dynamicDelivery, userUrlClick, reprocessed, zap, quarantineRelease, air, unknown, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Beta.Models.Security.TimelineEventType? EventType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Security.TimelineEventType?>("eventType"); }
            set { BackingStore?.Set("eventType", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.Security.TimelineEvent"/> and sets the default values.
        /// </summary>
        public TimelineEvent()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Security.TimelineEvent"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.Security.TimelineEvent CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.Security.TimelineEvent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "eventDateTime", n => { EventDateTime = n.GetDateTimeOffsetValue(); } },
                { "eventDetails", n => { EventDetails = n.GetStringValue(); } },
                { "eventResult", n => { EventResult = n.GetStringValue(); } },
                { "eventSource", n => { EventSource = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.Security.EventSource>(); } },
                { "eventThreats", n => { EventThreats = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "eventType", n => { EventType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.Security.TimelineEventType>(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("eventDateTime", EventDateTime);
            writer.WriteStringValue("eventDetails", EventDetails);
            writer.WriteStringValue("eventResult", EventResult);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.Security.EventSource>("eventSource", EventSource);
            writer.WriteCollectionOfPrimitiveValues<string>("eventThreats", EventThreats);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.Security.TimelineEventType>("eventType", EventType);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
