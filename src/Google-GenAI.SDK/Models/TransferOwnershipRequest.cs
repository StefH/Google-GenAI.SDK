namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Request to transfer the ownership of the tuned model.
/// </summary>
public class TransferOwnershipRequest
{
    /// <summary>
    /// Required. The email address of the user to whom the tuned model is being transferred to.
    /// </summary>
    public required string EmailAddress { get; init; }
}