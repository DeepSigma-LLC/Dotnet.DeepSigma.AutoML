
namespace DeepSigma.AutoML.Enums.MachineLearning;

/// <summary>
/// Defines various optimization algorithms used in machine learning.
/// </summary>
public enum Optimizer
{
    /// <summary>
    /// Stochastic Gradient Descent optimizer. A simple and widely used optimization algorithm.
    /// </summary>
    SGD,
    /// <summary>
    /// Adam optimizer. Adaptive Moment Estimation - combines the advantages of RMSprop and Momentum.
    /// </summary>
    Adam,
    /// <summary>
    /// RMSprop optimizer. Root Mean Square Propagation - adapts the learning rate for each parameter.
    /// </summary>
    RMSprop,
    /// <summary>
    /// Adagrad optimizer. Adaptive Gradient Algorithm - adjusts the learning rate based on past gradients.
    /// </summary>
    Adagrad,
    /// <summary>
    /// Adadelta optimizer. An extension of Adagrad that seeks to reduce its aggressive, monotonically decreasing learning rate.
    /// </summary>
    Adadelta
}
