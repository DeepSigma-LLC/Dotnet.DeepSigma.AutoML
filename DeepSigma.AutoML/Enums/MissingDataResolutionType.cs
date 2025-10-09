namespace DeepSigma.AutoML.Enums;

/// <summary>
/// Specifies the method used to handle missing data in a dataset.
/// </summary>
public enum MissingDataResolutionType
{
    /// <summary>
    /// Imputation involves filling in missing data points using statistical methods or machine learning techniques to estimate the missing values based on the available data.
    /// </summary>
    Imputation,
    /// <summary>
    /// Deletion involves removing any records or entries that contain missing data points from the dataset, which can lead to loss of information but ensures that the remaining data is complete and consistent.
    /// </summary>
    Deletion,
    /// <summary>
    /// Interpolation is a method used to estimate and fill in missing data points in a time series or dataset by using existing data points to create a continuous function that approximates the missing values.
    /// </summary>
    Interpolation,
}
