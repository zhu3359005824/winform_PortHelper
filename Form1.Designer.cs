namespace 串口助手
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cboxport = new System.Windows.Forms.ComboBox();
            this.rboxreceive = new System.Windows.Forms.RichTextBox();
            this.rboxsend = new System.Windows.Forms.RichTextBox();
            this.gbox_mainconfig = new System.Windows.Forms.GroupBox();
            this.gbox_receiveconfig = new System.Windows.Forms.GroupBox();
            this.gbox_sendconfig = new System.Windows.Forms.GroupBox();
            this.gboxreceive = new System.Windows.Forms.GroupBox();
            this.gboxsend = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkRTS = new System.Windows.Forms.CheckBox();
            this.checkDTR = new System.Windows.Forms.CheckBox();
            this.btnopen = new System.Windows.Forms.Button();
            this.check0x = new System.Windows.Forms.CheckBox();
            this.checkautoclear = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tboxreceivepath = new System.Windows.Forms.TextBox();
            this.tboxsendpath = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbox_mainconfig.SuspendLayout();
            this.gbox_receiveconfig.SuspendLayout();
            this.gbox_sendconfig.SuspendLayout();
            this.gboxreceive.SuspendLayout();
            this.gboxsend.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboxport
            // 
            this.cboxport.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboxport.FormattingEnabled = true;
            this.cboxport.Items.AddRange(new object[] {
            "com1",
            "com2",
            "com3"});
            this.cboxport.Location = new System.Drawing.Point(131, 27);
            this.cboxport.Name = "cboxport";
            this.cboxport.Size = new System.Drawing.Size(217, 32);
            this.cboxport.TabIndex = 2;
            // 
            // rboxreceive
            // 
            this.rboxreceive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rboxreceive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rboxreceive.Location = new System.Drawing.Point(3, 24);
            this.rboxreceive.Name = "rboxreceive";
            this.rboxreceive.Size = new System.Drawing.Size(547, 418);
            this.rboxreceive.TabIndex = 3;
            this.rboxreceive.Text = "";
            // 
            // rboxsend
            // 
            this.rboxsend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rboxsend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rboxsend.Location = new System.Drawing.Point(3, 24);
            this.rboxsend.Name = "rboxsend";
            this.rboxsend.Size = new System.Drawing.Size(544, 286);
            this.rboxsend.TabIndex = 6;
            this.rboxsend.Text = "";
            // 
            // gbox_mainconfig
            // 
            this.gbox_mainconfig.Controls.Add(this.btnopen);
            this.gbox_mainconfig.Controls.Add(this.checkDTR);
            this.gbox_mainconfig.Controls.Add(this.checkRTS);
            this.gbox_mainconfig.Controls.Add(this.label5);
            this.gbox_mainconfig.Controls.Add(this.label4);
            this.gbox_mainconfig.Controls.Add(this.label3);
            this.gbox_mainconfig.Controls.Add(this.label2);
            this.gbox_mainconfig.Controls.Add(this.label1);
            this.gbox_mainconfig.Controls.Add(this.comboBox4);
            this.gbox_mainconfig.Controls.Add(this.comboBox3);
            this.gbox_mainconfig.Controls.Add(this.comboBox2);
            this.gbox_mainconfig.Controls.Add(this.comboBox1);
            this.gbox_mainconfig.Controls.Add(this.cboxport);
            this.gbox_mainconfig.Location = new System.Drawing.Point(12, 12);
            this.gbox_mainconfig.Name = "gbox_mainconfig";
            this.gbox_mainconfig.Size = new System.Drawing.Size(374, 408);
            this.gbox_mainconfig.TabIndex = 7;
            this.gbox_mainconfig.TabStop = false;
            this.gbox_mainconfig.Text = "串口配置";
            // 
            // gbox_receiveconfig
            // 
            this.gbox_receiveconfig.Controls.Add(this.tboxreceivepath);
            this.gbox_receiveconfig.Controls.Add(this.button4);
            this.gbox_receiveconfig.Controls.Add(this.button3);
            this.gbox_receiveconfig.Controls.Add(this.button2);
            this.gbox_receiveconfig.Controls.Add(this.button1);
            this.gbox_receiveconfig.Controls.Add(this.check0x);
            this.gbox_receiveconfig.Controls.Add(this.checkautoclear);
            this.gbox_receiveconfig.Location = new System.Drawing.Point(12, 426);
            this.gbox_receiveconfig.Name = "gbox_receiveconfig";
            this.gbox_receiveconfig.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbox_receiveconfig.Size = new System.Drawing.Size(373, 201);
            this.gbox_receiveconfig.TabIndex = 8;
            this.gbox_receiveconfig.TabStop = false;
            this.gbox_receiveconfig.Text = "接收配置";
            // 
            // gbox_sendconfig
            // 
            this.gbox_sendconfig.Controls.Add(this.textBox1);
            this.gbox_sendconfig.Controls.Add(this.label6);
            this.gbox_sendconfig.Controls.Add(this.tboxsendpath);
            this.gbox_sendconfig.Controls.Add(this.button5);
            this.gbox_sendconfig.Controls.Add(this.button6);
            this.gbox_sendconfig.Controls.Add(this.button7);
            this.gbox_sendconfig.Controls.Add(this.button8);
            this.gbox_sendconfig.Controls.Add(this.checkBox1);
            this.gbox_sendconfig.Controls.Add(this.checkBox2);
            this.gbox_sendconfig.Location = new System.Drawing.Point(13, 633);
            this.gbox_sendconfig.Name = "gbox_sendconfig";
            this.gbox_sendconfig.Size = new System.Drawing.Size(373, 225);
            this.gbox_sendconfig.TabIndex = 9;
            this.gbox_sendconfig.TabStop = false;
            this.gbox_sendconfig.Text = "发送配置";
            // 
            // gboxreceive
            // 
            this.gboxreceive.Controls.Add(this.rboxreceive);
            this.gboxreceive.Location = new System.Drawing.Point(458, 12);
            this.gboxreceive.Name = "gboxreceive";
            this.gboxreceive.Size = new System.Drawing.Size(553, 445);
            this.gboxreceive.TabIndex = 10;
            this.gboxreceive.TabStop = false;
            this.gboxreceive.Text = "接受区";
            // 
            // gboxsend
            // 
            this.gboxsend.Controls.Add(this.rboxsend);
            this.gboxsend.Location = new System.Drawing.Point(461, 460);
            this.gboxsend.Name = "gboxsend";
            this.gboxsend.Size = new System.Drawing.Size(550, 313);
            this.gboxsend.TabIndex = 11;
            this.gboxsend.TabStop = false;
            this.gboxsend.Text = "发送区";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel7});
            this.statusStrip1.Location = new System.Drawing.Point(0, 861);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1050, 31);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "com1",
            "com2",
            "com3"});
            this.comboBox1.Location = new System.Drawing.Point(131, 93);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 32);
            this.comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "com1",
            "com2",
            "com3"});
            this.comboBox2.Location = new System.Drawing.Point(131, 159);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(217, 32);
            this.comboBox2.TabIndex = 4;
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "com1",
            "com2",
            "com3"});
            this.comboBox3.Location = new System.Drawing.Point(131, 225);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(217, 32);
            this.comboBox3.TabIndex = 5;
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "com1",
            "com2",
            "com3"});
            this.comboBox4.Location = new System.Drawing.Point(131, 291);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(217, 32);
            this.comboBox4.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "端口号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(19, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "波特率";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(19, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "校验位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(19, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "数据位";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(19, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "停止位";
            // 
            // checkRTS
            // 
            this.checkRTS.AutoSize = true;
            this.checkRTS.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkRTS.Location = new System.Drawing.Point(23, 329);
            this.checkRTS.Name = "checkRTS";
            this.checkRTS.Size = new System.Drawing.Size(72, 28);
            this.checkRTS.TabIndex = 12;
            this.checkRTS.Text = "RTS";
            this.checkRTS.UseVisualStyleBackColor = true;
            // 
            // checkDTR
            // 
            this.checkDTR.AutoSize = true;
            this.checkDTR.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkDTR.Location = new System.Drawing.Point(23, 374);
            this.checkDTR.Name = "checkDTR";
            this.checkDTR.Size = new System.Drawing.Size(72, 28);
            this.checkDTR.TabIndex = 13;
            this.checkDTR.Text = "DTR";
            this.checkDTR.UseVisualStyleBackColor = true;
            // 
            // btnopen
            // 
            this.btnopen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnopen.Location = new System.Drawing.Point(131, 329);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(217, 73);
            this.btnopen.TabIndex = 14;
            this.btnopen.Text = "打开串口";
            this.btnopen.UseVisualStyleBackColor = false;
            // 
            // check0x
            // 
            this.check0x.AutoSize = true;
            this.check0x.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.check0x.Location = new System.Drawing.Point(23, 83);
            this.check0x.Name = "check0x";
            this.check0x.Size = new System.Drawing.Size(120, 25);
            this.check0x.TabIndex = 15;
            this.check0x.Text = "十六进制";
            this.check0x.UseVisualStyleBackColor = true;
            // 
            // checkautoclear
            // 
            this.checkautoclear.AutoSize = true;
            this.checkautoclear.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkautoclear.Location = new System.Drawing.Point(23, 38);
            this.checkautoclear.Name = "checkautoclear";
            this.checkautoclear.Size = new System.Drawing.Size(120, 25);
            this.checkautoclear.TabIndex = 14;
            this.checkautoclear.Text = "自动清空";
            this.checkautoclear.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(204, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 32);
            this.button1.TabIndex = 16;
            this.button1.Text = "手动清空";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.Location = new System.Drawing.Point(204, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 32);
            this.button2.TabIndex = 17;
            this.button2.Text = "暂停";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.Location = new System.Drawing.Point(204, 116);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 32);
            this.button3.TabIndex = 18;
            this.button3.Text = "保存数据";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.Location = new System.Drawing.Point(23, 116);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 33);
            this.button4.TabIndex = 19;
            this.button4.Text = "选择路径";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // tboxreceivepath
            // 
            this.tboxreceivepath.Location = new System.Drawing.Point(23, 155);
            this.tboxreceivepath.Name = "tboxreceivepath";
            this.tboxreceivepath.Size = new System.Drawing.Size(325, 28);
            this.tboxreceivepath.TabIndex = 20;
            // 
            // tboxsendpath
            // 
            this.tboxsendpath.Location = new System.Drawing.Point(22, 148);
            this.tboxsendpath.Name = "tboxsendpath";
            this.tboxsendpath.Size = new System.Drawing.Size(325, 28);
            this.tboxsendpath.TabIndex = 27;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.Location = new System.Drawing.Point(24, 104);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 32);
            this.button5.TabIndex = 26;
            this.button5.Text = "打开文件";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.Location = new System.Drawing.Point(205, 105);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(115, 32);
            this.button6.TabIndex = 25;
            this.button6.Text = "发送文件";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.Location = new System.Drawing.Point(205, 65);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(115, 32);
            this.button7.TabIndex = 24;
            this.button7.Text = "清空发送";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.Location = new System.Drawing.Point(205, 25);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(115, 32);
            this.button8.TabIndex = 23;
            this.button8.Text = "手动发送";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox1.Location = new System.Drawing.Point(24, 67);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(120, 25);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "十六进制";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox2.Location = new System.Drawing.Point(24, 30);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(120, 25);
            this.checkBox2.TabIndex = 21;
            this.checkBox2.Text = "自动发送";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(20, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 21);
            this.label6.TabIndex = 29;
            this.label6.Text = "自动发送周期(ms)";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(219, 194);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(86, 31);
            this.textBox1.TabIndex = 30;
            this.textBox1.Text = "1000";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(50, 24);
            this.toolStripStatusLabel1.Text = "状态:";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(200, 24);
            this.toolStripStatusLabel2.Text = "初始化正常!";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(86, 24);
            this.toolStripStatusLabel3.Text = "发送计数:";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.AutoSize = false;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(50, 24);
            this.toolStripStatusLabel4.Text = "0";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(86, 24);
            this.toolStripStatusLabel5.Text = "接受计数:";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.AutoSize = false;
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(50, 24);
            this.toolStripStatusLabel6.Text = "0";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(82, 24);
            this.toolStripStatusLabel7.Text = "清空计数";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 892);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gboxsend);
            this.Controls.Add(this.gboxreceive);
            this.Controls.Add(this.gbox_sendconfig);
            this.Controls.Add(this.gbox_receiveconfig);
            this.Controls.Add(this.gbox_mainconfig);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "串口助手";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbox_mainconfig.ResumeLayout(false);
            this.gbox_mainconfig.PerformLayout();
            this.gbox_receiveconfig.ResumeLayout(false);
            this.gbox_receiveconfig.PerformLayout();
            this.gbox_sendconfig.ResumeLayout(false);
            this.gbox_sendconfig.PerformLayout();
            this.gboxreceive.ResumeLayout(false);
            this.gboxsend.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboxport;
        private System.Windows.Forms.RichTextBox rboxreceive;
        private System.Windows.Forms.RichTextBox rboxsend;
        private System.Windows.Forms.GroupBox gbox_mainconfig;
        private System.Windows.Forms.GroupBox gbox_receiveconfig;
        private System.Windows.Forms.GroupBox gbox_sendconfig;
        private System.Windows.Forms.GroupBox gboxreceive;
        private System.Windows.Forms.GroupBox gboxsend;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.CheckBox checkDTR;
        private System.Windows.Forms.CheckBox checkRTS;
        private System.Windows.Forms.TextBox tboxreceivepath;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox check0x;
        private System.Windows.Forms.CheckBox checkautoclear;
        private System.Windows.Forms.TextBox tboxsendpath;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
    }
}

