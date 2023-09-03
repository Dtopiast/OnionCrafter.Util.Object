namespace OnionCrafter.Util.Object.Pattern.Prototype
{
    /// <summary>
    /// Represents an interface for objects that can create copies of themselves.
    /// </summary>
    /// <typeparam name="T">The type of the cloned object.</typeparam>
    public interface IClonable<T>
    {
        /// <summary>
        /// Creates a copy of the object.
        /// </summary>
        /// <typeparam name="TReturn">The type of the cloned object.</typeparam>
        /// <returns>A new instance of the cloned object.</returns>
        TReturn Clone<TReturn>()
            where TReturn : T;
    }
}