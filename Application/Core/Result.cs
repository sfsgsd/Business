﻿namespace Application.Core
{
    public class Result<T>
    {
        public bool  IsSucceed { get; set; }
        public T Value { get; set; }
        public string Error { get; set; }

        public static Result<T> Success(T value) => new Result<T> { IsSucceed = true, Value = value };
        public static Result<T> Failure(string error) => new Result<T> { IsSucceed = false, Error = error };
    }
}
