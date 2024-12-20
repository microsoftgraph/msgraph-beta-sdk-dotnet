// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class MeetingParticipants : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Information of the meeting attendees.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.MeetingParticipantInfo>? Attendees
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.MeetingParticipantInfo>?>("attendees"); }
            set { BackingStore?.Set("attendees", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.MeetingParticipantInfo> Attendees
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.MeetingParticipantInfo>>("attendees"); }
            set { BackingStore?.Set("attendees", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>For broadcast meeting only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.MeetingParticipantInfo>? Contributors
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.MeetingParticipantInfo>?>("contributors"); }
            set { BackingStore?.Set("contributors", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.MeetingParticipantInfo> Contributors
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.MeetingParticipantInfo>>("contributors"); }
            set { BackingStore?.Set("contributors", value); }
        }
#endif
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
        /// <summary>Information of the meeting organizer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.MeetingParticipantInfo? Organizer
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.MeetingParticipantInfo?>("organizer"); }
            set { BackingStore?.Set("organizer", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.MeetingParticipantInfo Organizer
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.MeetingParticipantInfo>("organizer"); }
            set { BackingStore?.Set("organizer", value); }
        }
#endif
        /// <summary>For broadcast meeting only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.MeetingParticipantInfo>? Producers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.MeetingParticipantInfo>?>("producers"); }
            set { BackingStore?.Set("producers", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.MeetingParticipantInfo> Producers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.MeetingParticipantInfo>>("producers"); }
            set { BackingStore?.Set("producers", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.MeetingParticipants"/> and sets the default values.
        /// </summary>
        public MeetingParticipants()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.MeetingParticipants"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.MeetingParticipants CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.MeetingParticipants();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "attendees", n => { Attendees = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.MeetingParticipantInfo>(global::Microsoft.Graph.Beta.Models.MeetingParticipantInfo.CreateFromDiscriminatorValue)?.AsList(); } },
                { "contributors", n => { Contributors = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.MeetingParticipantInfo>(global::Microsoft.Graph.Beta.Models.MeetingParticipantInfo.CreateFromDiscriminatorValue)?.AsList(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "organizer", n => { Organizer = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.MeetingParticipantInfo>(global::Microsoft.Graph.Beta.Models.MeetingParticipantInfo.CreateFromDiscriminatorValue); } },
                { "producers", n => { Producers = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.MeetingParticipantInfo>(global::Microsoft.Graph.Beta.Models.MeetingParticipantInfo.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.MeetingParticipantInfo>("attendees", Attendees);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.MeetingParticipantInfo>("contributors", Contributors);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.MeetingParticipantInfo>("organizer", Organizer);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.MeetingParticipantInfo>("producers", Producers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
