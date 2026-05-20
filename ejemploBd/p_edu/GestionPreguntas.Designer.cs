/*
 * Created by SharpDevelop.
 * User: Alexandra
 * Date: 19/5/2026
 * Time: 9:29 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace p_edu
{
	partial class GestionPreguntas
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dgvPreguntas;
		private System.Windows.Forms.Button BtnGuardar;
		private System.Windows.Forms.TextBox txtPregunta;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.dgvPreguntas = new System.Windows.Forms.DataGridView();
			this.BtnGuardar = new System.Windows.Forms.Button();
			this.txtPregunta = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvPreguntas)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvPreguntas
			// 
			this.dgvPreguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPreguntas.Location = new System.Drawing.Point(77, 70);
			this.dgvPreguntas.Name = "dgvPreguntas";
			this.dgvPreguntas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvPreguntas.Size = new System.Drawing.Size(538, 302);
			this.dgvPreguntas.TabIndex = 0;
			// 
			// BtnGuardar
			// 
			this.BtnGuardar.Location = new System.Drawing.Point(269, 388);
			this.BtnGuardar.Name = "BtnGuardar";
			this.BtnGuardar.Size = new System.Drawing.Size(154, 74);
			this.BtnGuardar.TabIndex = 1;
			this.BtnGuardar.Text = "Guardar";
			this.BtnGuardar.UseVisualStyleBackColor = true;
			// 
			// txtPregunta
			// 
			this.txtPregunta.Location = new System.Drawing.Point(221, 28);
			this.txtPregunta.Name = "txtPregunta";
			this.txtPregunta.Size = new System.Drawing.Size(264, 20);
			this.txtPregunta.TabIndex = 2;
			// 
			// GestionPreguntas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(682, 494);
			this.Controls.Add(this.txtPregunta);
			this.Controls.Add(this.BtnGuardar);
			this.Controls.Add(this.dgvPreguntas);
			this.Name = "GestionPreguntas";
			this.Text = "GestionPreguntas";
			((System.ComponentModel.ISupportInitialize)(this.dgvPreguntas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
