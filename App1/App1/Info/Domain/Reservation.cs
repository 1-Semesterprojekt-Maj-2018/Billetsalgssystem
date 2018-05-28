using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using App1.Annotations;

namespace App1.Info.Domain
{
  public class Reservation
  {
      private DateTime _dato;
      private int _antalPersoner; 

      public Reservation(DateTime dato, int antalpersoner)
      {
          _dato = dato;
          _antalPersoner = antalpersoner;
      }

      public DateTime Dato
      {
          get { return _dato; }
          set { _dato = value;}
      }

      public int AntalPersoner
      {
          get { return _antalPersoner;}
          set { _antalPersoner = value;}
      }
  }
}

