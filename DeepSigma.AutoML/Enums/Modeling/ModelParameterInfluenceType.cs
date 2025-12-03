using System;
using System.Collections.Generic;
using System.Text;

namespace DeepSigma.AutoML.Enums.Modeling;

/// <summary>
/// Specifies whether a model parameter is influenced by internal or external factors.
/// </summary>
public enum ModelParameterInfluenceType
{
    /// <summary>
    /// The parameter is influenced by internal factors within the model or system.
    /// </summary>
    Endogenous,
    /// <summary>
    /// The parameter is influenced by external factors outside the model or system.
    /// </summary>
    Exogenous,
}
