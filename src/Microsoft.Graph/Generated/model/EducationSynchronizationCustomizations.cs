// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type EducationSynchronizationCustomizations.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class EducationSynchronizationCustomizations : EducationSynchronizationCustomizationsBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EducationSynchronizationCustomizations"/> class.
        /// </summary>
        public EducationSynchronizationCustomizations()
        {
            this.ODataType = "microsoft.graph.educationSynchronizationCustomizations";
        }

        /// <summary>
        /// Gets or sets school.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "school", Required = Newtonsoft.Json.Required.Default)]
        public EducationSynchronizationCustomization School { get; set; }
    
        /// <summary>
        /// Gets or sets section.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "section", Required = Newtonsoft.Json.Required.Default)]
        public EducationSynchronizationCustomization Section { get; set; }
    
        /// <summary>
        /// Gets or sets student.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "student", Required = Newtonsoft.Json.Required.Default)]
        public EducationSynchronizationCustomization Student { get; set; }
    
        /// <summary>
        /// Gets or sets studentEnrollment.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "studentEnrollment", Required = Newtonsoft.Json.Required.Default)]
        public EducationSynchronizationCustomization StudentEnrollment { get; set; }
    
        /// <summary>
        /// Gets or sets teacher.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "teacher", Required = Newtonsoft.Json.Required.Default)]
        public EducationSynchronizationCustomization Teacher { get; set; }
    
        /// <summary>
        /// Gets or sets teacherRoster.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "teacherRoster", Required = Newtonsoft.Json.Required.Default)]
        public EducationSynchronizationCustomization TeacherRoster { get; set; }
    
    }
}