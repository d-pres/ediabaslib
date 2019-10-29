﻿using System;
using Android.Content;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace BmwDeepObd
{
    public class TraceInfoInputDialog : AlertDialog.Builder
    {
        private Android.App.Activity _activity;
        private AlertDialog _dialog;
        private View _view;
        private TextView _textViewMessage;
        private EditText _editTextEmailAddress;
        private EditText _editTextInfo;

        public string Message
        {
            get
            {
                if (_textViewMessage != null)
                {
                    return _textViewMessage.Text;
                }
                return string.Empty;
            }
            set
            {
                if (_textViewMessage != null)
                {
                    _textViewMessage.Text = value;
                }
            }
        }

        public string EmailAddress
        {
            get
            {
                if (_editTextEmailAddress != null)
                {
                    return _editTextEmailAddress.Text;
                }
                return string.Empty;
            }
            set
            {
                if (_editTextEmailAddress != null)
                {
                    _editTextEmailAddress.Text = value;
                }
            }
        }

        public string InfoText
        {
            get
            {
                if (_editTextInfo != null)
                {
                    return _editTextInfo.Text;
                }
                return string.Empty;
            }
            set
            {
                if (_editTextInfo != null)
                {
                    _editTextInfo.Text = value;
                }
            }
        }

        public TraceInfoInputDialog(Context context) : base(context)
        {
            LoadView(context);
        }

        public TraceInfoInputDialog(Context context, int themeResId) : base(context, themeResId)
        {
            LoadView(context);
        }

        protected void LoadView(Context context)
        {
            SetCancelable(false);
            _activity = context as Android.App.Activity;
            if (_activity != null)
            {
                _view = _activity.LayoutInflater.Inflate(Resource.Layout.trace_info, null);
                SetView(_view);

                _textViewMessage = _view.FindViewById<TextView>(Resource.Id.textViewMessage);
                _editTextEmailAddress = _view.FindViewById<EditText>(Resource.Id.editTextEmailAddress);
                _editTextInfo = _view.FindViewById<EditText>(Resource.Id.editTextInfo);
            }
        }

        public new void Show()
        {
            if (_dialog == null)
            {
                _dialog = base.Show();
            }
        }

        public new void SetMessage(string message)
        {
            Message = message;
        }

        public new void SetMessage(int messageId)
        {
            if (_activity != null)
            {
                Message = _activity.GetString(messageId);
            }
        }

        public void Dismiss()
        {
            _dialog?.Dismiss();
            _dialog = null;
        }
    }
}