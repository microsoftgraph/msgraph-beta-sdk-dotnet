// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.CallRecords
{
    #pragma warning disable CS1591
    public class ParticipantBase : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>List of administrativeUnitInfo of the call participant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.CallRecords.AdministrativeUnitInfo>? AdministrativeUnitInfos
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.CallRecords.AdministrativeUnitInfo>?>("administrativeUnitInfos"); }
            set { BackingStore?.Set("administrativeUnitInfos", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.CallRecords.AdministrativeUnitInfo> AdministrativeUnitInfos
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.CallRecords.AdministrativeUnitInfo>>("administrativeUnitInfos"); }
            set { BackingStore?.Set("administrativeUnitInfos", value); }
        }
#endif
        /// <summary>The identity of the call participant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.CommunicationsIdentitySet? Identity
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CommunicationsIdentitySet?>("identity"); }
            set { BackingStore?.Set("identity", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.CommunicationsIdentitySet Identity
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CommunicationsIdentitySet>("identity"); }
            set { BackingStore?.Set("identity", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.CallRecords.ParticipantBase"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.CallRecords.ParticipantBase CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.callRecords.organizer" => new Microsoft.Graph.Beta.Models.CallRecords.Organizer(),
                "#microsoft.graph.callRecords.participant" => new Microsoft.Graph.Beta.Models.CallRecords.Participant(),
                _ => new Microsoft.Graph.Beta.Models.CallRecords.ParticipantBase(),
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
                { "administrativeUnitInfos", n => { AdministrativeUnitInfos = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.CallRecords.AdministrativeUnitInfo>(Microsoft.Graph.Beta.Models.CallRecords.AdministrativeUnitInfo.CreateFromDiscriminatorValue)?.ToList(); } },
                { "identity", n => { Identity = n.GetObjectValue<Microsoft.Graph.Beta.Models.CommunicationsIdentitySet>(Microsoft.Graph.Beta.Models.CommunicationsIdentitySet.CreateFromDiscriminatorValue); } },
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
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.CallRecords.AdministrativeUnitInfo>("administrativeUnitInfos", AdministrativeUnitInfos);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.CommunicationsIdentitySet>("identity", Identity);
        }
    }
}
