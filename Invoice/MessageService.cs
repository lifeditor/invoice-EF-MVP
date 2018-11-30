using System.Windows.Forms;

namespace Invoice
{
    public interface IMessageService
    {
        void ShowMessage(string message);
        void ShowExclamation(string exclamation);
        void ShowError(string error);
        DialogResult ShowDialog(string message);
    }

    public class MessageService: IMessageService
    {
        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowExclamation(string exclamation)
        {
            MessageBox.Show(exclamation, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void ShowError(string error)
        {
            MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public DialogResult ShowDialog(string message)
        {
            return MessageBox.Show(message, "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
