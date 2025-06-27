using GoogleGenAI.SDK.Models;
using RestEase;

namespace GoogleGenAI.SDK;

/// <summary>
/// The Gemini API allows developers to build generative AI applications using Gemini models. Gemini is our most capable model, built from the ground up to be multimodal.
/// It can generalize and seamlessly understand, operate across, and combine different types of information including language, images, audio, video, and code.
/// You can use the Gemini API for use cases like reasoning across text and images, content generation, dialogue agents, summarization and classification systems, and more.
/// </summary>
[Header("Content-Type", "application/json")]
public interface IGenerativeLanguageApi
{
    [Query("key")]
    string Key { get; set; }

    /// <summary>
    /// Generates a response from the model given an input message.
    /// </summary>
    /// <param name="model">The name of the `Model` to use for generating the completion.</param>
    /// <param name="body">The request body.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Post("/v1beta/models/{model}:generateText")]
    Task<GenerateTextResponse> GenerateTextAsync(
        [Path] string model,
        [Body] GenerateTextRequest body,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Performs a prediction request.
    /// </summary>
    /// <param name="model">The name of the `Model` to use for generating the completion.</param>
    /// <param name="body">The request body.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Post("/v1beta/models/{model}:predict")]
    Task<PredictResponse> PredictAsync(
        [Path] string model,
        [Body] PredictRequest body,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Generates a [streamed
    /// response](https://ai.google.dev/gemini-api/docs/text-generation?lang=python#generate-a-text-stream)
    /// from the model given an input `GenerateContentRequest`.
    /// </summary>
    /// <param name="model">The name of the `Model` to use for generating the completion.</param>
    /// <param name="body">The request body.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Post("/v1beta/models/{model}:streamGenerateContent")]
    Task<GenerateContentResponse> StreamGenerateContentAsync(
        [Path] string model,
        [Body] GenerateContentRequest body,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Lists CachedContents.
    /// </summary>
    /// <param name="pageSize">Optional. The maximum number of cached contents to return. The service may return
    /// fewer than this value.
    /// If unspecified, some default (under maximum) number of items will be
    /// returned.
    /// The maximum value is 1000; values above 1000 will be coerced to 1000.</param>
    /// <param name="pageToken">Optional. A page token, received from a previous `ListCachedContents` call.
    /// Provide this to retrieve the subsequent page.
    /// 
    /// When paginating, all other parameters provided to `ListCachedContents` must
    /// match the call that provided the page token.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Get("/v1beta/cachedContents")]
    Task<ListCachedContentsResponse> ListCachedContentsAsync(
        [Query] int? pageSize = null,
        [Query] string? pageToken = null,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Creates CachedContent resource.
    /// </summary>
    /// <param name="body">Required. The cached content to create.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Post("/v1beta/cachedContents")]
    Task<CachedContent> CreateCachedContentAsync(
        [Body] CachedContent body,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Generates a [streamed response](https://ai.google.dev/gemini-api/docs/text-generation?lang=python#generate-a-text-stream)
    /// from the model given an input `GenerateContentRequest`.
    /// </summary>
    /// <param name="dynamicId">Part of `model`. Required. The name of the `Model` to use for generating the completion.</param>
    /// <param name="body">The request body.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Post("/v1beta/dynamic/{dynamicId}:streamGenerateContent")]
    Task<GenerateContentResponse> StreamGenerateContentByDynamicIdAsync(
        [Path] string dynamicId,
        [Body] GenerateContentRequest body,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Runs a model's tokenizer on input `Content` and returns the token count.
    /// Refer to the [tokens guide](https://ai.google.dev/gemini-api/docs/tokens)
    /// to learn more about tokens.
    /// </summary>
    /// <param name="model">The name of the `Model` to use for generating the completion.</param>
    /// <param name="body">The request body.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Post("/v1beta/models/{model}:countTokens")]
    Task<CountTokensResponse> CountTokensAsync(
        [Path] string model,
        [Body] CountTokensRequest body,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Lists all `Corpora` owned by the user.
    /// </summary>
    /// <param name="pageSize">Optional. The maximum number of `Corpora` to return (per page).
    /// The service may return fewer `Corpora`.
    /// 
    /// If unspecified, at most 10 `Corpora` will be returned.
    /// The maximum size limit is 20 `Corpora` per page.</param>
    /// <param name="pageToken">Optional. A page token, received from a previous `ListCorpora` call.
    /// 
    /// Provide the `next_page_token` returned in the response as an argument to
    /// the next request to retrieve the next page.
    /// 
    /// When paginating, all other parameters provided to `ListCorpora`
    /// must match the call that provided the page token.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Get("/v1beta/corpora")]
    Task<ListCorporaResponse> ListCorporaAsync(
        [Query] int? pageSize = null,
        [Query] string? pageToken = null,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Creates an empty `Corpus`.
    /// </summary>
    /// <param name="body">Required. The `Corpus` to create.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Post("/v1beta/corpora")]
    Task<Corpus> CreateCorpusAsync(
        [Body] Corpus body,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Performs semantic search over a `Corpus`.
    /// </summary>
    /// <param name="corpus">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="body">The request body.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Post("/v1beta/corpora/{corpus}:query")]
    Task<QueryCorpusResponse> QueryCorpusAsync(
        [Path] string corpus,
        [Body] QueryCorpusRequest body,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Performs semantic search over a `Document`.
    /// </summary>
    /// <param name="corpus">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="document">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="body">The request body.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Post("/v1beta/corpora/{corpus}/documents/{document}:query")]
    Task<QueryDocumentResponse> QueryDocumentAsync(
        [Path] string corpus,
        [Path] string document,
        [Body] QueryDocumentRequest body,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Generates multiple embeddings from the model given input text in a
    /// synchronous call.
    /// </summary>
    /// <param name="model">The name of the `Model` to use for generating the completion.</param>
    /// <param name="body">The request body.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Post("/v1beta/models/{model}:batchEmbedText")]
    Task<BatchEmbedTextResponse> BatchEmbedTextAsync(
        [Path] string model,
        [Body] BatchEmbedTextRequest body,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a permission to a specific resource.
    /// </summary>
    /// <param name="corpus">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="body">Required. The permission to create.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Post("/v1beta/corpora/{corpus}/permissions")]
    Task<Permission> CreatePermissionByCorpusAsync(
        [Path] string corpus,
        [Body] Permission body,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Lists permissions for the specific resource.
    /// </summary>
    /// <param name="corpus">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="pageSize">Optional. The maximum number of `Permission`s to return (per page).
    /// The service may return fewer permissions.
    /// 
    /// If unspecified, at most 10 permissions will be returned.
    /// This method returns at most 1000 permissions per page, even if you pass
    /// larger page_size.</param>
    /// <param name="pageToken">Optional. A page token, received from a previous `ListPermissions` call.
    /// 
    /// Provide the `page_token` returned by one request as an argument to the
    /// next request to retrieve the next page.
    /// 
    /// When paginating, all other parameters provided to `ListPermissions`
    /// must match the call that provided the page token.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Get("/v1beta/corpora/{corpus}/permissions")]
    Task<ListPermissionsResponse> ListPermissionsByCorpusAsync(
        [Path] string corpus,
        [Query] int? pageSize = null,
        [Query] string? pageToken = null,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets the latest state of a long-running operation.  Clients can use this
    /// method to poll the operation result at intervals as recommended by the API
    /// service.
    /// </summary>
    /// <param name="model">The name of the `Model` to use for generating the completion.</param>
    /// <param name="operation">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Get("/v1beta/models/{model}/operations/{operation}")]
    Task<Operation> GetOperationByModelAndOperationAsync(
        [Path] string model,
        [Path] string operation,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Creates a `Chunk`.
    /// </summary>
    /// <param name="corpus">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="document">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="body">Required. The `Chunk` to create.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Post("/v1beta/corpora/{corpus}/documents/{document}/chunks")]
    Task<Chunk> CreateChunkAsync(
        [Path] string corpus,
        [Path] string document,
        [Body] Chunk body,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Lists all `Chunk`s in a `Document`.
    /// </summary>
    /// <param name="corpus">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="document">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="pageSize">Optional. The maximum number of `Chunk`s to return (per page).
    /// The service may return fewer `Chunk`s.
    /// 
    /// If unspecified, at most 10 `Chunk`s will be returned.
    /// The maximum size limit is 100 `Chunk`s per page.</param>
    /// <param name="pageToken">Optional. A page token, received from a previous `ListChunks` call.
    /// 
    /// Provide the `next_page_token` returned in the response as an argument to
    /// the next request to retrieve the next page.
    /// 
    /// When paginating, all other parameters provided to `ListChunks`
    /// must match the call that provided the page token.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Get("/v1beta/corpora/{corpus}/documents/{document}/chunks")]
    Task<ListChunksResponse> ListChunksAsync(
        [Path] string corpus,
        [Path] string document,
        [Query] int? pageSize = null,
        [Query] string? pageToken = null,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Download the `File`.
    /// </summary>
    /// <param name="file">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Get("/v1beta/files/{file}:download")]
    Task<DownloadFileResponse> DownloadFileAsync(
        [Path] string file,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Transfers ownership of the tuned model.
    /// This is the only way to change ownership of the tuned model.
    /// The current owner will be downgraded to writer role.
    /// </summary>
    /// <param name="tunedModel">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="body">The request body.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Post("/v1beta/tunedModels/{tunedModel}:transferOwnership")]
    Task<TransferOwnershipResponse> TransferOwnershipAsync(
        [Path] string tunedModel,
        [Body] TransferOwnershipRequest body,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates a `Document`.
    /// </summary>
    /// <param name="corpus">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="document">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="updateMask">Required. The list of fields to update.
    /// Currently, this only supports updating `display_name` and
    /// `custom_metadata`.</param>
    /// <param name="body">Required. The `Document` to update.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Patch("/v1beta/corpora/{corpus}/documents/{document}")]
    Task<Document> UpdateDocumentAsync(
        [Path] string corpus,
        [Path] string document,
        [Query] string updateMask,
        [Body] Document body,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes a `Document`.
    /// </summary>
    /// <param name="corpus">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="document">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="force">Optional. If set to true, any `Chunk`s and objects related to this `Document` will
    /// also be deleted.
    /// 
    /// If false (the default), a `FAILED_PRECONDITION` error will be returned if
    /// `Document` contains any `Chunk`s.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Delete("/v1beta/corpora/{corpus}/documents/{document}")]
    Task<Empty> DeleteDocumentAsync(
        [Path] string corpus,
        [Path] string document,
        [Query] bool? force = null,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets information about a specific `Document`.
    /// </summary>
    /// <param name="corpus">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="document">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Get("/v1beta/corpora/{corpus}/documents/{document}")]
    Task<Document> GetDocumentAsync(
        [Path] string corpus,
        [Path] string document,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets information about a specific Permission.
    /// </summary>
    /// <param name="corpus">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="permission">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Get("/v1beta/corpora/{corpus}/permissions/{permission}")]
    Task<Permission> GetPermissionByCorpusAndPermissionAsync(
        [Path] string corpus,
        [Path] string permission,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates the permission.
    /// </summary>
    /// <param name="corpus">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="permission">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="updateMask">Required. The list of fields to update. Accepted ones:
    ///  - role (`Permission.role` field)</param>
    /// <param name="body">Required. The permission to update.
    /// 
    /// The permission's `name` field is used to identify the permission to update.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Patch("/v1beta/corpora/{corpus}/permissions/{permission}")]
    Task<Permission> UpdatePermissionByCorpusAndPermissionAsync(
        [Path] string corpus,
        [Path] string permission,
        [Query] string updateMask,
        [Body] Permission body,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes the permission.
    /// </summary>
    /// <param name="corpus">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="permission">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Delete("/v1beta/corpora/{corpus}/permissions/{permission}")]
    Task<Empty> DeletePermissionByCorpusAndPermissionAsync(
        [Path] string corpus,
        [Path] string permission,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets a generated file. When calling this method via REST, only the metadata
    /// of the generated file is returned. To retrieve the file content via REST,
    /// add alt=media as a query parameter.
    /// </summary>
    /// <param name="generatedFile">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Get("/v1beta/generatedFiles/{generatedFile}")]
    Task<GeneratedFile> GetGeneratedFileAsync(
        [Path] string generatedFile,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Generates a model response given an input `GenerateContentRequest`.
    /// Refer to the [text generation
    /// guide](https://ai.google.dev/gemini-api/docs/text-generation) for detailed
    /// usage information. Input capabilities differ between models, including
    /// tuned models. Refer to the [model
    /// guide](https://ai.google.dev/gemini-api/docs/models/gemini) and [tuning
    /// guide](https://ai.google.dev/gemini-api/docs/model-tuning) for details.
    /// </summary>
    /// <param name="dynamicId">Part of `model`. Required. The name of the `Model` to use for generating the completion.</param>
    /// <param name="body">The request body.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Post("/v1beta/dynamic/{dynamicId}:generateContent")]
    Task<GenerateContentResponse> GenerateContentByDynamicIdAsync(
        [Path] string dynamicId,
        [Body] GenerateContentRequest body,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Creates a `File`.
    /// </summary>
    /// <param name="body">The request body.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Post("/v1beta/files")]
    Task<CreateFileResponse> CreateFileAsync(
        [Body] CreateFileRequest body,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Lists the metadata for `File`s owned by the requesting project.
    /// </summary>
    /// <param name="pageSize">Optional. Maximum number of `File`s to return per page.
    /// If unspecified, defaults to 10. Maximum `page_size` is 100.</param>
    /// <param name="pageToken">Optional. A page token from a previous `ListFiles` call.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Get("/v1beta/files")]
    Task<ListFilesResponse> ListFilesAsync(
        [Query] int? pageSize = null,
        [Query] string? pageToken = null,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Generates a response from the model given an input `MessagePrompt`.
    /// </summary>
    /// <param name="model">The name of the `Model` to use for generating the completion.</param>
    /// <param name="body">The request body.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Post("/v1beta/models/{model}:generateMessage")]
    Task<GenerateMessageResponse> GenerateMessageAsync(
        [Path] string model,
        [Body] GenerateMessageRequest body,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets information about a specific Permission.
    /// </summary>
    /// <param name="tunedModel">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="permission">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Get("/v1beta/tunedModels/{tunedModel}/permissions/{permission}")]
    Task<Permission> GetTunedModelPermissionAsync(
        [Path] string tunedModel,
        [Path] string permission,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes the permission.
    /// </summary>
    /// <param name="tunedModel">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="permission">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Delete("/v1beta/tunedModels/{tunedModel}/permissions/{permission}")]
    Task<Empty> DeleteTunedModelPermissionAsync(
        [Path] string tunedModel,
        [Path] string permission,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates the permission.
    /// </summary>
    /// <param name="tunedModel">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="permission">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="updateMask">Required. The list of fields to update. Accepted ones:
    ///  - role (`Permission.role` field)</param>
    /// <param name="body">Required. The permission to update.
    /// 
    /// The permission's `name` field is used to identify the permission to update.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Patch("/v1beta/tunedModels/{tunedModel}/permissions/{permission}")]
    Task<Permission> UpdateTunedModelPermissionAsync(
        [Path] string tunedModel,
        [Path] string permission,
        [Query] string updateMask,
        [Body] Permission body,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Lists permissions for the specific resource.
    /// </summary>
    /// <param name="tunedModel">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="pageSize">Optional. The maximum number of `Permission`s to return (per page).
    /// The service may return fewer permissions.
    /// 
    /// If unspecified, at most 10 permissions will be returned.
    /// This method returns at most 1000 permissions per page, even if you pass
    /// larger page_size.</param>
    /// <param name="pageToken">Optional. A page token, received from a previous `ListPermissions` call.
    /// 
    /// Provide the `page_token` returned by one request as an argument to the
    /// next request to retrieve the next page.
    /// 
    /// When paginating, all other parameters provided to `ListPermissions`
    /// must match the call that provided the page token.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Get("/v1beta/tunedModels/{tunedModel}/permissions")]
    Task<ListPermissionsResponse> ListTunedModelPermissionsAsync(
        [Path] string tunedModel,
        [Query] int? pageSize = null,
        [Query] string? pageToken = null,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a permission to a specific resource.
    /// </summary>
    /// <param name="tunedModel">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="body">Required. The permission to create.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Post("/v1beta/tunedModels/{tunedModel}/permissions")]
    Task<Permission> CreateTunedModelPermissionAsync(
        [Path] string tunedModel,
        [Body] Permission body,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Runs a model's tokenizer on a text and returns the token count.
    /// </summary>
    /// <param name="model">The name of the `Model` to use for generating the completion.</param>
    /// <param name="body">The request body.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Post("/v1beta/models/{model}:countTextTokens")]
    Task<CountTextTokensResponse> CountTextTokensAsync(
        [Path] string model,
        [Body] CountTextTokensRequest body,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes the `File`.
    /// </summary>
    /// <param name="file">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Delete("/v1beta/files/{file}")]
    Task<Empty> DeleteFileAsync(
        [Path] string file,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets the metadata for the given `File`.
    /// </summary>
    /// <param name="file">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Get("/v1beta/files/{file}")]
    Task<GoogleFile> GetFileAsync(
        [Path] string file,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes CachedContent resource.
    /// </summary>
    /// <param name="id">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Delete("/v1beta/cachedContents/{id}")]
    Task<Empty> DeleteCachedContentAsync(
        [Path] string id,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates CachedContent resource (only expiration is updatable).
    /// </summary>
    /// <param name="id">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="body">Required. The content cache entry to update</param>
    /// <param name="updateMask">The list of fields to update.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Patch("/v1beta/cachedContents/{id}")]
    Task<CachedContent> UpdateCachedContentAsync(
        [Path] string id,
        [Body] CachedContent body,
        [Query] string? updateMask = null,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Reads CachedContent resource.
    /// </summary>
    /// <param name="id">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Get("/v1beta/cachedContents/{id}")]
    Task<CachedContent> GetCachedContentAsync(
        [Path] string id,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Lists operations that match the specified filter in the request. If the
    /// server doesn't support this method, it returns `UNIMPLEMENTED`.
    /// </summary>
    /// <param name="filter">The standard list filter.</param>
    /// <param name="pageSize">The standard list page size.</param>
    /// <param name="pageToken">The standard list page token.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Get("/v1beta/batches")]
    Task<ListOperationsResponse> ListOperationsByAsync(
        [Query] string? filter = null,
        [Query] int? pageSize = null,
        [Query] string? pageToken = null,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets the latest state of a long-running operation.  Clients can use this
    /// method to poll the operation result at intervals as recommended by the API
    /// service.
    /// </summary>
    /// <param name="tunedModel">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="operation">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Get("/v1beta/tunedModels/{tunedModel}/operations/{operation}")]
    Task<Operation> GetTunedModelOperationAsync(
        [Path] string tunedModel,
        [Path] string operation,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Generates a model response given an input `GenerateContentRequest`.
    /// Refer to the [text generation
    /// guide](https://ai.google.dev/gemini-api/docs/text-generation) for detailed
    /// usage information. Input capabilities differ between models, including
    /// tuned models. Refer to the [model
    /// guide](https://ai.google.dev/gemini-api/docs/models/gemini) and [tuning
    /// guide](https://ai.google.dev/gemini-api/docs/model-tuning) for details.
    /// </summary>
    /// <param name="model">The name of the `Model` to use for generating the completion.</param>
    /// <param name="body">The request body.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Post("models/{model}:generateContent")]
    Task<GenerateContentResponse> GenerateContentAsync(
        [Path] string model,
        [Body] GenerateContentRequest body,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets the latest state of a long-running operation.  Clients can use this
    /// method to poll the operation result at intervals as recommended by the API
    /// service.
    /// </summary>
    /// <param name="generateContentBatch">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Get("/v1beta/batches/{generateContentBatch}")]
    Task<Operation> GetOperationByGenerateContentBatchAsync(
        [Path] string generateContentBatch,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Batch create `Chunk`s.
    /// </summary>
    /// <param name="corpus">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="document">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="body">The request body.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Post("/v1beta/corpora/{corpus}/documents/{document}/chunks:batchCreate")]
    Task<BatchCreateChunksResponse> BatchCreateChunksAsync(
        [Path] string corpus,
        [Path] string document,
        [Body] BatchCreateChunksRequest body,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates a `Chunk`.
    /// </summary>
    /// <param name="corpus">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="document">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="chunk">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="updateMask">Required. The list of fields to update.
    /// Currently, this only supports updating `custom_metadata` and `data`.</param>
    /// <param name="body">Required. The `Chunk` to update.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Patch("/v1beta/corpora/{corpus}/documents/{document}/chunks/{chunk}")]
    Task<Chunk> UpdateChunkAsync(
        [Path] string corpus,
        [Path] string document,
        [Path] string chunk,
        [Query] string updateMask,
        [Body] Chunk body,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes a `Chunk`.
    /// </summary>
    /// <param name="corpus">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="document">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="chunk">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Delete("/v1beta/corpora/{corpus}/documents/{document}/chunks/{chunk}")]
    Task<Empty> DeleteChunkAsync(
        [Path] string corpus,
        [Path] string document,
        [Path] string chunk,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets information about a specific `Chunk`.
    /// </summary>
    /// <param name="corpus">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="document">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="chunk">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Get("/v1beta/corpora/{corpus}/documents/{document}/chunks/{chunk}")]
    Task<Chunk> GetChunkAsync(
        [Path] string corpus,
        [Path] string document,
        [Path] string chunk,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Generates a text embedding vector from the input `Content` using the
    /// specified [Gemini Embedding
    /// model](https://ai.google.dev/gemini-api/docs/models/gemini#text-embedding).
    /// </summary>
    /// <param name="model">The name of the `Model` to use for generating the completion.</param>
    /// <param name="body">The request body.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Post("/v1beta/models/{model}:embedContent")]
    Task<EmbedContentResponse> EmbedContentAsync(
        [Path] string model,
        [Body] EmbedContentRequest body,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Creates an empty `Document`.
    /// </summary>
    /// <param name="corpus">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="body">Required. The `Document` to create.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Post("/v1beta/corpora/{corpus}/documents")]
    Task<Document> CreateDocumentAsync(
        [Path] string corpus,
        [Body] Document body,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Lists all `Document`s in a `Corpus`.
    /// </summary>
    /// <param name="corpus">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="pageSize">Optional. The maximum number of `Document`s to return (per page).
    /// The service may return fewer `Document`s.
    /// 
    /// If unspecified, at most 10 `Document`s will be returned.
    /// The maximum size limit is 20 `Document`s per page.</param>
    /// <param name="pageToken">Optional. A page token, received from a previous `ListDocuments` call.
    /// 
    /// Provide the `next_page_token` returned in the response as an argument to
    /// the next request to retrieve the next page.
    /// 
    /// When paginating, all other parameters provided to `ListDocuments`
    /// must match the call that provided the page token.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Get("/v1beta/corpora/{corpus}/documents")]
    Task<ListDocumentsResponse> ListDocumentsAsync(
        [Path] string corpus,
        [Query] int? pageSize = null,
        [Query] string? pageToken = null,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Generates a [streamed
    /// response](https://ai.google.dev/gemini-api/docs/text-generation?lang=python#generate-a-text-stream)
    /// from the model given an input `GenerateContentRequest`.
    /// </summary>
    /// <param name="tunedModel">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="body">The request body.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Post("/v1beta/tunedModels/{tunedModel}:streamGenerateContent")]
    Task<GenerateContentResponse> StreamGenerateContentByTunedModelAsync(
        [Path] string tunedModel,
        [Body] GenerateContentRequest body,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Generates multiple embedding vectors from the input `Content` which
    /// consists of a batch of strings represented as `EmbedContentRequest`
    /// objects.
    /// </summary>
    /// <param name="model">The name of the `Model` to use for generating the completion.</param>
    /// <param name="body">The request body.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Post("/v1beta/models/{model}:batchEmbedContents")]
    Task<BatchEmbedContentsResponse> BatchEmbedContentsAsync(
        [Path] string model,
        [Body] BatchEmbedContentsRequest body,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Generates a grounded answer from the model given an input
    /// `GenerateAnswerRequest`.
    /// </summary>
    /// <param name="model">The name of the `Model` to use for generating the completion.</param>
    /// <param name="body">The request body.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Post("/v1beta/models/{model}:generateAnswer")]
    Task<GenerateAnswerResponse> GenerateAnswerAsync(
        [Path] string model,
        [Body] GenerateAnswerRequest body,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Lists the generated files owned by the requesting project.
    /// </summary>
    /// <param name="pageSize">Optional. Maximum number of `GeneratedFile`s to return per page.
    /// If unspecified, defaults to 10. Maximum `page_size` is 50.</param>
    /// <param name="pageToken">Optional. A page token from a previous `ListGeneratedFiles` call.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Get("/v1beta/generatedFiles")]
    Task<ListGeneratedFilesResponse> ListGeneratedFilesAsync(
        [Query] int? pageSize = null,
        [Query] string? pageToken = null,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Lists operations that match the specified filter in the request. If the
    /// server doesn't support this method, it returns `UNIMPLEMENTED`.
    /// </summary>
    /// <param name="tunedModel">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="filter">The standard list filter.</param>
    /// <param name="pageSize">The standard list page size.</param>
    /// <param name="pageToken">The standard list page token.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Get("/v1beta/tunedModels/{tunedModel}/operations")]
    Task<ListOperationsResponse> ListTunedModelOperationsAsync(
        [Path] string tunedModel,
        [Query] string? filter = null,
        [Query] int? pageSize = null,
        [Query] string? pageToken = null,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Generates a model response given an input `GenerateContentRequest`.
    /// Refer to the [text generation
    /// guide](https://ai.google.dev/gemini-api/docs/text-generation) for detailed
    /// usage information. Input capabilities differ between models, including
    /// tuned models. Refer to the [model
    /// guide](https://ai.google.dev/gemini-api/docs/models/gemini) and [tuning
    /// guide](https://ai.google.dev/gemini-api/docs/model-tuning) for details.
    /// </summary>
    /// <param name="tunedModel">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="body">The request body.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Post("/v1beta/tunedModels/{tunedModel}:generateContent")]
    Task<GenerateContentResponse> GenerateContentByTunedModelAsync(
        [Path] string tunedModel,
        [Body] GenerateContentRequest body,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Runs a model's tokenizer on a string and returns the token count.
    /// </summary>
    /// <param name="model">The name of the `Model` to use for generating the completion.</param>
    /// <param name="body">The request body.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Post("/v1beta/models/{model}:countMessageTokens")]
    Task<CountMessageTokensResponse> CountMessageTokensAsync(
        [Path] string model,
        [Body] CountMessageTokensRequest body,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates a `Corpus`.
    /// </summary>
    /// <param name="corpus">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="updateMask">Required. The list of fields to update.
    /// Currently, this only supports updating `display_name`.</param>
    /// <param name="body">Required. The `Corpus` to update.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Patch("/v1beta/corpora/{corpus}")]
    Task<Corpus> UpdateCorpusAsync(
        [Path] string corpus,
        [Query] string updateMask,
        [Body] Corpus body,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets information about a specific `Corpus`.
    /// </summary>
    /// <param name="corpus">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Get("/v1beta/corpora/{corpus}")]
    Task<Corpus> GetCorpusAsync(
        [Path] string corpus,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes a `Corpus`.
    /// </summary>
    /// <param name="corpus">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="force">Optional. If set to true, any `Document`s and objects related to this `Corpus` will
    /// also be deleted.
    /// 
    /// If false (the default), a `FAILED_PRECONDITION` error will be returned if
    /// `Corpus` contains any `Document`s.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Delete("/v1beta/corpora/{corpus}")]
    Task<Empty> DeleteCorpusAsync(
        [Path] string corpus,
        [Query] bool? force = null,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Lists operations that match the specified filter in the request. If the
    /// server doesn't support this method, it returns `UNIMPLEMENTED`.
    /// </summary>
    /// <param name="model">The name of the `Model` to use for generating the completion.</param>
    /// <param name="filter">The standard list filter.</param>
    /// <param name="pageSize">The standard list page size.</param>
    /// <param name="pageToken">The standard list page token.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Get("/v1beta/models/{model}/operations")]
    Task<ListOperationsResponse> ListOperationsByModelAsync(
        [Path] string model,
        [Query] string? filter = null,
        [Query] int? pageSize = null,
        [Query] string? pageToken = null,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets information about a specific `Model` such as its version number, token
    /// limits,
    /// [parameters](https://ai.google.dev/gemini-api/docs/models/generative-models#model-parameters)
    /// and other metadata. Refer to the [Gemini models
    /// guide](https://ai.google.dev/gemini-api/docs/models/gemini) for detailed
    /// model information.
    /// </summary>
    /// <param name="model">The name of the `Model` to use for generating the completion.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Get("/v1beta/models/{model}")]
    Task<Model> GetModelAsync(
        [Path] string model,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets the latest state of a long-running operation.  Clients can use this
    /// method to poll the operation result at intervals as recommended by the API
    /// service.
    /// </summary>
    /// <param name="generatedFile">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="operation">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Get("/v1beta/generatedFiles/{generatedFile}/operations/{operation}")]
    Task<Operation> GetOperationByGeneratedFileAndOperationAsync(
        [Path] string generatedFile,
        [Path] string operation,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Starts asynchronous cancellation on a long-running operation.  The server
    /// makes a best effort to cancel the operation, but success is not
    /// guaranteed.  If the server doesn't support this method, it returns
    /// `google.rpc.Code.UNIMPLEMENTED`.  Clients can use
    /// Operations.GetOperation or
    /// other methods to check whether the cancellation succeeded or whether the
    /// operation completed despite cancellation. On successful cancellation,
    /// the operation is not deleted; instead, it becomes an operation with
    /// an Operation.error value with a google.rpc.Status.code of `1`,
    /// corresponding to `Code.CANCELLED`.
    /// </summary>
    /// <param name="generateContentBatch">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Post("/v1beta/batches/{generateContentBatch}:cancel")]
    Task<Empty> CancelOperationAsync(
        [Path] string generateContentBatch,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Generates an embedding from the model given an input message.
    /// </summary>
    /// <param name="model">The name of the `Model` to use for generating the completion.</param>
    /// <param name="body">The request body.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Post("/v1beta/models/{model}:embedText")]
    Task<EmbedTextResponse> EmbedTextAsync(
        [Path] string model,
        [Body] EmbedTextRequest body,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Batch update `Chunk`s.
    /// </summary>
    /// <param name="corpus">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="document">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="body">The request body.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Post("/v1beta/corpora/{corpus}/documents/{document}/chunks:batchUpdate")]
    Task<BatchUpdateChunksResponse> BatchUpdateChunksAsync(
        [Path] string corpus,
        [Path] string document,
        [Body] BatchUpdateChunksRequest body,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Lists the [`Model`s](https://ai.google.dev/gemini-api/docs/models/gemini)
    /// available through the Gemini API.
    /// </summary>
    /// <param name="pageSize">The maximum number of `Models` to return (per page).
    /// 
    /// If unspecified, 50 models will be returned per page.
    /// This method returns at most 1000 models per page, even if you pass a larger
    /// page_size.</param>
    /// <param name="pageToken">A page token, received from a previous `ListModels` call.
    /// 
    /// Provide the `page_token` returned by one request as an argument to the next
    /// request to retrieve the next page.
    /// 
    /// When paginating, all other parameters provided to `ListModels` must match
    /// the call that provided the page token.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Get("/v1beta/models")]
    Task<ListModelsResponse> ListModelsAsync(
        [Query] int? pageSize = null,
        [Query] string? pageToken = null,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Creates a tuned model.
    /// Check intermediate tuning progress (if any) through the
    /// [google.longrunning.Operations] service.
    /// 
    /// Access status and results through the Operations service.
    /// Example:
    ///   GET /v1/tunedModels/az2mb0bpw6i/operations/000-111-222
    /// </summary>
    /// <param name="body">Required. The tuned model to create.</param>
    /// <param name="tunedModelId">Optional. The unique id for the tuned model if specified.
    /// This value should be up to 40 characters, the first character must be a
    /// letter, the last could be a letter or a number. The id must match the
    /// regular expression: `[a-z]([a-z0-9-]{0,38}[a-z0-9])?`.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Post("/v1beta/tunedModels")]
    Task<CreateTunedModelOperation> CreateTunedModelAsync(
        [Body] TunedModel body,
        [Query] string? tunedModelId = null,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Lists created tuned models.
    /// </summary>
    /// <param name="pageSize">Optional. The maximum number of `TunedModels` to return (per page).
    /// The service may return fewer tuned models.
    /// 
    /// If unspecified, at most 10 tuned models will be returned.
    /// This method returns at most 1000 models per page, even if you pass a larger
    /// page_size.</param>
    /// <param name="pageToken">Optional. A page token, received from a previous `ListTunedModels` call.
    /// 
    /// Provide the `page_token` returned by one request as an argument to the next
    /// request to retrieve the next page.
    /// 
    /// When paginating, all other parameters provided to `ListTunedModels`
    /// must match the call that provided the page token.</param>
    /// <param name="filter">Optional. A filter is a full text search over the tuned model's description and
    /// display name. By default, results will not include tuned models shared
    /// with everyone.
    /// 
    /// Additional operators:
    ///   - owner:me
    ///   - writers:me
    ///   - readers:me
    ///   - readers:everyone
    /// 
    /// Examples:
    ///   "owner:me" returns all tuned models to which caller has owner role
    ///   "readers:me" returns all tuned models to which caller has reader role
    ///   "readers:everyone" returns all tuned models that are shared with everyone</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Get("/v1beta/tunedModels")]
    Task<ListTunedModelsResponse> ListTunedModelsAsync(
        [Query] int? pageSize = null,
        [Query] string? pageToken = null,
        [Query] string? filter = null,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Generates a response from the model given an input message.
    /// </summary>
    /// <param name="tunedModel">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="body">The request body.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Post("/v1beta/tunedModels/{tunedModel}:generateText")]
    Task<GenerateTextResponse> GenerateTextByTunedModelAsync(
        [Path] string tunedModel,
        [Body] GenerateTextRequest body,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates a tuned model.
    /// </summary>
    /// <param name="tunedModel">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="body">Required. The tuned model to update.</param>
    /// <param name="updateMask">Optional. The list of fields to update.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Patch("/v1beta/tunedModels/{tunedModel}")]
    Task<TunedModel> UpdateTunedModelAsync(
        [Path] string tunedModel,
        [Body] TunedModel body,
        [Query] string? updateMask = null,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets information about a specific TunedModel.
    /// </summary>
    /// <param name="tunedModel">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Get("/v1beta/tunedModels/{tunedModel}")]
    Task<TunedModel> GetTunedModelAsync(
        [Path] string tunedModel,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes a tuned model.
    /// </summary>
    /// <param name="tunedModel">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Delete("/v1beta/tunedModels/{tunedModel}")]
    Task<Empty> DeleteTunedModelAsync(
        [Path] string tunedModel,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Same as Predict but returns an LRO.
    /// </summary>
    /// <param name="model">The name of the `Model` to use for generating the completion.</param>
    /// <param name="body">The request body.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Post("/v1beta/models/{model}:predictLongRunning")]
    Task<PredictLongRunningOperation> PredictLongRunningAsync(
        [Path] string model,
        [Body] PredictLongRunningRequest body,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Batch delete `Chunk`s.
    /// </summary>
    /// <param name="corpus">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="document">Resource ID segment making up resource `name`. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</param>
    /// <param name="body">The request body.</param>
    /// <param name="alt">Data format for response.</param>
    /// <param name="callback">JSONP</param>
    /// <param name="prettyPrint">Returns response with indentations and line breaks.</param>
    /// <param name="xgafv">V1 error format.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Post("/v1beta/corpora/{corpus}/documents/{document}/chunks:batchDelete")]
    Task<Empty> BatchDeleteChunksAsync(
        [Path] string corpus,
        [Path] string document,
        [Body] BatchDeleteChunksRequest body,
        [Query("$alt")] string? alt = null,
        [Query("$callback")] string? callback = null,
        [Query("$prettyPrint")] bool? prettyPrint = null,
        [Query("$.xgafv")] string? xgafv = null,
        CancellationToken cancellationToken = default);
}