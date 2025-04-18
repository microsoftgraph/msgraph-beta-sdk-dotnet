// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class EventMessageResponse : global::Microsoft.Graph.Beta.Models.EventMessage, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>An alternate date/time proposed by an invitee for a meeting request to start and end. Read-only. Not filterable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.TimeSlot? ProposedNewTime
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.TimeSlot?>("proposedNewTime"); }
            set { BackingStore?.Set("proposedNewTime", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.TimeSlot ProposedNewTime
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.TimeSlot>("proposedNewTime"); }
            set { BackingStore?.Set("proposedNewTime", value); }
        }
#endif
        /// <summary>Specifies the type of response to a meeting request. Possible values are: tentativelyAccepted, accepted, declined. For the eventMessageResponse type, none, organizer, and notResponded are not supported. Read-only. Not filterable.</summary>
        public global::Microsoft.Graph.Beta.Models.ResponseType? ResponseType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ResponseType?>("responseType"); }
            set { BackingStore?.Set("responseType", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.EventMessageResponse"/> and sets the default values.
        /// </summary>
        public EventMessageResponse() : base()
        {
            OdataType = "#microsoft.graph.eventMessageResponse";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.EventMessageResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.EventMessageResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.EventMessageResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "proposedNewTime", n => { ProposedNewTime = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.TimeSlot>(global::Microsoft.Graph.Beta.Models.TimeSlot.CreateFromDiscriminatorValue); } },
                { "responseType", n => { ResponseType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.ResponseType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.TimeSlot>("proposedNewTime", ProposedNewTime);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.ResponseType>("responseType", ResponseType);
        }
    }
}
#pragma warning restore CS0618
