
namespace Woagedit_cs
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.play = new System.Windows.Forms.Button();
            this.Param = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LocalFiles = new System.Windows.Forms.Button();
            this.OpenWoagules = new System.Windows.Forms.Button();
            this.Woagulepath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // play
            // 
            this.play.Location = new System.Drawing.Point(600, 523);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(154, 49);
            this.play.TabIndex = 0;
            this.play.Text = "Launch";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // Param
            // 
            this.Param.Location = new System.Drawing.Point(600, 497);
            this.Param.Name = "Param";
            this.Param.Size = new System.Drawing.Size(154, 20);
            this.Param.TabIndex = 1;
            this.Param.TextChanged += new System.EventHandler(this.Param_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(595, 469);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Use with \"-\"";
            // 
            // LocalFiles
            // 
            this.LocalFiles.Location = new System.Drawing.Point(12, 497);
            this.LocalFiles.Name = "LocalFiles";
            this.LocalFiles.Size = new System.Drawing.Size(131, 49);
            this.LocalFiles.TabIndex = 3;
            this.LocalFiles.Text = "Open Local Files";
            this.LocalFiles.UseVisualStyleBackColor = true;
            this.LocalFiles.Click += new System.EventHandler(this.LocalFiles_Click);
            // 
            // OpenWoagules
            // 
            this.OpenWoagules.Location = new System.Drawing.Point(12, 442);
            this.OpenWoagules.Name = "OpenWoagules";
            this.OpenWoagules.Size = new System.Drawing.Size(131, 49);
            this.OpenWoagules.TabIndex = 4;
            this.OpenWoagules.Text = "Open Woagules";
            this.OpenWoagules.UseVisualStyleBackColor = true;
            this.OpenWoagules.Click += new System.EventHandler(this.OpenWoagules_Click);
            // 
            // Woagulepath
            // 
            this.Woagulepath.Location = new System.Drawing.Point(12, 416);
            this.Woagulepath.Name = "Woagulepath";
            this.Woagulepath.Size = new System.Drawing.Size(154, 20);
            this.Woagulepath.TabIndex = 5;
            this.Woagulepath.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter woagule name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 45.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 70);
            this.label3.TabIndex = 7;
            this.label3.Text = "WoagEdit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(32, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "V0.1-cs";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 49);
            this.button1.TabIndex = 9;
            this.button1.Text = "Replace original to woagule";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.checkBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox1.Location = new System.Drawing.Point(600, 436);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 30);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Debug";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(766, 584);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Woagulepath);
            this.Controls.Add(this.OpenWoagules);
            this.Controls.Add(this.LocalFiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Param);
            this.Controls.Add(this.play);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "WoagEdit";
            this.Load += new System.EventHandler(this.loading);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button play;
        private System.Windows.Forms.TextBox Param;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LocalFiles;
        private System.Windows.Forms.Button OpenWoagules;
        private System.Windows.Forms.TextBox Woagulepath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

