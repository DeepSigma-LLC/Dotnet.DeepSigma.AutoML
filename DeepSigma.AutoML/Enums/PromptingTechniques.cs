

namespace DeepSigma.AutoML.Enums;

/// <summary>
/// The PromptingTechniques enumeration defines various techniques used in prompting, which are strategies or methods employed to elicit specific responses or behaviors from a model or system based on the way prompts are structured and presented.
/// </summary>
public enum PromptingTechniques
{
    /// <summary>
    /// Instruction-based prompting involves providing explicit instructions or guidelines to a model or system in order to elicit specific responses or behaviors.
    /// </summary>
    InstructionBasedPrompting,
    /// <summary>
    /// In-context learning is a prompting technique that involves providing a model with examples or context within the prompt itself to guide its response generation, allowing it to learn and adapt based on the provided information without requiring explicit fine-tuning or training on the specific task.
    /// </summary>
    InContextLearning,
    /// <summary>
    /// Prompt enrichment is a prompting technique that involves enhancing the prompt with additional information, context, or constraints to guide the model's response generation and improve the quality and relevance of the output.
    /// </summary>
    PromptEnrichment,
    /// <summary>
    /// Chain-of-thought prompting is a technique that encourages a model to generate a sequence of intermediate reasoning steps or thoughts before arriving at a final answer, allowing it to break down complex problems into smaller, more manageable parts and improve the accuracy and coherence of its responses.
    /// </summary>
    ChainOfThought,
    /// <summary>
    /// Self-reflection prompting is a technique that encourages a model to reflect on its own reasoning process and outputs, allowing it to identify potential errors, inconsistencies, or areas for improvement in its responses, ultimately leading to more accurate and coherent outputs.
    /// </summary>
    SelfReflection,
    /// <summary>
    /// Self-consistency prompting is a technique that encourages a model to generate multiple responses to the same prompt and then evaluate the consistency of those responses to identify the most reliable and accurate answer, allowing it to improve the quality and reliability of its outputs by leveraging the diversity of its generated responses.
    /// </summary>
    SelfConsistency,
    /// <summary>
    /// Model ensemble prompting is a technique that involves using multiple models or systems in an ensemble to generate responses to a given prompt, allowing for improved accuracy and robustness by leveraging the strengths of each individual model and combining their outputs in a way that enhances the overall performance of the system.
    /// </summary>
    ModelEnsemblePrompting,
    /// <summary>
    /// Tree-of-thought prompting is a technique that encourages a model to generate a tree-like structure of reasoning steps or thoughts, allowing it to explore multiple branches of reasoning and arrive at a more comprehensive and accurate final answer by considering different perspectives and possibilities in its response generation process.
    /// Similar to chain-of-thought prompting, but instead of generating a linear sequence of reasoning steps, tree-of-thought prompting allows for branching and exploration of multiple paths of reasoning, leading to more diverse and comprehensive responses from the model.
    /// This strategy is commonly used in Deep Research, where the model is encouraged to explore multiple paths of reasoning and generate a more comprehensive and accurate final answer by considering different perspectives and possibilities in its response generation process.
    /// </summary>
    TreeOfThought,
    /// <summary>
    /// Output verification prompting is a technique that ask the model to verify the correctness or validity of its own outputs, allowing it to identify and correct potential errors or inconsistencies in its responses, ultimately leading to more accurate and reliable outputs.
    /// Similar to self-reflection prompting, but with a specific focus on verifying the correctness or validity of the model's outputs, rather than reflecting on its reasoning process as a whole. 
    /// This technique can be particularly effective in improving the accuracy and reliability of the model's responses by encouraging it to critically evaluate its own outputs and identify potential errors or inconsistencies that may arise during the response generation process.
    /// </summary>
    OutputVerificationPrompting,
}
