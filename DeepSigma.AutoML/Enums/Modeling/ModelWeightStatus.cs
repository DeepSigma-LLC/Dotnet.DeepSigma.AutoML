
namespace DeepSigma.AutoML.Enums.Modeling;

/// <summary>
/// ModelWeightStatus is an enumeration that defines the status of a machine learning model's weights, indicating whether they are frozen (fixed) or trainable (modifiable) during the training or fine-tuning process.
/// </summary>
public enum ModelWeightStatus
{
    /// <summary>
    /// Frozen indicates that the model's weights are fixed and cannot be updated during training or fine-tuning.
    /// </summary>
    Frozen,
    /// <summary>
    /// Trainable indicates that the model's weights are modifiable and can be updated during training or fine-tuning, allowing the model to learn and adapt to new data or tasks.
    /// </summary>
    Trainable
}
