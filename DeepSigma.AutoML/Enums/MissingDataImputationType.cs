
namespace DeepSigma.AutoML.Enums
{
    /// <summary>
    /// Specifies the method used for imputing missing data in a dataset.
    /// </summary>
    public enum MissingDataImputationType
    {
        /// <summary>
        /// Forward fill is a method used to handle missing data in a time series or sequential dataset by propagating the last valid observation forward to fill in the gaps left by missing values.
        /// </summary>
        ForwardFill,
        /// <summary>
        /// Backward fill is a method used to handle missing data in a time series or sequential dataset by propagating the next valid observation backward to fill in the gaps left by missing values.
        /// Note: This should not be used in real-time forecasting as it uses future data to fill past missing values and can introduce look-ahead bias.
        /// </summary>
        BackwardFill,
        /// <summary>
        /// Mean imputation is a technique used to handle missing data in a dataset by replacing missing values with the mean (average) of the available values for that particular variable.
        /// </summary>
        Mean,
        /// <summary>
        /// Moving average imputation is a technique used to handle missing data in time series datasets by replacing missing values with the average of neighboring data points within a specified window.
        /// </summary>
        MovingAverage,
        /// <summary>
        /// Interpolation is a method used to estimate and fill in missing data points in a time series or dataset by using existing data points to create a continuous function that approximates the missing values.
        /// Should be used in time series forecasing when data have a trend.
        /// </summary>
        Interpolation,
    }
}
