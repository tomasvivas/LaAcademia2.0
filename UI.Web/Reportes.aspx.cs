using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Logic;
using Business.Entities;

namespace UI.Web
{
    public partial class ReporteCursos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void dplReportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.dplReportes.SelectedIndex)
            {
                case 0: 
                    {
                        this.PanelDS.Visible = false;
                        this.PanelGrid.Visible = false;
                       break;
                    }
                case 3: 
                    {
                        gvReportes.DataSource = DSPlanes;
                        gvReportes.DataBind();
                        break;
                    }
                case 4:
                    {
                        DSEspecialidades.DataObjectTypeName = "Business.Logic.UsuarioLogic";
                        DSEspecialidades.Update();
                        DSEspecialidades.DataBind();
                        gvReportes.DataBind();
                        break;
                    }
                case 2:
                    {
                        
                        this.PanelDS.Visible = true;
                        this.PanelGrid.Visible = true;
                        gvReportes.DataSource = DSEspecialidades;
                        gvReportes.DataBind();
                        break;
                    }
                case 1:
                    {
                        this.gvReportes.DataSource = DSCursos;
                        this.PanelDS.Visible = true;
                        this.PanelGrid.Visible = true;
                        gvReportes.DataBind();
                        break;
                    }

            }
        }

        protected void gvReportes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}