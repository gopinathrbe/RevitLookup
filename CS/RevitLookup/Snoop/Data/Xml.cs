using System.Windows.Forms;

namespace RevitLookup.Snoop.Data
{
	/// <summary>
	/// Snoop.Data class to hold and format a chunk of XML.
	/// </summary>

	public class Xml : Data
	{
		protected string m_val;
		protected bool m_isFileName = false;

		public Xml(string label, string val, bool isFileName)
		: base(label)
		{
			m_val = val;
			m_isFileName = isFileName;
		}

		public override string StrValue()
		{
			return m_val;
		}

		public override bool HasDrillDown
		{
			get
			{
				if (m_val == string.Empty)
					return false;
				else
					return true;
			}
		}

		public override void DrillDown()
		{
			try
			{
				System.Xml.XmlDocument xmlDoc = new System.Xml.XmlDocument();
				if (m_isFileName)
					xmlDoc.Load(m_val);
				else
					xmlDoc.LoadXml(m_val);

				RevitLookup.Xml.Forms.Dom form = new RevitLookup.Xml.Forms.Dom(xmlDoc);
				form.ShowDialog();
			}
			catch (System.Xml.XmlException e)
			{
				MessageBox.Show(e.Message, "XML Exception");
			}
		}
	}
}
