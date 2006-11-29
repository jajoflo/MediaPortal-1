﻿namespace MediaPortal.TvNotifies
{
  partial class NotifySetupForm
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      this.groupBoxNotifyTV = new MediaPortal.UserInterface.Controls.MPGroupBox();
      this.textBoxPreNotify = new MediaPortal.UserInterface.Controls.MPTextBox();
      this.labelPreNotify = new MediaPortal.UserInterface.Controls.MPLabel();
      this.checkBoxNotifyPlaySound = new MediaPortal.UserInterface.Controls.MPCheckBox();
      this.textBoxNotifyTimeoutVal = new MediaPortal.UserInterface.Controls.MPTextBox();
      this.labelNotifyTimeout = new MediaPortal.UserInterface.Controls.MPLabel();
      this.labelNotifyHint = new MediaPortal.UserInterface.Controls.MPLabel();
      this.buttonCancel = new MediaPortal.UserInterface.Controls.MPButton();
      this.buttonOk = new MediaPortal.UserInterface.Controls.MPButton();
      this.groupBoxNotifyTV.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBoxNotifyTV
      // 
      this.groupBoxNotifyTV.Controls.Add(this.textBoxPreNotify);
      this.groupBoxNotifyTV.Controls.Add(this.labelPreNotify);
      this.groupBoxNotifyTV.Controls.Add(this.checkBoxNotifyPlaySound);
      this.groupBoxNotifyTV.Controls.Add(this.textBoxNotifyTimeoutVal);
      this.groupBoxNotifyTV.Controls.Add(this.labelNotifyTimeout);
      this.groupBoxNotifyTV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.groupBoxNotifyTV.Location = new System.Drawing.Point(9, 12);
      this.groupBoxNotifyTV.Name = "groupBoxNotifyTV";
      this.groupBoxNotifyTV.Size = new System.Drawing.Size(264, 104);
      this.groupBoxNotifyTV.TabIndex = 3;
      this.groupBoxNotifyTV.TabStop = false;
      this.groupBoxNotifyTV.Text = "Program start notification";
      // 
      // textBoxPreNotify
      // 
      this.textBoxPreNotify.BorderColor = System.Drawing.Color.Empty;
      this.textBoxPreNotify.Location = new System.Drawing.Point(200, 21);
      this.textBoxPreNotify.Name = "textBoxPreNotify";
      this.textBoxPreNotify.Size = new System.Drawing.Size(43, 20);
      this.textBoxPreNotify.TabIndex = 4;
      this.textBoxPreNotify.Text = "300";
      // 
      // labelPreNotify
      // 
      this.labelPreNotify.AutoSize = true;
      this.labelPreNotify.Location = new System.Drawing.Point(16, 24);
      this.labelPreNotify.Name = "labelPreNotify";
      this.labelPreNotify.Size = new System.Drawing.Size(160, 13);
      this.labelPreNotify.TabIndex = 3;
      this.labelPreNotify.Text = "Notify this many seconds before:";
      // 
      // checkBoxNotifyPlaySound
      // 
      this.checkBoxNotifyPlaySound.AutoSize = true;
      this.checkBoxNotifyPlaySound.Checked = true;
      this.checkBoxNotifyPlaySound.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBoxNotifyPlaySound.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.checkBoxNotifyPlaySound.Location = new System.Drawing.Point(19, 76);
      this.checkBoxNotifyPlaySound.Name = "checkBoxNotifyPlaySound";
      this.checkBoxNotifyPlaySound.Size = new System.Drawing.Size(105, 17);
      this.checkBoxNotifyPlaySound.TabIndex = 2;
      this.checkBoxNotifyPlaySound.Text = "Play \"notify.wav\"";
      this.checkBoxNotifyPlaySound.UseVisualStyleBackColor = true;
      // 
      // textBoxNotifyTimeoutVal
      // 
      this.textBoxNotifyTimeoutVal.BorderColor = System.Drawing.Color.Empty;
      this.textBoxNotifyTimeoutVal.Location = new System.Drawing.Point(200, 47);
      this.textBoxNotifyTimeoutVal.Name = "textBoxNotifyTimeoutVal";
      this.textBoxNotifyTimeoutVal.Size = new System.Drawing.Size(43, 20);
      this.textBoxNotifyTimeoutVal.TabIndex = 1;
      this.textBoxNotifyTimeoutVal.Text = "15";
      // 
      // labelNotifyTimeout
      // 
      this.labelNotifyTimeout.AutoSize = true;
      this.labelNotifyTimeout.Location = new System.Drawing.Point(16, 50);
      this.labelNotifyTimeout.Name = "labelNotifyTimeout";
      this.labelNotifyTimeout.Size = new System.Drawing.Size(139, 13);
      this.labelNotifyTimeout.TabIndex = 0;
      this.labelNotifyTimeout.Text = "Hide notification after (sec.):";
      // 
      // labelNotifyHint
      // 
      this.labelNotifyHint.Location = new System.Drawing.Point(15, 128);
      this.labelNotifyHint.Name = "labelNotifyHint";
      this.labelNotifyHint.Size = new System.Drawing.Size(262, 39);
      this.labelNotifyHint.TabIndex = 4;
      this.labelNotifyHint.Text = "Notifications can be set in the TV guide. To remind you of your favourite program" +
          " an OSD will show up.";
      // 
      // buttonCancel
      // 
      this.buttonCancel.Location = new System.Drawing.Point(198, 170);
      this.buttonCancel.Name = "buttonCancel";
      this.buttonCancel.Size = new System.Drawing.Size(75, 23);
      this.buttonCancel.TabIndex = 5;
      this.buttonCancel.Text = "Cancel";
      this.buttonCancel.UseVisualStyleBackColor = true;
      this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
      // 
      // buttonOk
      // 
      this.buttonOk.Location = new System.Drawing.Point(110, 170);
      this.buttonOk.Name = "buttonOk";
      this.buttonOk.Size = new System.Drawing.Size(75, 23);
      this.buttonOk.TabIndex = 6;
      this.buttonOk.Text = "Ok";
      this.buttonOk.UseVisualStyleBackColor = true;
      this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
      // 
      // NotifySetupForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(285, 204);
      this.Controls.Add(this.buttonOk);
      this.Controls.Add(this.buttonCancel);
      this.Controls.Add(this.labelNotifyHint);
      this.Controls.Add(this.groupBoxNotifyTV);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "NotifySetupForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Notifier setup";
      this.groupBoxNotifyTV.ResumeLayout(false);
      this.groupBoxNotifyTV.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private MediaPortal.UserInterface.Controls.MPGroupBox groupBoxNotifyTV;
    private MediaPortal.UserInterface.Controls.MPTextBox textBoxPreNotify;
    private MediaPortal.UserInterface.Controls.MPLabel labelPreNotify;
    private MediaPortal.UserInterface.Controls.MPCheckBox checkBoxNotifyPlaySound;
    private MediaPortal.UserInterface.Controls.MPTextBox textBoxNotifyTimeoutVal;
    private MediaPortal.UserInterface.Controls.MPLabel labelNotifyTimeout;
    private MediaPortal.UserInterface.Controls.MPLabel labelNotifyHint;
    private MediaPortal.UserInterface.Controls.MPButton buttonCancel;
    private MediaPortal.UserInterface.Controls.MPButton buttonOk;
  }
}