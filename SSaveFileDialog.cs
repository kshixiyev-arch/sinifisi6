
namespace sinifisi6
{
    internal class SSaveFileDialog
    {
        public string Filter { get; internal set; }
        public string Title { get; internal set; }
        public string FileName { get; internal set; }

        internal DialogResult ShowDialog()
        {
            throw new NotImplementedException();
        }

        public static implicit operator SSaveFileDialog(SaveFileDialog v)
        {
            throw new NotImplementedException();
        }
    }
}