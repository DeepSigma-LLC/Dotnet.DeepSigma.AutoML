namespace DeepSigma.AutoML.Enums.Statistical;

/// <summary>
/// Specifies whether a numerical characteristic is a parameter or a statistic.
/// </summary>
public enum NumericalCharateristicType
{
    /// <summary>
    /// Indicates that the numerical characteristic is a parameter, which is a value that describes a population.
    /// </summary>
    Parameter,
    /// <summary>
    /// Indicates that the numerical characteristic is a statistic, which is a value that describes a sample drawn from a population.
    /// </summary>
    Statistic
}
