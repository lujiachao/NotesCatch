﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NotesCatch
{
    [Serializable]
    public class DocsByReflectionException : Exception
    {
        /// <summary>
        /// Initializes a new exception instance with the specified
        /// error message and a reference to the inner exception that is the cause of
        /// this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or null if none.</param>
        public DocsByReflectionException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
