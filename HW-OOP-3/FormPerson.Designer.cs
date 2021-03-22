
namespace HWFormsApp
{
    partial class FormPerson
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelNum = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelBot = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelProducts = new System.Windows.Forms.Panel();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.panelProductButtons = new System.Windows.Forms.Panel();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.panelBot.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelProducts.SuspendLayout();
            this.panelProductButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(39, 15);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Location = new System.Drawing.Point(12, 55);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(34, 15);
            this.labelNum.TabIndex = 1;
            this.labelNum.Text = "Num";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 29);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(248, 23);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxNum
            // 
            this.textBoxNum.Location = new System.Drawing.Point(12, 73);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(248, 23);
            this.textBoxNum.TabIndex = 3;
            // 
            // buttonOk
            // 
            this.buttonOk.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonOk.Location = new System.Drawing.Point(289, 5);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 26);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCancel.Location = new System.Drawing.Point(214, 5);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 26);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // panelBot
            // 
            this.panelBot.Controls.Add(this.buttonCancel);
            this.panelBot.Controls.Add(this.buttonOk);
            this.panelBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBot.Location = new System.Drawing.Point(0, 362);
            this.panelBot.Name = "panelBot";
            this.panelBot.Padding = new System.Windows.Forms.Padding(5);
            this.panelBot.Size = new System.Drawing.Size(369, 36);
            this.panelBot.TabIndex = 6;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.textBoxName);
            this.panelTop.Controls.Add(this.textBoxNum);
            this.panelTop.Controls.Add(this.labelName);
            this.panelTop.Controls.Add(this.labelNum);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panelTop.Size = new System.Drawing.Size(369, 112);
            this.panelTop.TabIndex = 7;
            // 
            // panelProducts
            // 
            this.panelProducts.Controls.Add(this.listBoxProducts);
            this.panelProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProducts.Location = new System.Drawing.Point(0, 112);
            this.panelProducts.Name = "panelProducts";
            this.panelProducts.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.panelProducts.Size = new System.Drawing.Size(369, 209);
            this.panelProducts.TabIndex = 8;
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.ItemHeight = 15;
            this.listBoxProducts.Location = new System.Drawing.Point(10, 10);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(349, 199);
            this.listBoxProducts.TabIndex = 0;
            this.listBoxProducts.DoubleClick += new System.EventHandler(this.listBoxProducts_DoubleClick);
            this.listBoxProducts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxProducts_KeyDown);
            // 
            // panelProductButtons
            // 
            this.panelProductButtons.Controls.Add(this.buttonRemove);
            this.panelProductButtons.Controls.Add(this.buttonAddProduct);
            this.panelProductButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelProductButtons.Location = new System.Drawing.Point(0, 321);
            this.panelProductButtons.Name = "panelProductButtons";
            this.panelProductButtons.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.panelProductButtons.Size = new System.Drawing.Size(369, 41);
            this.panelProductButtons.TabIndex = 1;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonRemove.Location = new System.Drawing.Point(119, 5);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(120, 26);
            this.buttonRemove.TabIndex = 0;
            this.buttonRemove.Text = "Remove product";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemoveProduct_Click);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonAddProduct.Location = new System.Drawing.Point(239, 5);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(120, 26);
            this.buttonAddProduct.TabIndex = 0;
            this.buttonAddProduct.Text = "Add Product";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // FormPerson
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(369, 398);
            this.Controls.Add(this.panelProducts);
            this.Controls.Add(this.panelProductButtons);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBot);
            this.Name = "FormPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Person";
            this.panelBot.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelProducts.ResumeLayout(false);
            this.panelProductButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panelBot;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelProducts;
        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.Panel panelProductButtons;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAddProduct;
    }
}