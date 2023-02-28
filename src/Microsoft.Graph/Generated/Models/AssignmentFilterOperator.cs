namespace Microsoft.Graph.Beta.Models {
    /// <summary>Represents the different type of operators which can be used to craft the AssignmentFilter rule.</summary>
    public enum AssignmentFilterOperator {
        /// <summary>NotSet.</summary>
        NotSet,
        /// <summary>Equals.</summary>
        Equals,
        /// <summary>NotEquals.</summary>
        NotEquals,
        /// <summary>StartsWith.</summary>
        StartsWith,
        /// <summary>NotStartsWith.</summary>
        NotStartsWith,
        /// <summary>Contains.</summary>
        Contains,
        /// <summary>NotContains.</summary>
        NotContains,
        /// <summary>In.</summary>
        In,
        /// <summary>NotIn.</summary>
        NotIn,
        /// <summary>EndsWith.</summary>
        EndsWith,
        /// <summary>NotEndsWith.</summary>
        NotEndsWith,
    }
}
