
namespace CompyBrowser
{
    partial class CompyBrowser
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompyBrowser));
            this.Back = new System.Windows.Forms.Button();
            this.Forward = new System.Windows.Forms.Button();
            this.URL = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.PictureBox();
            this.Reload = new System.Windows.Forms.PictureBox();
            this.Browser = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reload)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Aqua;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(1, 1);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(70, 43);
            this.Back.TabIndex = 0;
            this.Back.Text = "<--";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Forward
            // 
            this.Forward.BackColor = System.Drawing.Color.Aqua;
            this.Forward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Forward.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forward.Location = new System.Drawing.Point(77, 1);
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(70, 43);
            this.Forward.TabIndex = 1;
            this.Forward.Text = "-->";
            this.Forward.UseVisualStyleBackColor = false;
            this.Forward.Click += new System.EventHandler(this.Forward_Click);
            // 
            // URL
            // 
            this.URL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.URL.BackColor = System.Drawing.Color.Yellow;
            this.URL.Font = new System.Drawing.Font("Comic Sans MS", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URL.Location = new System.Drawing.Point(153, 2);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(541, 42);
            this.URL.TabIndex = 2;
            this.URL.Text = "Type a URL";
            this.URL.Click += new System.EventHandler(this.URL_Click);
            this.URL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.URL_KeyPress);
            // 
            // Search
            // 
            this.Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Search.Image = global::CompyBrowser.Properties.Resources.Search;
            this.Search.Location = new System.Drawing.Point(700, 2);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(45, 42);
            this.Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Search.TabIndex = 4;
            this.Search.TabStop = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Reload
            // 
            this.Reload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Reload.Image = global::CompyBrowser.Properties.Resources.Refresh;
            this.Reload.Location = new System.Drawing.Point(751, 2);
            this.Reload.Name = "Reload";
            this.Reload.Size = new System.Drawing.Size(45, 42);
            this.Reload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Reload.TabIndex = 3;
            this.Reload.TabStop = false;
            this.Reload.Click += new System.EventHandler(this.Reload_Click);
            // 
            // Browser
            // 
            this.Browser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Browser.Location = new System.Drawing.Point(1, 50);
            this.Browser.Name = "Browser";
            this.Browser.Size = new System.Drawing.Size(811, 399);
            this.Browser.TabIndex = 5;
            // 
            // CompyBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(813, 450);
            this.Controls.Add(this.Browser);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Reload);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.Forward);
            this.Controls.Add(this.Back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CompyBrowser";
            this.Text = "Compy Browser";
            this.Load += new System.EventHandler(this.CompyBrowser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Forward;
        private System.Windows.Forms.TextBox URL;
        private System.Windows.Forms.PictureBox Reload;
        private System.Windows.Forms.PictureBox Search;
        private System.Windows.Forms.Panel Browser;
    }
}

