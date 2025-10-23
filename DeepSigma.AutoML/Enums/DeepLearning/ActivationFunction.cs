
namespace DeepSigma.AutoML.Enums.DeepLearning;

/// <summary>
/// Specifies the type of activation function used in neural networks.
/// </summary>
public enum ActivationFunction
{
    /// <summary>
    /// ReLU (Rectified Linear Unit) is an activation function defined as f(x) = max(0, x).
    /// </summary>
    ReLU,
    /// <summary>
    /// Sigmoid activation function is defined as f(x) = 1 / (1 + exp(-x)).
    /// </summary>
    Sigmoid,
    /// <summary>
    /// Tanh (Hyperbolic Tangent) activation function is defined as f(x) = (exp(x) - exp(-x)) / (exp(x) + exp(-x)).
    /// </summary>
    Tanh,
    /// <summary>
    /// LeakyReLU is a variant of the ReLU activation function that allows a small, non-zero gradient when the input is negative.
    /// </summary>
    LeakyReLU,
    /// <summary>
    /// ELU (Exponential Linear Unit) activation function is defined as f(x) = x if x > 0 else alpha * (exp(x) - 1).
    /// It helps to alleviate the vanishing gradient problem and allows for faster learning.
    /// It should be used in situations where negative inputs are expected to improve model performance.
    /// </summary>
    ELU,
    /// <summary>
    /// Swish activation function is defined as f(x) = x * sigmoid(beta * x).
    /// It is a smooth, non-monotonic function that has been shown to outperform ReLU in some deep learning models.
    /// It should be used in scenarios where improved performance over ReLU is desired, particularly in deep neural networks.
    /// </summary>
    Swish,
    /// <summary>
    /// GELU (Gaussian Error Linear Unit) activation function is defined as f(x) = 0.5 * x * (1 + tanh(sqrt(2/pi) * (x + 0.044715 * x^3))).
    /// It combines properties of ReLU and sigmoid functions, providing smooth activation and better gradient flow.
    /// It should be used in scenarios where improved performance and gradient flow are desired, especially in transformer models.
    /// </summary>
    GELU,
    /// <summary>
    /// Softmax activation function is used in multi-class classification problems to convert logits into probabilities.
    /// It is defined as f(x_i) = exp(x_i) / sum(exp(x_j)) for each class i.
    /// It should be used in the output layer of neural networks for multi-class classification tasks.
    /// </summary>
    Softmax
}
