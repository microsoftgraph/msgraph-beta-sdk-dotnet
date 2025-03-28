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
    public partial class OutlookItem : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The categories associated with the item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Categories
        {
            get { return BackingStore?.Get<List<string>?>("categories"); }
            set { BackingStore?.Set("categories", value); }
        }
#nullable restore
#else
        public List<string> Categories
        {
            get { return BackingStore?.Get<List<string>>("categories"); }
            set { BackingStore?.Set("categories", value); }
        }
#endif
        /// <summary>Identifies the version of the item. Every time the item is changed, changeKey changes as well. This allows Exchange to apply changes to the correct version of the object. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ChangeKey
        {
            get { return BackingStore?.Get<string?>("changeKey"); }
            set { BackingStore?.Set("changeKey", value); }
        }
#nullable restore
#else
        public string ChangeKey
        {
            get { return BackingStore?.Get<string>("changeKey"); }
            set { BackingStore?.Set("changeKey", value); }
        }
#endif
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? LastModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.OutlookItem"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.OutlookItem CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.calendarSharingMessage" => new global::Microsoft.Graph.Beta.Models.CalendarSharingMessage(),
                "#microsoft.graph.contact" => new global::Microsoft.Graph.Beta.Models.Contact(),
                "#microsoft.graph.event" => new global::Microsoft.Graph.Beta.Models.Event(),
                "#microsoft.graph.eventMessage" => new global::Microsoft.Graph.Beta.Models.EventMessage(),
                "#microsoft.graph.eventMessageRequest" => new global::Microsoft.Graph.Beta.Models.EventMessageRequest(),
                "#microsoft.graph.eventMessageResponse" => new global::Microsoft.Graph.Beta.Models.EventMessageResponse(),
                "#microsoft.graph.mailboxItem" => new global::Microsoft.Graph.Beta.Models.MailboxItem(),
                "#microsoft.graph.message" => new global::Microsoft.Graph.Beta.Models.Message(),
                "#microsoft.graph.note" => new global::Microsoft.Graph.Beta.Models.Note(),
                "#microsoft.graph.outlookTask" => new global::Microsoft.Graph.Beta.Models.OutlookTask(),
                "#microsoft.graph.post" => new global::Microsoft.Graph.Beta.Models.Post(),
                _ => new global::Microsoft.Graph.Beta.Models.OutlookItem(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "categories", n => { Categories = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "changeKey", n => { ChangeKey = n.GetStringValue(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("categories", Categories);
            writer.WriteStringValue("changeKey", ChangeKey);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
        }
    }
}
#pragma warning restore CS0618
