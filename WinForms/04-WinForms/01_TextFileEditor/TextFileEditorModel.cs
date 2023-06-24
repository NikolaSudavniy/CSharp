using System;
using System.IO;

namespace TextFileEditor
{
    public interface ITextFileEditorModel
    {
        bool IsNew { get; set; }
        string FileName { get; set; }
        string OpenFile(string fileName);
        bool SaveInTheSameFile(string context);
    }

    public class TextFileEditorModel
    {
        public string FileName { get; set; } = string.Empty;
        public bool IsNew { get; set; } = true;
        public string Buffer { get; set; } = null;
        public string PrevStateText { get; set; } = null;

        public bool OpenFile(string fileName, out string text)
        {
            FileName = fileName;
            IsNew = false;
            PrevStateText = null;
            text = null;

            try
            {
                using (var filereaqder = File.OpenText(fileName))
                    text = filereaqder.ReadToEnd();
            }
            catch (FileNotFoundException)
            {
                return false;
            }
            catch (Exception ex)
            {
                LogExceptionData(ex);
                return false;
            }

            return true;
        }

        public void NewDoc()
        {
            FileName = string.Empty;
            IsNew = true;
            PrevStateText = null;
        }

        /// <summary>
        /// Save context in the file saved in Model property
        /// </summary>
        /// <param name="context">string to write in the file</param>
        /// <returns></returns>
        public bool Save(string context)
        {
            return Save(context, FileName);
        }

        /// <summary>
        /// Save context in new file.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="fileName">Name of new file</param>
        /// <returns>If file is null or too short or an exception is happened - method returns false.
        /// Returns true if context is successfully saved/</returns>
        public bool Save(string context, string fileName)
        {
            if (fileName == null || fileName.Length == 0)
                return false;

            try
            {
                File.WriteAllText(fileName, context);
                FileName = fileName;
            }
            catch (Exception ex)
            {
                LogExceptionData(ex);
                return false;
            }

            return true;
        }

        private void LogExceptionData(Exception ex)
        {
            using (StreamWriter writer = new StreamWriter("..\\..\\Exception.txt", true))
            {
                writer.WriteLine("---------------------------------------------------------"
                    + "Date : " + DateTime.Now.ToString() + "\n");

                while (ex != null)
                {
                    writer.WriteLine(ex.GetType().FullName
                        + "\nMessage : " + ex.Message
                        + "\nStackTrace : " + ex.StackTrace);
                }
            }
        }
    }
}
