﻿using Nikse.SubtitleEdit.Core;
using Nikse.SubtitleEdit.Core.SubtitleFormats;
using Nikse.SubtitleEdit.Forms;
using System.Windows.Forms;

namespace Nikse.SubtitleEdit.Logic
{
    public class UiEbuSaveHelper : Ebu.IEbuUiHelper
    {

        private Ebu.EbuGeneralSubtitleInformation _header;
        private byte _justificationCode;
        private string _fileName;
        private Subtitle _subtitle;

        public void Initialize(Ebu.EbuGeneralSubtitleInformation header, byte justificationCode, string fileName, Subtitle subtitle)
        {
            _header = header;
            _justificationCode = justificationCode;
            _fileName = fileName;
            _subtitle = subtitle;            
        }

        public bool ShowDialogOk()
        {
            using (var saveOptions = new EbuSaveOptions())
            {
                saveOptions.Initialize(_header, _justificationCode, _fileName, _subtitle);
                return saveOptions.ShowDialog() == DialogResult.OK;
            }
        }

        public byte JustificationCode
        {
            get { return _justificationCode; } 
            set { _justificationCode = value; }
        }

    }
}
