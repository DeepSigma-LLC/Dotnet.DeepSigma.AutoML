

namespace DeepSigma.AutoML.Enums.TimeSeries;

/// <summary>
/// Specifies the distance measures that can be used to compare and analyze time series data techniques that capture the temporal dynamics and patterns in the data.
/// </summary>
public enum TemporalAwareDistanceMeasures
{
    /// <summary>
    /// Dynamic Time Warping (DTW) is a distance measure that compares two time series by finding the optimal alignment between them, allowing for non-linear warping of the time axis to account for differences in speed and timing.
    /// Computationally more expensive than other distance measures, but can be more effective for comparing time series that have different lengths or are misaligned in time, as it focuses on the overall shape and pattern of the data rather than specific time points.
    /// Often computed using dynamic programming algorithms, which can be optimized for efficiency, making it a popular choice for time series analysis and classification tasks in various domains, such as speech recognition, gesture recognition, and financial analysis.
    /// </summary>
    DynamicTimeWarping,
    /// <summary>
    /// Pearson Correlation is a distance measure that quantifies the linear relationship between two time series, measuring how closely they follow the same pattern over time, regardless of their scale or amplitude.
    /// Good for comparing time series that have similar shapes but different magnitudes, as it focuses on the overall pattern rather than the specific values. 
    /// Computationally efficient and widely used in various applications, such as finance, signal processing, and machine learning, to analyze and compare time series data.
    /// </summary>
    PearsonCorrelation,
    /// <summary>
    /// Frechet Distance is a distance measure that quantifies the similarity between two curves or trajectories, taking into account both the spatial and temporal aspects of the data. It measures the minimum distance that a point on one curve must travel to reach a point on the other curve, while also considering the order and timing of the points along the curves.
    /// You can think of it as the minimum leash length required to walk a dog along one curve while the owner walks along the other curve, without backtracking or skipping points.
    /// </summary>
    FrechetDistance,
    /// <summary>
    /// Longest Common Subsequence (LCSS) is a distance measure that quantifies the similarity between two time series by finding the longest subsequence of points that are common to both series, allowing for some degree of temporal misalignment and noise.
    /// LCSS is particularly useful for comparing time series that may have different lengths or contain noise, as it focuses on the overall pattern and structure of the data rather than specific time points or values.
    /// </summary>
    LongestCommonSubsequence,
}
