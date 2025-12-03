using System;
using System.Collections.Generic;
using System.Text;

namespace DeepSigma.AutoML.Enums.Modeling;

/// <summary>
/// Specifies the type of state a system can be in.
/// </summary>
public enum SystemStateType
{
    /// <summary>
    /// The system is in a stable state, maintaining consistent behavior over time.
    /// </summary>
    Stable,
    /// <summary>
    /// The system exhibits periodic behavior, repeating patterns at regular intervals.
    /// </summary>
    Periodic,
    /// <summary>
    /// The system is in a transient state, temporarily deviating from its normal behavior.
    /// </summary>
    Transient,
    /// <summary>
    /// The system exhibits chaotic behavior, characterized by sensitivity to initial conditions.
    Chaotic,
    /// <summary>
    /// The system's state changes randomly without a predictable pattern.
    /// </summary>
    Random,
    /// <summary>
    /// The system exhibits fractal behavior, showing self-similarity across different scales.
    /// </summary>
    Fractal
}
