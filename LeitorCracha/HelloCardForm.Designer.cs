namespace LeitorCracha
{
    partial class HelloCardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblInsiraCard = new System.Windows.Forms.Label();
            this.txtMainBox = new System.Windows.Forms.RichTextBox();
            this.m_aApiVersion = new System.Windows.Forms.Label();
            this.m_aLinkLabel = new System.Windows.Forms.LinkLabel();
            this.m_aCopyrightLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInsiraCard
            // 
            this.lblInsiraCard.AutoSize = true;
            this.lblInsiraCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsiraCard.Location = new System.Drawing.Point(12, 29);
            this.lblInsiraCard.Name = "lblInsiraCard";
            this.lblInsiraCard.Size = new System.Drawing.Size(231, 24);
            this.lblInsiraCard.TabIndex = 0;
            this.lblInsiraCard.Text = "Por favor insira o crachá ...";
            // 
            // txtMainBox
            // 
            this.txtMainBox.BackColor = System.Drawing.SystemColors.Control;
            this.txtMainBox.Location = new System.Drawing.Point(12, 83);
            this.txtMainBox.Name = "txtMainBox";
            this.txtMainBox.ReadOnly = true;
            this.txtMainBox.Size = new System.Drawing.Size(540, 308);
            this.txtMainBox.TabIndex = 1;
            this.txtMainBox.Text = "";
            // 
            // m_aApiVersion
            // 
            this.m_aApiVersion.AutoSize = true;
            this.m_aApiVersion.Location = new System.Drawing.Point(12, 404);
            this.m_aApiVersion.Name = "m_aApiVersion";
            this.m_aApiVersion.Size = new System.Drawing.Size(41, 13);
            this.m_aApiVersion.TabIndex = 10;
            this.m_aApiVersion.Text = "version";
            // 
            // m_aLinkLabel
            // 
            this.m_aLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_aLinkLabel.AutoSize = true;
            this.m_aLinkLabel.Location = new System.Drawing.Point(418, 421);
            this.m_aLinkLabel.Name = "m_aLinkLabel";
            this.m_aLinkLabel.Size = new System.Drawing.Size(142, 13);
            this.m_aLinkLabel.TabIndex = 9;
            this.m_aLinkLabel.TabStop = true;
            this.m_aLinkLabel.Text = "https://davidsoft.webs.com/";
            // 
            // m_aCopyrightLabel
            // 
            this.m_aCopyrightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_aCopyrightLabel.AutoSize = true;
            this.m_aCopyrightLabel.Location = new System.Drawing.Point(12, 423);
            this.m_aCopyrightLabel.Name = "m_aCopyrightLabel";
            this.m_aCopyrightLabel.Size = new System.Drawing.Size(163, 13);
            this.m_aCopyrightLabel.TabIndex = 8;
            this.m_aCopyrightLabel.Text = "Copyright 2020 David Sanculane";
            // 
            // HelloCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 441);
            this.Controls.Add(this.m_aApiVersion);
            this.Controls.Add(this.m_aLinkLabel);
            this.Controls.Add(this.m_aCopyrightLabel);
            this.Controls.Add(this.txtMainBox);
            this.Controls.Add(this.lblInsiraCard);
            this.Name = "HelloCardForm";
            this.Text = "Leitor de Crachá";
            this.Load += new System.EventHandler(this.HelloCardForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInsiraCard;
        private System.Windows.Forms.RichTextBox txtMainBox;
        private System.Windows.Forms.Label m_aApiVersion;
        private System.Windows.Forms.LinkLabel m_aLinkLabel;
        private System.Windows.Forms.Label m_aCopyrightLabel;
    }
}

