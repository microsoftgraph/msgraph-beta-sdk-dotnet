using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class VirtualEventPresenter : Entity, IParsable {
        /// <summary>The email property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email {
            get { return BackingStore?.Get<string?>("email"); }
            set { BackingStore?.Set("email", value); }
        }
#nullable restore
#else
        public string Email {
            get { return BackingStore?.Get<string>("email"); }
            set { BackingStore?.Set("email", value); }
        }
#endif
        /// <summary>The identity property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CommunicationsUserIdentity? Identity {
            get { return BackingStore?.Get<CommunicationsUserIdentity?>("identity"); }
            set { BackingStore?.Set("identity", value); }
        }
#nullable restore
#else
        public CommunicationsUserIdentity Identity {
            get { return BackingStore?.Get<CommunicationsUserIdentity>("identity"); }
            set { BackingStore?.Set("identity", value); }
        }
#endif
        /// <summary>The presenterDetails property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public VirtualEventPresenterDetails? PresenterDetails {
            get { return BackingStore?.Get<VirtualEventPresenterDetails?>("presenterDetails"); }
            set { BackingStore?.Set("presenterDetails", value); }
        }
#nullable restore
#else
        public VirtualEventPresenterDetails PresenterDetails {
            get { return BackingStore?.Get<VirtualEventPresenterDetails>("presenterDetails"); }
            set { BackingStore?.Set("presenterDetails", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new VirtualEventPresenter CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VirtualEventPresenter();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"email", n => { Email = n.GetStringValue(); } },
                {"identity", n => { Identity = n.GetObjectValue<CommunicationsUserIdentity>(CommunicationsUserIdentity.CreateFromDiscriminatorValue); } },
                {"presenterDetails", n => { PresenterDetails = n.GetObjectValue<VirtualEventPresenterDetails>(VirtualEventPresenterDetails.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("email", Email);
            writer.WriteObjectValue<CommunicationsUserIdentity>("identity", Identity);
            writer.WriteObjectValue<VirtualEventPresenterDetails>("presenterDetails", PresenterDetails);
        }
    }
}
