

namespace DeepSigma.AutoML.Enums.NLP;

/// <summary>
/// TopicRepresentationSteps is an enumeration that defines different steps or techniques for representing topics in natural language processing (NLP) tasks, which can be crucial for improving the performance of topic modeling and semantic analysis tasks by providing a more meaningful representation of the underlying topics in the text data, ultimately enhancing the overall understanding of the documents being analyzed and enabling more accurate identification of relevant terms and concepts associated with specific topics, while also reducing the influence of common words that may not carry significant meaning in the analysis, especially in cases where traditional methods may struggle to capture the full complexity and richness of the text data being analyzed.
/// </summary>
public enum TopicRepresentationSteps
{
    /// <summary>
    /// BadOfWords is a topic representation step that involves representing documents as a bag of words, where each document is represented as a vector of word frequencies or counts, without considering the order or context of the words, which can be useful for certain applications such as text classification or clustering, but may not capture the full meaning and nuances of the text data, especially in cases where word order and context are important for understanding the underlying themes and topics in the documents.
    /// This step can be used for extracting keywords and key phrases from the documents, which can help identify important terms and concepts that are relevant to the topics being analyzed, but it may not capture the relationships between words or the overall structure of the text, which can limit its effectiveness for certain applications such as topic modeling or semantic analysis.
    /// </summary>
    BadOfWords,
    /// <summary>
    /// TFIDF (Term Frequency-Inverse Document Frequency) is a topic representation step that involves representing documents as vectors of term frequencies weighted by the inverse document frequency, which helps to capture the importance of words in the context of the entire corpus, allowing for better identification of relevant terms and concepts that are associated with specific topics, while also reducing the influence of common words that may not carry significant meaning in the analysis.
    /// This is a weighting scheme that assigns higher weights to terms that are more frequent in a document but less frequent across the entire corpus, which can help to highlight important terms and concepts that are relevant to specific topics, while also reducing the influence of common words that may not carry significant meaning in the analysis, ultimately improving the performance of topic modeling and semantic analysis tasks by providing a more meaningful representation of the text data.
    /// </summary>
    TFIDF,
    /// <summary>
    /// Reranking is a topic representation step that involves reordering the terms or concepts in a document based on their relevance or importance to the underlying topics, which can help to improve the performance of topic modeling and semantic analysis tasks by providing a more meaningful representation of the text data, especially in cases where the original order of the terms may not accurately reflect their relevance to the topics being analyzed.
    /// This step can be used to identify and prioritize the most relevant terms and concepts in a document, which can help to improve the accuracy and interpretability of topic modeling and semantic analysis results, while also providing insights into the underlying themes and topics that are present in the text data, ultimately enhancing the overall understanding of the documents being analyzed.
    /// </summary>
    Reranking,
    /// <summary>
    /// GenerativeRepresentationBasedOnReranking is a topic representation step that involves generating new representations of documents based on the reranking of terms or concepts, which can help to capture more complex relationships and patterns in the text data, ultimately improving the performance of topic modeling and semantic analysis tasks by providing a more nuanced and meaningful representation of the underlying topics.
    /// This is a more modern approach that leverages generative models to create new representations of documents based on the reranking of terms/concepts, which can help to capture more complex relationships and patterns in the text data, ultimately improving the performance of topic modeling and semantic analysis tasks by providing a more nuanced and meaningful representation of the underlying topics, especially in cases where traditional methods may struggle to capture the full complexity and richness of the text data being analyzed.
    /// </summary>
    GenerativeRepresentationBasedOnReranking,
}
