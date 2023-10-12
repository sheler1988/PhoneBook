namespace MyApplication;

public partial class StartupForm : Infrastructure.BaseForm
{
	public StartupForm()
	{
		InitializeComponent();
	}

	private void StartupForm_Load(object sender, System.EventArgs e)
	{
		Persistence.DatabaseContext? databaseContext = null;

		try
		{
			databaseContext =
				new Persistence.DatabaseContext();

			// با آن کار می‌کنیم
		}
		catch (System.Exception ex)
		{
			// Log

			//var errorMessage =
			//	$"خطای ناشناخته‌ای صورت گرفته است، لطفا با تیم پشتیبانی تماس حاصل فرمایدد!";

			var errorMessage =
				$"Error Message: {ex.Message}";

			System.Windows.Forms.MessageBox.Show(text: errorMessage);
		}
		finally
		{
			//if (databaseContext != null)
			//{
			//	databaseContext.Dispose();
			//	databaseContext = null;
			//}

			//if (databaseContext != null)
			//{
			//	databaseContext.Dispose();
			//}

			databaseContext?.Dispose();
		}
	}
}
