using CommonHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogViewer.Domain
{
    /// <summary>
    /// данные лога
    /// </summary>
    public class Data
    {
        public int Id { get; set; }

        [Description("Line #")]
        public int Line
        {
            get
            {
                int result = -1;

                if (!this.Value.IsNullOrEmpty() && this.Value.Contains("строка"))
                {
                    int index = this.Value.LastIndexOf("строка");
                    if (index != -1)
                    {
                        string value = this.Value.Substring(index, this.Value.Length - index);
                        value = value.Replace("строка", "");

                        result = value.ParseInt().Value;
                    }
                }

                return result;
            }
        }

        [Description("Type")]
        public DataTypes DataType { get; set; }

        //[Description("Class")]
        //public string ClassName
        //{
        //    get
        //    {
        //        string result = String.Empty;

        //        string[] splits = this.Value.Split(" ");
        //        if (splits.Length > 3)
        //            result = splits[4];

        //        return result;
        //    }
        //}

        [Description("Exception")]
        public string Exception
        {
            get
            {
                string result = String.Empty;

                if (!this.Value.IsNullOrEmpty())
                {
                    var lines = this.Value.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);
                    if (lines.Any())
                    {
                        var line = lines.FirstOrDefault();

                        line = line.Replace(this.Date, "").Trim();

                        var _lines = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                        if (_lines.Any())
                            result = line.Replace(_lines[0], "");
                    }
                }

                return result;
            }
        }

        [Description("Date")]
        public string Date
        {
            get
            {
                string result = String.Empty;

                string[] splits = this.Value.Split(" ");
                if (splits.Length > 1)
                    result = string.Format("{0} {1}", splits[0], splits[1]);

                return result;
            }
        }

        /// <summary>
        /// текст ошибки
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// чисто сообщение
        /// </summary>
        public string Message
        {
            get
            {
                string result = String.Empty;

                if (this.DataType != DataTypes.INFO && this.DataType != DataTypes.WARN)
                {
                    string text = this.Value.Replace(this.Date, "").Trim();

                    int index = text.IndexOf('-');
                    index += 2;
                    result = text.Substring(index, text.Length - index);
                }

                return result;
            }
        }

        public enum DataTypes { NONE, DEBUG, INFO, WARN, ERROR, FATAL }

        public Data()
        {

        }
    }
}
