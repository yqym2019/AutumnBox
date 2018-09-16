﻿using System;

namespace AutumnBox.GUI.Util.Debugging
{
    public static class SLogger
    {
        private const string NULL_SENDER_OR_TAG = "UnknowClass";
        public static void Debug(object senderOrTag, object content)
        {
            LoggingStation.Instance.Log(senderOrTag?.ToString() ?? NULL_SENDER_OR_TAG, nameof(Debug), content);
        }
        public static void Info(object senderOrTag, object content)
        {
            LoggingStation.Instance.Log(senderOrTag?.ToString() ?? NULL_SENDER_OR_TAG, nameof(Debug), content);
        }
        public static void Warn<TSender>(object senderOrTag, object content)
        {
            LoggingStation.Instance.Log(senderOrTag?.ToString() ?? NULL_SENDER_OR_TAG, nameof(Warn), content);
        }
        public static void Warn<TSender>(object senderOrTag, object content, Exception ex)
        {
            LoggingStation.Instance.Log(senderOrTag?.ToString() ?? NULL_SENDER_OR_TAG, nameof(Warn), content, ex);
        }
        public static void Fatal<TSender>(object senderOrTag, object content)
        {
            LoggingStation.Instance.Log(senderOrTag?.ToString() ?? NULL_SENDER_OR_TAG, nameof(Fatal), content);
        }
    }
}