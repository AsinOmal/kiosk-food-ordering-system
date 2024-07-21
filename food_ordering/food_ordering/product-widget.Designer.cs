namespace food_ordering
{
    partial class product_widget
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(product_widget));
            this.itemImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.btnMinus = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.lblCount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnCart = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.itemImage)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemImage
            // 
            this.itemImage.Image = ((System.Drawing.Image)(resources.GetObject("itemImage.Image")));
            this.itemImage.Location = new System.Drawing.Point(6, 2);
            this.itemImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemImage.Name = "itemImage";
            this.itemImage.ShadowDecoration.Parent = this.itemImage;
            this.itemImage.Size = new System.Drawing.Size(176, 161);
            this.itemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.itemImage.TabIndex = 0;
            this.itemImage.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.Red;
            this.btnAdd.FillColor2 = System.Drawing.Color.Red;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnAdd.HoverState.FillColor2 = System.Drawing.Color.Black;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(103, 189);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(30, 30);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "+";
            this.btnAdd.TextOffset = new System.Drawing.Point(-1, -2);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.Transparent;
            this.btnMinus.BorderColor = System.Drawing.Color.Transparent;
            this.btnMinus.BorderRadius = 15;
            this.btnMinus.CheckedState.Parent = this.btnMinus;
            this.btnMinus.CustomImages.Parent = this.btnMinus;
            this.btnMinus.FillColor = System.Drawing.Color.LimeGreen;
            this.btnMinus.FillColor2 = System.Drawing.Color.LimeGreen;
            this.btnMinus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.ForeColor = System.Drawing.Color.White;
            this.btnMinus.HoverState.FillColor = System.Drawing.Color.Lime;
            this.btnMinus.HoverState.FillColor2 = System.Drawing.Color.Green;
            this.btnMinus.HoverState.Parent = this.btnMinus;
            this.btnMinus.Location = new System.Drawing.Point(46, 189);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnMinus.ShadowDecoration.Parent = this.btnMinus;
            this.btnMinus.Size = new System.Drawing.Size(30, 30);
            this.btnMinus.TabIndex = 5;
            this.btnMinus.Text = "-";
            this.btnMinus.TextOffset = new System.Drawing.Point(0, -2);
            this.btnMinus.Click += new System.EventHandler(this.guna2GradientCircleButton1_Click);
            // 
            // lblCount
            // 
            this.lblCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(83, 192);
            this.lblCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(12, 23);
            this.lblCount.TabIndex = 7;
            this.lblCount.Text = "1";
            this.lblCount.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(18, 165);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(153, 20);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "PLACEHOLDER TEXT";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(48, 221);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(91, 25);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Rs. 1250 ";
            // 
            // btnCart
            // 
            this.btnCart.BorderRadius = 10;
            this.btnCart.CheckedState.Parent = this.btnCart;
            this.btnCart.CustomImages.Parent = this.btnCart;
            this.btnCart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCart.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart.ForeColor = System.Drawing.Color.White;
            this.btnCart.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnCart.HoverState.FillColor2 = System.Drawing.Color.Black;
            this.btnCart.HoverState.Parent = this.btnCart;
            this.btnCart.Location = new System.Drawing.Point(15, 251);
            this.btnCart.Margin = new System.Windows.Forms.Padding(4);
            this.btnCart.Name = "btnCart";
            this.btnCart.ShadowDecoration.Parent = this.btnCart;
            this.btnCart.Size = new System.Drawing.Size(155, 50);
            this.btnCart.TabIndex = 11;
            this.btnCart.Text = "Add to Cart";
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.Controls.Add(this.btnCart);
            this.guna2Panel1.Controls.Add(this.lblName);
            this.guna2Panel1.Controls.Add(this.btnMinus);
            this.guna2Panel1.Controls.Add(this.itemImage);
            this.guna2Panel1.Controls.Add(this.lblPrice);
            this.guna2Panel1.Controls.Add(this.btnAdd);
            this.guna2Panel1.Controls.Add(this.lblCount);
            this.guna2Panel1.ForeColor = System.Drawing.Color.Black;
            this.guna2Panel1.Location = new System.Drawing.Point(3, 5);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Color = System.Drawing.Color.DarkGray;
            this.guna2Panel1.ShadowDecoration.Depth = 5;
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(193, 306);
            this.guna2Panel1.TabIndex = 12;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.Controls.Add(this.guna2Panel1);
            this.guna2Panel2.ForeColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Color = System.Drawing.Color.DarkGray;
            this.guna2Panel2.ShadowDecoration.Depth = 5;
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(199, 314);
            this.guna2Panel2.TabIndex = 13;
            // 
            // product_widget
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2Panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "product_widget";
            this.Size = new System.Drawing.Size(202, 318);
            this.Load += new System.EventHandler(this.product_widget_Load);
            this.LocationChanged += new System.EventHandler(this.product_widget_LocationChanged);
            ((System.ComponentModel.ISupportInitialize)(this.itemImage)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox itemImage;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnAdd;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnMinus;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCount;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private Guna.UI2.WinForms.Guna2GradientButton btnCart;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
    }
}
