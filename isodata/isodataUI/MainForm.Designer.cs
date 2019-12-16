namespace isodata
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusTb = new System.Windows.Forms.RichTextBox();
            this.zgc = new ZedGraph.ZedGraphControl();
            this.pointsDgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KTb = new MetroFramework.Controls.MetroTextBox();
            this.kLbl = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tetanTb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tetacTb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tetasTb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.ITb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.lowerkTb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.LTb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.NcTb = new MetroFramework.Controls.MetroTextBox();
            this.startBtn = new MetroFramework.Controls.MetroButton();
            this.parCb = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.KaTb = new MetroFramework.Controls.MetroLabel();
            this.tetanaTb = new MetroFramework.Controls.MetroLabel();
            this.tetasaTb = new MetroFramework.Controls.MetroLabel();
            this.tetacaTb = new MetroFramework.Controls.MetroLabel();
            this.NcaTb = new MetroFramework.Controls.MetroLabel();
            this.LaTb = new MetroFramework.Controls.MetroLabel();
            this.lowerkaTb = new MetroFramework.Controls.MetroLabel();
            this.IaTb = new MetroFramework.Controls.MetroLabel();
            this.addPointBox = new System.Windows.Forms.GroupBox();
            this.addXTb = new MetroFramework.Controls.MetroTextBox();
            this.addYTb = new MetroFramework.Controls.MetroTextBox();
            this.addBtn = new MetroFramework.Controls.MetroButton();
            this.fileBtn = new MetroFramework.Controls.MetroButton();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pointsDgv)).BeginInit();
            this.addPointBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusTb
            // 
            this.statusTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusTb.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusTb.ForeColor = System.Drawing.Color.Black;
            this.statusTb.Location = new System.Drawing.Point(190, 399);
            this.statusTb.Name = "statusTb";
            this.statusTb.ReadOnly = true;
            this.statusTb.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.statusTb.Size = new System.Drawing.Size(727, 207);
            this.statusTb.TabIndex = 1;
            this.statusTb.Text = "";
            this.statusTb.TextChanged += new System.EventHandler(this.statusTb_TextChanged);
            // 
            // zgc
            // 
            this.zgc.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zgc.IsAutoScrollRange = true;
            this.zgc.IsShowContextMenu = false;
            this.zgc.IsShowPointValues = true;
            this.zgc.Location = new System.Drawing.Point(190, 66);
            this.zgc.Name = "zgc";
            this.zgc.ScrollGrace = 0D;
            this.zgc.ScrollMaxX = 0D;
            this.zgc.ScrollMaxY = 0D;
            this.zgc.ScrollMaxY2 = 0D;
            this.zgc.ScrollMinX = 0D;
            this.zgc.ScrollMinY = 0D;
            this.zgc.ScrollMinY2 = 0D;
            this.zgc.Size = new System.Drawing.Size(727, 319);
            this.zgc.TabIndex = 2;
            // 
            // pointsDgv
            // 
            this.pointsDgv.AllowUserToAddRows = false;
            this.pointsDgv.AllowUserToDeleteRows = false;
            this.pointsDgv.AllowUserToResizeColumns = false;
            this.pointsDgv.AllowUserToResizeRows = false;
            this.pointsDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pointsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pointsDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.pointsDgv.Location = new System.Drawing.Point(23, 66);
            this.pointsDgv.Name = "pointsDgv";
            this.pointsDgv.ReadOnly = true;
            this.pointsDgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pointsDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.pointsDgv.RowHeadersWidth = 60;
            this.pointsDgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.pointsDgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.pointsDgv.Size = new System.Drawing.Size(143, 193);
            this.pointsDgv.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "X";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 40;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Y";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 40;
            // 
            // KTb
            // 
            // 
            // 
            // 
            this.KTb.CustomButton.Image = null;
            this.KTb.CustomButton.Location = new System.Drawing.Point(14, 1);
            this.KTb.CustomButton.Name = "";
            this.KTb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.KTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.KTb.CustomButton.TabIndex = 1;
            this.KTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.KTb.CustomButton.UseSelectable = true;
            this.KTb.CustomButton.Visible = false;
            this.KTb.Lines = new string[] {
        "3"};
            this.KTb.Location = new System.Drawing.Point(54, 399);
            this.KTb.MaxLength = 32767;
            this.KTb.Name = "KTb";
            this.KTb.PasswordChar = '\0';
            this.KTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.KTb.SelectedText = "";
            this.KTb.SelectionLength = 0;
            this.KTb.SelectionStart = 0;
            this.KTb.ShortcutsEnabled = true;
            this.KTb.Size = new System.Drawing.Size(36, 23);
            this.KTb.TabIndex = 4;
            this.KTb.Text = "3";
            this.KTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.KTb.UseSelectable = true;
            this.KTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.KTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // kLbl
            // 
            this.kLbl.AutoSize = true;
            this.kLbl.Location = new System.Drawing.Point(20, 399);
            this.kLbl.Name = "kLbl";
            this.kLbl.Size = new System.Drawing.Size(19, 19);
            this.kLbl.TabIndex = 5;
            this.kLbl.Text = "K:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(20, 429);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(30, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Θn:";
            // 
            // tetanTb
            // 
            // 
            // 
            // 
            this.tetanTb.CustomButton.Image = null;
            this.tetanTb.CustomButton.Location = new System.Drawing.Point(14, 1);
            this.tetanTb.CustomButton.Name = "";
            this.tetanTb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tetanTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tetanTb.CustomButton.TabIndex = 1;
            this.tetanTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tetanTb.CustomButton.UseSelectable = true;
            this.tetanTb.CustomButton.Visible = false;
            this.tetanTb.Lines = new string[] {
        "1"};
            this.tetanTb.Location = new System.Drawing.Point(54, 429);
            this.tetanTb.MaxLength = 32767;
            this.tetanTb.Name = "tetanTb";
            this.tetanTb.PasswordChar = '\0';
            this.tetanTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tetanTb.SelectedText = "";
            this.tetanTb.SelectionLength = 0;
            this.tetanTb.SelectionStart = 0;
            this.tetanTb.ShortcutsEnabled = true;
            this.tetanTb.Size = new System.Drawing.Size(36, 23);
            this.tetanTb.TabIndex = 6;
            this.tetanTb.Text = "1";
            this.tetanTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tetanTb.UseSelectable = true;
            this.tetanTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tetanTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(20, 489);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(29, 19);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Θc:";
            // 
            // tetacTb
            // 
            // 
            // 
            // 
            this.tetacTb.CustomButton.Image = null;
            this.tetacTb.CustomButton.Location = new System.Drawing.Point(14, 1);
            this.tetacTb.CustomButton.Name = "";
            this.tetacTb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tetacTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tetacTb.CustomButton.TabIndex = 1;
            this.tetacTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tetacTb.CustomButton.UseSelectable = true;
            this.tetacTb.CustomButton.Visible = false;
            this.tetacTb.Lines = new string[] {
        "3"};
            this.tetacTb.Location = new System.Drawing.Point(54, 489);
            this.tetacTb.MaxLength = 32767;
            this.tetacTb.Name = "tetacTb";
            this.tetacTb.PasswordChar = '\0';
            this.tetacTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tetacTb.SelectedText = "";
            this.tetacTb.SelectionLength = 0;
            this.tetacTb.SelectionStart = 0;
            this.tetacTb.ShortcutsEnabled = true;
            this.tetacTb.Size = new System.Drawing.Size(36, 23);
            this.tetacTb.TabIndex = 10;
            this.tetacTb.Text = "3";
            this.tetacTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tetacTb.UseSelectable = true;
            this.tetacTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tetacTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(20, 459);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(28, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Θs:";
            // 
            // tetasTb
            // 
            // 
            // 
            // 
            this.tetasTb.CustomButton.Image = null;
            this.tetasTb.CustomButton.Location = new System.Drawing.Point(14, 1);
            this.tetasTb.CustomButton.Name = "";
            this.tetasTb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tetasTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tetasTb.CustomButton.TabIndex = 1;
            this.tetasTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tetasTb.CustomButton.UseSelectable = true;
            this.tetasTb.CustomButton.Visible = false;
            this.tetasTb.Lines = new string[] {
        "1"};
            this.tetasTb.Location = new System.Drawing.Point(54, 459);
            this.tetasTb.MaxLength = 32767;
            this.tetasTb.Name = "tetasTb";
            this.tetasTb.PasswordChar = '\0';
            this.tetasTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tetasTb.SelectedText = "";
            this.tetasTb.SelectionLength = 0;
            this.tetasTb.SelectionStart = 0;
            this.tetasTb.ShortcutsEnabled = true;
            this.tetasTb.Size = new System.Drawing.Size(36, 23);
            this.tetasTb.TabIndex = 8;
            this.tetasTb.Text = "1";
            this.tetasTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tetasTb.UseSelectable = true;
            this.tetasTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tetasTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(96, 490);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(15, 19);
            this.metroLabel5.TabIndex = 17;
            this.metroLabel5.Text = "I:";
            // 
            // ITb
            // 
            // 
            // 
            // 
            this.ITb.CustomButton.Image = null;
            this.ITb.CustomButton.Location = new System.Drawing.Point(14, 1);
            this.ITb.CustomButton.Name = "";
            this.ITb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ITb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ITb.CustomButton.TabIndex = 1;
            this.ITb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ITb.CustomButton.UseSelectable = true;
            this.ITb.CustomButton.Visible = false;
            this.ITb.Lines = new string[] {
        "3"};
            this.ITb.Location = new System.Drawing.Point(130, 490);
            this.ITb.MaxLength = 32767;
            this.ITb.Name = "ITb";
            this.ITb.PasswordChar = '\0';
            this.ITb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ITb.SelectedText = "";
            this.ITb.SelectionLength = 0;
            this.ITb.SelectionStart = 0;
            this.ITb.ShortcutsEnabled = true;
            this.ITb.Size = new System.Drawing.Size(36, 23);
            this.ITb.TabIndex = 16;
            this.ITb.Text = "3";
            this.ITb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ITb.UseSelectable = true;
            this.ITb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ITb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(96, 460);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(18, 19);
            this.metroLabel6.TabIndex = 15;
            this.metroLabel6.Text = "k:";
            // 
            // lowerkTb
            // 
            // 
            // 
            // 
            this.lowerkTb.CustomButton.Image = null;
            this.lowerkTb.CustomButton.Location = new System.Drawing.Point(14, 1);
            this.lowerkTb.CustomButton.Name = "";
            this.lowerkTb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lowerkTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lowerkTb.CustomButton.TabIndex = 1;
            this.lowerkTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lowerkTb.CustomButton.UseSelectable = true;
            this.lowerkTb.CustomButton.Visible = false;
            this.lowerkTb.Lines = new string[] {
        "0,5"};
            this.lowerkTb.Location = new System.Drawing.Point(130, 460);
            this.lowerkTb.MaxLength = 32767;
            this.lowerkTb.Name = "lowerkTb";
            this.lowerkTb.PasswordChar = '\0';
            this.lowerkTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lowerkTb.SelectedText = "";
            this.lowerkTb.SelectionLength = 0;
            this.lowerkTb.SelectionStart = 0;
            this.lowerkTb.ShortcutsEnabled = true;
            this.lowerkTb.Size = new System.Drawing.Size(36, 23);
            this.lowerkTb.TabIndex = 14;
            this.lowerkTb.Text = "0,5";
            this.lowerkTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lowerkTb.UseSelectable = true;
            this.lowerkTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lowerkTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(96, 430);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(18, 19);
            this.metroLabel7.TabIndex = 13;
            this.metroLabel7.Text = "L:";
            // 
            // LTb
            // 
            // 
            // 
            // 
            this.LTb.CustomButton.Image = null;
            this.LTb.CustomButton.Location = new System.Drawing.Point(14, 1);
            this.LTb.CustomButton.Name = "";
            this.LTb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.LTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LTb.CustomButton.TabIndex = 1;
            this.LTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LTb.CustomButton.UseSelectable = true;
            this.LTb.CustomButton.Visible = false;
            this.LTb.Lines = new string[] {
        "1"};
            this.LTb.Location = new System.Drawing.Point(130, 430);
            this.LTb.MaxLength = 32767;
            this.LTb.Name = "LTb";
            this.LTb.PasswordChar = '\0';
            this.LTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LTb.SelectedText = "";
            this.LTb.SelectionLength = 0;
            this.LTb.SelectionStart = 0;
            this.LTb.ShortcutsEnabled = true;
            this.LTb.Size = new System.Drawing.Size(36, 23);
            this.LTb.TabIndex = 12;
            this.LTb.Text = "1";
            this.LTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LTb.UseSelectable = true;
            this.LTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.LTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(96, 399);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(28, 19);
            this.metroLabel4.TabIndex = 19;
            this.metroLabel4.Text = "Nc:";
            // 
            // NcTb
            // 
            // 
            // 
            // 
            this.NcTb.CustomButton.Image = null;
            this.NcTb.CustomButton.Location = new System.Drawing.Point(14, 1);
            this.NcTb.CustomButton.Name = "";
            this.NcTb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NcTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NcTb.CustomButton.TabIndex = 1;
            this.NcTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NcTb.CustomButton.UseSelectable = true;
            this.NcTb.CustomButton.Visible = false;
            this.NcTb.Lines = new string[] {
        "1"};
            this.NcTb.Location = new System.Drawing.Point(130, 399);
            this.NcTb.MaxLength = 32767;
            this.NcTb.Name = "NcTb";
            this.NcTb.PasswordChar = '\0';
            this.NcTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NcTb.SelectedText = "";
            this.NcTb.SelectionLength = 0;
            this.NcTb.SelectionStart = 0;
            this.NcTb.ShortcutsEnabled = true;
            this.NcTb.Size = new System.Drawing.Size(36, 23);
            this.NcTb.TabIndex = 18;
            this.NcTb.Text = "1";
            this.NcTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NcTb.UseSelectable = true;
            this.NcTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NcTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // startBtn
            // 
            this.startBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.startBtn.Location = new System.Drawing.Point(23, 565);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(143, 41);
            this.startBtn.TabIndex = 20;
            this.startBtn.Text = "Execute";
            this.startBtn.UseSelectable = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // parCb
            // 
            this.parCb.AutoSize = true;
            this.parCb.Location = new System.Drawing.Point(23, 532);
            this.parCb.Name = "parCb";
            this.parCb.Size = new System.Drawing.Size(112, 15);
            this.parCb.TabIndex = 21;
            this.parCb.Text = "Ongoing change";
            this.parCb.UseSelectable = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(500, 609);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(20, 19);
            this.metroLabel8.TabIndex = 22;
            this.metroLabel8.Text = "K:";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(667, 609);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(29, 19);
            this.metroLabel9.TabIndex = 26;
            this.metroLabel9.Text = "Θc:";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(609, 609);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(29, 19);
            this.metroLabel10.TabIndex = 25;
            this.metroLabel10.Text = "Θs:";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(549, 609);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(31, 19);
            this.metroLabel11.TabIndex = 24;
            this.metroLabel11.Text = "Θn:";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel12.Location = new System.Drawing.Point(725, 609);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(28, 19);
            this.metroLabel12.TabIndex = 30;
            this.metroLabel12.Text = "Nc:";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel13.Location = new System.Drawing.Point(878, 609);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(16, 19);
            this.metroLabel13.TabIndex = 29;
            this.metroLabel13.Text = "I:";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel14.Location = new System.Drawing.Point(830, 609);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(19, 19);
            this.metroLabel14.TabIndex = 28;
            this.metroLabel14.Text = "k:";
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel15.Location = new System.Drawing.Point(782, 609);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(19, 19);
            this.metroLabel15.TabIndex = 27;
            this.metroLabel15.Text = "L:";
            // 
            // KaTb
            // 
            this.KaTb.AutoSize = true;
            this.KaTb.Location = new System.Drawing.Point(526, 609);
            this.KaTb.Name = "KaTb";
            this.KaTb.Size = new System.Drawing.Size(17, 19);
            this.KaTb.TabIndex = 31;
            this.KaTb.Text = "#";
            // 
            // tetanaTb
            // 
            this.tetanaTb.AutoSize = true;
            this.tetanaTb.Location = new System.Drawing.Point(586, 609);
            this.tetanaTb.Name = "tetanaTb";
            this.tetanaTb.Size = new System.Drawing.Size(17, 19);
            this.tetanaTb.TabIndex = 32;
            this.tetanaTb.Text = "#";
            // 
            // tetasaTb
            // 
            this.tetasaTb.AutoSize = true;
            this.tetasaTb.Location = new System.Drawing.Point(644, 609);
            this.tetasaTb.Name = "tetasaTb";
            this.tetasaTb.Size = new System.Drawing.Size(17, 19);
            this.tetasaTb.TabIndex = 33;
            this.tetasaTb.Text = "#";
            // 
            // tetacaTb
            // 
            this.tetacaTb.AutoSize = true;
            this.tetacaTb.Location = new System.Drawing.Point(702, 609);
            this.tetacaTb.Name = "tetacaTb";
            this.tetacaTb.Size = new System.Drawing.Size(17, 19);
            this.tetacaTb.TabIndex = 34;
            this.tetacaTb.Text = "#";
            // 
            // NcaTb
            // 
            this.NcaTb.AutoSize = true;
            this.NcaTb.Location = new System.Drawing.Point(759, 609);
            this.NcaTb.Name = "NcaTb";
            this.NcaTb.Size = new System.Drawing.Size(17, 19);
            this.NcaTb.TabIndex = 35;
            this.NcaTb.Text = "#";
            // 
            // LaTb
            // 
            this.LaTb.AutoSize = true;
            this.LaTb.Location = new System.Drawing.Point(807, 609);
            this.LaTb.Name = "LaTb";
            this.LaTb.Size = new System.Drawing.Size(17, 19);
            this.LaTb.TabIndex = 36;
            this.LaTb.Text = "#";
            // 
            // lowerkaTb
            // 
            this.lowerkaTb.AutoSize = true;
            this.lowerkaTb.Location = new System.Drawing.Point(855, 609);
            this.lowerkaTb.Name = "lowerkaTb";
            this.lowerkaTb.Size = new System.Drawing.Size(17, 19);
            this.lowerkaTb.TabIndex = 37;
            this.lowerkaTb.Text = "#";
            // 
            // IaTb
            // 
            this.IaTb.AutoSize = true;
            this.IaTb.Location = new System.Drawing.Point(900, 609);
            this.IaTb.Name = "IaTb";
            this.IaTb.Size = new System.Drawing.Size(17, 19);
            this.IaTb.TabIndex = 38;
            this.IaTb.Text = "#";
            // 
            // addPointBox
            // 
            this.addPointBox.Controls.Add(this.addYTb);
            this.addPointBox.Controls.Add(this.addXTb);
            this.addPointBox.Location = new System.Drawing.Point(23, 317);
            this.addPointBox.Name = "addPointBox";
            this.addPointBox.Size = new System.Drawing.Size(143, 68);
            this.addPointBox.TabIndex = 39;
            this.addPointBox.TabStop = false;
            this.addPointBox.Text = "Add a point";
            // 
            // addXTb
            // 
            // 
            // 
            // 
            this.addXTb.CustomButton.Image = null;
            this.addXTb.CustomButton.Location = new System.Drawing.Point(14, 1);
            this.addXTb.CustomButton.Name = "";
            this.addXTb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.addXTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.addXTb.CustomButton.TabIndex = 1;
            this.addXTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.addXTb.CustomButton.UseSelectable = true;
            this.addXTb.CustomButton.Visible = false;
            this.addXTb.Lines = new string[0];
            this.addXTb.Location = new System.Drawing.Point(6, 29);
            this.addXTb.MaxLength = 32767;
            this.addXTb.Name = "addXTb";
            this.addXTb.PasswordChar = '\0';
            this.addXTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.addXTb.SelectedText = "";
            this.addXTb.SelectionLength = 0;
            this.addXTb.SelectionStart = 0;
            this.addXTb.ShortcutsEnabled = true;
            this.addXTb.Size = new System.Drawing.Size(36, 23);
            this.addXTb.TabIndex = 40;
            this.addXTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addXTb.UseSelectable = true;
            this.addXTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.addXTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // addYTb
            // 
            // 
            // 
            // 
            this.addYTb.CustomButton.Image = null;
            this.addYTb.CustomButton.Location = new System.Drawing.Point(14, 1);
            this.addYTb.CustomButton.Name = "";
            this.addYTb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.addYTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.addYTb.CustomButton.TabIndex = 1;
            this.addYTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.addYTb.CustomButton.UseSelectable = true;
            this.addYTb.CustomButton.Visible = false;
            this.addYTb.Lines = new string[0];
            this.addYTb.Location = new System.Drawing.Point(48, 29);
            this.addYTb.MaxLength = 32767;
            this.addYTb.Name = "addYTb";
            this.addYTb.PasswordChar = '\0';
            this.addYTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.addYTb.SelectedText = "";
            this.addYTb.SelectionLength = 0;
            this.addYTb.SelectionStart = 0;
            this.addYTb.ShortcutsEnabled = true;
            this.addYTb.Size = new System.Drawing.Size(36, 23);
            this.addYTb.TabIndex = 41;
            this.addYTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addYTb.UseSelectable = true;
            this.addYTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.addYTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // addBtn
            // 
            this.addBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.addBtn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.addBtn.Location = new System.Drawing.Point(113, 346);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(47, 23);
            this.addBtn.TabIndex = 40;
            this.addBtn.Text = "Add";
            this.addBtn.UseSelectable = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // fileBtn
            // 
            this.fileBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.fileBtn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.fileBtn.Location = new System.Drawing.Point(23, 265);
            this.fileBtn.Name = "fileBtn";
            this.fileBtn.Size = new System.Drawing.Size(143, 46);
            this.fileBtn.TabIndex = 41;
            this.fileBtn.Text = "Add points (.txt)";
            this.fileBtn.UseSelectable = true;
            this.fileBtn.Click += new System.EventHandler(this.fileBtn_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 636);
            this.Controls.Add(this.fileBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.addPointBox);
            this.Controls.Add(this.IaTb);
            this.Controls.Add(this.lowerkaTb);
            this.Controls.Add(this.LaTb);
            this.Controls.Add(this.NcaTb);
            this.Controls.Add(this.tetacaTb);
            this.Controls.Add(this.tetasaTb);
            this.Controls.Add(this.tetanaTb);
            this.Controls.Add(this.KaTb);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.metroLabel15);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.parCb);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.NcTb);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.ITb);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.lowerkTb);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.LTb);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.tetacTb);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.tetasTb);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tetanTb);
            this.Controls.Add(this.kLbl);
            this.Controls.Add(this.KTb);
            this.Controls.Add(this.pointsDgv);
            this.Controls.Add(this.zgc);
            this.Controls.Add(this.statusTb);
            this.Name = "MainForm";
            this.Resizable = false;
            this.Text = "ISODATA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pointsDgv)).EndInit();
            this.addPointBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox statusTb;
        private ZedGraph.ZedGraphControl zgc;
        private System.Windows.Forms.DataGridView pointsDgv;
        private MetroFramework.Controls.MetroTextBox KTb;
        private MetroFramework.Controls.MetroLabel kLbl;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tetanTb;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tetacTb;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox tetasTb;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox ITb;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox lowerkTb;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox LTb;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox NcTb;
        private MetroFramework.Controls.MetroButton startBtn;
        private MetroFramework.Controls.MetroCheckBox parCb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel KaTb;
        private MetroFramework.Controls.MetroLabel tetanaTb;
        private MetroFramework.Controls.MetroLabel tetasaTb;
        private MetroFramework.Controls.MetroLabel tetacaTb;
        private MetroFramework.Controls.MetroLabel NcaTb;
        private MetroFramework.Controls.MetroLabel LaTb;
        private MetroFramework.Controls.MetroLabel lowerkaTb;
        private MetroFramework.Controls.MetroLabel IaTb;
        private System.Windows.Forms.GroupBox addPointBox;
        private MetroFramework.Controls.MetroTextBox addYTb;
        private MetroFramework.Controls.MetroTextBox addXTb;
        private MetroFramework.Controls.MetroButton addBtn;
        private MetroFramework.Controls.MetroButton fileBtn;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}

