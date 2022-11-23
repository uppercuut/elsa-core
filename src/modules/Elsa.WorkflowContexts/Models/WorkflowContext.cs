using Elsa.Expressions.Models;
using Elsa.WorkflowContexts.Services;
using Elsa.Workflows.Core;

namespace Elsa.WorkflowContexts.Models;

public class WorkflowContext
{
    public WorkflowContext(Type providerType)
    {
        ProviderType = providerType;
    }
    
    public Type ProviderType { get; }
}

public class WorkflowContext<T, TProvider> : WorkflowContext where TProvider:IWorkflowContextProvider
{
    public WorkflowContext() : base(typeof(TProvider))
    {
    }
    
    public T? Get(ExpressionExecutionContext context)
    {
        var workflowExecutionContext = context.GetWorkflowExecutionContext();
        var transientProperties = workflowExecutionContext.TransientProperties;
        var workflowContexts = (IDictionary<WorkflowContext, object?>)transientProperties["WorkflowContexts"]!;
        return workflowContexts.TryGetValue(this, out var workflowContext) ? (T?)workflowContext : default;
    }
}