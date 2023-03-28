namespace _Forms
{
    partial class Form1
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
            this.btn_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_CustName = new System.Windows.Forms.TextBox();
            this.tb_Id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Strict = new System.Windows.Forms.CheckBox();
            this.cb_Relaxed = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_OrderPrice = new System.Windows.Forms.TextBox();
            this.btn_SaveOrder = new System.Windows.Forms.Button();
            this.tb_OrderId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(284, 48);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(83, 29);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Name";
            // 
            // tb_CustName
            // 
            this.tb_CustName.Location = new System.Drawing.Point(15, 49);
            this.tb_CustName.Name = "tb_CustName";
            this.tb_CustName.Size = new System.Drawing.Size(160, 27);
            this.tb_CustName.TabIndex = 2;
            // 
            // tb_Id
            // 
            this.tb_Id.Location = new System.Drawing.Point(182, 49);
            this.tb_Id.Name = "tb_Id";
            this.tb_Id.Size = new System.Drawing.Size(86, 27);
            this.tb_Id.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Id";
            // 
            // cb_Strict
            // 
            this.cb_Strict.AutoSize = true;
            this.cb_Strict.Location = new System.Drawing.Point(6, 27);
            this.cb_Strict.Name = "cb_Strict";
            this.cb_Strict.Size = new System.Drawing.Size(65, 24);
            this.cb_Strict.TabIndex = 0;
            this.cb_Strict.Text = "Strict";
            this.cb_Strict.UseVisualStyleBackColor = true;
            this.cb_Strict.CheckedChanged += new System.EventHandler(this.cb_Strict_CheckedChanged);
            // 
            // cb_Relaxed
            // 
            this.cb_Relaxed.AutoSize = true;
            this.cb_Relaxed.Location = new System.Drawing.Point(6, 57);
            this.cb_Relaxed.Name = "cb_Relaxed";
            this.cb_Relaxed.Size = new System.Drawing.Size(84, 24);
            this.cb_Relaxed.TabIndex = 1;
            this.cb_Relaxed.Text = "Relaxed";
            this.cb_Relaxed.UseVisualStyleBackColor = true;
            this.cb_Relaxed.CheckedChanged += new System.EventHandler(this.cb_Relaxed_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_Strict);
            this.groupBox1.Controls.Add(this.cb_Relaxed);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 190);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type of method used";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tb_CustName);
            this.groupBox2.Controls.Add(this.btn_Save);
            this.groupBox2.Controls.Add(this.tb_Id);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(195, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 91);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Save";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tb_OrderPrice);
            this.groupBox3.Controls.Add(this.btn_SaveOrder);
            this.groupBox3.Controls.Add(this.tb_OrderId);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(195, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(389, 91);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order Save";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Order Price";
            // 
            // tb_OrderPrice
            // 
            this.tb_OrderPrice.Location = new System.Drawing.Point(15, 49);
            this.tb_OrderPrice.Name = "tb_OrderPrice";
            this.tb_OrderPrice.Size = new System.Drawing.Size(160, 27);
            this.tb_OrderPrice.TabIndex = 5;
            // 
            // btn_SaveOrder
            // 
            this.btn_SaveOrder.Location = new System.Drawing.Point(284, 48);
            this.btn_SaveOrder.Name = "btn_SaveOrder";
            this.btn_SaveOrder.Size = new System.Drawing.Size(83, 29);
            this.btn_SaveOrder.TabIndex = 7;
            this.btn_SaveOrder.Text = "Save";
            this.btn_SaveOrder.UseVisualStyleBackColor = true;
            this.btn_SaveOrder.Click += new System.EventHandler(this.btn_SaveOrder_Click);
            // 
            // tb_OrderId
            // 
            this.tb_OrderId.Location = new System.Drawing.Point(182, 49);
            this.tb_OrderId.Name = "tb_OrderId";
            this.tb_OrderId.Size = new System.Drawing.Size(86, 27);
            this.tb_OrderId.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "OrderNr";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 214);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_Save;
        private Label label1;
        private TextBox tb_CustName;
        private TextBox tb_Id;
        private Label label2;
        private CheckBox cb_Strict;
        private CheckBox cb_Relaxed;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label3;
        private TextBox tb_OrderPrice;
        private Button btn_SaveOrder;
        private TextBox tb_OrderId;
        private Label label4;
    }
}