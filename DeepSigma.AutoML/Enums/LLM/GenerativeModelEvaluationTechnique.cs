namespace DeepSigma.AutoML.Enums.LLM;

/// <summary>
/// Generative model evaluation techniques refer to the various methods and approaches used to assess the performance and quality of generative models, which are a type of machine learning model that can generate new data based on patterns learned from existing data.
/// </summary>
public enum GenerativeModelEvaluationTechnique
{
    /// <summary>
    /// Word-level metrics involve evaluating the performance of a generative model based on the individual words it generates, rather than the overall output or meaning of the generated text.
    /// This approach can be useful for assessing the model's ability to generate grammatically correct and coherent sentences, as well as its ability to use appropriate vocabulary and syntax.
    /// Of note is "perplexity", which measures how well a language model predicts a text. 
    /// Given input text, the model predicts how likely the next token is. 
    /// With perplexity, we assume a model performs better if it gives the next token a high probability.
    /// In other words, the models should not be “perplexed” when presented with a well-written document
    /// </summary>
    WordLevelMetrics,
    /// <summary>
    /// Benchmarking involves evaluating the performance of a generative model by comparing it to a set of predefined benchmarks or reference models.
    /// This approach can be useful for assessing the model's performance on specific tasks or datasets, and for comparing it to other models in the same domain.
    /// However, public benchmarks may not always be representative of real-world applications, and they may not capture all aspects of a model's performance, such as its ability to generate creative or novel outputs.
    /// Additionally, model providers may have incentives to optimize their models specifically for benchmark performance, which can lead to overfitting and may not reflect the model's performance in real-world applications.
    /// </summary>
    Benchmarking,
    /// <summary>
    /// Automated evaluation involves using automated tools and techniques to evaluate the performance of a generative model, such as natural language processing (NLP) metrics, machine learning algorithms, or other computational methods.
    /// A common example of automated evaluation is the use of BLEU (Bilingual Evaluation Understudy) scores, which measure the similarity between the generated text and reference texts based on n-gram overlap.
    /// A more modern approach is using an LLM-based evaluation, where a large language model is used to assess the quality of the generated text based on various criteria, such as coherence, relevance, and creativity.
    /// An LLM-based evaluation can provide a more nuanced and comprehensive assessment of the generated text, as it can take into account factors such as context, semantics, and style, which may not be captured by traditional metrics like BLEU.
    /// Additionally, as large language models continue to improve in their ability to understand and generate human-like text, LLM-based evaluation has the potential to become a more reliable and effective method for assessing the performance of generative models in a wide range of applications.
    /// </summary>
    AutomatedEvaluation,
    /// <summary>
    /// Human evaluation involves using human judges to assess the quality of the generated text based on various criteria, such as coherence, relevance, creativity, and overall quality.
    /// This approach can provide a more subjective and nuanced assessment of the generated text, as human judges can take into account factors such as context, semantics, and style that may not be captured by automated metrics.
    /// However, human evaluation can be time-consuming and expensive, and it may also be subject to bias and variability among judges.
    /// </summary>
    HumanEvaluation,
}
