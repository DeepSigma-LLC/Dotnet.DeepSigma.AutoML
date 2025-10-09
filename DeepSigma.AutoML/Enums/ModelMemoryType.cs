
namespace DeepSigma.AutoML.Enums;

/// <summary>
/// Specifies the memory type of a model, indicating whether it relies on learned parameters or external data for making predictions.
/// </summary>
public enum ModelMemoryType
{
    /// <summary>
    /// Parametric models are characterized by a fixed number of parameters that are learned from the training data. These models make assumptions about the underlying data distribution and use these parameters to make predictions.
    /// </summary>
    Parametric,
    /// <summary>
    /// Non-parametric models do not assume a fixed form for the underlying data distribution and can adapt to the complexity of the data. They often rely on external data or memory to make predictions, allowing them to capture more intricate patterns and relationships.
    /// </summary>
    NonParametric
}
