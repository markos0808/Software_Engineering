﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace DIjagram_aktivnosti
{
    public partial class Form1 : Form
    {

        public delegate void Delegat(string poruka);
        private int prviBroj = 0;
        private int drugiBroj = 0;
        public Thread dretvaSuma;
        public Thread dretvaUmnozak;
      



        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Aplikacija je spremna za korištenje!");
            //CheckForIllegalCrossThreadCalls = false;
           /* dretvaSuma = new Thread(new ThreadStart(DretvaSumaWork));
            dretvaUmnozak = new Thread(new ThreadStart(DretvaUmnozakWork)); */
        }

        public void PisiULog(string poruka)
        {
            lock (txtLog)
            {
                txtLog.Text = poruka + Environment.NewLine + txtLog.Text;
            }
        }


        public void ProvjeriUnos()
        {
            int zamjena = 0;
            prviBroj = int.Parse(txtPrvi.Text);
            drugiBroj = int.Parse(txtDrugi.Text);
            if (prviBroj > drugiBroj)
            {
                zamjena = drugiBroj;
                drugiBroj = prviBroj;
                prviBroj = zamjena;
            }
            PisiULog("Prvi broj:  " + prviBroj.ToString());
            PisiULog("Drugi broj:  " + drugiBroj.ToString());
        }

        private void btnUnesiVrijednost_Click(object sender, EventArgs e)
        {
            ProvjeriUnos();
        }



        public void DretvaSumaWork(Object stateInfo)
        {
            Delegat delInstance = PisiULog;
            int suma = 0;
            for (int i = prviBroj; i < drugiBroj; i++)
            {
                suma += i;
            }
            string poruka = (" Suma= " + suma.ToString() + " Kraj: " + DateTime.Now.ToString());
            txtLog.Invoke((MethodInvoker)delegate
            {
                PisiULog(poruka);
            });
        }


        public void DretvaUmnozakWork(Object stateInfo)
        {
            Delegat delInstance = PisiULog;
            int umnozak = 1;
            for (int i = prviBroj; i < drugiBroj; i++)
            {
                umnozak *= i;
            }
            string poruka = (" Umnozak= " + umnozak.ToString() + " Kraj: " + DateTime.Now.ToString());
            txtLog.Invoke((MethodInvoker)delegate
            {
                PisiULog(poruka);
            });
        }

        private void btnPokreniIzracun_Click(object sender, EventArgs e)
        {
            PisiULog("Početak svih izračuna u:  " + DateTime.Now.ToString());
            /* dretvaSuma.Start();
               dretvaUmnozak.Start(); */
            ThreadPool.QueueUserWorkItem(DretvaSumaWork);
            ThreadPool.QueueUserWorkItem(DretvaUmnozakWork);
        }
    
        
    
    }
}
