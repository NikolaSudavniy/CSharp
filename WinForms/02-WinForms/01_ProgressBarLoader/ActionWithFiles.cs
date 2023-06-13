using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ProgressBarLoader
{
    public abstract class ActionWithFiles
    {
        public abstract void Do(ref List<byte> dataList, string fileName);
    }

    public class ActionWithByteFile : ActionWithFiles
    {
        public override void Do(ref List<byte> dataList, string fileName)
        {
            MessageBox.Show("Byte file", fileName);
        }
    }

    public class ActionWithTextFile : ActionWithFiles
    {
        public override void Do(ref List<byte> dataList, string fileName)
        {
            if (dataList.Count > 1000)
            {
                MessageBox.Show("Text file", fileName);
                return;
            }

            var data = new StringBuilder();

            for (int i = 0; i < dataList.Count; i++)
                data.Insert(data.Length, (char)dataList[i]);

            MessageBox.Show(data.ToString(), fileName);
        }
    }
}
