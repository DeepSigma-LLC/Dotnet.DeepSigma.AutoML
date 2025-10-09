
namespace DeepSigma.AutoML.Enums;

/// <summary>
/// Specifies the method used to test for stationarity in a time series.
/// </summary>
public enum StationaryTestType
{
    /// <summary>
    /// For example, plotting the time series data and visually inspecting it for trends, seasonality, and other patterns that may indicate non-stationarity.
    /// </summary>
    Visually,
    /// <summary>
    /// For example, comparing the behavior of a time series at different time scales, such as examining short-term fluctuations versus long-term trends to determine if the series exhibits stationarity across these scales.
    /// </summary>
    GlobalVsLocalTests,
    /// <summary>
    /// For example, the augmented Dickey-Fuller Test (ADF), the Kwiatkowski-Phillips-Schmidt-Shin (KPSS) test, and the Phillips-Perron (PP) test.
    /// </summary>
    StatisticalTests,
}
