

namespace DeepSigma.AutoML.Enums.LLM;

public enum SemanticSearchCategories
{
    /// <summary>
    /// DenseRetrieval refers to a semantic search approach that utilizes dense vector representations (embeddings) of text data to retrieve relevant information based on the meaning and context of the query, rather than relying solely on keyword matching.
    /// </summary>
    DenseRetrieval,
    /// <summary>
    /// Reranking refers to a semantic search approach that involves retrieving an initial set of results based on keyword matching or other traditional search methods, and then reordering or reranking those results based on their semantic relevance to the query using techniques such as embedding similarity or machine learning models.
    /// </summary>
    Reranking,
    /// <summary>
    /// RetrievalAugmentedGeneration (RAG) is a semantic search approach that combines retrieval-based methods with generative models to enhance the search experience by not only retrieving relevant information but also generating new content based on the retrieved information, allowing for more comprehensive and contextually relevant search results.
    /// </summary>
    RetrievalAugmentedGeneration,
}
