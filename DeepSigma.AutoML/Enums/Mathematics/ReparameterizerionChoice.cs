
namespace DeepSigma.AutoML.Enums.Mathematics;

/// <summary>
/// Specifies the choice of reparameterization being referred to.
/// </summary>
public enum ReparameterizerionChoice
{
    /// <summary>
    /// Reparameterization in terms of time.
    /// </summary>
    Time,
    /// <summary>
    /// Reparameterization in terms of phase (aka physical state). A phyical system can often be described in terms of its discrete phases rather than time.
    /// </summary>
    Phase,
    /// <summary>
    /// Other reparameterization choice not listed.
    /// </summary>
    Other
}
