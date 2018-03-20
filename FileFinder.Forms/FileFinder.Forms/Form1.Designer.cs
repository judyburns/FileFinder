namespace FileFinder.Forms
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
            this.pathlabel = new System.Windows.Forms.Label();
            this.extlabel = new System.Windows.Forms.Label();
            this.stringlabel = new System.Windows.Forms.Label();
            this.pathvalue = new System.Windows.Forms.TextBox();
            this.extvalue = new System.Windows.Forms.TextBox();
            this.stringvalue = new System.Windows.Forms.TextBox();
            this.resultsvalue = new System.Windows.Forms.ListBox();
            this.search = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.resultslabel = new System.Windows.Forms.Label();
            this.errorvalue = new System.Windows.Forms.TextBox();
            this.errorlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pathlabel
            // 
            this.pathlabel.AutoSize = true;
            this.pathlabel.Location = new System.Drawing.Point(92, 43);
            this.pathlabel.Name = "pathlabel";
            this.pathlabel.Size = new System.Drawing.Size(129, 17);
            this.pathlabel.TabIndex = 0;
            this.pathlabel.Text = "PATH TO SEARCH";
            // 
            // extlabel
            // 
            this.extlabel.AutoSize = true;
            this.extlabel.Location = new System.Drawing.Point(93, 99);
            this.extlabel.Name = "extlabel";
            this.extlabel.Size = new System.Drawing.Size(119, 17);
            this.extlabel.TabIndex = 1;
            this.extlabel.Text = "FILE EXTENSION";
            // 
            // stringlabel
            // 
            this.stringlabel.AutoSize = true;
            this.stringlabel.Location = new System.Drawing.Point(93, 154);
            this.stringlabel.Name = "stringlabel";
            this.stringlabel.Size = new System.Drawing.Size(120, 17);
            this.stringlabel.TabIndex = 2;
            this.stringlabel.Text = "SEARCH STRING";
            // 
            // pathvalue
            // 
            this.pathvalue.Location = new System.Drawing.Point(281, 43);
            this.pathvalue.Name = "pathvalue";
            this.pathvalue.Size = new System.Drawing.Size(451, 22);
            this.pathvalue.TabIndex = 3;
            // 
            // extvalue
            // 
            this.extvalue.Location = new System.Drawing.Point(281, 99);
            this.extvalue.Name = "extvalue";
            this.extvalue.Size = new System.Drawing.Size(113, 22);
            this.extvalue.TabIndex = 4;
            // 
            // stringvalue
            // 
            this.stringvalue.Location = new System.Drawing.Point(281, 152);
            this.stringvalue.Name = "stringvalue";
            this.stringvalue.Size = new System.Drawing.Size(451, 22);
            this.stringvalue.TabIndex = 5;
            // 
            // resultsvalue
            // 
            this.resultsvalue.FormattingEnabled = true;
            this.resultsvalue.ItemHeight = 16;
            this.resultsvalue.Location = new System.Drawing.Point(98, 283);
            this.resultsvalue.Name = "resultsvalue";
            this.resultsvalue.ScrollAlwaysVisible = true;
            this.resultsvalue.Size = new System.Drawing.Size(637, 196);
            this.resultsvalue.TabIndex = 6;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(284, 508);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(110, 29);
            this.search.TabIndex = 7;
            this.search.Text = "SEARCH";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.Search_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(439, 508);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(107, 29);
            this.cancel.TabIndex = 8;
            this.cancel.Text = "CLEAR";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.Clear_Click);
            // 
            // resultslabel
            // 
            this.resultslabel.AutoSize = true;
            this.resultslabel.Location = new System.Drawing.Point(95, 248);
            this.resultslabel.Name = "resultslabel";
            this.resultslabel.Size = new System.Drawing.Size(72, 17);
            this.resultslabel.TabIndex = 9;
            this.resultslabel.Text = "RESULTS";
            // 
            // errorvalue
            // 
            this.errorvalue.ForeColor = System.Drawing.Color.Red;
            this.errorvalue.Location = new System.Drawing.Point(281, 201);
            this.errorvalue.Name = "errorvalue";
            this.errorvalue.Size = new System.Drawing.Size(451, 22);
            this.errorvalue.TabIndex = 10;
            // 
            // errorlabel
            // 
            this.errorlabel.AutoSize = true;
            this.errorlabel.ForeColor = System.Drawing.Color.Black;
            this.errorlabel.Location = new System.Drawing.Point(95, 201);
            this.errorlabel.Name = "errorlabel";
            this.errorlabel.Size = new System.Drawing.Size(129, 17);
            this.errorlabel.TabIndex = 11;
            this.errorlabel.Text = "ERROR MESSAGE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 567);
            this.Controls.Add(this.errorlabel);
            this.Controls.Add(this.errorvalue);
            this.Controls.Add(this.resultslabel);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.search);
            this.Controls.Add(this.resultsvalue);
            this.Controls.Add(this.stringvalue);
            this.Controls.Add(this.extvalue);
            this.Controls.Add(this.pathvalue);
            this.Controls.Add(this.stringlabel);
            this.Controls.Add(this.extlabel);
            this.Controls.Add(this.pathlabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pathlabel;
        private System.Windows.Forms.Label extlabel;
        private System.Windows.Forms.Label stringlabel;
        private System.Windows.Forms.TextBox pathvalue;
        private System.Windows.Forms.TextBox extvalue;
        private System.Windows.Forms.TextBox stringvalue;
        private System.Windows.Forms.ListBox resultsvalue;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label resultslabel;
        private System.Windows.Forms.TextBox errorvalue;
        private System.Windows.Forms.Label errorlabel;
    }
}

