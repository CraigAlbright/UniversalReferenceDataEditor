namespace UniversalReferenceDataEditor
{
    partial class QueryRunningForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryRunningForm));
            this.progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressPanel1
            // 
            this.progressPanel1.AnimationElementImage = ((System.Drawing.Image)(resources.GetObject("progressPanel1.AnimationElementImage")));
            this.progressPanel1.AnimationSpeed = 8F;
            this.progressPanel1.Appearance.BackColor = System.Drawing.Color.DarkBlue;
            this.progressPanel1.Appearance.Options.UseBackColor = true;
            this.progressPanel1.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressPanel1.AppearanceCaption.Options.UseFont = true;
            this.progressPanel1.AppearanceCaption.Options.UseTextOptions = true;
            this.progressPanel1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.progressPanel1.AppearanceCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.progressPanel1.AppearanceCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.progressPanel1.AppearanceDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.progressPanel1.AppearanceDescription.Options.UseFont = true;
            this.progressPanel1.BarAnimationElementThickness = 2;
            this.progressPanel1.ContentAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.progressPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressPanel1.FrameCount = 44100;
            this.progressPanel1.FrameInterval = 350;
            this.progressPanel1.ImageHorzOffset = 20;
            this.progressPanel1.LineAnimationElementHeight = 15;
            this.progressPanel1.Location = new System.Drawing.Point(0, 27);
            this.progressPanel1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.progressPanel1.Name = "progressPanel1";
            this.progressPanel1.Size = new System.Drawing.Size(650, 196);
            this.progressPanel1.TabIndex = 0;
            this.progressPanel1.Text = "progressPanel1";
            this.progressPanel1.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Line;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.progressPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 22, 0, 22);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(650, 250);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // QueryRunningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(650, 250);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "QueryRunningForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraWaitForm.ProgressPanel progressPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
