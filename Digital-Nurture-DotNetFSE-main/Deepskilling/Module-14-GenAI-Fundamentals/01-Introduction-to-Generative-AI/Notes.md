# Notes: Introduction to Generative AI

## 1. What is Generative AI?

Generative Artificial Intelligence (GenAI) is a subset of artificial intelligence focused on creating new, original content. Unlike traditional AI, which analyzes existing data to make predictions, classify objects, or detect anomalies, Generative AI models learn the underlying patterns and structure of their input training data to generate new data that looks similar but is entirely novel.

### Comparison: Traditional AI vs. Generative AI

| Dimension | Traditional AI | Generative AI |
|---|---|---|
| **Primary Goal** | Analyze, classify, or predict. | Create, generate, or synthesize. |
| **Output Type** | Numeric predictions, labels, categories, or decision flags. | Natural language text, code, images, audio, video, or synthetic data. |
| **Examples** | Spam filters, house price predictors, credit scoring, image classifiers. | GPT-4, Gemini, Stable Diffusion, GitHub Copilot. |
| **Paradigm** | Discriminative (learning boundaries between classes). | Generative (learning the probability distribution of data). |

---

## 2. Foundations of Large Language Models (LLMs)

Large Language Models (LLMs) are a class of foundation models trained on massive text datasets (often terabytes of book text, web scrapes, code repositories, and articles). At their core, LLMs are statistical engines designed to perform next-token prediction. Given a sequence of words (or characters), the model predicts the most statistically probable next segment of text.

### The Transformer Architecture

Introduced in the seminal 2017 paper *"Attention Is All You Need"* by Vaswani et al., the Transformer architecture replaced recurrent neural networks (RNNs) and Long Short-Term Memory (LSTM) networks as the standard framework for natural language processing. 

Key innovations of Transformers include:
- **Parallelization**: RNNs process tokens sequentially, which makes training slow. Transformers process all tokens in a sequence simultaneously, allowing massive scaling on modern GPU hardware.
- **Self-Attention Mechanism**: Self-attention allows the model to dynamically compute the relationship between every single word in a sentence, regardless of their distance from one another. This captures context much better than previous architectures.

### Key Components of Language Processing

1. **Tokenization**: Before text is processed by a model, it is broken down into smaller chunks called tokens. A token can be a whole word, a part of a word (sub-word), or a single character. For instance, the word "unbelievable" might be tokenized into `["un", "believ", "able"]`.
2. **Embeddings**: Once tokenized, tokens are mapped to high-dimensional vectors (lists of numbers) called embeddings. These embeddings capture the semantic meaning of the token. Words with similar meanings or contexts (e.g., "king" and "queen", or "cat" and "dog") are positioned closer to each other in this high-dimensional vector space.
3. **Attention Weighting**: The model uses attention vectors to determine which other words in a prompt are most relevant to the current word being processed. For example, in the sentence "The bank of the river was muddy," the word "bank" receives higher attention weights for "river" and "muddy" to resolve its meaning as a geographical bank rather than a financial institution.

---

## 3. Training Phases of Modern LLMs

Foundation models undergo a rigorous, multi-stage training process:

1. **Pre-training (Unsupervised/Self-Supervised)**:
   - The model is fed raw text from the internet.
   - It learns general language structures, grammar, facts about the world, and reasoning skills by predicting the next token.
   - This phase is computationally expensive, taking weeks or months on thousands of GPUs.
2. **Supervised Fine-Tuning (SFT)**:
   - The model is refined on curated instruction-response datasets.
   - Human experts write prompts and high-quality answers to teach the model how to act like an assistant rather than just a next-word predictor.
3. **Reinforcement Learning from Human Feedback (RLHF)**:
   - The model generates multiple responses to a prompt, and human evaluators rate them based on helpfulness, accuracy, and safety.
   - A reward model is trained on these ratings to guide the main model's outputs.
   - This aligns the AI's behavior with human values and reduces harmful outputs.

---

## 4. Key LLM Terms and Parameters

When interacting with LLMs via APIs or development tools, several parameters control the style and randomness of the outputs:

- **Context Window**: The maximum amount of text (tokens) a model can read and write in a single interaction. This includes both the input prompt and the generated response. If a conversation exceeds the context window, older parts of the conversation are forgotten.
- **Temperature**: Controls the randomness of the next-token prediction.
  - *Low Temperature (e.g., 0.1 - 0.3)*: The model becomes deterministic and focused, choosing the highest probability tokens. Best for coding, math, and factual queries.
  - *High Temperature (e.g., 0.7 - 1.0)*: The model introduces more variety and randomness. Best for creative writing, brainstorming, and conversational variety.
- **Top-P (Nucleus Sampling)**: An alternative to temperature that controls token pool selection. A Top-P of 0.9 means the model only considers the pool of top tokens whose cumulative probability is 90%.
- **Hallucination**: A phenomenon where an LLM generates text that is grammatically correct and sounds highly confident, but is factually incorrect, illogical, or completely fabricated. This occurs because the model works on statistical probabilities of word combinations, not a database of absolute truths.
