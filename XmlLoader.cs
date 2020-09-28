using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace XmlLoader
{
	public class XmlObjectLoader
	{
		protected string modPath;
		protected XmlDocument doc;

		public XmlObjectLoader(string path)
		{
			modPath = path;
		}

		public virtual bool Load<T>(out T xmlData)
		{
			try
			{
				XmlSerializer xr = new XmlSerializer(typeof(T));
				FileStream stream = new FileStream(modPath, FileMode.Open, FileAccess.Read);
				xmlData = (T)xr.Deserialize(stream);
				stream.Close();
				return true;
			}
			catch (Exception ex)
			{
				xmlData = default(T);
				return false;
			}
		}

		public bool Save<T>(T xmlData)
		{
			try
			{
				XmlSerializer xr = new XmlSerializer(typeof(T));
				var stream = File.Create(modPath);
				xr.Serialize(stream, xmlData);
				stream.Close();
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}
	}
}
