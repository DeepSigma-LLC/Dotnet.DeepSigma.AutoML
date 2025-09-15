

namespace DeepSigma.AutoML.Enums
{
    /// <summary>
    /// Specifies the type of relationship between data variables, indicating how they are related or associated with each other.
    /// </summary>
    public enum DataRelationType
    {
        /// <summary>
        /// None indicates that there is no specific relationship or association between the variables being considered.
        /// </summary>
        None,
        /// <summary>
        /// Correlation (aka association) refers to a statistical relationship between two or more variables, indicating how they tend to move together.
        /// Note: Correlation does not imply causation; it simply indicates that there is a relationship between the variables, but it does not determine whether one variable causes changes in another.
        /// Correlations can be positive (both variables increase or decrease together) or negative (one variable increases while the other decreases).
        /// Correlations can be spurious, meaning they may arise due to chance or the influence of a third variable, rather than a direct relationship between the variables themselves.
        /// </summary>
        Correlation,
        /// <summary>
        /// Cointegration refers to a statistical property of a collection of time series variables that indicates a long-term equilibrium relationship among them, even if the individual series themselves are non-stationary.
        /// </summary>
        Cointegration,
        /// <summary>
        /// Causation indicates a relationship where one event (the cause) directly influences another event (the effect), leading to a change in the effect as a result of the cause.
        /// </summary>
        Causation
    }
}
