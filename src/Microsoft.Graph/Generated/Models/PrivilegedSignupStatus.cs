using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class PrivilegedSignupStatus : Entity, IParsable {
        /// <summary>The isRegistered property</summary>
        public bool? IsRegistered {
            get { return BackingStore?.Get<bool?>("isRegistered"); }
            set { BackingStore?.Set("isRegistered", value); }
        }
        /// <summary>The status property</summary>
        public SetupStatus? Status {
            get { return BackingStore?.Get<SetupStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Instantiates a new privilegedSignupStatus and sets the default values.
        /// </summary>
        public PrivilegedSignupStatus() : base() {
            OdataType = "#microsoft.graph.privilegedSignupStatus";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new PrivilegedSignupStatus CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrivilegedSignupStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"isRegistered", n => { IsRegistered = n.GetBoolValue(); } },
                {"status", n => { Status = n.GetEnumValue<SetupStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("isRegistered", IsRegistered);
            writer.WriteEnumValue<SetupStatus>("status", Status);
        }
    }
}
