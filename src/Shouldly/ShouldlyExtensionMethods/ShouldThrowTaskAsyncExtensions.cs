﻿using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Shouldly
{
    [DebuggerStepThrough]
    [ShouldlyMethods]
    public static partial class ShouldThrowAsyncExtensions
    {
        /*** ShouldThrowAsync(Task) ***/
        public static Task<TException> ShouldThrowAsync<TException>(this Task task, string? customMessage = null) where TException : Exception
        {
            return Should.ThrowAsync<TException>(task, customMessage);
        }

        /*** ShouldThrowAsync(Task) ***/
        public static Task<Exception> ShouldThrowAsync(this Task task, Type exceptionType)
        {
            return Should.ThrowAsync(task, exceptionType);
        }
        public static Task<Exception> ShouldThrowAsync(this Task task, string? customMessage, Type exceptionType)
        {
            return Should.ThrowAsync(task, customMessage, exceptionType);
        }

        /*** ShouldThrowAsync(Func<Task>) ***/
        public static Task<TException> ShouldThrowAsync<TException>(this Func<Task> actual, string? customMessage = null) where TException : Exception
        {
            return Should.ThrowAsync<TException>(actual, customMessage);
        }

        /*** ShouldThrowAsync(Func<Task>) ***/
        public static Task<Exception> ShouldThrowAsync(this Func<Task> actual, Type exceptionType)
        {
            return Should.ThrowAsync(actual, exceptionType);
        }
        public static Task<Exception> ShouldThrowAsync(this Func<Task> actual, string? customMessage, Type exceptionType)
        {
            return Should.ThrowAsync(actual, customMessage, exceptionType);
        }
    }
}