namespace MTDEV_0019_ServicioWindows
{
    partial class MTDEV_Service
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.serviceLog = new System.Diagnostics.EventLog();
            ((System.ComponentModel.ISupportInitialize)(this.serviceLog)).BeginInit();
            // 
            // MTDEV_Service
            // 
            this.ServiceName = "Service1";
            ((System.ComponentModel.ISupportInitialize)(this.serviceLog)).EndInit();

        }

        #endregion

        private System.Diagnostics.EventLog serviceLog;
    }
}
