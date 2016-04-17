using System;
using System.IO;
using System.Diagnostics;

namespace Menu
{
	public class ExecCom
	{
		private String _command;

		public ExecCom (String Command)
		{
			if(Command != null) AppendCommand (Command);
		}

		public void AppendCommand (String Command)
		{
			this._command = Command + "\n";
		}

		public void RunExecCom()
		{
			Process pipe = new Process();
			string tmpScript = "/Desktop/cmd.sh"; 
			File.WriteAllText(tmpScript , _command); 
			pipe.StartInfo.FileName = "sh"; 
			pipe.StartInfo.Arguments = tmpScript; 
			pipe.Start(); 
		}
	}
}

