
namespace half_pipe_app
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonProducts = new System.Windows.Forms.Button();
            this.buttonBuyers = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.panelLabelText = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(189)))), ((int)(((byte)(115)))));
            this.panelMenu.Controls.Add(this.button3);
            this.panelMenu.Controls.Add(this.buttonProducts);
            this.panelMenu.Controls.Add(this.buttonBuyers);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(150, 572);
            this.panelMenu.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(0, 228);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // buttonProducts
            // 
            this.buttonProducts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonProducts.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonProducts.Location = new System.Drawing.Point(0, 188);
            this.buttonProducts.Name = "buttonProducts";
            this.buttonProducts.Size = new System.Drawing.Size(150, 40);
            this.buttonProducts.TabIndex = 1;
            this.buttonProducts.Text = "Товары";
            this.buttonProducts.UseVisualStyleBackColor = false;
            // 
            // buttonBuyers
            // 
            this.buttonBuyers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonBuyers.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBuyers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBuyers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBuyers.Location = new System.Drawing.Point(0, 148);
            this.buttonBuyers.Name = "buttonBuyers";
            this.buttonBuyers.Size = new System.Drawing.Size(150, 40);
            this.buttonBuyers.TabIndex = 0;
            this.buttonBuyers.Text = "Покупатели";
            this.buttonBuyers.UseVisualStyleBackColor = false;
            this.buttonBuyers.Click += new System.EventHandler(this.buttonBuyers_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 148);
            this.panel1.TabIndex = 3;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.SandyBrown;
            this.panelTitle.Controls.Add(this.panelLabelText);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(150, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1242, 34);
            this.panelTitle.TabIndex = 2;
            // 
            // panelLabelText
            // 
            this.panelLabelText.AutoSize = true;
            this.panelLabelText.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLabelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelLabelText.Location = new System.Drawing.Point(0, 0);
            this.panelLabelText.Name = "panelLabelText";
            this.panelLabelText.Size = new System.Drawing.Size(69, 31);
            this.panelLabelText.TabIndex = 0;
            this.panelLabelText.Text = "Дом";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.button1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(150, 34);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1242, 538);
            this.panelDesktop.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(635, 153);
            this.button1.TabIndex = 0;
            this.button1.Text = "БАТОН";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 572);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Name = "mainForm";
            this.Text = "half pipe";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonProducts;
        private System.Windows.Forms.Button buttonBuyers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label panelLabelText;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button button1;
    }
}

