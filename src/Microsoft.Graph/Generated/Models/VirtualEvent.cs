using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class VirtualEvent : Entity, IParsable {
        /// <summary>Identity information of who created the virtual event. Inherited from virtualEvent.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CommunicationsIdentitySet? CreatedBy {
            get { return BackingStore?.Get<CommunicationsIdentitySet?>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#nullable restore
#else
        public CommunicationsIdentitySet CreatedBy {
            get { return BackingStore?.Get<CommunicationsIdentitySet>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#endif
        /// <summary>Description of the virtual event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>Display name of the virtual event</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>End time of the virtual event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DateTimeTimeZone? EndDateTime {
            get { return BackingStore?.Get<DateTimeTimeZone?>("endDateTime"); }
            set { BackingStore?.Set("endDateTime", value); }
        }
#nullable restore
#else
        public DateTimeTimeZone EndDateTime {
            get { return BackingStore?.Get<DateTimeTimeZone>("endDateTime"); }
            set { BackingStore?.Set("endDateTime", value); }
        }
#endif
        /// <summary>Presenters&apos; information of the virtual event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<VirtualEventPresenter>? Presenters {
            get { return BackingStore?.Get<List<VirtualEventPresenter>?>("presenters"); }
            set { BackingStore?.Set("presenters", value); }
        }
#nullable restore
#else
        public List<VirtualEventPresenter> Presenters {
            get { return BackingStore?.Get<List<VirtualEventPresenter>>("presenters"); }
            set { BackingStore?.Set("presenters", value); }
        }
#endif
        /// <summary>Sessions of the virtual event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<VirtualEventSession>? Sessions {
            get { return BackingStore?.Get<List<VirtualEventSession>?>("sessions"); }
            set { BackingStore?.Set("sessions", value); }
        }
#nullable restore
#else
        public List<VirtualEventSession> Sessions {
            get { return BackingStore?.Get<List<VirtualEventSession>>("sessions"); }
            set { BackingStore?.Set("sessions", value); }
        }
#endif
        /// <summary>Start time of the virtual event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DateTimeTimeZone? StartDateTime {
            get { return BackingStore?.Get<DateTimeTimeZone?>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
#nullable restore
#else
        public DateTimeTimeZone StartDateTime {
            get { return BackingStore?.Get<DateTimeTimeZone>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
#endif
        /// <summary>Status of the virtual event. The possible values are: draft, published, canceled, unknownFutureValue.</summary>
        public VirtualEventStatus? Status {
            get { return BackingStore?.Get<VirtualEventStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new VirtualEvent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.virtualEventWebinar" => new VirtualEventWebinar(),
                _ => new VirtualEvent(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"createdBy", n => { CreatedBy = n.GetObjectValue<CommunicationsIdentitySet>(CommunicationsIdentitySet.CreateFromDiscriminatorValue); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"endDateTime", n => { EndDateTime = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"presenters", n => { Presenters = n.GetCollectionOfObjectValues<VirtualEventPresenter>(VirtualEventPresenter.CreateFromDiscriminatorValue)?.ToList(); } },
                {"sessions", n => { Sessions = n.GetCollectionOfObjectValues<VirtualEventSession>(VirtualEventSession.CreateFromDiscriminatorValue)?.ToList(); } },
                {"startDateTime", n => { StartDateTime = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"status", n => { Status = n.GetEnumValue<VirtualEventStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<CommunicationsIdentitySet>("createdBy", CreatedBy);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<DateTimeTimeZone>("endDateTime", EndDateTime);
            writer.WriteCollectionOfObjectValues<VirtualEventPresenter>("presenters", Presenters);
            writer.WriteCollectionOfObjectValues<VirtualEventSession>("sessions", Sessions);
            writer.WriteObjectValue<DateTimeTimeZone>("startDateTime", StartDateTime);
            writer.WriteEnumValue<VirtualEventStatus>("status", Status);
        }
    }
}
