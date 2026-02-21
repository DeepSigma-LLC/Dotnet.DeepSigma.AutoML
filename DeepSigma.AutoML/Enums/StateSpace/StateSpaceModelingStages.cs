
namespace DeepSigma.AutoML.Enums.StateSpace;

/// <summary>
/// Specifies the different stages in state space modeling.
/// </summary>
public enum StateSpaceModelingStages
{
    /// <summary>
    /// Filtering involves estimating the current state of a system based on past and present observations, typically using algorithms like the Kalman filter.
    /// This is a way of deciding how to weigh the most recent information against past information in updating our estimate of state.
    /// </summary>
    Filtering,
    /// <summary>
    /// Smoothing involves estimating past states of a system using both past and future observations to improve accuracy of the estimates.
    /// </summary>
    Smoothing,
    /// <summary>
    /// Prediction involves forecasting future states of a system based on current and past observations. 
    /// Normally done without any information about the future observations to prevent data leakage.
    /// </summary>
    Prediction
}
