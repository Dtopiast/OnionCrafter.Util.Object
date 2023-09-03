namespace OnionCrafter.Util.Object.Pattern.Prototype
{
    /// <summary>
    /// Represents an interface for objects that can be copied to another object of type T.
    /// </summary>
    /// <typeparam name="T">
    /// The type to which the object can be copied.
    /// </typeparam>
    public interface ICopyable<in T>
    {
        /// <summary>
        /// Copies the content of the current object to another object of type T.
        /// </summary>
        /// <param name="toCopy">
        /// The target object to which the content should be copied.
        /// </param>
        /// <remarks>
        /// Implementing classes should define how the copying is performed.
        /// </remarks>
        void CopyTo(T toCopy);
    }
}