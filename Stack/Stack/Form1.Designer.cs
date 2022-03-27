namespace Stack
{
    partial class Form1
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
            this.btn_push = new System.Windows.Forms.Button();
            this.btn_pop = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.sayi = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_push
            // 
            this.btn_push.Location = new System.Drawing.Point(64, 189);
            this.btn_push.Name = "btn_push";
            this.btn_push.Size = new System.Drawing.Size(199, 63);
            this.btn_push.TabIndex = 0;
            this.btn_push.Text = "Yığına Ekle";
            this.btn_push.UseVisualStyleBackColor = true;
            this.btn_push.Click += new System.EventHandler(this.btn_push_Click);
            // 
            // btn_pop
            // 
            this.btn_pop.Location = new System.Drawing.Point(297, 189);
            this.btn_pop.Name = "btn_pop";
            this.btn_pop.Size = new System.Drawing.Size(199, 63);
            this.btn_pop.TabIndex = 1;
            this.btn_pop.Text = "Yığından Sil";
            this.btn_pop.UseVisualStyleBackColor = true;
            this.btn_pop.Click += new System.EventHandler(this.btn_pop_Click);
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(64, 274);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(432, 190);
            this.listView.TabIndex = 2;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.List;
            // 
            // sayi
            // 
            this.sayi.Location = new System.Drawing.Point(196, 113);
            this.sayi.Name = "sayi";
            this.sayi.Size = new System.Drawing.Size(213, 22);
            this.sayi.TabIndex = 3;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(103, 119);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(76, 16);
            this.label.TabIndex = 4;
            this.label.Text = "Sayi Giriniz:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 501);
            this.Controls.Add(this.label);
            this.Controls.Add(this.sayi);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.btn_pop);
            this.Controls.Add(this.btn_push);
            this.Name = "Form1";
            this.Text = "Yığın Oluştur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_push;
        private System.Windows.Forms.Button btn_pop;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.TextBox sayi;
        private System.Windows.Forms.Label label;
    }
}

