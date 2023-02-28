namespace Microsoft.Graph.Beta.Models {
    public enum ErrorCode {
        /// <summary>Default Value to indicate no error.</summary>
        NoError,
        /// <summary>The current user does not have access due to lack of RBAC permissions on the resource.</summary>
        Unauthorized,
        /// <summary>The current user does not have access due to lack of RBAC Scope Tags on the resource.</summary>
        NotFound,
        /// <summary>The resource has been deleted.</summary>
        Deleted,
    }
}
