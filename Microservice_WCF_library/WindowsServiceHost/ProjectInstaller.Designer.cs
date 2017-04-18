namespace WindowsServiceHost
{
    partial class ProjectInstaller
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
            this.GetEstimateWSHostProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.GetEstimateWSHost = new System.ServiceProcess.ServiceInstaller();
            // 
            // GetEstimateWSHostProcessInstaller
            // 
            this.GetEstimateWSHostProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.GetEstimateWSHostProcessInstaller.Password = null;
            this.GetEstimateWSHostProcessInstaller.Username = null;
            this.GetEstimateWSHostProcessInstaller.AfterInstall += new System.Configuration.Install.InstallEventHandler(this.serviceProcessInstaller1_AfterInstall);
            // 
            // GetEstimateWSHost
            // 
            this.GetEstimateWSHost.ServiceName = "GetEstimateWSHost";
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.GetEstimateWSHostProcessInstaller,
            this.GetEstimateWSHost});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller GetEstimateWSHostProcessInstaller;
        private System.ServiceProcess.ServiceInstaller GetEstimateWSHost;
    }
}