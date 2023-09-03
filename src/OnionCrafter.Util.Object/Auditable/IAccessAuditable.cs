namespace OnionCrafter.Util.Object.Auditable
{
    /// <summary>
    /// Represents an interface for objects that can be audited for access.
    /// </summary>
    public interface IAccessAuditable
    {
        /// <summary>
        /// Gets the date and time when the object was last accessed.
        /// </summary>
        /// <value>
        /// The date and time of the last access, or <c>null</c> if not accessed yet.
        /// </value>
        DateTime? LastAccessedAt { get; }

        /// <summary>
        /// Gets the user or entity that last accessed the object.
        /// </summary>
        /// <value>
        /// The name or identifier of the last accessing user or entity, or <c>null</c> if not accessed yet.
        /// </value>
        string? LastAccessedBy { get; }
    }
}