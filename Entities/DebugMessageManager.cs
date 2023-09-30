using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaModdingTool.Entities
{
	public enum DebugMessageLevel
	{
		Info,
		Warning,
		Error,
	}

	public class DebugMessageManager
	{
		private Stack<string> historyMessages = new Stack<string>();
		public event Action<string, DebugMessageLevel> MessageReceived;

		private static DebugMessageManager instance;
		public static DebugMessageManager Instance
		{
			get
			{
				if(instance == null)
					instance = new DebugMessageManager();
				return instance;
			}
		}

		public void AppendDebugMessage(string message, DebugMessageLevel level)
		{
			historyMessages.Push(message);
			MessageReceived?.Invoke(message, level);
		}
	}
}
