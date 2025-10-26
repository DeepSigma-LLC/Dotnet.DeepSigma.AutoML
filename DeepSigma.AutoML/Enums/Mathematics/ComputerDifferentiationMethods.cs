
namespace DeepSigma.AutoML.Enums.Mathematics;

/// <summary>
/// Specifies the methods used for computer-based differentiation.
/// </summary>
public enum ComputerDifferentiationMethods
{
    /// <summary>
    /// Numerical differentiation approximates the derivative of a function using discrete data points, often through finite difference methods.
    /// </summary>
    FiniteDifference,
    /// <summary>
    /// Automatic differentiation computes derivatives accurately and efficiently by systematically applying the chain rule of calculus to computer programs.
    /// </summary>
    AutomaticDifferentiation,
    /// <summary>
    /// Symbolic differentiation involves manipulating mathematical expressions symbolically to obtain the derivative, often using computer algebra systems.
    /// It provides exact derivatives in symbolic form, therefore this results in an analytical solution.
    /// </summary>
    SymbolicDifferentiation
}
