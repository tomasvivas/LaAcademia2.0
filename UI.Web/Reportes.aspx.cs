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
            
        }

        protected void gvReportes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        protected void Button3_Click(object sender, EventArgs e)
        {
            switch (dplReportes.SelectedValue)
            {
                case "(Ninguno)":
                    {
                        gvReportes.DataSource = null;
                        gvReportes.DataBind();
                        break;
                    }
                case "Planes":
                    {
                        gvReportes.DataSource = DSPlanes;
                        gvReportes.DataBind();
                        break;
                    }
                case "Usuarios":
                    {
                        gvReportes.DataSource = DSUsuarios;
                        gvReportes.DataBind();
                        break;
                    }
                case "Especialidades":
                    {
                        gvReportes.DataSource = DSEspecialidades;
                        gvReportes.DataBind();
                        break;
                    }
                case "Cursos":
                    {
                        gvReportes.DataSource = DSCursos;
                        gvReportes.DataBind();
                        break;
                    }

            }
        }
    }
}