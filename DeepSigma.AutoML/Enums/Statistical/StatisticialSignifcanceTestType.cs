namespace DeepSigma.AutoML.Enums.Statistical;

/// <summary>
/// Specifies the type of statistical significance test to be used.
/// </summary>
public enum StatisticialSignifcanceTestType
{
    /// <summary>
    /// Z-test should be used when the population standard deviation is known since it relies on the normal distribution.
    /// </summary>
    ZTest,
    /// <summary>
    /// T-test should be used when the population standard deviation is not known since the standard deviation is only an estimate and there is error associated with your estimate.
    /// </summary>
    TTest
}
