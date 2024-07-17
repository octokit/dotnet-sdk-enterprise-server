// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Orgs.Item.Repos {
    /// <summary>The visibility of the repository. **Note**: For GitHub Enterprise Server, this endpoint will only list repositories available to all users on the enterprise. For more information, see &quot;[Creating an internal repository](https://docs.github.com/enterprise-server@3.12/github/creating-cloning-and-archiving-repositories/about-repository-visibility#about-internal-repositories)&quot; in the GitHub Help documentation.  The `visibility` parameter overrides the `private` parameter when you use both parameters with the `nebula-preview` preview header.</summary>
    public enum ReposPostRequestBody_visibility
    {
        [EnumMember(Value = "public")]
        #pragma warning disable CS1591
        Public,
        #pragma warning restore CS1591
        [EnumMember(Value = "private")]
        #pragma warning disable CS1591
        Private,
        #pragma warning restore CS1591
        [EnumMember(Value = "internal")]
        #pragma warning disable CS1591
        Internal,
        #pragma warning restore CS1591
    }
}
