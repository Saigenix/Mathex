using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class btnclick : MonoBehaviour
{


   static public bool add_ = false;
   static public bool sub_ = false;
   static public bool mul_ = false;
   static public bool div_ = false;
   static public bool mix_ = false;
    static public void gameplayon (){

     SceneManager.LoadScene("Add");
  }
   public void add(){

       add_ = true ;
       
    
   }
   public void mix(){

       mix_ = true ;

   }
   public void sub(){

       sub_ = true ;

   }
   public void mul(){

       mul_ = true ;

   }
   public void div(){

       div_ = true ;

   }
}
