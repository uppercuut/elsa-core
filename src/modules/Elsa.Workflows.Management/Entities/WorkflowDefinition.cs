using Elsa.Common.Entities;
using Elsa.Workflows.Core.Models;

namespace Elsa.Workflows.Management.Entities;

/// <summary>
/// Represents a versioned workflow definition.
/// </summary>
public class WorkflowDefinition : VersionedEntity
{
    /// <summary>
    /// The logical ID of the workflow. This ID is the same across versions. 
    /// </summary>
    public string DefinitionId { get; set; } = default!;
    
    /// <summary>
    /// The name of the workflow.
    /// </summary>
    public string? Name { get; set; }
    
    /// <summary>
    /// A short description of that the workflow is about.  
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// A set of options for the workflow.
    /// </summary>
    public WorkflowOptions? Options { get; set; }
    
    /// <summary>
    /// A set of workflow variables that are accessible throughout the workflow.
    /// </summary>
    public ICollection<Variable> Variables { get; set; } = new List<Variable>();
    
    /// <summary>
    /// Stores custom information about the workflow. Can be used to store application-specific properties to associate with the workflow.
    /// </summary>
    public IDictionary<string, object> CustomProperties { get; set; } = new Dictionary<string, object>();

    /// <summary>
    /// The name of the workflow materializer to interpret the <see cref="StringData"/> or <see cref="BinaryData"/>.
    /// </summary>
    public string MaterializerName { get; set; } = default!;

    /// <summary>
    /// Provider-specific data.
    /// </summary>
    public string? MaterializerContext { get; set; }
    
    /// <summary>
    /// A textual representation of the workflow. The data is to be interpreted by the configured materializer.
    /// </summary>
    public string? StringData { get; set; }
    
    /// <summary>
    /// A binary representation of the workflow. The data is to be interpreted by the configured materializer.
    /// </summary>
    public byte[]? BinaryData { get; set; }
    
    /// <summary>
    /// Creates and returns a shallow copy of the workflow definition.
    /// </summary>
    /// <returns></returns>
    public WorkflowDefinition ShallowClone() => (WorkflowDefinition)MemberwiseClone();
}