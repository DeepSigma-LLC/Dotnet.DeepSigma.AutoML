
namespace DeepSigma.AutoML.Enums.Mathematics;

/// <summary>
/// Specifies the type of convergence for a mathematical sequence or series.
/// </summary>
public enum ConvergentType
{
    /// <summary>
    /// The sequence or series approaches a specific value as the number of terms increases.
    /// </summary>
    Convergent,
    /// <summary>
    /// The sequence or series does not approach a specific value and instead diverges to infinity or negative infinity.
    /// </summary>
    Divergent,
    /// <summary>
    /// The sequence or series oscillates between values without settling on a specific limit.
    /// </summary>
    Oscillatory,
}
