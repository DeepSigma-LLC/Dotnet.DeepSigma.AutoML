
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
    /// Indicates an adaptive learning rate that changes based on the training progress or other criteria.
    /// </summary>
    Adaptive,
}
