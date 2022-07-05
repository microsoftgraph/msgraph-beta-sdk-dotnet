using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Casts the previous resource to application.</summary>
    public class SynchronizationTemplate : Entity, IParsable {
        /// <summary>Identifier of the application this template belongs to.</summary>
        public string ApplicationId {
            get { return BackingStore?.Get<string>(nameof(ApplicationId)); }
            set { BackingStore?.Set(nameof(ApplicationId), value); }
        }
        /// <summary>true if this template is recommended to be the default for the application.</summary>
        public bool? Default {
            get { return BackingStore?.Get<bool?>(nameof(Default)); }
            set { BackingStore?.Set(nameof(Default), value); }
        }
        /// <summary>Description of the template.</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>true if this template should appear in the collection of templates available for the application instance (service principal).</summary>
        public bool? Discoverable {
            get { return BackingStore?.Get<bool?>(nameof(Discoverable)); }
            set { BackingStore?.Set(nameof(Discoverable), value); }
        }
        /// <summary>One of the well-known factory tags supported by the synchronization engine. The factoryTag tells the synchronization engine which implementation to use when processing jobs based on this template.</summary>
        public string FactoryTag {
            get { return BackingStore?.Get<string>(nameof(FactoryTag)); }
            set { BackingStore?.Set(nameof(FactoryTag), value); }
        }
        /// <summary>Additional extension properties. Unless mentioned explicitly, metadata values should not be changed.</summary>
        public List<MetadataEntry> Metadata {
            get { return BackingStore?.Get<List<MetadataEntry>>(nameof(Metadata)); }
            set { BackingStore?.Set(nameof(Metadata), value); }
        }
        /// <summary>Default synchronization schema for the jobs based on this template.</summary>
        public SynchronizationSchema Schema {
            get { return BackingStore?.Get<SynchronizationSchema>(nameof(Schema)); }
            set { BackingStore?.Set(nameof(Schema), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SynchronizationTemplate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SynchronizationTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"applicationId", n => { ApplicationId = n.GetStringValue(); } },
                {"default", n => { Default = n.GetBoolValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"discoverable", n => { Discoverable = n.GetBoolValue(); } },
                {"factoryTag", n => { FactoryTag = n.GetStringValue(); } },
                {"metadata", n => { Metadata = n.GetCollectionOfObjectValues<MetadataEntry>(MetadataEntry.CreateFromDiscriminatorValue).ToList(); } },
                {"schema", n => { Schema = n.GetObjectValue<SynchronizationSchema>(SynchronizationSchema.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("applicationId", ApplicationId);
            writer.WriteBoolValue("default", Default);
            writer.WriteStringValue("description", Description);
            writer.WriteBoolValue("discoverable", Discoverable);
            writer.WriteStringValue("factoryTag", FactoryTag);
            writer.WriteCollectionOfObjectValues<MetadataEntry>("metadata", Metadata);
            writer.WriteObjectValue<SynchronizationSchema>("schema", Schema);
        }
    }
}
