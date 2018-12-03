namespace _3Drawer
{
    partial class ControlForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlForm));
            this.functionLabel = new System.Windows.Forms.Label();
            this.functionField = new System.Windows.Forms.TextBox();
            this.zoomLabel = new System.Windows.Forms.Label();
            this.zoomField = new System.Windows.Forms.TextBox();
            this.dxLabel = new System.Windows.Forms.Label();
            this.dxField = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pointCountLabel = new System.Windows.Forms.Label();
            this.rotationTitleLabel = new System.Windows.Forms.Label();
            this.angleLabel = new System.Windows.Forms.Label();
            this.rotationExplanationLabel = new System.Windows.Forms.Label();
            this.drawFunctionBtn = new System.Windows.Forms.Button();
            this.pointCountApplyBtn = new System.Windows.Forms.Button();
            this.dxApplyBtn = new System.Windows.Forms.Button();
            this.xRotationBtn = new System.Windows.Forms.Button();
            this.yRotationBtn = new System.Windows.Forms.Button();
            this.zRotationBtn = new System.Windows.Forms.Button();
            this.praseFunctionBtn = new System.Windows.Forms.Button();
            this.pointCountField = new System.Windows.Forms.NumericUpDown();
            this.angleField = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pointCountField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleField)).BeginInit();
            this.SuspendLayout();
            // 
            // functionLabel
            // 
            this.functionLabel.AutoSize = true;
            this.functionLabel.Location = new System.Drawing.Point(12, 14);
            this.functionLabel.Name = "functionLabel";
            this.functionLabel.Size = new System.Drawing.Size(20, 13);
            this.functionLabel.TabIndex = 0;
            this.functionLabel.Text = "Z=";
            // 
            // functionField
            // 
            this.functionField.Location = new System.Drawing.Point(38, 11);
            this.functionField.Name = "functionField";
            this.functionField.Size = new System.Drawing.Size(328, 20);
            this.functionField.TabIndex = 1;
            this.functionField.Text = "sin(x) + cos(y)";
            // 
            // zoomLabel
            // 
            this.zoomLabel.AutoSize = true;
            this.zoomLabel.Location = new System.Drawing.Point(12, 46);
            this.zoomLabel.Name = "zoomLabel";
            this.zoomLabel.Size = new System.Drawing.Size(34, 13);
            this.zoomLabel.TabIndex = 2;
            this.zoomLabel.Text = "Zoom";
            // 
            // zoomField
            // 
            this.zoomField.Location = new System.Drawing.Point(52, 43);
            this.zoomField.Name = "zoomField";
            this.zoomField.Size = new System.Drawing.Size(51, 20);
            this.zoomField.TabIndex = 3;
            this.zoomField.Text = "10";
            this.zoomField.KeyUp += new System.Windows.Forms.KeyEventHandler(this.zoomField_KeyUp);
            // 
            // dxLabel
            // 
            this.dxLabel.AutoSize = true;
            this.dxLabel.Location = new System.Drawing.Point(106, 102);
            this.dxLabel.Name = "dxLabel";
            this.dxLabel.Size = new System.Drawing.Size(28, 13);
            this.dxLabel.TabIndex = 4;
            this.dxLabel.Text = "DX=";
            this.toolTip.SetToolTip(this.dxLabel, "Increase in x value");
            // 
            // dxField
            // 
            this.dxField.Location = new System.Drawing.Point(177, 102);
            this.dxField.Name = "dxField";
            this.dxField.Size = new System.Drawing.Size(51, 20);
            this.dxField.TabIndex = 5;
            this.dxField.Text = "1";
            // 
            // toolTip
            // 
            this.toolTip.ToolTipTitle = "What is this?";
            // 
            // pointCountLabel
            // 
            this.pointCountLabel.AutoSize = true;
            this.pointCountLabel.Location = new System.Drawing.Point(106, 73);
            this.pointCountLabel.Name = "pointCountLabel";
            this.pointCountLabel.Size = new System.Drawing.Size(65, 13);
            this.pointCountLabel.TabIndex = 6;
            this.pointCountLabel.Text = "PointCount=";
            this.toolTip.SetToolTip(this.pointCountLabel, "As it increases the representation becomes more accurate but the execution more s" +
        "low");
            // 
            // rotationTitleLabel
            // 
            this.rotationTitleLabel.AutoSize = true;
            this.rotationTitleLabel.Location = new System.Drawing.Point(162, 143);
            this.rotationTitleLabel.Name = "rotationTitleLabel";
            this.rotationTitleLabel.Size = new System.Drawing.Size(47, 13);
            this.rotationTitleLabel.TabIndex = 10;
            this.rotationTitleLabel.Text = "Rotation";
            this.toolTip.SetToolTip(this.rotationTitleLabel, "Increase in x value");
            // 
            // angleLabel
            // 
            this.angleLabel.AutoSize = true;
            this.angleLabel.Location = new System.Drawing.Point(12, 174);
            this.angleLabel.Name = "angleLabel";
            this.angleLabel.Size = new System.Drawing.Size(40, 13);
            this.angleLabel.TabIndex = 12;
            this.angleLabel.Text = "Angle=";
            this.toolTip.SetToolTip(this.angleLabel, "Rotational angel in degrees");
            // 
            // rotationExplanationLabel
            // 
            this.rotationExplanationLabel.AutoSize = true;
            this.rotationExplanationLabel.Location = new System.Drawing.Point(124, 174);
            this.rotationExplanationLabel.Name = "rotationExplanationLabel";
            this.rotationExplanationLabel.Size = new System.Drawing.Size(67, 13);
            this.rotationExplanationLabel.TabIndex = 13;
            this.rotationExplanationLabel.Text = "RotateAbout";
            this.toolTip.SetToolTip(this.rotationExplanationLabel, "Increase in x value");
            // 
            // drawFunctionBtn
            // 
            this.drawFunctionBtn.Location = new System.Drawing.Point(29, 214);
            this.drawFunctionBtn.Name = "drawFunctionBtn";
            this.drawFunctionBtn.Size = new System.Drawing.Size(383, 23);
            this.drawFunctionBtn.TabIndex = 17;
            this.drawFunctionBtn.Text = "Draw";
            this.toolTip.SetToolTip(this.drawFunctionBtn, "Draw the fuction with lines");
            this.drawFunctionBtn.UseVisualStyleBackColor = true;
            this.drawFunctionBtn.Click += new System.EventHandler(this.drawFunctionBtn_Click);
            // 
            // pointCountApplyBtn
            // 
            this.pointCountApplyBtn.Location = new System.Drawing.Point(234, 73);
            this.pointCountApplyBtn.Name = "pointCountApplyBtn";
            this.pointCountApplyBtn.Size = new System.Drawing.Size(40, 23);
            this.pointCountApplyBtn.TabIndex = 8;
            this.pointCountApplyBtn.Text = "apply";
            this.pointCountApplyBtn.UseVisualStyleBackColor = true;
            this.pointCountApplyBtn.Click += new System.EventHandler(this.pointCountApplyBtn_Click);
            // 
            // dxApplyBtn
            // 
            this.dxApplyBtn.Location = new System.Drawing.Point(234, 102);
            this.dxApplyBtn.Name = "dxApplyBtn";
            this.dxApplyBtn.Size = new System.Drawing.Size(40, 23);
            this.dxApplyBtn.TabIndex = 9;
            this.dxApplyBtn.Text = "apply";
            this.dxApplyBtn.UseVisualStyleBackColor = true;
            this.dxApplyBtn.Click += new System.EventHandler(this.dxApplyBtn_Click);
            // 
            // xRotationBtn
            // 
            this.xRotationBtn.Location = new System.Drawing.Point(222, 169);
            this.xRotationBtn.Name = "xRotationBtn";
            this.xRotationBtn.Size = new System.Drawing.Size(52, 23);
            this.xRotationBtn.TabIndex = 14;
            this.xRotationBtn.Text = "X axis";
            this.xRotationBtn.UseVisualStyleBackColor = true;
            this.xRotationBtn.Click += new System.EventHandler(this.xRotationBtn_Click);
            // 
            // yRotationBtn
            // 
            this.yRotationBtn.Location = new System.Drawing.Point(280, 168);
            this.yRotationBtn.Name = "yRotationBtn";
            this.yRotationBtn.Size = new System.Drawing.Size(64, 23);
            this.yRotationBtn.TabIndex = 15;
            this.yRotationBtn.Text = "Y axis";
            this.yRotationBtn.UseVisualStyleBackColor = true;
            this.yRotationBtn.Click += new System.EventHandler(this.yRotationBtn_Click);
            // 
            // zRotationBtn
            // 
            this.zRotationBtn.Location = new System.Drawing.Point(350, 168);
            this.zRotationBtn.Name = "zRotationBtn";
            this.zRotationBtn.Size = new System.Drawing.Size(62, 23);
            this.zRotationBtn.TabIndex = 16;
            this.zRotationBtn.Text = "Z axis";
            this.zRotationBtn.UseVisualStyleBackColor = true;
            this.zRotationBtn.Click += new System.EventHandler(this.zRotationBtn_Click);
            // 
            // praseFunctionBtn
            // 
            this.praseFunctionBtn.Location = new System.Drawing.Point(372, 9);
            this.praseFunctionBtn.Name = "praseFunctionBtn";
            this.praseFunctionBtn.Size = new System.Drawing.Size(40, 23);
            this.praseFunctionBtn.TabIndex = 19;
            this.praseFunctionBtn.Text = "apply";
            this.praseFunctionBtn.UseVisualStyleBackColor = true;
            this.praseFunctionBtn.Click += new System.EventHandler(this.praseFunctionBtn_Click);
            // 
            // pointCountField
            // 
            this.pointCountField.Location = new System.Drawing.Point(177, 71);
            this.pointCountField.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.pointCountField.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.pointCountField.Name = "pointCountField";
            this.pointCountField.Size = new System.Drawing.Size(51, 20);
            this.pointCountField.TabIndex = 20;
            this.pointCountField.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // angleField
            // 
            this.angleField.Location = new System.Drawing.Point(52, 171);
            this.angleField.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.angleField.Name = "angleField";
            this.angleField.Size = new System.Drawing.Size(51, 20);
            this.angleField.TabIndex = 21;
            this.angleField.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(424, 261);
            this.Controls.Add(this.angleField);
            this.Controls.Add(this.pointCountField);
            this.Controls.Add(this.praseFunctionBtn);
            this.Controls.Add(this.drawFunctionBtn);
            this.Controls.Add(this.zRotationBtn);
            this.Controls.Add(this.yRotationBtn);
            this.Controls.Add(this.xRotationBtn);
            this.Controls.Add(this.rotationExplanationLabel);
            this.Controls.Add(this.angleLabel);
            this.Controls.Add(this.rotationTitleLabel);
            this.Controls.Add(this.dxApplyBtn);
            this.Controls.Add(this.pointCountApplyBtn);
            this.Controls.Add(this.pointCountLabel);
            this.Controls.Add(this.dxField);
            this.Controls.Add(this.dxLabel);
            this.Controls.Add(this.zoomField);
            this.Controls.Add(this.zoomLabel);
            this.Controls.Add(this.functionField);
            this.Controls.Add(this.functionLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(440, 300);
            this.MinimumSize = new System.Drawing.Size(440, 300);
            this.Name = "ControlForm";
            this.ShowIcon = false;
            this.Text = "ControlForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ControlForm_FormClosing);
            this.Load += new System.EventHandler(this.ControlForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pointCountField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label functionLabel;
        private System.Windows.Forms.TextBox functionField;
        private System.Windows.Forms.Label zoomLabel;
        private System.Windows.Forms.TextBox zoomField;
        private System.Windows.Forms.Label dxLabel;
        private System.Windows.Forms.TextBox dxField;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label pointCountLabel;
        private System.Windows.Forms.Button pointCountApplyBtn;
        private System.Windows.Forms.Button dxApplyBtn;
        private System.Windows.Forms.Label rotationTitleLabel;
        private System.Windows.Forms.Label angleLabel;
        private System.Windows.Forms.Label rotationExplanationLabel;
        private System.Windows.Forms.Button xRotationBtn;
        private System.Windows.Forms.Button yRotationBtn;
        private System.Windows.Forms.Button zRotationBtn;
        private System.Windows.Forms.Button drawFunctionBtn;
        private System.Windows.Forms.Button praseFunctionBtn;
        private System.Windows.Forms.NumericUpDown pointCountField;
        private System.Windows.Forms.NumericUpDown angleField;
    }
}