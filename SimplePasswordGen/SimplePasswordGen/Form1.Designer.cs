
namespace SimplePasswordGen
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
            this.components = new System.ComponentModel.Container();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bnt_Gen = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtPassword = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Check6Chars = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.Check10Chars = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.Check20Chars = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.Check35Chars = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bnt_Copy = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bnt_Gen
            // 
            this.bnt_Gen.AllowAnimations = true;
            this.bnt_Gen.AllowMouseEffects = true;
            this.bnt_Gen.AllowToggling = false;
            this.bnt_Gen.AnimationSpeed = 200;
            this.bnt_Gen.AutoGenerateColors = false;
            this.bnt_Gen.AutoRoundBorders = false;
            this.bnt_Gen.AutoSizeLeftIcon = true;
            this.bnt_Gen.AutoSizeRightIcon = true;
            this.bnt_Gen.BackColor = System.Drawing.Color.Transparent;
            this.bnt_Gen.BackColor1 = System.Drawing.Color.Gray;
            this.bnt_Gen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnt_Gen.BackgroundImage")));
            this.bnt_Gen.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bnt_Gen.ButtonText = "Generate Password";
            this.bnt_Gen.ButtonTextMarginLeft = 0;
            this.bnt_Gen.ColorContrastOnClick = 45;
            this.bnt_Gen.ColorContrastOnHover = 45;
            this.bnt_Gen.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.bnt_Gen.CustomizableEdges = borderEdges2;
            this.bnt_Gen.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bnt_Gen.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bnt_Gen.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bnt_Gen.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bnt_Gen.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bnt_Gen.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_Gen.ForeColor = System.Drawing.Color.White;
            this.bnt_Gen.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnt_Gen.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bnt_Gen.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bnt_Gen.IconMarginLeft = 11;
            this.bnt_Gen.IconPadding = 10;
            this.bnt_Gen.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bnt_Gen.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bnt_Gen.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bnt_Gen.IconSize = 25;
            this.bnt_Gen.IdleBorderColor = System.Drawing.Color.Transparent;
            this.bnt_Gen.IdleBorderRadius = 16;
            this.bnt_Gen.IdleBorderThickness = 1;
            this.bnt_Gen.IdleFillColor = System.Drawing.Color.Gray;
            this.bnt_Gen.IdleIconLeftImage = null;
            this.bnt_Gen.IdleIconRightImage = null;
            this.bnt_Gen.IndicateFocus = false;
            this.bnt_Gen.Location = new System.Drawing.Point(36, 295);
            this.bnt_Gen.Name = "bnt_Gen";
            this.bnt_Gen.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bnt_Gen.OnDisabledState.BorderRadius = 16;
            this.bnt_Gen.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bnt_Gen.OnDisabledState.BorderThickness = 1;
            this.bnt_Gen.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bnt_Gen.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bnt_Gen.OnDisabledState.IconLeftImage = null;
            this.bnt_Gen.OnDisabledState.IconRightImage = null;
            this.bnt_Gen.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.bnt_Gen.onHoverState.BorderRadius = 16;
            this.bnt_Gen.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bnt_Gen.onHoverState.BorderThickness = 1;
            this.bnt_Gen.onHoverState.FillColor = System.Drawing.Color.Green;
            this.bnt_Gen.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bnt_Gen.onHoverState.IconLeftImage = null;
            this.bnt_Gen.onHoverState.IconRightImage = null;
            this.bnt_Gen.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.bnt_Gen.OnIdleState.BorderRadius = 16;
            this.bnt_Gen.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bnt_Gen.OnIdleState.BorderThickness = 1;
            this.bnt_Gen.OnIdleState.FillColor = System.Drawing.Color.Gray;
            this.bnt_Gen.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bnt_Gen.OnIdleState.IconLeftImage = null;
            this.bnt_Gen.OnIdleState.IconRightImage = null;
            this.bnt_Gen.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.bnt_Gen.OnPressedState.BorderRadius = 16;
            this.bnt_Gen.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bnt_Gen.OnPressedState.BorderThickness = 1;
            this.bnt_Gen.OnPressedState.FillColor = System.Drawing.Color.Green;
            this.bnt_Gen.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bnt_Gen.OnPressedState.IconLeftImage = null;
            this.bnt_Gen.OnPressedState.IconRightImage = null;
            this.bnt_Gen.Size = new System.Drawing.Size(171, 45);
            this.bnt_Gen.TabIndex = 0;
            this.bnt_Gen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnt_Gen.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bnt_Gen.TextMarginLeft = 0;
            this.bnt_Gen.TextPadding = new System.Windows.Forms.Padding(0);
            this.bnt_Gen.UseDefaultRadiusAndThickness = true;
            this.bnt_Gen.Click += new System.EventHandler(this.bnt_Gen_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsReturn = false;
            this.txtPassword.AcceptsTab = false;
            this.txtPassword.AnimationSpeed = 200;
            this.txtPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPassword.BackgroundImage")));
            this.txtPassword.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtPassword.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtPassword.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtPassword.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtPassword.BorderRadius = 1;
            this.txtPassword.BorderThickness = 1;
            this.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtPassword.DefaultText = "";
            this.txtPassword.FillColor = System.Drawing.Color.White;
            this.txtPassword.HideSelection = true;
            this.txtPassword.IconLeft = null;
            this.txtPassword.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.IconPadding = 10;
            this.txtPassword.IconRight = null;
            this.txtPassword.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(36, 63);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtPassword.Modified = false;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPassword.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.OnIdleState = stateProperties4;
            this.txtPassword.Padding = new System.Windows.Forms.Padding(3);
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtPassword.PlaceholderText = "Generated Password";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(346, 49);
            this.txtPassword.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.TextMarginBottom = 0;
            this.txtPassword.TextMarginLeft = 3;
            this.txtPassword.TextMarginTop = 0;
            this.txtPassword.TextPlaceholder = "Generated Password";
            this.txtPassword.UseSystemPasswordChar = false;
            this.txtPassword.WordWrap = true;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 53;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(558, -28);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(106, 106);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 3;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.bunifuPictureBox1.Click += new System.EventHandler(this.bunifuPictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(67, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "6 Characters";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "10 Characters";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(67, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "20 Characters";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(67, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "35 Characters";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(43, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Default is 8 Characters";
            // 
            // Check6Chars
            // 
            this.Check6Chars.AllowBindingControlAnimation = true;
            this.Check6Chars.AllowBindingControlColorChanges = false;
            this.Check6Chars.AllowBindingControlLocation = true;
            this.Check6Chars.AllowCheckBoxAnimation = false;
            this.Check6Chars.AllowCheckmarkAnimation = true;
            this.Check6Chars.AllowOnHoverStates = true;
            this.Check6Chars.AutoCheck = true;
            this.Check6Chars.BackColor = System.Drawing.Color.Transparent;
            this.Check6Chars.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Check6Chars.BackgroundImage")));
            this.Check6Chars.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Check6Chars.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.Check6Chars.BorderRadius = 17;
            this.Check6Chars.Checked = false;
            this.Check6Chars.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.Check6Chars.Cursor = System.Windows.Forms.Cursors.Default;
            this.Check6Chars.CustomCheckmarkImage = null;
            this.Check6Chars.Location = new System.Drawing.Point(40, 125);
            this.Check6Chars.MinimumSize = new System.Drawing.Size(17, 17);
            this.Check6Chars.Name = "Check6Chars";
            this.Check6Chars.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Check6Chars.OnCheck.BorderRadius = 17;
            this.Check6Chars.OnCheck.BorderThickness = 2;
            this.Check6Chars.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.Check6Chars.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.Check6Chars.OnCheck.CheckmarkThickness = 2;
            this.Check6Chars.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.Check6Chars.OnDisable.BorderRadius = 17;
            this.Check6Chars.OnDisable.BorderThickness = 2;
            this.Check6Chars.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.Check6Chars.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.Check6Chars.OnDisable.CheckmarkThickness = 2;
            this.Check6Chars.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Check6Chars.OnHoverChecked.BorderRadius = 17;
            this.Check6Chars.OnHoverChecked.BorderThickness = 2;
            this.Check6Chars.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Check6Chars.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.Check6Chars.OnHoverChecked.CheckmarkThickness = 2;
            this.Check6Chars.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Check6Chars.OnHoverUnchecked.BorderRadius = 17;
            this.Check6Chars.OnHoverUnchecked.BorderThickness = 1;
            this.Check6Chars.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.Check6Chars.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.Check6Chars.OnUncheck.BorderRadius = 17;
            this.Check6Chars.OnUncheck.BorderThickness = 1;
            this.Check6Chars.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.Check6Chars.Size = new System.Drawing.Size(21, 21);
            this.Check6Chars.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Flat;
            this.Check6Chars.TabIndex = 5;
            this.Check6Chars.ThreeState = false;
            this.Check6Chars.ToolTipText = null;
            // 
            // Check10Chars
            // 
            this.Check10Chars.AllowBindingControlAnimation = true;
            this.Check10Chars.AllowBindingControlColorChanges = false;
            this.Check10Chars.AllowBindingControlLocation = true;
            this.Check10Chars.AllowCheckBoxAnimation = false;
            this.Check10Chars.AllowCheckmarkAnimation = true;
            this.Check10Chars.AllowOnHoverStates = true;
            this.Check10Chars.AutoCheck = true;
            this.Check10Chars.BackColor = System.Drawing.Color.Transparent;
            this.Check10Chars.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Check10Chars.BackgroundImage")));
            this.Check10Chars.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Check10Chars.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.Check10Chars.BorderRadius = 17;
            this.Check10Chars.Checked = false;
            this.Check10Chars.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.Check10Chars.Cursor = System.Windows.Forms.Cursors.Default;
            this.Check10Chars.CustomCheckmarkImage = null;
            this.Check10Chars.Location = new System.Drawing.Point(40, 160);
            this.Check10Chars.MinimumSize = new System.Drawing.Size(17, 17);
            this.Check10Chars.Name = "Check10Chars";
            this.Check10Chars.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Check10Chars.OnCheck.BorderRadius = 17;
            this.Check10Chars.OnCheck.BorderThickness = 2;
            this.Check10Chars.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.Check10Chars.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.Check10Chars.OnCheck.CheckmarkThickness = 2;
            this.Check10Chars.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.Check10Chars.OnDisable.BorderRadius = 17;
            this.Check10Chars.OnDisable.BorderThickness = 2;
            this.Check10Chars.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.Check10Chars.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.Check10Chars.OnDisable.CheckmarkThickness = 2;
            this.Check10Chars.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Check10Chars.OnHoverChecked.BorderRadius = 17;
            this.Check10Chars.OnHoverChecked.BorderThickness = 2;
            this.Check10Chars.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Check10Chars.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.Check10Chars.OnHoverChecked.CheckmarkThickness = 2;
            this.Check10Chars.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Check10Chars.OnHoverUnchecked.BorderRadius = 17;
            this.Check10Chars.OnHoverUnchecked.BorderThickness = 1;
            this.Check10Chars.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.Check10Chars.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.Check10Chars.OnUncheck.BorderRadius = 17;
            this.Check10Chars.OnUncheck.BorderThickness = 1;
            this.Check10Chars.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.Check10Chars.Size = new System.Drawing.Size(21, 21);
            this.Check10Chars.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Flat;
            this.Check10Chars.TabIndex = 5;
            this.Check10Chars.ThreeState = false;
            this.Check10Chars.ToolTipText = null;
            // 
            // Check20Chars
            // 
            this.Check20Chars.AllowBindingControlAnimation = true;
            this.Check20Chars.AllowBindingControlColorChanges = false;
            this.Check20Chars.AllowBindingControlLocation = true;
            this.Check20Chars.AllowCheckBoxAnimation = false;
            this.Check20Chars.AllowCheckmarkAnimation = true;
            this.Check20Chars.AllowOnHoverStates = true;
            this.Check20Chars.AutoCheck = true;
            this.Check20Chars.BackColor = System.Drawing.Color.Transparent;
            this.Check20Chars.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Check20Chars.BackgroundImage")));
            this.Check20Chars.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Check20Chars.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.Check20Chars.BorderRadius = 17;
            this.Check20Chars.Checked = false;
            this.Check20Chars.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.Check20Chars.Cursor = System.Windows.Forms.Cursors.Default;
            this.Check20Chars.CustomCheckmarkImage = null;
            this.Check20Chars.Location = new System.Drawing.Point(40, 193);
            this.Check20Chars.MinimumSize = new System.Drawing.Size(17, 17);
            this.Check20Chars.Name = "Check20Chars";
            this.Check20Chars.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Check20Chars.OnCheck.BorderRadius = 17;
            this.Check20Chars.OnCheck.BorderThickness = 2;
            this.Check20Chars.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.Check20Chars.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.Check20Chars.OnCheck.CheckmarkThickness = 2;
            this.Check20Chars.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.Check20Chars.OnDisable.BorderRadius = 17;
            this.Check20Chars.OnDisable.BorderThickness = 2;
            this.Check20Chars.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.Check20Chars.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.Check20Chars.OnDisable.CheckmarkThickness = 2;
            this.Check20Chars.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Check20Chars.OnHoverChecked.BorderRadius = 17;
            this.Check20Chars.OnHoverChecked.BorderThickness = 2;
            this.Check20Chars.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Check20Chars.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.Check20Chars.OnHoverChecked.CheckmarkThickness = 2;
            this.Check20Chars.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Check20Chars.OnHoverUnchecked.BorderRadius = 17;
            this.Check20Chars.OnHoverUnchecked.BorderThickness = 1;
            this.Check20Chars.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.Check20Chars.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.Check20Chars.OnUncheck.BorderRadius = 17;
            this.Check20Chars.OnUncheck.BorderThickness = 1;
            this.Check20Chars.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.Check20Chars.Size = new System.Drawing.Size(21, 21);
            this.Check20Chars.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Flat;
            this.Check20Chars.TabIndex = 5;
            this.Check20Chars.ThreeState = false;
            this.Check20Chars.ToolTipText = null;
            // 
            // Check35Chars
            // 
            this.Check35Chars.AllowBindingControlAnimation = true;
            this.Check35Chars.AllowBindingControlColorChanges = false;
            this.Check35Chars.AllowBindingControlLocation = true;
            this.Check35Chars.AllowCheckBoxAnimation = false;
            this.Check35Chars.AllowCheckmarkAnimation = true;
            this.Check35Chars.AllowOnHoverStates = true;
            this.Check35Chars.AutoCheck = true;
            this.Check35Chars.BackColor = System.Drawing.Color.Transparent;
            this.Check35Chars.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Check35Chars.BackgroundImage")));
            this.Check35Chars.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Check35Chars.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.Check35Chars.BorderRadius = 17;
            this.Check35Chars.Checked = false;
            this.Check35Chars.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.Check35Chars.Cursor = System.Windows.Forms.Cursors.Default;
            this.Check35Chars.CustomCheckmarkImage = null;
            this.Check35Chars.Location = new System.Drawing.Point(40, 226);
            this.Check35Chars.MinimumSize = new System.Drawing.Size(17, 17);
            this.Check35Chars.Name = "Check35Chars";
            this.Check35Chars.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Check35Chars.OnCheck.BorderRadius = 17;
            this.Check35Chars.OnCheck.BorderThickness = 2;
            this.Check35Chars.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.Check35Chars.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.Check35Chars.OnCheck.CheckmarkThickness = 2;
            this.Check35Chars.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.Check35Chars.OnDisable.BorderRadius = 17;
            this.Check35Chars.OnDisable.BorderThickness = 2;
            this.Check35Chars.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.Check35Chars.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.Check35Chars.OnDisable.CheckmarkThickness = 2;
            this.Check35Chars.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Check35Chars.OnHoverChecked.BorderRadius = 17;
            this.Check35Chars.OnHoverChecked.BorderThickness = 2;
            this.Check35Chars.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Check35Chars.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.Check35Chars.OnHoverChecked.CheckmarkThickness = 2;
            this.Check35Chars.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Check35Chars.OnHoverUnchecked.BorderRadius = 17;
            this.Check35Chars.OnHoverUnchecked.BorderThickness = 1;
            this.Check35Chars.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.Check35Chars.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.Check35Chars.OnUncheck.BorderRadius = 17;
            this.Check35Chars.OnUncheck.BorderThickness = 1;
            this.Check35Chars.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.Check35Chars.Size = new System.Drawing.Size(21, 21);
            this.Check35Chars.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Flat;
            this.Check35Chars.TabIndex = 5;
            this.Check35Chars.ThreeState = false;
            this.Check35Chars.ToolTipText = null;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Aquatico", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(364, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Simple C# Password Generator for github :D";
            // 
            // bnt_Copy
            // 
            this.bnt_Copy.AllowAnimations = true;
            this.bnt_Copy.AllowMouseEffects = true;
            this.bnt_Copy.AllowToggling = false;
            this.bnt_Copy.AnimationSpeed = 200;
            this.bnt_Copy.AutoGenerateColors = false;
            this.bnt_Copy.AutoRoundBorders = false;
            this.bnt_Copy.AutoSizeLeftIcon = true;
            this.bnt_Copy.AutoSizeRightIcon = true;
            this.bnt_Copy.BackColor = System.Drawing.Color.Transparent;
            this.bnt_Copy.BackColor1 = System.Drawing.Color.Gray;
            this.bnt_Copy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnt_Copy.BackgroundImage")));
            this.bnt_Copy.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bnt_Copy.ButtonText = "Copy Password";
            this.bnt_Copy.ButtonTextMarginLeft = 0;
            this.bnt_Copy.ColorContrastOnClick = 45;
            this.bnt_Copy.ColorContrastOnHover = 45;
            this.bnt_Copy.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bnt_Copy.CustomizableEdges = borderEdges1;
            this.bnt_Copy.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bnt_Copy.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bnt_Copy.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bnt_Copy.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bnt_Copy.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bnt_Copy.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_Copy.ForeColor = System.Drawing.Color.White;
            this.bnt_Copy.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnt_Copy.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bnt_Copy.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bnt_Copy.IconMarginLeft = 11;
            this.bnt_Copy.IconPadding = 10;
            this.bnt_Copy.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bnt_Copy.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bnt_Copy.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bnt_Copy.IconSize = 25;
            this.bnt_Copy.IdleBorderColor = System.Drawing.Color.Transparent;
            this.bnt_Copy.IdleBorderRadius = 16;
            this.bnt_Copy.IdleBorderThickness = 1;
            this.bnt_Copy.IdleFillColor = System.Drawing.Color.Gray;
            this.bnt_Copy.IdleIconLeftImage = null;
            this.bnt_Copy.IdleIconRightImage = null;
            this.bnt_Copy.IndicateFocus = false;
            this.bnt_Copy.Location = new System.Drawing.Point(391, 63);
            this.bnt_Copy.Name = "bnt_Copy";
            this.bnt_Copy.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bnt_Copy.OnDisabledState.BorderRadius = 16;
            this.bnt_Copy.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bnt_Copy.OnDisabledState.BorderThickness = 1;
            this.bnt_Copy.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bnt_Copy.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bnt_Copy.OnDisabledState.IconLeftImage = null;
            this.bnt_Copy.OnDisabledState.IconRightImage = null;
            this.bnt_Copy.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.bnt_Copy.onHoverState.BorderRadius = 16;
            this.bnt_Copy.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bnt_Copy.onHoverState.BorderThickness = 1;
            this.bnt_Copy.onHoverState.FillColor = System.Drawing.Color.Green;
            this.bnt_Copy.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bnt_Copy.onHoverState.IconLeftImage = null;
            this.bnt_Copy.onHoverState.IconRightImage = null;
            this.bnt_Copy.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.bnt_Copy.OnIdleState.BorderRadius = 16;
            this.bnt_Copy.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bnt_Copy.OnIdleState.BorderThickness = 1;
            this.bnt_Copy.OnIdleState.FillColor = System.Drawing.Color.Gray;
            this.bnt_Copy.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bnt_Copy.OnIdleState.IconLeftImage = null;
            this.bnt_Copy.OnIdleState.IconRightImage = null;
            this.bnt_Copy.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.bnt_Copy.OnPressedState.BorderRadius = 16;
            this.bnt_Copy.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bnt_Copy.OnPressedState.BorderThickness = 1;
            this.bnt_Copy.OnPressedState.FillColor = System.Drawing.Color.Green;
            this.bnt_Copy.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bnt_Copy.OnPressedState.IconLeftImage = null;
            this.bnt_Copy.OnPressedState.IconRightImage = null;
            this.bnt_Copy.Size = new System.Drawing.Size(161, 39);
            this.bnt_Copy.TabIndex = 7;
            this.bnt_Copy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnt_Copy.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bnt_Copy.TextMarginLeft = 0;
            this.bnt_Copy.TextPadding = new System.Windows.Forms.Padding(0);
            this.bnt_Copy.UseDefaultRadiusAndThickness = true;
            this.bnt_Copy.Click += new System.EventHandler(this.bnt_Copy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(640, 375);
            this.Controls.Add(this.bnt_Copy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Check35Chars);
            this.Controls.Add(this.Check20Chars);
            this.Controls.Add(this.Check10Chars);
            this.Controls.Add(this.Check6Chars);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuPictureBox1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.bnt_Gen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bnt_Gen;
        private Bunifu.UI.WinForms.BunifuTextBox txtPassword;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuCheckBox Check35Chars;
        private Bunifu.UI.WinForms.BunifuCheckBox Check20Chars;
        private Bunifu.UI.WinForms.BunifuCheckBox Check10Chars;
        private Bunifu.UI.WinForms.BunifuCheckBox Check6Chars;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bnt_Copy;
    }
}

