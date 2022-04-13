
namespace LAScriptManager
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShip = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.btnFish = new System.Windows.Forms.Button();
            this.btnFindHandle = new System.Windows.Forms.Button();
            this.lblHandle = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnShip);
            this.panel1.Controls.Add(this.btnG);
            this.panel1.Controls.Add(this.btnFish);
            this.panel1.Location = new System.Drawing.Point(12, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(98, 247);
            this.panel1.TabIndex = 0;
            // 
            // btnShip
            // 
            this.btnShip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShip.ForeColor = System.Drawing.Color.Red;
            this.btnShip.Location = new System.Drawing.Point(14, 166);
            this.btnShip.Name = "btnShip";
            this.btnShip.Size = new System.Drawing.Size(69, 69);
            this.btnShip.TabIndex = 1;
            this.btnShip.Text = "Auto ship sprint";
            this.btnShip.UseVisualStyleBackColor = true;
            this.btnShip.Click += new System.EventHandler(this.btnShip_Click);
            // 
            // btnG
            // 
            this.btnG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnG.ForeColor = System.Drawing.Color.Red;
            this.btnG.Location = new System.Drawing.Point(14, 91);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(69, 69);
            this.btnG.TabIndex = 1;
            this.btnG.Text = "Auto G";
            this.btnG.UseVisualStyleBackColor = true;
            this.btnG.Click += new System.EventHandler(this.btnG_Click);
            // 
            // btnFish
            // 
            this.btnFish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFish.ForeColor = System.Drawing.Color.Red;
            this.btnFish.Location = new System.Drawing.Point(14, 16);
            this.btnFish.Name = "btnFish";
            this.btnFish.Size = new System.Drawing.Size(69, 69);
            this.btnFish.TabIndex = 1;
            this.btnFish.Text = "Auto Fishing";
            this.btnFish.UseVisualStyleBackColor = true;
            this.btnFish.Click += new System.EventHandler(this.btnFish_Click);
            // 
            // btnFindHandle
            // 
            this.btnFindHandle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFindHandle.ForeColor = System.Drawing.Color.Black;
            this.btnFindHandle.Location = new System.Drawing.Point(26, 12);
            this.btnFindHandle.Name = "btnFindHandle";
            this.btnFindHandle.Size = new System.Drawing.Size(69, 69);
            this.btnFindHandle.TabIndex = 1;
            this.btnFindHandle.Text = "Find Handle";
            this.btnFindHandle.UseVisualStyleBackColor = true;
            this.btnFindHandle.Click += new System.EventHandler(this.btnFindHandle_Click);
            // 
            // lblHandle
            // 
            this.lblHandle.AutoSize = true;
            this.lblHandle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHandle.ForeColor = System.Drawing.Color.Red;
            this.lblHandle.Location = new System.Drawing.Point(0, 84);
            this.lblHandle.Name = "lblHandle";
            this.lblHandle.Size = new System.Drawing.Size(121, 17);
            this.lblHandle.TabIndex = 2;
            this.lblHandle.Text = "Window not found";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(124, 361);
            this.Controls.Add(this.lblHandle);
            this.Controls.Add(this.btnFindHandle);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnShip;
        private System.Windows.Forms.Button btnG;
        private System.Windows.Forms.Button btnFish;
        private System.Windows.Forms.Button btnFindHandle;
        private System.Windows.Forms.Label lblHandle;
        private System.Windows.Forms.Timer timer1;
    }
}

