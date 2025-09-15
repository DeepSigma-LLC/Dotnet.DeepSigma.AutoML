
namespace DeepSigma.AutoML.Enums
{
    /// <summary>
    /// Specifies the outcome of a statistical significance test, indicating whether the null hypothesis can be rejected or not.
    /// </summary>
    public enum StatisticalSignificanceOutcome
    {
        /// <summary>
        /// Reject the null hypothesis, indicating that there is enough evidence to support the alternative hypothesis.
        /// </summary>
        RejectNullHypothesis,
        /// <summary>
        /// Cnnot reject the null hypothesis. This does not mean the null hypothesis is true, just that there is not enough evidence to reject it.
        /// </summary>
        CannotRejectNullHypothesis,
    }
}
