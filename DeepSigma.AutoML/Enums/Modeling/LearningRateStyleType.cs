
namespace DeepSigma.AutoML.Enums.Modeling;

/// <summary>
/// Defines the styles of learning rate adjustment used in machine learning models.
/// </summary>
public enum LearningRateStyleType
{
    /// <summary>
    /// Indicates a static learning rate that remains constant throughout the training process.
    /// </summary>
    Static,
    /// <summary>
    /// Indicates a dynamic learning rate that changes over time, often decreasing as training progresses. Dynamic learning rates can be implemented using various strategies, such as step decay, exponential decay, or cyclical learning rates.
    /// </summary>
    /// <remarks>
    /// Note: The difference between Dynamic and Adaptive learning rates is that Dynamic learning rates follow a predetermined schedule or pattern, while Adaptive learning rates adjust based on the model's performance or other criteria during training.
    /// </remarks>
    Dynamic,
    /// <summary>
    /// Indicates an adaptive learning rate that changes based on the training progress or other criteria.
    /// </summary>
    Adaptive,
}
