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
    public partial class Planner : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Read-only. Nullable. Returns a collection of the specified buckets</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.PlannerBucket>? Buckets
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.PlannerBucket>?>("buckets"); }
            set { BackingStore?.Set("buckets", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.PlannerBucket> Buckets
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.PlannerBucket>>("buckets"); }
            set { BackingStore?.Set("buckets", value); }
        }
#endif
        /// <summary>Read-only. Nullable. Returns a collection of the specified plans</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.PlannerPlan>? Plans
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.PlannerPlan>?>("plans"); }
            set { BackingStore?.Set("plans", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.PlannerPlan> Plans
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.PlannerPlan>>("plans"); }
            set { BackingStore?.Set("plans", value); }
        }
#endif
        /// <summary>Read-only. Nullable. Returns a collection of the specified rosters</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.PlannerRoster>? Rosters
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.PlannerRoster>?>("rosters"); }
            set { BackingStore?.Set("rosters", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.PlannerRoster> Rosters
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.PlannerRoster>>("rosters"); }
            set { BackingStore?.Set("rosters", value); }
        }
#endif
        /// <summary>Read-only. Nullable. Returns a collection of the specified tasks</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.PlannerTask>? Tasks
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.PlannerTask>?>("tasks"); }
            set { BackingStore?.Set("tasks", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.PlannerTask> Tasks
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.PlannerTask>>("tasks"); }
            set { BackingStore?.Set("tasks", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Planner"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.Planner CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.Planner();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "buckets", n => { Buckets = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.PlannerBucket>(global::Microsoft.Graph.Beta.Models.PlannerBucket.CreateFromDiscriminatorValue)?.AsList(); } },
                { "plans", n => { Plans = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.PlannerPlan>(global::Microsoft.Graph.Beta.Models.PlannerPlan.CreateFromDiscriminatorValue)?.AsList(); } },
                { "rosters", n => { Rosters = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.PlannerRoster>(global::Microsoft.Graph.Beta.Models.PlannerRoster.CreateFromDiscriminatorValue)?.AsList(); } },
                { "tasks", n => { Tasks = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.PlannerTask>(global::Microsoft.Graph.Beta.Models.PlannerTask.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.PlannerBucket>("buckets", Buckets);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.PlannerPlan>("plans", Plans);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.PlannerRoster>("rosters", Rosters);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.PlannerTask>("tasks", Tasks);
        }
    }
}
#pragma warning restore CS0618
