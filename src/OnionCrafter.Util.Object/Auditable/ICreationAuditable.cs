namespace OnionCrafter.Util.Object.Auditable
{
    /// <summary>
    /// Represents an interface for objects that can be audited for creation.
    /// </summary>
    public interface ICreationAuditable
    {
        /// <summary>
        /// Gets the date and time when the object was created.
        /// </summary>
        /// <value>
        /// The date and time of creation.
        /// </value>
        DateTime CreatedAt { get; }

        /// <summary>
        /// Gets the user or entity that created the object.
        /// </summary>
        /// <value>
        /// The name or identifier of the creating user or entity, or <c>null</c> if not specified.
        /// </value>
        string? CreatedBy { get; }
    }
}