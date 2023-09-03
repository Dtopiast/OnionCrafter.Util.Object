namespace OnionCrafter.Util.Object.Auditable
{
    /// <summary>
    /// Represents an interface for objects that can be audited for access, modification, and creation.
    /// </summary>
    public interface IAuditable :
        IAccessAuditable,
        IModificationAuditable,
        ICreationAuditable
    {
    }
}