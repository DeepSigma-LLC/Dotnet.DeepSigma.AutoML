

namespace DeepSigma.AutoML.Enums.DeepLearning;

/// <summary>
/// PropagationDirection is an enumeration that defines the direction of propagation in a neural network during the training process.
/// </summary>
public enum PropagationDirection
{
    /// <summary>
    /// ForwardPropagation is the process of passing input data through the layers of a neural network to generate an output.
    /// </summary>
    ForwardPropagation,
    /// <summary>
    /// BackwardPropagation is the process of calculating the gradients of the loss function with respect to the weights of the neural network and updating the weights accordingly to minimize the loss.
    /// Learning (optimization) is typically performed during backward propagation, where the model adjusts its parameters to improve its performance on the training data based on the loss calculated during forward propagation.
    /// </summary>
    BackwardPropagation
}
