
namespace DeepSigma.AutoML.Enums
{
    /// <summary>
    /// Specifies the variability type of data, indicating whether the data is invariant or variant in nature.
    /// </summary>
    public enum VariablilityDataType
    {
        /// <summary>
        /// Indicates that the data is invariant, meaning it does not change or vary over time or across different conditions. Invariant data remains constant and stable, making it easier to analyze and interpret.
        /// </summary>
        Invariant,
        /// <summary>
        /// Indicates that the data is variant, meaning it changes or varies over time or across different conditions. Variant data exhibits fluctuations and variability, which can provide valuable insights into patterns, trends, and relationships within the data.
        /// </summary>
        Variant
    }
}
