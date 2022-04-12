using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ProgramControl : Entity, IParsable {
        /// <summary>The controlId of the control, in particular the identifier of an access review. Required on create.</summary>
        public string ControlId { get; set; }
        /// <summary>The programControlType identifies the type of program control - for example, a control linking to guest access reviews. Required on create.</summary>
        public string ControlTypeId { get; set; }
        /// <summary>The creation date and time of the program control.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The name of the control.</summary>
        public string DisplayName { get; set; }
        /// <summary>The user who created the program control.</summary>
        public UserIdentity Owner { get; set; }
        /// <summary>The program this control is part of.</summary>
        public Microsoft.Graph.Beta.Models.Program Program { get; set; }
        /// <summary>The programId of the program this control is a part of. Required on create.</summary>
        public string ProgramId { get; set; }
        /// <summary>The resource, a group or an app, targeted by this program control&apos;s access review.</summary>
        public ProgramResource Resource { get; set; }
        /// <summary>The life cycle status of the control.</summary>
        public string Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ProgramControl CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ProgramControl();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"controlId", n => { ControlId = n.GetStringValue(); } },
                {"controlTypeId", n => { ControlTypeId = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"owner", n => { Owner = n.GetObjectValue<UserIdentity>(UserIdentity.CreateFromDiscriminatorValue); } },
                {"program", n => { Program = n.GetObjectValue<Microsoft.Graph.Beta.Models.Program>(Microsoft.Graph.Beta.Models.Program.CreateFromDiscriminatorValue); } },
                {"programId", n => { ProgramId = n.GetStringValue(); } },
                {"resource", n => { Resource = n.GetObjectValue<ProgramResource>(ProgramResource.CreateFromDiscriminatorValue); } },
                {"status", n => { Status = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("controlId", ControlId);
            writer.WriteStringValue("controlTypeId", ControlTypeId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<UserIdentity>("owner", Owner);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Program>("program", Program);
            writer.WriteStringValue("programId", ProgramId);
            writer.WriteObjectValue<ProgramResource>("resource", Resource);
            writer.WriteStringValue("status", Status);
        }
    }
}
