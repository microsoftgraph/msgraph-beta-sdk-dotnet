using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class EducationSynchronizationCustomizations : EducationSynchronizationCustomizationsBase, IParsable {
        /// <summary>Customizations for School entities.</summary>
        public EducationSynchronizationCustomization School {
            get { return BackingStore?.Get<EducationSynchronizationCustomization>(nameof(School)); }
            set { BackingStore?.Set(nameof(School), value); }
        }
        /// <summary>Customizations for Section entities.</summary>
        public EducationSynchronizationCustomization Section {
            get { return BackingStore?.Get<EducationSynchronizationCustomization>(nameof(Section)); }
            set { BackingStore?.Set(nameof(Section), value); }
        }
        /// <summary>Customizations for Student entities.</summary>
        public EducationSynchronizationCustomization Student {
            get { return BackingStore?.Get<EducationSynchronizationCustomization>(nameof(Student)); }
            set { BackingStore?.Set(nameof(Student), value); }
        }
        /// <summary>Customizations for Student Enrollments.</summary>
        public EducationSynchronizationCustomization StudentEnrollment {
            get { return BackingStore?.Get<EducationSynchronizationCustomization>(nameof(StudentEnrollment)); }
            set { BackingStore?.Set(nameof(StudentEnrollment), value); }
        }
        /// <summary>Customizations for Teacher entities.</summary>
        public EducationSynchronizationCustomization Teacher {
            get { return BackingStore?.Get<EducationSynchronizationCustomization>(nameof(Teacher)); }
            set { BackingStore?.Set(nameof(Teacher), value); }
        }
        /// <summary>Customizations for Teacher Rosters.</summary>
        public EducationSynchronizationCustomization TeacherRoster {
            get { return BackingStore?.Get<EducationSynchronizationCustomization>(nameof(TeacherRoster)); }
            set { BackingStore?.Set(nameof(TeacherRoster), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EducationSynchronizationCustomizations CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationSynchronizationCustomizations();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"school", n => { School = n.GetObjectValue<EducationSynchronizationCustomization>(EducationSynchronizationCustomization.CreateFromDiscriminatorValue); } },
                {"section", n => { Section = n.GetObjectValue<EducationSynchronizationCustomization>(EducationSynchronizationCustomization.CreateFromDiscriminatorValue); } },
                {"student", n => { Student = n.GetObjectValue<EducationSynchronizationCustomization>(EducationSynchronizationCustomization.CreateFromDiscriminatorValue); } },
                {"studentEnrollment", n => { StudentEnrollment = n.GetObjectValue<EducationSynchronizationCustomization>(EducationSynchronizationCustomization.CreateFromDiscriminatorValue); } },
                {"teacher", n => { Teacher = n.GetObjectValue<EducationSynchronizationCustomization>(EducationSynchronizationCustomization.CreateFromDiscriminatorValue); } },
                {"teacherRoster", n => { TeacherRoster = n.GetObjectValue<EducationSynchronizationCustomization>(EducationSynchronizationCustomization.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<EducationSynchronizationCustomization>("school", School);
            writer.WriteObjectValue<EducationSynchronizationCustomization>("section", Section);
            writer.WriteObjectValue<EducationSynchronizationCustomization>("student", Student);
            writer.WriteObjectValue<EducationSynchronizationCustomization>("studentEnrollment", StudentEnrollment);
            writer.WriteObjectValue<EducationSynchronizationCustomization>("teacher", Teacher);
            writer.WriteObjectValue<EducationSynchronizationCustomization>("teacherRoster", TeacherRoster);
        }
    }
}
