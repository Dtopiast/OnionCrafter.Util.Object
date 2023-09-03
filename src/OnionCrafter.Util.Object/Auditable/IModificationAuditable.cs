namespace OnionCrafter.Util.Object.Auditable
{
    /// <summary>
    /// Represents an interface for objects that can be audited for modifications.
    /// </summary>
    public interface IModificationAuditable
    {
        /// <summary>
        /// Gets the date and time when the object was last modified.
        /// </summary>
        /// <value>
        /// The date and time of the last modification, or <c>null</c> if not modified yet.
        /// </value>
        DateTime? ModifiedAt { get; }

        /// <summary>
        /// Gets the user or entity that last modified the object.
        /// </summary>
        /// <value>
        /// The name or identifier of the last modifying user or entity.
        /// </value>
        string ModifiedBy { get; }
    }
}