using System.Windows.Forms;

namespace BadProcessHunter.Classes
{
	public class ErrorPopup
	{
		private static ToolTip ErrorToolTip;

		private static Control ErrorControl;

		private static string ErrorMessage;

		public static void SetError(Control control, string message)
		{
			ErrorControl = control;
			ErrorMessage = message;
		}

		public static void ShowPopup()
		{
			ErrorToolTip.Active = false;
			ErrorToolTip.Show("", ErrorControl);
			ErrorToolTip.Active = true;
			ErrorToolTip.Show(ErrorMessage, ErrorControl, 2000);
		}

		static ErrorPopup()
		{
			ErrorToolTip = new ToolTip();
			ErrorToolTip.ToolTipIcon = ToolTipIcon.Error;
			ErrorToolTip.ToolTipTitle = "Ошибка";
			ErrorToolTip.IsBalloon = true;
		}
	}
}
