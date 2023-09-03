namespace OnionCrafter.Util.Object.Pattern.TempleteMethod
{
    /// <summary>
    /// Represents an interface for objects that handle execution both before and after an asynchronous operation.
    /// </summary>
    public interface IExecutionHandler :
        IAfterExecuteAsync,
        IBeforeExecuteAsync
    {
    }
}