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
    public partial class LearningAssignment : global::Microsoft.Graph.Beta.Models.LearningCourseActivity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Assigned date for the course activity. Optional.</summary>
        public DateTimeOffset? AssignedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("assignedDateTime"); }
            set { BackingStore?.Set("assignedDateTime", value); }
        }
        /// <summary>The user ID of the assigner. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssignerUserId
        {
            get { return BackingStore?.Get<string?>("assignerUserId"); }
            set { BackingStore?.Set("assignerUserId", value); }
        }
#nullable restore
#else
        public string AssignerUserId
        {
            get { return BackingStore?.Get<string>("assignerUserId"); }
            set { BackingStore?.Set("assignerUserId", value); }
        }
#endif
        /// <summary>The assignmentType property</summary>
        public global::Microsoft.Graph.Beta.Models.AssignmentType? AssignmentType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AssignmentType?>("assignmentType"); }
            set { BackingStore?.Set("assignmentType", value); }
        }
        /// <summary>Due date for the course activity. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.DateTimeTimeZone? DueDateTime
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DateTimeTimeZone?>("dueDateTime"); }
            set { BackingStore?.Set("dueDateTime", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.DateTimeTimeZone DueDateTime
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DateTimeTimeZone>("dueDateTime"); }
            set { BackingStore?.Set("dueDateTime", value); }
        }
#endif
        /// <summary>Notes for the course activity. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.ItemBody? Notes
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ItemBody?>("notes"); }
            set { BackingStore?.Set("notes", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.ItemBody Notes
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ItemBody>("notes"); }
            set { BackingStore?.Set("notes", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.LearningAssignment"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.LearningAssignment CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.LearningAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "assignedDateTime", n => { AssignedDateTime = n.GetDateTimeOffsetValue(); } },
                { "assignerUserId", n => { AssignerUserId = n.GetStringValue(); } },
                { "assignmentType", n => { AssignmentType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.AssignmentType>(); } },
                { "dueDateTime", n => { DueDateTime = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.DateTimeTimeZone>(global::Microsoft.Graph.Beta.Models.DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                { "notes", n => { Notes = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.ItemBody>(global::Microsoft.Graph.Beta.Models.ItemBody.CreateFromDiscriminatorValue); } },
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
            writer.WriteDateTimeOffsetValue("assignedDateTime", AssignedDateTime);
            writer.WriteStringValue("assignerUserId", AssignerUserId);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.AssignmentType>("assignmentType", AssignmentType);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.DateTimeTimeZone>("dueDateTime", DueDateTime);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.ItemBody>("notes", Notes);
        }
    }
}
#pragma warning restore CS0618
