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
    public partial class VirtualEvent : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The identity information for the creator of the virtual event. Inherited from virtualEvent.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.CommunicationsIdentitySet? CreatedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CommunicationsIdentitySet?>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.CommunicationsIdentitySet CreatedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CommunicationsIdentitySet>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#endif
        /// <summary>A description of the virtual event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.ItemBody? Description
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ItemBody?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.ItemBody Description
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ItemBody>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The display name of the virtual event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The end time of the virtual event. The timeZone property can be set to any of the time zones currently supported by Windows. For details on how to get all available time zones using PowerShell, see Get-TimeZone.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.DateTimeTimeZone? EndDateTime
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DateTimeTimeZone?>("endDateTime"); }
            set { BackingStore?.Set("endDateTime", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.DateTimeTimeZone EndDateTime
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DateTimeTimeZone>("endDateTime"); }
            set { BackingStore?.Set("endDateTime", value); }
        }
#endif
        /// <summary>The external information of a virtual event. Returned only for event organizers or coorganizers; otherwise, null.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.VirtualEventExternalInformation>? ExternalEventInformation
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.VirtualEventExternalInformation>?>("externalEventInformation"); }
            set { BackingStore?.Set("externalEventInformation", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.VirtualEventExternalInformation> ExternalEventInformation
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.VirtualEventExternalInformation>>("externalEventInformation"); }
            set { BackingStore?.Set("externalEventInformation", value); }
        }
#endif
        /// <summary>The virtual event presenters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.VirtualEventPresenter>? Presenters
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.VirtualEventPresenter>?>("presenters"); }
            set { BackingStore?.Set("presenters", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.VirtualEventPresenter> Presenters
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.VirtualEventPresenter>>("presenters"); }
            set { BackingStore?.Set("presenters", value); }
        }
#endif
        /// <summary>The sessions for the virtual event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.VirtualEventSession>? Sessions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.VirtualEventSession>?>("sessions"); }
            set { BackingStore?.Set("sessions", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.VirtualEventSession> Sessions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.VirtualEventSession>>("sessions"); }
            set { BackingStore?.Set("sessions", value); }
        }
#endif
        /// <summary>The virtual event settings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.VirtualEventSettings? Settings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.VirtualEventSettings?>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.VirtualEventSettings Settings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.VirtualEventSettings>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#endif
        /// <summary>Start time of the virtual event. The timeZone property can be set to any of the time zones currently supported by Windows. For details on how to get all available time zones using PowerShell, see Get-TimeZone.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.DateTimeTimeZone? StartDateTime
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DateTimeTimeZone?>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.DateTimeTimeZone StartDateTime
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DateTimeTimeZone>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
#endif
        /// <summary>The status of the virtual event. The possible values are: draft, published, canceled, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Beta.Models.VirtualEventStatus? Status
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.VirtualEventStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.VirtualEvent"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.VirtualEvent CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.virtualEventTownhall" => new global::Microsoft.Graph.Beta.Models.VirtualEventTownhall(),
                "#microsoft.graph.virtualEventWebinar" => new global::Microsoft.Graph.Beta.Models.VirtualEventWebinar(),
                _ => new global::Microsoft.Graph.Beta.Models.VirtualEvent(),
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
                { "createdBy", n => { CreatedBy = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.CommunicationsIdentitySet>(global::Microsoft.Graph.Beta.Models.CommunicationsIdentitySet.CreateFromDiscriminatorValue); } },
                { "description", n => { Description = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.ItemBody>(global::Microsoft.Graph.Beta.Models.ItemBody.CreateFromDiscriminatorValue); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "endDateTime", n => { EndDateTime = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.DateTimeTimeZone>(global::Microsoft.Graph.Beta.Models.DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                { "externalEventInformation", n => { ExternalEventInformation = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.VirtualEventExternalInformation>(global::Microsoft.Graph.Beta.Models.VirtualEventExternalInformation.CreateFromDiscriminatorValue)?.AsList(); } },
                { "presenters", n => { Presenters = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.VirtualEventPresenter>(global::Microsoft.Graph.Beta.Models.VirtualEventPresenter.CreateFromDiscriminatorValue)?.AsList(); } },
                { "sessions", n => { Sessions = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.VirtualEventSession>(global::Microsoft.Graph.Beta.Models.VirtualEventSession.CreateFromDiscriminatorValue)?.AsList(); } },
                { "settings", n => { Settings = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.VirtualEventSettings>(global::Microsoft.Graph.Beta.Models.VirtualEventSettings.CreateFromDiscriminatorValue); } },
                { "startDateTime", n => { StartDateTime = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.DateTimeTimeZone>(global::Microsoft.Graph.Beta.Models.DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                { "status", n => { Status = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.VirtualEventStatus>(); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.CommunicationsIdentitySet>("createdBy", CreatedBy);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.ItemBody>("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.DateTimeTimeZone>("endDateTime", EndDateTime);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.VirtualEventExternalInformation>("externalEventInformation", ExternalEventInformation);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.VirtualEventPresenter>("presenters", Presenters);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.VirtualEventSession>("sessions", Sessions);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.VirtualEventSettings>("settings", Settings);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.DateTimeTimeZone>("startDateTime", StartDateTime);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.VirtualEventStatus>("status", Status);
        }
    }
}
#pragma warning restore CS0618
