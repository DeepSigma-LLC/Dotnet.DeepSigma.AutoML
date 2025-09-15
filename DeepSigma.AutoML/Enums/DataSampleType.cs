
namespace DeepSigma.AutoML.Enums
{
    /// <summary>
    /// Specifies the type of data sampling technique used to adjust the distribution of a dataset, either by increasing (upsampling) or decreasing (downsampling) the number of samples in certain classes or categories.
    /// </summary>
    public enum DataSampleType
    {
        /// <summary>
        /// Upsampling involves increasing the number of samples in the minority class to balance the dataset, often by duplicating existing samples or generating new synthetic samples.
        /// </summary>
        Upsampling,
        /// <summary>
        /// Downsampling involves decreasing the number of samples in the majority class to balance the dataset, often by randomly removing samples from the majority class.
        /// </summary>
        Downsampling,
    }
}
