﻿using System;

namespace JungFranco.AntiCaptcha.CapLib
{
    public class CaptchaException : Exception
    {
        public CaptchaException() { }
        public CaptchaException(string message)
            : base(message) { }
        public CaptchaException(string message, Exception inner)
            : base(message, inner) { }
    }
}
