namespace CodeImp.DoomBuilder.BuilderModes
{
	partial class PreferencesForm
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
			if(disposing && (components != null))
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
            this.tabs = new System.Windows.Forms.TabControl();
            this.taboptions = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.maxeventlines = new CodeImp.DoomBuilder.Controls.ButtonsNumericTextbox();
            this.eventlinelabelstyle = new System.Windows.Forms.ComboBox();
            this.eventlinelabelvisibility = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.defaultfloorheight = new CodeImp.DoomBuilder.Controls.ButtonsNumericTextbox();
            this.label13 = new System.Windows.Forms.Label();
            this.defaultceilheight = new CodeImp.DoomBuilder.Controls.ButtonsNumericTextbox();
            this.label12 = new System.Windows.Forms.Label();
            this.defaultbrightness = new CodeImp.DoomBuilder.Controls.ButtonsNumericTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.usebuggyfloodselect = new System.Windows.Forms.CheckBox();
            this.selectafterundoredo = new System.Windows.Forms.CheckBox();
            this.useoppositesmartpivothandle = new System.Windows.Forms.CheckBox();
            this.additivepaintselect = new System.Windows.Forms.CheckBox();
            this.switchviewmodes = new System.Windows.Forms.CheckBox();
            this.autodrawonedit = new System.Windows.Forms.CheckBox();
            this.syncSelection = new System.Windows.Forms.CheckBox();
            this.dontMoveGeometryOutsideBounds = new System.Windows.Forms.CheckBox();
            this.autoaligntexturesoncreate = new System.Windows.Forms.CheckBox();
            this.autodragonpaste = new System.Windows.Forms.CheckBox();
            this.visualmodeclearselection = new System.Windows.Forms.CheckBox();
            this.autoclearselection = new System.Windows.Forms.CheckBox();
            this.editnewthing = new System.Windows.Forms.CheckBox();
            this.editnewsector = new System.Windows.Forms.CheckBox();
            this.additiveselect = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mouseselectionthreshold = new CodeImp.DoomBuilder.Controls.ButtonsNumericTextbox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.splitlinedefsrange = new CodeImp.DoomBuilder.Controls.ButtonsNumericTextbox();
            this.stitchrange = new CodeImp.DoomBuilder.Controls.ButtonsNumericTextbox();
            this.highlightthingsrange = new CodeImp.DoomBuilder.Controls.ButtonsNumericTextbox();
            this.highlightrange = new CodeImp.DoomBuilder.Controls.ButtonsNumericTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.scaletexturesonslopes = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.splitbehavior = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.heightbysidedef = new System.Windows.Forms.ComboBox();
            this.tabs.SuspendLayout();
            this.taboptions.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs.Controls.Add(this.taboptions);
            this.tabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabs.Location = new System.Drawing.Point(15, 15);
            this.tabs.Margin = new System.Windows.Forms.Padding(4);
            this.tabs.Name = "tabs";
            this.tabs.Padding = new System.Drawing.Point(24, 3);
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(856, 701);
            this.tabs.TabIndex = 0;
            // 
            // taboptions
            // 
            this.taboptions.Controls.Add(this.groupBox5);
            this.taboptions.Controls.Add(this.groupBox4);
            this.taboptions.Controls.Add(this.groupBox3);
            this.taboptions.Controls.Add(this.groupBox2);
            this.taboptions.Controls.Add(this.groupBox1);
            this.taboptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taboptions.Location = new System.Drawing.Point(4, 26);
            this.taboptions.Margin = new System.Windows.Forms.Padding(4);
            this.taboptions.Name = "taboptions";
            this.taboptions.Padding = new System.Windows.Forms.Padding(4);
            this.taboptions.Size = new System.Drawing.Size(848, 671);
            this.taboptions.TabIndex = 0;
            this.taboptions.Text = "Editing";
            this.taboptions.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.maxeventlines);
            this.groupBox5.Controls.Add(this.eventlinelabelstyle);
            this.groupBox5.Controls.Add(this.eventlinelabelvisibility);
            this.groupBox5.Location = new System.Drawing.Point(8, 556);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(340, 106);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Event lines rendering";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(276, 68);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 17);
            this.label20.TabIndex = 28;
            this.label20.Text = "lines";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(19, 68);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(171, 18);
            this.label19.TabIndex = 27;
            this.label19.Text = "Selection render limit:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // maxeventlines
            // 
            this.maxeventlines.AllowDecimal = false;
            this.maxeventlines.AllowExpressions = false;
            this.maxeventlines.AllowNegative = false;
            this.maxeventlines.AllowRelative = false;
            this.maxeventlines.ButtonStep = 500;
            this.maxeventlines.ButtonStepBig = 1000F;
            this.maxeventlines.ButtonStepFloat = 1F;
            this.maxeventlines.ButtonStepSmall = 0.1F;
            this.maxeventlines.ButtonStepsUseModifierKeys = false;
            this.maxeventlines.ButtonStepsWrapAround = false;
            this.maxeventlines.Location = new System.Drawing.Point(195, 63);
            this.maxeventlines.Margin = new System.Windows.Forms.Padding(5);
            this.maxeventlines.Name = "maxeventlines";
            this.maxeventlines.Size = new System.Drawing.Size(74, 27);
            this.maxeventlines.StepValues = null;
            this.maxeventlines.TabIndex = 27;
            // 
            // eventlinelabelstyle
            // 
            this.eventlinelabelstyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eventlinelabelstyle.FormattingEnabled = true;
            this.eventlinelabelstyle.Items.AddRange(new object[] {
            "Action only",
            "Action + short arguments",
            "Action + full arguments"});
            this.eventlinelabelstyle.Location = new System.Drawing.Point(166, 24);
            this.eventlinelabelstyle.Margin = new System.Windows.Forms.Padding(4);
            this.eventlinelabelstyle.Name = "eventlinelabelstyle";
            this.eventlinelabelstyle.Size = new System.Drawing.Size(165, 25);
            this.eventlinelabelstyle.TabIndex = 1;
            // 
            // eventlinelabelvisibility
            // 
            this.eventlinelabelvisibility.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eventlinelabelvisibility.FormattingEnabled = true;
            this.eventlinelabelvisibility.Items.AddRange(new object[] {
            "Never show",
            "Forward only",
            "Reverse only",
            "Forward + Reverse"});
            this.eventlinelabelvisibility.Location = new System.Drawing.Point(8, 24);
            this.eventlinelabelvisibility.Margin = new System.Windows.Forms.Padding(4);
            this.eventlinelabelvisibility.Name = "eventlinelabelvisibility";
            this.eventlinelabelvisibility.Size = new System.Drawing.Size(150, 25);
            this.eventlinelabelvisibility.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.defaultfloorheight);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.defaultceilheight);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.defaultbrightness);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(8, 400);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(340, 149);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = " Default sector settings";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(272, 34);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 17);
            this.label15.TabIndex = 26;
            this.label15.Text = "m.u.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(272, 71);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 17);
            this.label14.TabIndex = 20;
            this.label14.Text = "m.u.";
            // 
            // defaultfloorheight
            // 
            this.defaultfloorheight.AllowDecimal = false;
            this.defaultfloorheight.AllowExpressions = false;
            this.defaultfloorheight.AllowNegative = true;
            this.defaultfloorheight.AllowRelative = false;
            this.defaultfloorheight.ButtonStep = 5;
            this.defaultfloorheight.ButtonStepBig = 10F;
            this.defaultfloorheight.ButtonStepFloat = 1F;
            this.defaultfloorheight.ButtonStepSmall = 0.1F;
            this.defaultfloorheight.ButtonStepsUseModifierKeys = false;
            this.defaultfloorheight.ButtonStepsWrapAround = false;
            this.defaultfloorheight.Location = new System.Drawing.Point(191, 28);
            this.defaultfloorheight.Margin = new System.Windows.Forms.Padding(5);
            this.defaultfloorheight.Name = "defaultfloorheight";
            this.defaultfloorheight.Size = new System.Drawing.Size(74, 27);
            this.defaultfloorheight.StepValues = null;
            this.defaultfloorheight.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(48, 34);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 18);
            this.label13.TabIndex = 24;
            this.label13.Text = "Default floor height:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // defaultceilheight
            // 
            this.defaultceilheight.AllowDecimal = false;
            this.defaultceilheight.AllowExpressions = false;
            this.defaultceilheight.AllowNegative = true;
            this.defaultceilheight.AllowRelative = false;
            this.defaultceilheight.ButtonStep = 5;
            this.defaultceilheight.ButtonStepBig = 10F;
            this.defaultceilheight.ButtonStepFloat = 1F;
            this.defaultceilheight.ButtonStepSmall = 0.1F;
            this.defaultceilheight.ButtonStepsUseModifierKeys = false;
            this.defaultceilheight.ButtonStepsWrapAround = false;
            this.defaultceilheight.Location = new System.Drawing.Point(191, 65);
            this.defaultceilheight.Margin = new System.Windows.Forms.Padding(5);
            this.defaultceilheight.Name = "defaultceilheight";
            this.defaultceilheight.Size = new System.Drawing.Size(74, 27);
            this.defaultceilheight.StepValues = null;
            this.defaultceilheight.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(28, 71);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(158, 18);
            this.label12.TabIndex = 22;
            this.label12.Text = "Default ceiling height:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // defaultbrightness
            // 
            this.defaultbrightness.AllowDecimal = false;
            this.defaultbrightness.AllowExpressions = false;
            this.defaultbrightness.AllowNegative = false;
            this.defaultbrightness.AllowRelative = false;
            this.defaultbrightness.ButtonStep = 5;
            this.defaultbrightness.ButtonStepBig = 10F;
            this.defaultbrightness.ButtonStepFloat = 1F;
            this.defaultbrightness.ButtonStepSmall = 0.1F;
            this.defaultbrightness.ButtonStepsUseModifierKeys = false;
            this.defaultbrightness.ButtonStepsWrapAround = false;
            this.defaultbrightness.Location = new System.Drawing.Point(191, 102);
            this.defaultbrightness.Margin = new System.Windows.Forms.Padding(5);
            this.defaultbrightness.Name = "defaultbrightness";
            this.defaultbrightness.Size = new System.Drawing.Size(74, 27);
            this.defaultbrightness.StepValues = null;
            this.defaultbrightness.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(48, 109);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 18);
            this.label11.TabIndex = 20;
            this.label11.Text = "Default brightness:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.usebuggyfloodselect);
            this.groupBox3.Controls.Add(this.selectafterundoredo);
            this.groupBox3.Controls.Add(this.useoppositesmartpivothandle);
            this.groupBox3.Controls.Add(this.additivepaintselect);
            this.groupBox3.Controls.Add(this.switchviewmodes);
            this.groupBox3.Controls.Add(this.autodrawonedit);
            this.groupBox3.Controls.Add(this.syncSelection);
            this.groupBox3.Controls.Add(this.dontMoveGeometryOutsideBounds);
            this.groupBox3.Controls.Add(this.autoaligntexturesoncreate);
            this.groupBox3.Controls.Add(this.autodragonpaste);
            this.groupBox3.Controls.Add(this.visualmodeclearselection);
            this.groupBox3.Controls.Add(this.autoclearselection);
            this.groupBox3.Controls.Add(this.editnewthing);
            this.groupBox3.Controls.Add(this.editnewsector);
            this.groupBox3.Controls.Add(this.additiveselect);
            this.groupBox3.Location = new System.Drawing.Point(355, 174);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(474, 488);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " Options ";
            // 
            // usebuggyfloodselect
            // 
            this.usebuggyfloodselect.AutoSize = true;
            this.usebuggyfloodselect.Location = new System.Drawing.Point(16, 449);
            this.usebuggyfloodselect.Margin = new System.Windows.Forms.Padding(4);
            this.usebuggyfloodselect.Name = "usebuggyfloodselect";
            this.usebuggyfloodselect.Size = new System.Drawing.Size(270, 21);
            this.usebuggyfloodselect.TabIndex = 13;
            this.usebuggyfloodselect.Text = "Use buggy flood select in Visual Mode";
            this.usebuggyfloodselect.UseVisualStyleBackColor = true;
            // 
            // selectafterundoredo
            // 
            this.selectafterundoredo.AutoSize = true;
            this.selectafterundoredo.Location = new System.Drawing.Point(16, 420);
            this.selectafterundoredo.Margin = new System.Windows.Forms.Padding(4);
            this.selectafterundoredo.Name = "selectafterundoredo";
            this.selectafterundoredo.Size = new System.Drawing.Size(322, 21);
            this.selectafterundoredo.TabIndex = 12;
            this.selectafterundoredo.Text = "Select changed map elements after undo/redo";
            this.selectafterundoredo.UseVisualStyleBackColor = true;
            // 
            // useoppositesmartpivothandle
            // 
            this.useoppositesmartpivothandle.AutoSize = true;
            this.useoppositesmartpivothandle.Location = new System.Drawing.Point(16, 391);
            this.useoppositesmartpivothandle.Margin = new System.Windows.Forms.Padding(4);
            this.useoppositesmartpivothandle.Name = "useoppositesmartpivothandle";
            this.useoppositesmartpivothandle.Size = new System.Drawing.Size(427, 21);
            this.useoppositesmartpivothandle.TabIndex = 12;
            this.useoppositesmartpivothandle.Text = "Opposite side/vertex is smart pivot handle on triangular sectors";
            this.useoppositesmartpivothandle.UseVisualStyleBackColor = true;
            // 
            // additivepaintselect
            // 
            this.additivepaintselect.AutoSize = true;
            this.additivepaintselect.Location = new System.Drawing.Point(16, 164);
            this.additivepaintselect.Margin = new System.Windows.Forms.Padding(4);
            this.additivepaintselect.Name = "additivepaintselect";
            this.additivepaintselect.Size = new System.Drawing.Size(305, 21);
            this.additivepaintselect.TabIndex = 11;
            this.additivepaintselect.Text = "Additive paint selecting without holding Shift";
            this.additivepaintselect.UseVisualStyleBackColor = true;
            // 
            // switchviewmodes
            // 
            this.switchviewmodes.AutoSize = true;
            this.switchviewmodes.Location = new System.Drawing.Point(16, 362);
            this.switchviewmodes.Margin = new System.Windows.Forms.Padding(4);
            this.switchviewmodes.Name = "switchviewmodes";
            this.switchviewmodes.Size = new System.Drawing.Size(410, 21);
            this.switchviewmodes.TabIndex = 10;
            this.switchviewmodes.Text = "Switch view modes when switching to the same Classic Mode";
            this.switchviewmodes.UseVisualStyleBackColor = true;
            // 
            // autodrawonedit
            // 
            this.autodrawonedit.AutoSize = true;
            this.autodrawonedit.Location = new System.Drawing.Point(16, 30);
            this.autodrawonedit.Margin = new System.Windows.Forms.Padding(4);
            this.autodrawonedit.Name = "autodrawonedit";
            this.autodrawonedit.Size = new System.Drawing.Size(466, 38);
            this.autodrawonedit.TabIndex = 0;
            this.autodrawonedit.Text = "Start drawing when Edit pressed over empty space in Classic modes\r\nInsert new thi" +
    "ng when Edit pressed over empty space in Things mode";
            this.autodrawonedit.UseVisualStyleBackColor = true;
            // 
            // syncSelection
            // 
            this.syncSelection.AutoSize = true;
            this.syncSelection.Location = new System.Drawing.Point(16, 334);
            this.syncSelection.Margin = new System.Windows.Forms.Padding(4);
            this.syncSelection.Name = "syncSelection";
            this.syncSelection.Size = new System.Drawing.Size(389, 21);
            this.syncSelection.TabIndex = 9;
            this.syncSelection.Text = "Synchronize selection between Visual and Classic modes";
            this.syncSelection.UseVisualStyleBackColor = true;
            // 
            // dontMoveGeometryOutsideBounds
            // 
            this.dontMoveGeometryOutsideBounds.AutoSize = true;
            this.dontMoveGeometryOutsideBounds.Location = new System.Drawing.Point(16, 305);
            this.dontMoveGeometryOutsideBounds.Margin = new System.Windows.Forms.Padding(4);
            this.dontMoveGeometryOutsideBounds.Name = "dontMoveGeometryOutsideBounds";
            this.dontMoveGeometryOutsideBounds.Size = new System.Drawing.Size(430, 21);
            this.dontMoveGeometryOutsideBounds.TabIndex = 8;
            this.dontMoveGeometryOutsideBounds.Text = "Don\'t move selection if any part of it is outside of map boundary";
            this.dontMoveGeometryOutsideBounds.UseVisualStyleBackColor = true;
            // 
            // autoaligntexturesoncreate
            // 
            this.autoaligntexturesoncreate.AutoSize = true;
            this.autoaligntexturesoncreate.Location = new System.Drawing.Point(16, 276);
            this.autoaligntexturesoncreate.Margin = new System.Windows.Forms.Padding(4);
            this.autoaligntexturesoncreate.Name = "autoaligntexturesoncreate";
            this.autoaligntexturesoncreate.Size = new System.Drawing.Size(308, 21);
            this.autoaligntexturesoncreate.TabIndex = 7;
            this.autoaligntexturesoncreate.Text = "Auto-align textures of newly created linedefs";
            this.autoaligntexturesoncreate.UseVisualStyleBackColor = true;
            // 
            // autodragonpaste
            // 
            this.autodragonpaste.AutoSize = true;
            this.autodragonpaste.Location = new System.Drawing.Point(16, 248);
            this.autodragonpaste.Margin = new System.Windows.Forms.Padding(4);
            this.autodragonpaste.Name = "autodragonpaste";
            this.autodragonpaste.Size = new System.Drawing.Size(265, 21);
            this.autodragonpaste.TabIndex = 6;
            this.autodragonpaste.Text = "Automatically drag selection on paste";
            this.autodragonpaste.UseVisualStyleBackColor = true;
            // 
            // visualmodeclearselection
            // 
            this.visualmodeclearselection.AutoSize = true;
            this.visualmodeclearselection.Location = new System.Drawing.Point(16, 220);
            this.visualmodeclearselection.Margin = new System.Windows.Forms.Padding(4);
            this.visualmodeclearselection.Name = "visualmodeclearselection";
            this.visualmodeclearselection.Size = new System.Drawing.Size(304, 21);
            this.visualmodeclearselection.TabIndex = 5;
            this.visualmodeclearselection.Text = "Automatically clear selection in Visual Mode";
            this.visualmodeclearselection.UseVisualStyleBackColor = true;
            // 
            // autoclearselection
            // 
            this.autoclearselection.AutoSize = true;
            this.autoclearselection.Location = new System.Drawing.Point(16, 191);
            this.autoclearselection.Margin = new System.Windows.Forms.Padding(4);
            this.autoclearselection.Name = "autoclearselection";
            this.autoclearselection.Size = new System.Drawing.Size(317, 21);
            this.autoclearselection.TabIndex = 4;
            this.autoclearselection.Text = "Automatically clear selection in Classic Modes";
            this.autoclearselection.UseVisualStyleBackColor = true;
            // 
            // editnewthing
            // 
            this.editnewthing.AutoSize = true;
            this.editnewthing.Location = new System.Drawing.Point(16, 78);
            this.editnewthing.Margin = new System.Windows.Forms.Padding(4);
            this.editnewthing.Name = "editnewthing";
            this.editnewthing.Size = new System.Drawing.Size(328, 21);
            this.editnewthing.TabIndex = 1;
            this.editnewthing.Text = "Edit thing properties when inserting a new thing";
            this.editnewthing.UseVisualStyleBackColor = true;
            // 
            // editnewsector
            // 
            this.editnewsector.AutoSize = true;
            this.editnewsector.Location = new System.Drawing.Point(16, 106);
            this.editnewsector.Margin = new System.Windows.Forms.Padding(4);
            this.editnewsector.Name = "editnewsector";
            this.editnewsector.Size = new System.Drawing.Size(335, 21);
            this.editnewsector.TabIndex = 2;
            this.editnewsector.Text = "Edit sector properties after drawing a new sector";
            this.editnewsector.UseVisualStyleBackColor = true;
            // 
            // additiveselect
            // 
            this.additiveselect.AutoSize = true;
            this.additiveselect.Location = new System.Drawing.Point(16, 135);
            this.additiveselect.Margin = new System.Windows.Forms.Padding(4);
            this.additiveselect.Name = "additiveselect";
            this.additiveselect.Size = new System.Drawing.Size(270, 21);
            this.additiveselect.TabIndex = 3;
            this.additiveselect.Text = "Additive selecting without holding Shift";
            this.additiveselect.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mouseselectionthreshold);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.splitlinedefsrange);
            this.groupBox2.Controls.Add(this.stitchrange);
            this.groupBox2.Controls.Add(this.highlightthingsrange);
            this.groupBox2.Controls.Add(this.highlightrange);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(8, 174);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(340, 219);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Ranges ";
            // 
            // mouseselectionthreshold
            // 
            this.mouseselectionthreshold.AllowDecimal = false;
            this.mouseselectionthreshold.AllowExpressions = false;
            this.mouseselectionthreshold.AllowNegative = false;
            this.mouseselectionthreshold.AllowRelative = false;
            this.mouseselectionthreshold.ButtonStep = 5;
            this.mouseselectionthreshold.ButtonStepBig = 10F;
            this.mouseselectionthreshold.ButtonStepFloat = 1F;
            this.mouseselectionthreshold.ButtonStepSmall = 0.1F;
            this.mouseselectionthreshold.ButtonStepsUseModifierKeys = false;
            this.mouseselectionthreshold.ButtonStepsWrapAround = false;
            this.mouseselectionthreshold.Location = new System.Drawing.Point(195, 176);
            this.mouseselectionthreshold.Margin = new System.Windows.Forms.Padding(5);
            this.mouseselectionthreshold.Name = "mouseselectionthreshold";
            this.mouseselectionthreshold.Size = new System.Drawing.Size(74, 27);
            this.mouseselectionthreshold.StepValues = null;
            this.mouseselectionthreshold.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(276, 182);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 17);
            this.label16.TabIndex = 18;
            this.label16.Text = "pixels";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 182);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(177, 17);
            this.label17.TabIndex = 17;
            this.label17.Text = "Mouse selection threshold:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // splitlinedefsrange
            // 
            this.splitlinedefsrange.AllowDecimal = false;
            this.splitlinedefsrange.AllowExpressions = false;
            this.splitlinedefsrange.AllowNegative = false;
            this.splitlinedefsrange.AllowRelative = false;
            this.splitlinedefsrange.ButtonStep = 5;
            this.splitlinedefsrange.ButtonStepBig = 10F;
            this.splitlinedefsrange.ButtonStepFloat = 1F;
            this.splitlinedefsrange.ButtonStepSmall = 0.1F;
            this.splitlinedefsrange.ButtonStepsUseModifierKeys = false;
            this.splitlinedefsrange.ButtonStepsWrapAround = false;
            this.splitlinedefsrange.Location = new System.Drawing.Point(195, 139);
            this.splitlinedefsrange.Margin = new System.Windows.Forms.Padding(5);
            this.splitlinedefsrange.Name = "splitlinedefsrange";
            this.splitlinedefsrange.Size = new System.Drawing.Size(74, 27);
            this.splitlinedefsrange.StepValues = null;
            this.splitlinedefsrange.TabIndex = 3;
            // 
            // stitchrange
            // 
            this.stitchrange.AllowDecimal = false;
            this.stitchrange.AllowExpressions = false;
            this.stitchrange.AllowNegative = false;
            this.stitchrange.AllowRelative = false;
            this.stitchrange.ButtonStep = 5;
            this.stitchrange.ButtonStepBig = 10F;
            this.stitchrange.ButtonStepFloat = 1F;
            this.stitchrange.ButtonStepSmall = 0.1F;
            this.stitchrange.ButtonStepsUseModifierKeys = false;
            this.stitchrange.ButtonStepsWrapAround = false;
            this.stitchrange.Location = new System.Drawing.Point(195, 101);
            this.stitchrange.Margin = new System.Windows.Forms.Padding(5);
            this.stitchrange.Name = "stitchrange";
            this.stitchrange.Size = new System.Drawing.Size(74, 27);
            this.stitchrange.StepValues = null;
            this.stitchrange.TabIndex = 2;
            // 
            // highlightthingsrange
            // 
            this.highlightthingsrange.AllowDecimal = false;
            this.highlightthingsrange.AllowExpressions = false;
            this.highlightthingsrange.AllowNegative = false;
            this.highlightthingsrange.AllowRelative = false;
            this.highlightthingsrange.ButtonStep = 5;
            this.highlightthingsrange.ButtonStepBig = 10F;
            this.highlightthingsrange.ButtonStepFloat = 1F;
            this.highlightthingsrange.ButtonStepSmall = 0.1F;
            this.highlightthingsrange.ButtonStepsUseModifierKeys = false;
            this.highlightthingsrange.ButtonStepsWrapAround = false;
            this.highlightthingsrange.Location = new System.Drawing.Point(195, 64);
            this.highlightthingsrange.Margin = new System.Windows.Forms.Padding(5);
            this.highlightthingsrange.Name = "highlightthingsrange";
            this.highlightthingsrange.Size = new System.Drawing.Size(74, 27);
            this.highlightthingsrange.StepValues = null;
            this.highlightthingsrange.TabIndex = 1;
            // 
            // highlightrange
            // 
            this.highlightrange.AllowDecimal = false;
            this.highlightrange.AllowExpressions = false;
            this.highlightrange.AllowNegative = false;
            this.highlightrange.AllowRelative = false;
            this.highlightrange.ButtonStep = 5;
            this.highlightrange.ButtonStepBig = 10F;
            this.highlightrange.ButtonStepFloat = 1F;
            this.highlightrange.ButtonStepSmall = 0.1F;
            this.highlightrange.ButtonStepsUseModifierKeys = false;
            this.highlightrange.ButtonStepsWrapAround = false;
            this.highlightrange.Location = new System.Drawing.Point(195, 26);
            this.highlightrange.Margin = new System.Windows.Forms.Padding(5);
            this.highlightrange.Name = "highlightrange";
            this.highlightrange.Size = new System.Drawing.Size(74, 27);
            this.highlightrange.StepValues = null;
            this.highlightrange.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(276, 145);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "pixels";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Stitch geometry within:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "pixels";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 144);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Split linedefs within:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Highlight geometry within:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 69);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "pixels";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "pixels";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 70);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Highlight things within:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.scaletexturesonslopes);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.splitbehavior);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.heightbysidedef);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(821, 159);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Behavior ";
            // 
            // scaletexturesonslopes
            // 
            this.scaletexturesonslopes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scaletexturesonslopes.FormattingEnabled = true;
            this.scaletexturesonslopes.Items.AddRange(new object[] {
            "Use a scale of 1 as base",
            "Use current scale as base",
            "Don\'t scale"});
            this.scaletexturesonslopes.Location = new System.Drawing.Point(428, 114);
            this.scaletexturesonslopes.Margin = new System.Windows.Forms.Padding(4);
            this.scaletexturesonslopes.Name = "scaletexturesonslopes";
            this.scaletexturesonslopes.Size = new System.Drawing.Size(385, 25);
            this.scaletexturesonslopes.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(166, 118);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(254, 17);
            this.label18.TabIndex = 2;
            this.label18.Text = "When auto-aligning textures on slopes:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // splitbehavior
            // 
            this.splitbehavior.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.splitbehavior.FormattingEnabled = true;
            this.splitbehavior.Items.AddRange(new object[] {
            "Interpolate texture coordinates",
            "Duplicate texture coordinates",
            "Reset X coordinate, duplicate Y coordinate",
            "Reset X and Y coordinates"});
            this.splitbehavior.Location = new System.Drawing.Point(428, 69);
            this.splitbehavior.Margin = new System.Windows.Forms.Padding(4);
            this.splitbehavior.Name = "splitbehavior";
            this.splitbehavior.Size = new System.Drawing.Size(385, 25);
            this.splitbehavior.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(254, 72);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "When splitting a linedef:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "When sector height changes are used on a wall in Visual Mode:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // heightbysidedef
            // 
            this.heightbysidedef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.heightbysidedef.FormattingEnabled = true;
            this.heightbysidedef.Items.AddRange(new object[] {
            "Do nothing",
            "Change the ceiling height",
            "Change the floor height",
            "Change both floor and ceiling height",
            "Change the texture offset"});
            this.heightbysidedef.Location = new System.Drawing.Point(428, 24);
            this.heightbysidedef.Margin = new System.Windows.Forms.Padding(4);
            this.heightbysidedef.Name = "heightbysidedef";
            this.heightbysidedef.Size = new System.Drawing.Size(385, 25);
            this.heightbysidedef.TabIndex = 0;
            // 
            // PreferencesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(886, 731);
            this.Controls.Add(this.tabs);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PreferencesForm";
            this.ShowIcon = false;
            this.Text = "PreferencesForm";
            this.tabs.ResumeLayout(false);
            this.taboptions.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabs;
		private System.Windows.Forms.TabPage taboptions;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox heightbysidedef;
		private System.Windows.Forms.CheckBox editnewsector;
		private System.Windows.Forms.CheckBox editnewthing;
		private System.Windows.Forms.CheckBox additiveselect;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox autoclearselection;
		private System.Windows.Forms.CheckBox visualmodeclearselection;
		private CodeImp.DoomBuilder.Controls.ButtonsNumericTextbox splitlinedefsrange;
		private CodeImp.DoomBuilder.Controls.ButtonsNumericTextbox stitchrange;
		private CodeImp.DoomBuilder.Controls.ButtonsNumericTextbox highlightthingsrange;
		private CodeImp.DoomBuilder.Controls.ButtonsNumericTextbox highlightrange;
		private System.Windows.Forms.CheckBox autodragonpaste;
		private System.Windows.Forms.ComboBox splitbehavior;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.CheckBox autoaligntexturesoncreate;
		private System.Windows.Forms.CheckBox dontMoveGeometryOutsideBounds;
		private System.Windows.Forms.CheckBox syncSelection;
		private System.Windows.Forms.GroupBox groupBox4;
		private CodeImp.DoomBuilder.Controls.ButtonsNumericTextbox defaultbrightness;
		private System.Windows.Forms.Label label11;
		private CodeImp.DoomBuilder.Controls.ButtonsNumericTextbox defaultfloorheight;
		private System.Windows.Forms.Label label13;
		private CodeImp.DoomBuilder.Controls.ButtonsNumericTextbox defaultceilheight;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.CheckBox autodrawonedit;
		private System.Windows.Forms.CheckBox switchviewmodes;
		private Controls.ButtonsNumericTextbox mouseselectionthreshold;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.CheckBox additivepaintselect;
		private System.Windows.Forms.ComboBox scaletexturesonslopes;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.ComboBox eventlinelabelvisibility;
		private System.Windows.Forms.ComboBox eventlinelabelstyle;
		private System.Windows.Forms.CheckBox useoppositesmartpivothandle;
		private System.Windows.Forms.CheckBox selectafterundoredo;
		private System.Windows.Forms.CheckBox usebuggyfloodselect;
		private Controls.ButtonsNumericTextbox maxeventlines;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
	}
}