using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Insurance.Domain.Code;

namespace SV.Domain.Code
{
    
    // writes log events to the Windows event log.
    // ** Design Pattern: Observer.

    public class ObserverLogToEventlog : ILog
    {
        public void Log(object sender, LogEventArgs e)
        {
            string message = "[" + e.Date.ToString() + "] " +
                e.SeverityString + ": " + e.Message;

            var eventLog = new EventLog();
          

            // map severity level to an Windows EventLog entry type

            var type = EventLogEntryType.Error;
			if(e.Severity < LogSeverity.Warning) 
				type = EventLogEntryType.Information;
			else if(e.Severity < LogSeverity.Error) 
				type = EventLogEntryType.Warning;

            // in try catch. You will need proper privileges to write to eventlog

            try { eventLog.WriteEntry(message, type); }
            catch { /* do nothing */ }
        }
    }
}
