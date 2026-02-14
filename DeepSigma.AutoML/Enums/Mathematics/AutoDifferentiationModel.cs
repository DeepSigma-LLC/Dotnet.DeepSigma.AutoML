
namespace DeepSigma.AutoML.Enums.Mathematics;

/// <summary>
/// AutoDifferentiationModel is an enumeration that defines the different methods of automatic differentiation used in mathematical computations and machine learning.
/// </summary>
public enum AutoDifferentiationModel
{
    /// <summary>
    /// ForwardMode is a method of automatic differentiation that computes derivatives by traversing the computational graph in a forward direction, starting from the input variables and propagating through the operations to compute the output and its derivatives.
    /// Note: with this mode, you do need to store intermediate values during the forward pass, which can lead to increased memory usage, especially for deep computational graphs. 
    /// This is because the forward mode only requires storing the intermediate results of each operation to compute the derivatives correctly.
    /// </summary>
    ForwardMode,
    /// <summary>
    /// ReverseMode, also known as backpropagation, is a method of automatic differentiation that computes gradients efficiently by traversing the computational graph in reverse order.
    /// Note: with this mode, you need to store all intermediate values during the forward pass and the computational graph structure, which can lead to increased memory usage to compute the gradients correctly during the backward pass, especially for deep computational graphs.
    /// </summary>
    ReverseMode
}
