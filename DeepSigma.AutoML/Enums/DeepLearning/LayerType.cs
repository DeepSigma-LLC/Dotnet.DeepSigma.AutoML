
namespace DeepSigma.AutoML.Enums.DeepLearning;

/// <summary>
/// Specifies the type of layer in a neural network.
/// </summary>
public enum LayerType
{
    /// <summary>
    /// Input layer is the first layer of a neural network that receives the input data and passes it to the subsequent layers for processing.
    /// </summary>
    Input,
    /// <summary>
    /// Hidden layer is an intermediate layer in a neural network that processes the input data and extracts relevant features before passing them to the output layer.
    /// </summary>
    Hidden,
    /// <summary>
    /// Output layer is the final layer of a neural network that produces the output predictions or classifications based on the learned features from the previous layers.
    /// </summary>
    Output
}
