
namespace DeepSigma.AutoML.Enums.Mathematics;

/// <summary>
/// SamplingMethod is an enumeration that defines different methods for sampling data in the context of mathematics, statistics, and machine learning.
/// </summary>
public enum SamplingMethod
{
    /// <summary>
    /// GreedySearch is a sampling method that selects the most promising option at each step, based on a specific criterion or heuristic, without considering the overall consequences of those choices.
    /// </summary>
    GreedySearch,
    /// <summary>
    /// RandomSelection is a sampling method that randomly selects options from a defined search space, without any specific strategy or heuristic guiding the selection process.
    /// </summary>
    RandomSelection,
    /// <summary>
    /// StratifiedSampling is a sampling method that divides the population into distinct subgroups or strata based on specific characteristics, and then samples from each stratum proportionally to its size in the population, ensuring that the sample is representative of the overall population.
    /// </summary>
    StratifiedSampling,
    /// <summary>
    /// SystematicSampling is a sampling method that selects samples from a population at regular intervals, starting from a randomly chosen point, and then selecting every nth item from the list until the desired sample size is reached.
    /// </summary>
    SystematicSampling,
    /// <summary>
    /// StratifiedSystematicSampling is a sampling method that combines the principles of stratified sampling and systematic sampling, where the population is first divided into distinct strata based on specific characteristics, and then samples are selected from each stratum using a systematic approach, ensuring that the sample is representative of the overall population while also maintaining a regular interval for selection within each stratum.
    /// </summary>
    StratifiedSystematicSampling,
    /// <summary>
    /// StratifiedRandomSampling is a sampling method that combines the principles of stratified sampling and random sampling, where the population is first divided into distinct strata based on specific characteristics, and then samples are randomly selected from each stratum, ensuring that the sample is representative of the overall population while also introducing randomness in the selection process within each stratum.
    /// </summary>
    StratifiedRandomSampling,
}
