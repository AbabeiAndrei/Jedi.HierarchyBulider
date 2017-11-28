using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jedi.HierarchyBuilder.Logging
{
    public class Logger : ILog
    {
        #region Fields

        private readonly LogWriter _writer;
        private bool _autoInsertDateTime;

        #endregion

        #region Properties

        public virtual bool AutoInsertDateTime
        {
            get
            {
                return _autoInsertDateTime;
            }
            set
            {
                _autoInsertDateTime = value;
            }
        }

        public virtual string LastLogMessage { get; protected set; }
        
        #endregion

        #region Constructors

        private Logger()
        {
            _autoInsertDateTime = true;
        }

        public Logger(LogWriter writer)
            : this()
        {
            _writer = writer;
        }

        #endregion

        #region Public methods

        public virtual void Write(string log)
        {
            LastLogMessage = log;
            _writer?.Invoke(CreateLogMessage(log));
        }

        #endregion

        #region Private methods

        private string CreateLogMessage(string log)
        {
            if (AutoInsertDateTime)
                return DateTime.Now.ToString("G", CultureInfo.CurrentCulture) + " > " + log;

            return log;
        }

        #endregion
    }
}
