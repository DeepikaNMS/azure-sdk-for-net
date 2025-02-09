// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.Language.QuestionAnswering
{
    /// <summary> The question and text record parameters to answer. </summary>
    public partial class AnswersFromTextOptions
    {
        /// <summary> Initializes a new instance of <see cref="AnswersFromTextOptions"/>. </summary>
        /// <param name="question"> User question to query against the given text records. </param>
        /// <param name="textDocuments"> Text records to be searched for given question. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="question"/> or <paramref name="textDocuments"/> is null. </exception>
        public AnswersFromTextOptions(string question, IEnumerable<TextDocument> textDocuments)
        {
            if (question == null)
            {
                throw new ArgumentNullException(nameof(question));
            }
            if (textDocuments == null)
            {
                throw new ArgumentNullException(nameof(textDocuments));
            }

            Question = question;
            TextDocuments = textDocuments.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="AnswersFromTextOptions"/>. </summary>
        /// <param name="question"> User question to query against the given text records. </param>
        /// <param name="textDocuments"> Text records to be searched for given question. </param>
        /// <param name="language"> Language of the text records. This is BCP-47 representation of a language. For example, use "en" for English; "es" for Spanish etc. If not set, use "en" for English as default. </param>
        /// <param name="stringIndexType"> Specifies the method used to interpret string offsets.  Defaults to Text Elements (Graphemes) according to Unicode v8.0.0. For additional information see https://aka.ms/text-analytics-offsets. </param>
        internal AnswersFromTextOptions(string question, IList<TextDocument> textDocuments, string language, StringIndexType? stringIndexType)
        {
            Question = question;
            TextDocuments = textDocuments;
            Language = language;
            StringIndexType = stringIndexType;
        }
    }
}
