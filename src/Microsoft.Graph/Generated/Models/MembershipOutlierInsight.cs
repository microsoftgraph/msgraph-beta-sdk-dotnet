using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MembershipOutlierInsight : GovernanceInsight, IParsable {
        /// <summary>The container property</summary>
        public DirectoryObject Container {
            get { return BackingStore?.Get<DirectoryObject>("container"); }
            set { BackingStore?.Set("container", value); }
        }
        /// <summary>The containerId property</summary>
        public string ContainerId {
            get { return BackingStore?.Get<string>("containerId"); }
            set { BackingStore?.Set("containerId", value); }
        }
        /// <summary>The member property</summary>
        public DirectoryObject Member {
            get { return BackingStore?.Get<DirectoryObject>("member"); }
            set { BackingStore?.Set("member", value); }
        }
        /// <summary>The memberId property</summary>
        public string MemberId {
            get { return BackingStore?.Get<string>("memberId"); }
            set { BackingStore?.Set("memberId", value); }
        }
        /// <summary>The outlierContainerType property</summary>
        public Microsoft.Graph.Beta.Models.OutlierContainerType? OutlierContainerType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.OutlierContainerType?>("outlierContainerType"); }
            set { BackingStore?.Set("outlierContainerType", value); }
        }
        /// <summary>The outlierMemberType property</summary>
        public Microsoft.Graph.Beta.Models.OutlierMemberType? OutlierMemberType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.OutlierMemberType?>("outlierMemberType"); }
            set { BackingStore?.Set("outlierMemberType", value); }
        }
        /// <summary>
        /// Instantiates a new MembershipOutlierInsight and sets the default values.
        /// </summary>
        public MembershipOutlierInsight() : base() {
            OdataType = "#microsoft.graph.membershipOutlierInsight";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MembershipOutlierInsight CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MembershipOutlierInsight();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"container", n => { Container = n.GetObjectValue<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue); } },
                {"containerId", n => { ContainerId = n.GetStringValue(); } },
                {"member", n => { Member = n.GetObjectValue<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue); } },
                {"memberId", n => { MemberId = n.GetStringValue(); } },
                {"outlierContainerType", n => { OutlierContainerType = n.GetEnumValue<OutlierContainerType>(); } },
                {"outlierMemberType", n => { OutlierMemberType = n.GetEnumValue<OutlierMemberType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<DirectoryObject>("container", Container);
            writer.WriteStringValue("containerId", ContainerId);
            writer.WriteObjectValue<DirectoryObject>("member", Member);
            writer.WriteStringValue("memberId", MemberId);
            writer.WriteEnumValue<OutlierContainerType>("outlierContainerType", OutlierContainerType);
            writer.WriteEnumValue<OutlierMemberType>("outlierMemberType", OutlierMemberType);
        }
    }
}
