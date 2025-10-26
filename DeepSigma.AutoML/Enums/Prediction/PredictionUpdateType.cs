
namespace DeepSigma.AutoML.Enums.Prediction;

/// <summary>
/// Specifies the type of reaction in prediction updates.
/// </summary>
public enum PredictionUpdateType
{
    /// <summary>
    /// Overreaction indicates that the prediction update is excessively responsive to new information, leading to larger-than-necessary adjustments in the predicted values.
    /// </summary>
    Overreaction,
    /// <summary>
    /// AppropriateReaction indicates that the prediction update is suitably responsive to new information, resulting in adjustments that accurately reflect the significance of the incoming data.
    /// </summary>
    AppropriateReaction,
    /// <summary>
    /// Underreaction indicates that the prediction update is insufficiently responsive to new information, leading to smaller-than-necessary adjustments in the predicted values.
    /// </summary>
    Underreaction
}
