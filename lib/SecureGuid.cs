using System.Security.Cryptography;

namespace Warrensoft.SecureGuid;

/// <summary>
/// Generates a secure, globally unique identifier (GUID) using 128 bits of entropy from <see ref="System.Security.Cryptography.RandomNumberGenerator" /> with zero allocations.
/// </summary>
public static class SecureGuid
{
    /// <summary>
    /// Generates a secure, globally unique identifier (GUID) using 128 bits of entropy from <see ref="System.Security.Cryptography.RandomNumberGenerator" /> with zero allocations.
    /// </summary>
    public static Guid New()
    {
        Span<byte> entropy = stackalloc byte[16];
        RandomNumberGenerator.Fill(entropy);
        return new Guid(entropy);
    }
}
