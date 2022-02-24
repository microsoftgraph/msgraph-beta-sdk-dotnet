using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
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
        public Program Program { get; set; }
        /// <summary>The programId of the program this control is a part of. Required on create.</summary>
        public string ProgramId { get; set; }
        /// <summary>The resource, a group or an app, targeted by this program control's access review.</summary>
        public ProgramResource Resource { get; set; }
        /// <summary>The life cycle status of the control.</summary>
        public string Status { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"controlId", (o,n) => { (o as ProgramControl).ControlId = n.GetStringValue(); } },
                {"controlTypeId", (o,n) => { (o as ProgramControl).ControlTypeId = n.GetStringValue(); } },
                {"createdDateTime", (o,n) => { (o as ProgramControl).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayName", (o,n) => { (o as ProgramControl).DisplayName = n.GetStringValue(); } },
                {"owner", (o,n) => { (o as ProgramControl).Owner = n.GetObjectValue<UserIdentity>(); } },
                {"program", (o,n) => { (o as ProgramControl).Program = n.GetObjectValue<Program>(); } },
                {"programId", (o,n) => { (o as ProgramControl).ProgramId = n.GetStringValue(); } },
                {"resource", (o,n) => { (o as ProgramControl).Resource = n.GetObjectValue<ProgramResource>(); } },
                {"status", (o,n) => { (o as ProgramControl).Status = n.GetStringValue(); } },
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
            writer.WriteObjectValue<Program>("program", Program);
            writer.WriteStringValue("programId", ProgramId);
            writer.WriteObjectValue<ProgramResource>("resource", Resource);
            writer.WriteStringValue("status", Status);
        }
    }
}
