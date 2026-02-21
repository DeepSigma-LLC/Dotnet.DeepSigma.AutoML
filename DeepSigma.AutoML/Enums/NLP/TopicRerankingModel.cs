
namespace DeepSigma.AutoML.Enums.NLP;

/// <summary>
/// TopicRerankingModel is an enumeration that defines different models for reranking topics in natural language processing (NLP) tasks.
/// </summary>
public enum TopicRerankingModel
{
    /// <summary>
    /// KeyBERTInspired is a topic reranking model that is inspired by the KeyBERT algorithm, which is a keyword extraction technique that uses BERT embeddings to identify and rank the most relevant keywords in a document based on their semantic similarity to the overall content of the document.
    /// It ultimately improves the performance of topic modeling and semantic analysis tasks by providing a more meaningful representation of the underlying topics in the text data, especially in cases where traditional methods may struggle to capture the full complexity and richness of the text data being analyzed.
    /// </summary>
    KeyBERTInspired,
    /// <summary>
    /// MMR (Maximal Marginal Relevance) is a topic reranking model which is a technique for reordering the terms or concepts in a document based on their relevance to the underlying topics while also considering their diversity and novelty.
    /// This can help to improve the performance of topic modeling and semantic analysis tasks by providing a more meaningful representation of the text data, especially in cases where the original order of the terms may not accurately reflect their relevance to the topics being analyzed, and where it is important to capture a diverse range of relevant terms and concepts to fully understand the underlying themes and topics in the documents being analyzed.
    /// </summary>
    MaximalMarginalRelevance,

}
