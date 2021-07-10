
namespace WinFormsApp1
{
    partial class TableControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTableNo = new System.Windows.Forms.Label();
            this.lblFloorNo = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTableNo
            // 
            this.lblTableNo.AutoSize = true;
            this.lblTableNo.Location = new System.Drawing.Point(15, 14);
            this.lblTableNo.Name = "lblTableNo";
            this.lblTableNo.Size = new System.Drawing.Size(38, 15);
            this.lblTableNo.TabIndex = 0;
            this.lblTableNo.Text = "label1";
            // 
            // lblFloorNo
            // 
            this.lblFloorNo.AutoSize = true;
            this.lblFloorNo.Location = new System.Drawing.Point(90, 14);
            this.lblFloorNo.Name = "lblFloorNo";
            this.lblFloorNo.Size = new System.Drawing.Size(38, 15);
            this.lblFloorNo.TabIndex = 1;
            this.lblFloorNo.Text = "label2";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalAmount.ForeColor = System.Drawing.Color.Red;
            this.lblTotalAmount.Location = new System.Drawing.Point(15, 72);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(59, 25);
            this.lblTotalAmount.TabIndex = 2;
            this.lblTotalAmount.Text = "label3";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(15, 119);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(50, 23);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(71, 119);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(76, 23);
            this.btnCheckOut.TabIndex = 4;
            this.btnCheckOut.Text = "Checkout";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // TableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblFloorNo);
            this.Controls.Add(this.lblTableNo);
            this.Name = "TableControl";
            this.Size = new System.Drawing.Size(146, 146);
            this.Load += new System.EventHandler(this.TableControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTableNo;
        private System.Windows.Forms.Label lblFloorNo;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnCheckOut;
    }
}
