
namespace DeepSigma.AutoML.Enums.Modeling;

/// <summary>
/// ModelSpecificity is an enumeration that defines the level of specificity of a machine learning model, particularly in the context of foundation models and fine-tuned models.
/// </summary>
public enum ModelSpecificity
{
    /// <summary>
    /// FoundationModel refers to a pre-trained machine learning model that has been trained on a large and diverse dataset, typically using self-supervised learning techniques, and can be fine-tuned for specific downstream tasks.
    /// </summary>
    FoundationModel,
    /// <summary>
    /// FineTunedModel refers to a machine learning model that has been further trained or fine-tuned on a specific task or dataset after being pre-trained as a foundation model, allowing it to adapt and perform well on the specific task while leveraging the knowledge learned from the foundation model.
    /// </summary>
    FineTunedModel,
    /// <summary>
    /// PreferenceTunedModel refers to a machine learning model that has been fine-tuned based on user preferences or specific criteria, allowing it to better align with the desired outcomes or user requirements, often used in recommendation systems or personalized applications.
    /// OpenAI's InstructGPT is an example of a preference-tuned model, where the model is fine-tuned using human feedback to better align with user instructions and preferences.
    /// </summary>
    PreferenceTunedModel,
}
