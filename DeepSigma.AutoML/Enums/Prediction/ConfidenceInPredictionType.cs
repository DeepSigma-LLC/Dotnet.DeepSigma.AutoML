
namespace DeepSigma.AutoML.Enums.Prediction;

/// <summary>
/// Specifies the confidence calibration of a predictive model's probability estimates.
/// </summary>
public enum ConfidenceInPredictionType
{
    /// <summary>
    /// OverConfident indicates that the model's predicted probabilities are generally higher than the actual observed frequencies, meaning that the model tends to be too certain about its predictions.
    /// </summary>
    OverConfident,
    /// <summary>
    /// WellCalibrated indicates that the model's predicted probabilities closely match the actual observed frequencies, meaning that the model's confidence in its predictions is generally accurate.
    /// </summary>
    WellCalibrated,
    /// <summary>
    /// UnderConfident indicates that the model's predicted probabilities are generally lower than the actual observed frequencies, meaning that the model tends to be too uncertain about its predictions.
    /// </summary>
    UnderConfident
}
