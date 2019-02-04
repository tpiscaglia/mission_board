using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace mission_board_keyboard
{
	internal class RegexUtilities
	{
		private bool invalid = false;

		public bool IsValidEmail(string strIn)
		{
			invalid = false;
			if (string.IsNullOrEmpty(strIn))
			{
				return false;
			}
			try
			{
				strIn = Regex.Replace(strIn, "(@)(.+)$", DomainMapper, RegexOptions.None, TimeSpan.FromMilliseconds(200.0));
			}
			catch (RegexMatchTimeoutException)
			{
				return false;
			}
			if (invalid)
			{
				return false;
			}
			try
			{
				return Regex.IsMatch(strIn, "^(?(\")(\".+?(?<!\\\\)\"@)|(([0-9a-z]((\\.(?!\\.))|[-!#\\$%&'\\*\\+/=\\?\\^`\\{\\}\\|~\\w])*)(?<=[0-9a-z])@))(?(\\[)(\\[(\\d{1,3}\\.){3}\\d{1,3}\\])|(([0-9a-z][-\\w]*[0-9a-z]*\\.)+[a-z0-9][\\-a-z0-9]{0,22}[a-z0-9]))$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250.0));
			}
			catch (RegexMatchTimeoutException)
			{
				return false;
			}
		}

		private string DomainMapper(Match match)
		{
			IdnMapping idnMapping = new IdnMapping();
			string text = match.Groups[2].Value;
			try
			{
				text = idnMapping.GetAscii(text);
			}
			catch (ArgumentException)
			{
				invalid = true;
			}
			return match.Groups[1].Value + text;
		}
	}
}
