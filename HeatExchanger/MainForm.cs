/*
 * Created by SharpDevelop.
 * User: Mokrev_AA
 * Date: 27.02.2019
 * Time: 14:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HeatExchanger
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1_Click(object sender, EventArgs e)
		{
			// TODO: Implement Button1_Click
			
			double Gm1 = 5;
			double tnm1 = 20;
			double tkm1 = 70;
			double tmcp;
			double Pizb1 = 1;
		    double Patm = 1;
		    double  Pabs;
		    Pabs = Patm+Pizb1;
		    Pabs = 2;
		    
		    
		    
		    double tkond = 119.6;
		    
		    double dtb;
		    dtb = tkond - tnm1;
		    dtb = 99.6;
		    
		    double dtm;
		    dtm = tkond - tkm1;
		     dtm =49.6;
		     
		    double dtcp;
		     dtcp = (dtb - dtm)/Math.Log(dtb/dtm);
		     dtcp = 71.8;
		      tmcp  = tkond - dtcp;
		      tmcp = 47.8;
		      
		    double cm = 1787;
		    double Q;
		       Q = Gm1*cm*(tnm1-tkm1);
		       Q = 469200;
		       
		    double  r = 2208*10^3;
		    double Gnapa = Q/r;
		    Gnapa = 0.215;	     
		   
		    int Kopient = 300;
		    
		    double Fopient;
		    Fopient = Q/(Kopient*dtcp);
		}
		
	}
}
