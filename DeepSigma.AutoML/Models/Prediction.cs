using System;
using System.Collections.Generic;
using System.Text;
using DeepSigma.AutoML.Enums.Prediction;

namespace DeepSigma.AutoML.Models;

/// <summary>
/// Represents the prediction characteristics of a model.
/// </summary>
public class Prediction
{
    public decimal Value { get; set; }
    public decimal BrierScore { get; set; }
    public ConfidenceInPredictionType ConfidenceInPrediction { get; set; }
    public ApproachToRisk ApproachToRisk { get; set; }
}
