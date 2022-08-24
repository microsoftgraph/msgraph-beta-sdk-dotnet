using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    public class OauthApplicationEvidence : AlertEvidence, IParsable {
        /// <summary>Unique identifier of the application.</summary>
        public string AppId {
            get { return BackingStore?.Get<string>("appId"); }
            set { BackingStore?.Set("appId", value); }
        }
        /// <summary>Name of the application.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The unique identifier of the application object in Azure AD.</summary>
        public string ObjectId {
            get { return BackingStore?.Get<string>("objectId"); }
            set { BackingStore?.Set("objectId", value); }
        }
        /// <summary>The name of the application publisher.</summary>
        public string Publisher {
            get { return BackingStore?.Get<string>("publisher"); }
            set { BackingStore?.Set("publisher", value); }
        }
        /// <summary>
        /// Instantiates a new OauthApplicationEvidence and sets the default values.
        /// </summary>
        public OauthApplicationEvidence() : base() {
            OdataType = "#microsoft.graph.security.oauthApplicationEvidence";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new OauthApplicationEvidence CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OauthApplicationEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appId", n => { AppId = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"objectId", n => { ObjectId = n.GetStringValue(); } },
                {"publisher", n => { Publisher = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appId", AppId);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("objectId", ObjectId);
            writer.WriteStringValue("publisher", Publisher);
        }
    }
}
