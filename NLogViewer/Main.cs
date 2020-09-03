using CommonWrapper;
using NLogViewer.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NLogViewer
{
    public partial class Main : Form
    {
        #region ===PROPERTIES===

        private List<Data> datas;

        private bool isCanceled;

        #endregion

        public Main()
        {
            InitializeComponent();

            formSkinMain.Text = $"{Application.ProductName} 0.1";

            datas = new List<Data>();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                Task.Run(() => initialize());
            }
            catch (Exception ex)
            {
                updateStatus(ex: ex);
            }
        }

        private void FlatButtonStop_Click(object sender, EventArgs e)
        {
            updateStatus("Завершение работы");

            isCanceled = true;
        }

        private void FlatButtonPath_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogMain.Filter = "logs |*.log";

                if (openFileDialogMain.ShowDialog() == DialogResult.OK)
                {
                    flatTextBoxPath.Text = openFileDialogMain.FileName;

                    doWork(flatTextBoxPath.Text);
                }
            }
            catch (Exception ex)
            {
                updateStatus(ex: ex);
            }
        }

        private void FlatCheckBoxIsDebug_CheckedChanged(object sender)
        {
            Properties.Settings.Default.IsDebug = flatCheckBoxIsDebug.Checked;
            Properties.Settings.Default.Save();

            refreshDatas(datas.ToList());
        }

        private void FlatCheckBoxIsInfo_CheckedChanged(object sender)
        {
            Properties.Settings.Default.IsInfo = flatCheckBoxIsInfo.Checked;
            Properties.Settings.Default.Save();

            refreshDatas(datas.ToList());
        }

        private void FlatCheckBoxIsWarn_CheckedChanged(object sender)
        {
            Properties.Settings.Default.IsWarn = flatCheckBoxIsWarn.Checked;
            Properties.Settings.Default.Save();

            refreshDatas(datas.ToList());
        }

        private void FlatCheckBoxIsError_CheckedChanged(object sender)
        {
            Properties.Settings.Default.IsError = flatCheckBoxIsError.Checked;
            Properties.Settings.Default.Save();

            refreshDatas(datas.ToList());
        }

        private void FlatCheckBoxIsFatal_CheckedChanged(object sender)
        {
            Properties.Settings.Default.IsFatal = flatCheckBoxIsFatal.Checked;
            Properties.Settings.Default.Save();

            refreshDatas(datas.ToList());
        }

        private void FlatCheckBoxIsGroup_CheckedChanged(object sender)
        {
            Properties.Settings.Default.IsGroup = flatCheckBoxIsGroup.Checked;
            Properties.Settings.Default.Save();

            refreshDatas(datas.ToList());
        }

        private void DataGridViewDatas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            DataGridViewImageColumn column = null;
            DataGridViewCheckBoxColumn columnCheckBox = null;

            if (e.ColumnIndex != -1)
            {
                column = senderGrid.Columns[e.ColumnIndex] as DataGridViewImageColumn;
                columnCheckBox = senderGrid.Columns[e.ColumnIndex] as DataGridViewCheckBoxColumn;
            }

            if (e.RowIndex != -1)
            {
                try
                {
                    int id = int.Parse(senderGrid[nameof(Data.Id), e.RowIndex].Value.ToString());

                    var data = datas.FirstOrDefault(x => x.Id == id);

                    // отобразить детальную инфу
                    flatTextBoxDetails.Text = data.Message;
                }
                catch (Exception ex)
                {
                    updateStatus(ex: ex);
                }
            }
        }

        #region ===PRIVATE===

        /// <summary>
        /// поиск в папке лог файлов и обработка 
        /// </summary>
        private void doWork(string path)
        {
            datas = new List<Data>();

            try
            {
                Data data = null;

                var lines = File.ReadAllLines(path, Encoding.GetEncoding(1251));
                foreach (var line in lines)
                {
                    var dataType = getDataType(line);
                    if (dataType != Data.DataTypes.NONE)
                    {
                        if (data == null)
                        {
                            data = new Data();
                            data.Id = datas.Count + 1;
                            data.DataType = dataType;
                            data.Value = line;
                        }
                        else
                        {
                            datas.Add(data);

                            data = new Data();
                            data.Id = datas.Count + 1;
                            data.DataType = dataType;
                            data.Value = line;
                        }
                    }
                    else
                    {
                        data.Value += Environment.NewLine + line;
                    }
                }

                datas.Add(data);

                refreshDatas(datas);
            }
            catch (Exception ex)
            {
                updateStatus(ex: ex);
            }
            finally
            {
                enable();
            }
        }

        /// <summary>
        /// определить тип
        /// </summary>
        /// <param name="log"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        private Data.DataTypes getDataType(string text)
        {
            Data.DataTypes result = Data.DataTypes.NONE;

            if (text.Contains(Data.DataTypes.DEBUG.ToString(), StringComparison.Ordinal))
                result = Data.DataTypes.DEBUG;
            else if (text.Contains(Data.DataTypes.INFO.ToString(), StringComparison.Ordinal))
                result = Data.DataTypes.INFO;
            else if (text.Contains(Data.DataTypes.WARN.ToString(), StringComparison.Ordinal))
                result = Data.DataTypes.WARN;
            else if (text.Contains(Data.DataTypes.ERROR.ToString(), StringComparison.Ordinal))
                result = Data.DataTypes.ERROR;
            else if (text.Contains(Data.DataTypes.FATAL.ToString(), StringComparison.Ordinal))
                result = Data.DataTypes.FATAL;

            return result;
        }

        private void enable()
        {
            formSkinMain.Invoke((MethodInvoker)delegate
            {
                //flatButtonStart.Enabled = true;

                //flatButtonStop.Enabled = false;
            });
        }

        private void disable()
        {
            formSkinMain.Invoke((MethodInvoker)delegate
            {
                //flatButtonStart.Enabled = false;

                //flatButtonStop.Enabled = true;
            });
        }

        private void updateStatus(string text = "", Exception ex = null)
        {
            flatStatusBarMain.Invoke((MethodInvoker)delegate
            {
                flatStatusBarMain.MyTextColor = ex != null ? Brushes.LightPink : Brushes.White;
                flatStatusBarMain.Text = ex != null ? ex.Message : text;
            });
        }

        private List<Data> filterDatas(List<Data> list)
        {
            List<Data> result = new List<Data>();

            if (Properties.Settings.Default.IsDebug)
                result.AddRange(list.Where(x => x.DataType == Data.DataTypes.DEBUG));

            if (Properties.Settings.Default.IsInfo)
                result.AddRange(list.Where(x => x.DataType == Data.DataTypes.INFO));

            if (Properties.Settings.Default.IsWarn)
                result.AddRange(list.Where(x => x.DataType == Data.DataTypes.WARN));

            if (Properties.Settings.Default.IsError)
                result.AddRange(list.Where(x => x.DataType == Data.DataTypes.ERROR));

            if (Properties.Settings.Default.IsFatal)
                result.AddRange(list.Where(x => x.DataType == Data.DataTypes.FATAL));

            if (Properties.Settings.Default.IsGroup)
                result = result.GroupBy(x => x.Exception).Select(x => x.First()).ToList();

            return result.OrderBy(x => x.Line).ToList();
        }

        #endregion

        #region ===INIT===

        private void initialize()
        {
            try
            {
                formSkinMain.Invoke((MethodInvoker)delegate
                {
                    flatCheckBoxIsDebug.Checked = Properties.Settings.Default.IsDebug;
                    flatCheckBoxIsInfo.Checked = Properties.Settings.Default.IsInfo;
                    flatCheckBoxIsWarn.Checked = Properties.Settings.Default.IsWarn;
                    flatCheckBoxIsError.Checked = Properties.Settings.Default.IsError;
                    flatCheckBoxIsFatal.Checked = Properties.Settings.Default.IsFatal;
                    flatCheckBoxIsGroup.Checked = Properties.Settings.Default.IsGroup;
                });

                initDatas();
            }
            catch (Exception ex)
            {
                updateStatus(ex: ex);
            }
        }

        private void initDatas()
        {
            formSkinMain.Invoke((MethodInvoker)delegate
            {
                dataGridViewDatas.DataGridView_Init(ControlExtensions.DataGridStyles.MonoFlatDark);
                dataGridViewDatas.DataSource = new List<Data>();

                foreach (DataGridViewColumn column in dataGridViewDatas.Columns)
                {
                    string description = ControlExtensions.GetDescription<Data>(column.Name);
                    if (!String.IsNullOrEmpty(description))
                    {
                        column.HeaderText = description;

                        switch (column.Name)
                        {
                            case nameof(Data.Line):
                                column.Width = 90;
                                break;

                            case nameof(Data.DataType):
                                column.Width = 90;
                                break;

                            case nameof(Data.Exception):
                                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                break;

                            case nameof(Data.Date):
                                column.Width = 185;
                                column.DefaultCellStyle.Format = "dd.MM.yyyy HH:mm:ss";
                                break;

                            default:
                                column.Visible = false;
                                break;
                        }
                    }
                    else
                        column.Visible = false;
                }
            });
        }

        #endregion

        #region ===REFRESH===

        private void refreshDatas(List<Data> list)
        {
            dataGridViewDatas.Invoke((MethodInvoker)delegate
            {
                list = filterDatas(list);
                dataGridViewDatas.DataSource = list;

                tabPageDetails.Text = $"Детально | {list.Count}";
            });
        }

        #endregion
    }
}
