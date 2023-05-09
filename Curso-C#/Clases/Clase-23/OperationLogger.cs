using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class OperationLogger
{
    private readonly ITransientOperation _transientOperation;
    private readonly IScopedOperation _scopedOperation;
    private readonly ISingletonOperation _singletonOperation;

    public OperationLogger(ITransientOperation transientOperation,
    IScopedOperation scopedOperation,
    ISingletonOperation singletonOperation) =>
        (_transientOperation, _scopedOperation, _singletonOperation) =
        (transientOperation, scopedOperation, singletonOperation);

    public void LogOperations(string scope)
    {
        LogOperation(_transientOperation, scope, "From TransientOperation");
        LogOperation(_scopedOperation, scope, "From ScopedOperation");
        LogOperation(_singletonOperation, scope, "From SingletonOperation");
    }

    private static void LogOperation<T>(T operation, string scope, string message)
    where T : IOperation =>
        Console.WriteLine($"{scope}:{typeof(T).Name,-19} " +
            $"[{operation.operationID} - {message}]");

}

