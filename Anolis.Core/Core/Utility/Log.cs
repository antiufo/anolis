﻿using System;
using System.IO;
using System.Collections.ObjectModel;
using System.Text;

namespace Anolis.Core.Utility {
	
	public class Log : Collection<LogItem> {
		
		public void Add(LogSeverity severity, String message) {
			
			LogItem item = new LogItem(severity, message);
			
			this.Add( item );
		}
		
		public void Save(String path) {
			
			using(FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write))
			using(StreamWriter wtr = new StreamWriter(fs)) {
				
				foreach(LogItem item in this) {
					
					item.Write( wtr );
				}
				
			}
			
		}
		
	}
	
	public class LogItem {
		
		public LogItem(LogSeverity severity, String message) {
			
			TimeStamp = DateTime.Now;
			
			Severity = severity;
			Message  = message;
		}
		
		public LogItem(Exception ex, Anolis.Core.Packages.Operations.Operation op) {
			
			TimeStamp = DateTime.Now;
			
			Message  = "Exception: " + op.Name + " - " + op.Path;
			Severity = LogSeverity.Error;
			
			Exception = ex;
		}
		
		public DateTime    TimeStamp { get; private set; }
		public LogSeverity Severity  { get; private set; }
		public String      Message   { get; private set; }
		
		public Exception   Exception { get; private set; }
		
		public void Write(TextWriter wtr) {
			
			wtr.Write( TimeStamp.ToString("s") );
			wtr.Write(" - ");
			wtr.Write( Severity.ToString() );
			wtr.Write(" - ");
			wtr.WriteLine( Message );
			
			Exception ex = Exception;
			Int32 indent = 1;
			while(ex != null) {
				
				String indentString = "".PadRight( indent, '\t' );
				
				wtr.WriteLine( indentString + ex.Message );
				
				String[] stackTrace = ex.StackTrace.Replace("\r\n", "\n").Split('\n');
				
				foreach(String call in stackTrace) {
					
					// indent the stack trace at (indent + 1)
					wtr.Write( indentString + '\t' );
					wtr.WriteLine( call );
				}
				
				ex = ex.InnerException;
				
				indent++;
			}
			
		}
	}
	
	public enum LogSeverity {
		Fatal,
		Error,
		Warning,
		Info
	}
}
