
namespace Gui
{
    partial class frm_TickerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtbx_inputticker = new System.Windows.Forms.TextBox();
            this.bttn_addticker = new System.Windows.Forms.Button();
            this.tickerGrid = new System.Windows.Forms.DataGridView();
            this.engineGrid = new System.Windows.Forms.DataGridView();
            this.bttn_refresh = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.engineGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Location = new System.Drawing.Point(12, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 104);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_ClickAsync);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.Location = new System.Drawing.Point(12, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 104);
            this.button2.TabIndex = 1;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_ClickAsync);
            // 
            // txtbx_inputticker
            // 
            this.txtbx_inputticker.Location = new System.Drawing.Point(311, 59);
            this.txtbx_inputticker.Name = "txtbx_inputticker";
            this.txtbx_inputticker.PlaceholderText = "Add ticker";
            this.txtbx_inputticker.Size = new System.Drawing.Size(100, 23);
            this.txtbx_inputticker.TabIndex = 4;
            this.txtbx_inputticker.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bttn_addticker
            // 
            this.bttn_addticker.Location = new System.Drawing.Point(311, 100);
            this.bttn_addticker.Name = "bttn_addticker";
            this.bttn_addticker.Size = new System.Drawing.Size(100, 23);
            this.bttn_addticker.TabIndex = 5;
            this.bttn_addticker.Text = "Subscribe";
            this.bttn_addticker.UseVisualStyleBackColor = true;
            this.bttn_addticker.Click += new System.EventHandler(this.bttn_addticker_ClickAsync);
            // 
            // tickerGrid
            // 
            this.tickerGrid.AllowUserToAddRows = false;
            this.tickerGrid.AllowUserToDeleteRows = false;
            this.tickerGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tickerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tickerGrid.Location = new System.Drawing.Point(442, 59);
            this.tickerGrid.Name = "tickerGrid";
            this.tickerGrid.ReadOnly = true;
            this.tickerGrid.RowHeadersVisible = false;
            this.tickerGrid.RowTemplate.Height = 25;
            this.tickerGrid.Size = new System.Drawing.Size(162, 229);
            this.tickerGrid.TabIndex = 6;
            // 
            // engineGrid
            // 
            this.engineGrid.AllowUserToAddRows = false;
            this.engineGrid.AllowUserToDeleteRows = false;
            this.engineGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.engineGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.engineGrid.Location = new System.Drawing.Point(133, 59);
            this.engineGrid.Name = "engineGrid";
            this.engineGrid.ReadOnly = true;
            this.engineGrid.RowHeadersVisible = false;
            this.engineGrid.RowTemplate.Height = 25;
            this.engineGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.engineGrid.Size = new System.Drawing.Size(144, 229);
            this.engineGrid.TabIndex = 7;
            // 
            // bttn_refresh
            // 
            this.bttn_refresh.Location = new System.Drawing.Point(311, 139);
            this.bttn_refresh.Name = "bttn_refresh";
            this.bttn_refresh.Size = new System.Drawing.Size(100, 23);
            this.bttn_refresh.TabIndex = 8;
            this.bttn_refresh.Text = "Refresh";
            this.bttn_refresh.UseVisualStyleBackColor = true;
            this.bttn_refresh.Click += new System.EventHandler(this.bttn_refresh_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(12, 13);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(191, 37);
            this.title.TabIndex = 9;
            this.title.Text = "Ticker Viewer";
            // 
            // frm_TickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 356);
            this.Controls.Add(this.title);
            this.Controls.Add(this.bttn_refresh);
            this.Controls.Add(this.engineGrid);
            this.Controls.Add(this.tickerGrid);
            this.Controls.Add(this.bttn_addticker);
            this.Controls.Add(this.txtbx_inputticker);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frm_TickerForm";
            this.Text = "Ticker Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.engineGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox txtbx_inputticker;
        private System.Windows.Forms.Button bttn_addticker;
        private System.Windows.Forms.DataGridView tickerGrid;
        private System.Windows.Forms.DataGridView engineGrid;
        private System.Windows.Forms.Button bttn_refresh;
        private System.Windows.Forms.Label title;
    }
}

