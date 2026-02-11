
namespace DeepSigma.AutoML.Enums.MachineLearning;

/// <summary>
/// Defines various optimization algorithms used in machine learning.
/// </summary>
public enum Optimizer
{
    /// <summary>
    /// Gradient Descent optimizer. A simple optimization algorithm that iteratively updates the model parameters in the direction of the negative gradient of the loss function with respect to the parameters.
    /// Gradient Descent can be computationally expensive for large datasets, as it requires computing the gradient for the entire dataset at each iteration, but it can be effective for optimizing simple models and small datasets.
    /// </summary>
    GradientDescent,
    /// <summary>
    /// Batch Gradient Descent optimizer. A variant of Gradient Descent that computes the gradient using a batch of data points, rather than the entire dataset, at each iteration. 
    /// This can help to reduce the computational cost and improve convergence for large datasets, but it may also introduce some noise and instability in the optimization process.
    /// </summary>
    BatchGradientDescent,
    /// <summary>
    /// Stochastic Gradient Descent optimizer. A variant of Gradient Descent that computes the gradient using a single data point at each iteration, rather than a batch of data points.
    /// Stochastic comes from the fact that the optimization process is more noisy and less stable than Batch Gradient Descent, as it relies on a single data point to update the model parameters at each iteration, which can lead to faster convergence and better generalization for large datasets, but it may also require more careful tuning of the learning rate and other hyperparameters to avoid divergence or oscillation in the optimization process.
    /// </summary>
    StochasticGradientDescent,
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
