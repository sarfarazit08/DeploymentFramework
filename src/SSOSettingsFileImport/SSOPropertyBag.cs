using System;
using System.Collections;
using Microsoft.BizTalk.SSOClient.Interop;

namespace SSOSettingsFileManager
{
	/// <summary>
	/// IPropertyBag storage for SSO info
	/// </summary>
	internal class SSOPropertyBag : IPropertyBag
	{
		Hashtable m_Properties = new Hashtable();

		#region IPropertyBag Members

		/// <summary>
		/// Writes the specified name of the prop.
		/// </summary>
		/// <param name="propName">Name of the prop.</param>
		/// <param name="ptrVar">PTR var.</param>
		public void Write(string propName, ref object ptrVar)
		{
			m_Properties[propName] = ptrVar;
		}

		/// <summary>
		/// Reads the specified name of the prop.
		/// </summary>
		/// <param name="propName">Name of the prop.</param>
		/// <param name="ptrVar">PTR var.</param>
		/// <param name="errorLog">Error log.</param>
		public void Read(string propName, out object ptrVar, int errorLog)
		{
			ptrVar = m_Properties[propName];
		}

		#endregion
	}
}