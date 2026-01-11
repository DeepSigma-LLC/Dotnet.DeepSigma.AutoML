
namespace DeepSigma.AutoML.Enums.Statistical;

/// <summary>
/// Specifies the category of statistical sampling method.
/// </summary>
public enum StatisticalSamplingCategory
{
    /// <summary>
    /// Probability sampling method, where each member of the population has a known, non-zero chance of being selected.
    /// </summary>
    ProbabilitySampling,
    /// <summary>
    /// Non-probability sampling method, where some members of the population have no chance of being selected.
    /// </summary>
    NonProbabilitySampling,
}
