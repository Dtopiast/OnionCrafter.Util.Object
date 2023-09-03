namespace OnionCrafter.Util.Object.Pattern.TempleteMethod
{
    /// <summary>
    /// Represents an interface for objects that provide a method to be executed after an asynchronous operation.
    /// </summary>
    public interface IAfterExecuteAsync
    {
        /// <summary>
        /// Defines a method to be executed after an asynchronous operation.
        /// </summary>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> that can be used to cancel the operation asynchronously.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> representing the asynchronous operation.
        /// </returns>
        Task OnAfterExecuteAsync(CancellationToken cancellationToken = default);
    }
}