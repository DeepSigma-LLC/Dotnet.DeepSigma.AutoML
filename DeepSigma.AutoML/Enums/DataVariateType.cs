
namespace DeepSigma.AutoML.Enums
{
    /// <summary>
    /// Specifies the type of data variate, indicating whether the data involves a single variable (univariate) or multiple variables (multivariate).
    /// </summary>
    public enum DataVariateType
    {
        /// <summary>
        /// Univariate data involves a single variable or feature. It focuses on analyzing and understanding the behavior, patterns, and trends of that one variable over time or across different observations. Examples of univariate data include daily temperatures, stock prices, or sales figures for a single product.
        /// </summary>
        Univariate,
        /// <summary>
        /// Multivariate data involves multiple variables or features. It focuses on analyzing the relationships, interactions, and dependencies among several variables simultaneously. Examples of multivariate data include datasets with multiple attributes such as height, weight, age, and income of individuals, or datasets containing various economic indicators like GDP, unemployment rate, and inflation rate.
        /// </summary>
        Multivariate
    }
}
