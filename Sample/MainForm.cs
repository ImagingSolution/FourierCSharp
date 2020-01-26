using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Numerics;  // System.Numericsへの参照が必要

namespace Sample
{
    public partial class MainForm : Form
    {
        private string appName = " - Fourier Transform";

        public Complex[] _complexSrc;   // 変換前データ
        public Complex[] _complexDst;   // 変換後データ

        private double _fourierDirection = 1.0; // フーリエ変換の向き（フーリエ変換 = 1.0: 逆フーリエ変換 = -1.0）   

        public MainForm()
        {
            InitializeComponent();
        }

        private void mnuFileLoadData_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV(*.csv;*.htm)|*.csv";

            if (ofd.ShowDialog() == DialogResult.Cancel) return;

            this.Text = System.IO.Path.GetFileName(ofd.FileName) + appName;

            // データの読み込み
            _complexSrc = LoadData(ofd.FileName);

            // フーリエ変換
            FourierCSharp.FourierTransform.Fourier(_complexSrc, ref _complexDst, _fourierDirection);

            // データの表示
            DrawGraph();

        }

        private void mnuFileSaveFourierData_Click(object sender, EventArgs e)
        {
            if (_complexDst == null) return;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV(*.csv;*.htm)|*.csv";

            if (sfd.ShowDialog() == DialogResult.Cancel) return;

            // 複素数データを保存する
            SaveComplexData(sfd.FileName, _complexDst);
        }

        /// <summary>
        /// 終了
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuFourierForward_Click(object sender, EventArgs e)
        {
            mnuFourierForward.Checked = true;
            mnuFourierBackward.Checked = false;
            _fourierDirection = 1.0;

            // フーリエ変換
            FourierCSharp.FourierTransform.Fourier(_complexSrc, ref _complexDst, _fourierDirection);
            // データの表示
            DrawGraph();
        }

        private void mnuFourierBackward_Click(object sender, EventArgs e)
        {
            mnuFourierForward.Checked = false;
            mnuFourierBackward.Checked = true;
            _fourierDirection = -1.0;

            // フーリエ変換
            FourierCSharp.FourierTransform.Fourier(_complexSrc, ref _complexDst, _fourierDirection);
            // データの表示
            DrawGraph();
        }


        private void mnuWindowHamming_Click(object sender, EventArgs e)
        {
            // ハミング窓
            FourierCSharp.FourierTransform.Hamming(_complexSrc);
            // フーリエ変換
            FourierCSharp.FourierTransform.Fourier(_complexSrc, ref _complexDst, _fourierDirection);
            // データの表示
            DrawGraph();
        }

        private void mnuWindowHanning_Click(object sender, EventArgs e)
        {
            // ハミング窓
            FourierCSharp.FourierTransform.Hanning(_complexSrc);
            // フーリエ変換
            FourierCSharp.FourierTransform.Fourier(_complexSrc, ref _complexDst, _fourierDirection);
            // データの表示
            DrawGraph();
        }

        private void mnuWindowBlackman_Click(object sender, EventArgs e)
        {
            // ブラックマン窓
            FourierCSharp.FourierTransform.Blackman(_complexSrc);
            // フーリエ変換
            FourierCSharp.FourierTransform.Fourier(_complexSrc, ref _complexDst, _fourierDirection);
            // データの表示
            DrawGraph();
        }


        private Complex[] LoadData(string filename)
        {
            var lines = System.IO.File.ReadAllLines(filename, Encoding.GetEncoding("shift_jis"));

            // 複素数配列の確保
            var dataList = new List<Complex>();

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] == "") continue;

                var lineData = lines[i].Split(',');
                if (lineData.Length == 1)
                {
                    // 実数のみの場合
                    dataList.Add(new Complex(double.Parse(lineData[0]), 0));
                }
                else
                {
                    // 実数、虚数がある場合
                    dataList.Add(new Complex(double.Parse(lineData[0]), double.Parse(lineData[1])));
                }
            }

            return dataList.ToArray();
        }

        private void SaveComplexData(string filename, Complex[] complex)
        {
            if (complex == null) return;

            using (var sw = new System.IO.StreamWriter(filename, false))
            {
                for (int i = 0; i < complex.Length; i++)
                {
                    sw.WriteLine($"{complex[i].Real}, {complex[i].Imaginary}");
                }
            }
        }

        /// <summary>
        /// グラフとデータの表示
        /// </summary>
        private void DrawGraph()
        {
            // 変換前データのグラフ描画
            DrawRealData(_complexSrc);
            // 変換前データの表示
            SetDataGridViewData(dgvchtData, _complexSrc);

            // 変換後データのグラフ描画
            DrawMagnitudeData(_complexDst);
            // 変換後データの表示
            SetDataGridViewData(dgvFourier, _complexDst);
        }

        /// <summary>
        /// データ（主にＦｏｕｒｉｅｒ変換前のデータ）の実数成分をグラフ表示します。
        /// </summary>
        /// <param name="data"></param>
        private void DrawRealData(Complex[] data)
        {
            // /////////////////////////////////////////////////////
            // Chartコントロール内のグラフ、凡例、目盛り領域を削除
            chtData.Series.Clear();
            chtData.Legends.Clear();
            chtData.ChartAreas.Clear();
            chtData.Titles.Clear();

            // /////////////////////////////////////////////////////
            // 目盛り領域の設定
            var ca = chtData.ChartAreas.Add("Data");
            chtData.Titles.Add("Input Data");

            // X軸
            ca.AxisX.Title = "Index";  // タイトル
            ca.AxisX.Minimum = 0;         // 最大値
            ca.AxisX.Maximum = data.Length;         // 最大値
                                            // Y軸
            ca.AxisY.Title = "Data";

            // 虚部の描画
            // グラフの系列を追加
            var seriesIm = chtData.Series.Add("Imaginary");
            // グラフの種類を折れ線に設定する
            seriesIm.ChartType
                = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            // 線幅
            seriesIm.BorderWidth = 3;
            seriesIm.Color = Color.HotPink;

            // データ設定
            for (int i = 0; i < data.Length; i++)
            {
                seriesIm.Points.AddXY(i, data[i].Imaginary);
            }

            // 実部の描画
            // グラフの系列を追加
            var seriesRe = chtData.Series.Add("Real");
            // グラフの種類を折れ線に設定する
            seriesRe.ChartType
                = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            // 線幅
            seriesRe.BorderWidth = 3;
            seriesRe.Color = Color.DodgerBlue;
            
            // データ設定
            for (int i = 0; i < data.Length; i++)
            {
                seriesRe.Points.AddXY(i, data[i].Real);
            }

        }

        /// <summary>
        /// データ（主にＦｏｕｒｉｅｒ変換後のデータ）の大きさをグラフ表示します。
        /// </summary>
        /// <param name="data">複素数の配列</param>
        private void DrawMagnitudeData(Complex[] data)
        {
            // /////////////////////////////////////////////////////
            // Chartコントロール内のグラフ、凡例、目盛り領域を削除
            chtFourier.Series.Clear();
            chtFourier.Legends.Clear();
            chtFourier.ChartAreas.Clear();
            chtFourier.Titles.Clear();

            // /////////////////////////////////////////////////////
            // 目盛り領域の設定
            var ca = chtFourier.ChartAreas.Add("Fourier");

            chtFourier.Titles.Add("Fourier Transform");

            // X軸
            ca.AxisX.Title = "Frequency";  // タイトル
            ca.AxisX.Minimum = 0;           // 最小値0
            ca.AxisX.Maximum = data.Length;         // 最大値
            
            // Y軸
            ca.AxisY.Title = "Magnitude";
            ca.AxisY.Minimum = 0;

            // グラフの系列を追加
            var s = chtFourier.Series.Add("Data");
            // 棒グラフの隙間を小さくする
            s.SetCustomProperty("PointWidth", "0.9");

            // データ設定
            double mag;
            for (int i = 0; i < data.Length; i++)
            {
                mag = data[i].Magnitude;
                s.Points.AddXY(i, mag);
            }
        }

        /// <summary>
        /// データ表示の設定
        /// </summary>
        /// <param name="dgv">表示するDataGridView</param>
        /// <param name="data">複素数のデータ</param>
        private void SetDataGridViewData(DataGridView dgv, Complex[] data)
        {
            // データ削除
            dgv.Rows.Clear();

            dgv.RowHeadersVisible = false;  // 先頭の列の非表示
            dgv.ColumnCount = 5;            // 列数
            dgv.ReadOnly = true;            // セルの編集不可
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;    // ヘッダ行の色

            dgv.Columns[0].HeaderText = "Index";
            dgv.Columns[1].HeaderText = "Real";
            dgv.Columns[2].HeaderText = "Imaginary";
            dgv.Columns[3].HeaderText = "Magnitude";
            dgv.Columns[4].HeaderText = "Phase";

            for (int i = 0; i < data.Length; i++)
            {
                dgv.Rows.Add(i, data[i].Real, data[i].Imaginary, data[i].Magnitude, data[i].Phase);
            }

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // 列の幅の自動調整
        }


    }
}
