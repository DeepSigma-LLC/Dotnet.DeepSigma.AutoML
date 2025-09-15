
namespace DeepSigma.AutoML.Enums
{
    /// <summary>
    /// Specifies the type of mathematical combination used to combine multiple series into a single series.
    /// </summary>
    public enum SeriesMathematicalCombinationType
    {
        /// <summary>
        /// Additive combination involves summing the values of two or more series together to create a new series. 
        /// This method is often used when the individual series represent different components that contribute to a total value.
        /// </summary>
        Additive,
        /// <summary>
        /// Multiplicative combination involves multiplying the values of two or more series together to create a new series.
        /// </summary>
        Multiplicative,
        /// <summary>
        /// Exponential combination involves raising the values of one series to the power of another series to create a new series.
        /// </summary>
        Exponential
    }
}
